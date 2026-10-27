

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4650730063329986483L),

new System.Numerics.BigInteger(4787750494947119639L),

new System.Numerics.BigInteger(4140637132471525823L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4109660371734016795L),

new System.Numerics.BigInteger(7830037641457981170L),

new System.Numerics.BigInteger(3381466932357503746L),

new System.Numerics.BigInteger(6766269039078989507L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4532088459115832021L),

new System.Numerics.BigInteger(2844806590038244842L),

new System.Numerics.BigInteger(4668101631833278282L),

new System.Numerics.BigInteger(1690041346694010961L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3781257971415635186L),

new System.Numerics.BigInteger(2730270802616530882L),

new System.Numerics.BigInteger(8106578259946434215L),

new System.Numerics.BigInteger(810186478520610209L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9126143075940116717L),

new System.Numerics.BigInteger(9195909255447454779L),

new System.Numerics.BigInteger(7466106359993698669L),

new System.Numerics.BigInteger(7959084236528112740L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3280173328569660467L),

new System.Numerics.BigInteger(7341701593026808199L),

new System.Numerics.BigInteger(2218570588711806388L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5958794158343089786L),

new System.Numerics.BigInteger(413819454534002868L),

new System.Numerics.BigInteger(840949449686277187L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8711798737680759386L),

new System.Numerics.BigInteger(2265269977858186492L),

new System.Numerics.BigInteger(875877445052118012L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6505821128430368483L),

new System.Numerics.BigInteger(8902820260243078023L),

new System.Numerics.BigInteger(6393269417989255998L),

new System.Numerics.BigInteger(4655085798823821663L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(759115838434466085L),

new System.Numerics.BigInteger(5722680315983638485L),

new System.Numerics.BigInteger(3164593358220131061L),

new System.Numerics.BigInteger(2160928658326579434L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5043400504002234911L),

new System.Numerics.BigInteger(607121974626962767L),

new System.Numerics.BigInteger(1439382583702018970L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8192321193950264939L),

new System.Numerics.BigInteger(2060975003359700158L),

new System.Numerics.BigInteger(5480361847498879751L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3259459440735838170L),

new System.Numerics.BigInteger(5884525396119309322L),

new System.Numerics.BigInteger(2457993569825536950L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9094532031102639372L),

new System.Numerics.BigInteger(122769550787322325L),

new System.Numerics.BigInteger(3421513254520094850L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2163163175855979484L),

new System.Numerics.BigInteger(8566913964478253155L),

new System.Numerics.BigInteger(2991497149511685822L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5513507102305799597L),

new System.Numerics.BigInteger(4527296201559086782L),

new System.Numerics.BigInteger(6495849451592734928L),

new System.Numerics.BigInteger(8148819687419485493L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1156625230816553434L),

new System.Numerics.BigInteger(5166904092713542757L),

new System.Numerics.BigInteger(6635525273015817080L),

new System.Numerics.BigInteger(7037744976948507221L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2728663462948128458L),

new System.Numerics.BigInteger(3211987945708146827L),

new System.Numerics.BigInteger(8552874092457955534L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8856604639897684151L),

new System.Numerics.BigInteger(7761246975830568191L),

new System.Numerics.BigInteger(3409723190618187474L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(199490126237387368L),

new System.Numerics.BigInteger(4399558789128344955L),

new System.Numerics.BigInteger(369464090660966528L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8596699081680564496L),

new System.Numerics.BigInteger(633638325229608494L),

new System.Numerics.BigInteger(6027967590501668223L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8927344167117795593L),

new System.Numerics.BigInteger(7499756649759106191L),

new System.Numerics.BigInteger(1177216909303267410L),

new System.Numerics.BigInteger(5868103287845860319L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7223350603750164813L),

new System.Numerics.BigInteger(8518773884429335805L),

new System.Numerics.BigInteger(3313421267987762661L),

new System.Numerics.BigInteger(6723207938880274705L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2488021269893607604L),

new System.Numerics.BigInteger(6976685840751839372L),

new System.Numerics.BigInteger(8565071448062865092L),

new System.Numerics.BigInteger(9143942653938952610L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2362468379333593680L),

new System.Numerics.BigInteger(4853020173554497010L),

new System.Numerics.BigInteger(4971134106475985382L),

new System.Numerics.BigInteger(8166878910641841113L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(922096583748671101L),

new System.Numerics.BigInteger(3219895379940924954L),

new System.Numerics.BigInteger(1621697764821320947L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3836775252140550065L),

new System.Numerics.BigInteger(6052587884085749690L),

new System.Numerics.BigInteger(1987203401751784529L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(607625715666626325L),

new System.Numerics.BigInteger(6199572955843295763L),

new System.Numerics.BigInteger(831692100539112280L),

new System.Numerics.BigInteger(8590053929387768145L),

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
new System.Numerics.BigInteger(8242690342444714752L),

new System.Numerics.BigInteger(2565598227059114319L),

new System.Numerics.BigInteger(8543846288727219395L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3924778672841852222L),

new System.Numerics.BigInteger(6114338827819650866L),

new System.Numerics.BigInteger(8356009940729613131L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2466742126237740176L),

new System.Numerics.BigInteger(2036200921827534049L),

new System.Numerics.BigInteger(6925468072530886432L),

new System.Numerics.BigInteger(6086343535378512710L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2930592730460133296L),

new System.Numerics.BigInteger(7153059401728394055L),

new System.Numerics.BigInteger(7342646644183018773L),

new System.Numerics.BigInteger(225265319876583167L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(733386156394952731L),

new System.Numerics.BigInteger(5463578197809290049L),

new System.Numerics.BigInteger(2085965032485787212L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7786910112591094148L),

new System.Numerics.BigInteger(241632217828728213L),

new System.Numerics.BigInteger(3988913922477093198L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(812737024041712536L),

new System.Numerics.BigInteger(5401241753696282131L),

new System.Numerics.BigInteger(1081432351012889022L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6084486989369058241L),

new System.Numerics.BigInteger(8733166106244731052L),

new System.Numerics.BigInteger(2818099778172344888L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1326366749230344137L),

new System.Numerics.BigInteger(6176743538940761500L),

new System.Numerics.BigInteger(5338536022268932742L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2544465998307858536L),

new System.Numerics.BigInteger(2709404052237187707L),

new System.Numerics.BigInteger(7973916758623679111L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7000935200087388651L),

new System.Numerics.BigInteger(2359264694216701483L),

new System.Numerics.BigInteger(6513823955009107441L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5972675592773094619L),

new System.Numerics.BigInteger(3862139818216965162L),

new System.Numerics.BigInteger(8451734944039186159L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3887032480665230355L),

new System.Numerics.BigInteger(276280294417531363L),

new System.Numerics.BigInteger(5508800853117083294L),

new System.Numerics.BigInteger(9006092267738277173L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8107575902702516421L),

new System.Numerics.BigInteger(4201389981215717772L),

new System.Numerics.BigInteger(2497685656097335183L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8203295978434580587L),

new System.Numerics.BigInteger(685222868840118111L),

new System.Numerics.BigInteger(1194538838846413235L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7754382894531261546L),

new System.Numerics.BigInteger(3305114745497897985L),

new System.Numerics.BigInteger(973660338187013974L),

new System.Numerics.BigInteger(2390321080881687502L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1762687243707011588L),

new System.Numerics.BigInteger(3271579842172832197L),

new System.Numerics.BigInteger(3497078095894984512L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1763250428046292210L),

new System.Numerics.BigInteger(2646416480938946748L),

new System.Numerics.BigInteger(4109909068786741634L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5189711869742629404L),

new System.Numerics.BigInteger(2392179295566483822L),

new System.Numerics.BigInteger(6249232644770635291L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5071443161389058378L),

new System.Numerics.BigInteger(6676223502941944616L),

new System.Numerics.BigInteger(1568728506738046226L),

new System.Numerics.BigInteger(6735412806452093875L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5331171298880174190L),

new System.Numerics.BigInteger(130098116258266381L),

new System.Numerics.BigInteger(6486349667449220726L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5437083711538248094L),

new System.Numerics.BigInteger(6505103009006744978L),

new System.Numerics.BigInteger(3542360024182374637L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1612678895279489926L),

new System.Numerics.BigInteger(4123362535642361584L),

new System.Numerics.BigInteger(292350105210135529L),

new System.Numerics.BigInteger(3196880522028489928L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6388450844019238488L),

new System.Numerics.BigInteger(4671218970857745692L),

new System.Numerics.BigInteger(3803437808210630913L),

new System.Numerics.BigInteger(1254068138342643834L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4433906270483787209L),

new System.Numerics.BigInteger(2593163211385890304L),

new System.Numerics.BigInteger(949477982861436429L),

new System.Numerics.BigInteger(1149199216535700635L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4999341135635785233L),

new System.Numerics.BigInteger(6489064977211669040L),

new System.Numerics.BigInteger(8791962973105306804L),

new System.Numerics.BigInteger(3671412801108307419L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(69418366875533380L),

new System.Numerics.BigInteger(8356403048131909112L),

new System.Numerics.BigInteger(3902319425729424476L),

new System.Numerics.BigInteger(8983818433091416420L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(945365560207288056L),

new System.Numerics.BigInteger(8566100369535334810L),

new System.Numerics.BigInteger(545772045533416919L),

new System.Numerics.BigInteger(6251487788741141132L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2710680903261807545L),

new System.Numerics.BigInteger(1117097143796739433L),

new System.Numerics.BigInteger(9143604721423272750L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4087019374156608342L),

new System.Numerics.BigInteger(5908119006697952265L),

new System.Numerics.BigInteger(7325215677109507592L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2682609398199446791L),

new System.Numerics.BigInteger(5364212066941923715L),

new System.Numerics.BigInteger(7372826114021771230L),

new System.Numerics.BigInteger(7316647692318226551L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5250631960707105293L),

new System.Numerics.BigInteger(1084483436001244923L),

new System.Numerics.BigInteger(5789626236940036730L),

new System.Numerics.BigInteger(959996596372616340L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7035242357445146124L),

new System.Numerics.BigInteger(5324261802508112592L),

new System.Numerics.BigInteger(7850995148327381453L),

new System.Numerics.BigInteger(4123234392217111201L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6597759560774593180L),

new System.Numerics.BigInteger(2486066308025557922L),

new System.Numerics.BigInteger(1096404824729973402L),

new System.Numerics.BigInteger(6310163867492285348L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(255071415842887075L),

new System.Numerics.BigInteger(7421065036371954154L),

new System.Numerics.BigInteger(5064194354610567981L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4685989481117658919L),

new System.Numerics.BigInteger(8918068734664865396L),

new System.Numerics.BigInteger(1727334721188515932L),

new System.Numerics.BigInteger(4963716263732454690L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2509897989610411851L),

new System.Numerics.BigInteger(4643126108208739130L),

new System.Numerics.BigInteger(482677281755924080L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6757249729958793622L),

new System.Numerics.BigInteger(155970376553323780L),

new System.Numerics.BigInteger(338401591868359081L),

new System.Numerics.BigInteger(7994446025332264896L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7715333933977409540L),

new System.Numerics.BigInteger(2857108620786131410L),

new System.Numerics.BigInteger(6385893860718772083L),

new System.Numerics.BigInteger(1975088806361508708L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(800884719117269411L),

new System.Numerics.BigInteger(1003152293085194729L),

new System.Numerics.BigInteger(7680463159506999508L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6010187120464177345L),

new System.Numerics.BigInteger(4377950389208986873L),

new System.Numerics.BigInteger(380749394881351367L),

new System.Numerics.BigInteger(8833410604453919239L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4796407936879360487L),

new System.Numerics.BigInteger(2262186466860347263L),

new System.Numerics.BigInteger(156187368284937350L),

new System.Numerics.BigInteger(1700604088620243258L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1335594500013342806L),

new System.Numerics.BigInteger(8698494962185844673L),

new System.Numerics.BigInteger(3019926120947257575L),

new System.Numerics.BigInteger(7489014182418852677L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7151788417698759235L),

new System.Numerics.BigInteger(9066617491693482937L),

new System.Numerics.BigInteger(4106465525265996977L),

new System.Numerics.BigInteger(2258382664841269482L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8981748332179070014L),

new System.Numerics.BigInteger(7816193130473439705L),

new System.Numerics.BigInteger(1911995830252954767L),

new System.Numerics.BigInteger(2264620539459578912L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8187458878663534557L),

new System.Numerics.BigInteger(6396605232785160754L),

new System.Numerics.BigInteger(6337311227441019684L),

new System.Numerics.BigInteger(2642137327872811318L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6616642777093330124L),

new System.Numerics.BigInteger(6584256200131442022L),

new System.Numerics.BigInteger(207732955339225922L),

new System.Numerics.BigInteger(507798895643376766L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7338547950974370019L),

new System.Numerics.BigInteger(266328899454274971L),

new System.Numerics.BigInteger(2227188703490724884L),

new System.Numerics.BigInteger(802616442167187458L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1981928756648264428L),

new System.Numerics.BigInteger(4406708943763615824L),

new System.Numerics.BigInteger(2765756692499914074L),

new System.Numerics.BigInteger(3583111806338019035L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5259865818893255019L),

new System.Numerics.BigInteger(5155994706021990986L),

new System.Numerics.BigInteger(5711502114600013460L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(908860476977403401L),

new System.Numerics.BigInteger(1311845794745410511L),

new System.Numerics.BigInteger(7858453240547577565L),

},
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[7], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                await ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 27, query1, 149, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
                await ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 61, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
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
                 ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 15, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
                 ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 61, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 142, query1, 72, query2))
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[34], false);
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
                await ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 5, query1, 167, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 61, query1, 102, query2))
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[34], false);
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
                 ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 104, query1, 153, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 47, 161))
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatch(connection, 104, 142))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[34], false);
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
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models = await ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[12], false);
                BigIntegernumericListD1E2M.AssertModel(models[1],_testData[13], false);
                BigIntegernumericListD1E2M.AssertModel(models[2],_testData[14], false);
                BigIntegernumericListD1E2M.AssertModel(models[3],_testData[15], false);
                BigIntegernumericListD1E2M.AssertModel(models[4],_testData[16], false);
                BigIntegernumericListD1E2M.AssertModel(models[5],_testData[17], false);
                BigIntegernumericListD1E2M.AssertModel(models[6],_testData[18], false);
                BigIntegernumericListD1E2M.AssertModel(models[7],_testData[19], false);
                BigIntegernumericListD1E2M.AssertModel(models[8],_testData[20], false);
                BigIntegernumericListD1E2M.AssertModel(models[9],_testData[21], false);
                BigIntegernumericListD1E2M.AssertModel(models[10],_testData[22], false);
                BigIntegernumericListD1E2M.AssertModel(models[11],_testData[23], false);
                BigIntegernumericListD1E2M.AssertModel(models[12],_testData[24], false);
                BigIntegernumericListD1E2M.AssertModel(models[13],_testData[25], false);
                BigIntegernumericListD1E2M.AssertModel(models[14],_testData[26], false);
                BigIntegernumericListD1E2M.AssertModel(models[15],_testData[27], false);
                BigIntegernumericListD1E2M.AssertModel(models[16],_testData[28], false);
                BigIntegernumericListD1E2M.AssertModel(models[17],_testData[29], false);
                BigIntegernumericListD1E2M.AssertModel(models[18],_testData[30], false);
                BigIntegernumericListD1E2M.AssertModel(models[19],_testData[31], false);
                BigIntegernumericListD1E2M.AssertModel(models[20],_testData[32], false);
                BigIntegernumericListD1E2M.AssertModel(models[21],_testData[33], false);
                BigIntegernumericListD1E2M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 113);
                var models =  ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

