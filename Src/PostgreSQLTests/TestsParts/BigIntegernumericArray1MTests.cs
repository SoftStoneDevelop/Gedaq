

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
    Id = 8,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4082174978896627548L),
new System.Numerics.BigInteger(2913780537896992437L),
new System.Numerics.BigInteger(7759809183640158902L),
new System.Numerics.BigInteger(8206181891275546497L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8058242158333533579L),
new System.Numerics.BigInteger(9043880982521389238L),
new System.Numerics.BigInteger(341259688319012474L),
new System.Numerics.BigInteger(3497078863152408814L),
},
},
            new BigIntegernumericArray1M
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1260861563767865372L),
new System.Numerics.BigInteger(3491858009773039039L),
new System.Numerics.BigInteger(8618313210955275785L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 7,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3915486535768385717L),
new System.Numerics.BigInteger(7545119990614664741L),
new System.Numerics.BigInteger(3185064144813801360L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 19,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(326976534736265878L),
new System.Numerics.BigInteger(9001300626073888558L),
new System.Numerics.BigInteger(1672860682012402958L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8059072573228286000L),
new System.Numerics.BigInteger(4676101375483909681L),
new System.Numerics.BigInteger(5582985009841999405L),
new System.Numerics.BigInteger(4997273150598779370L),
},
},
            new BigIntegernumericArray1M
{
    Id = 28,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1850566221307170756L),
new System.Numerics.BigInteger(3263144249762512631L),
new System.Numerics.BigInteger(8870001374702133721L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 16,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4669819274060194797L),
new System.Numerics.BigInteger(1024151742693883595L),
new System.Numerics.BigInteger(9107862866753775473L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4045665589697987917L),
new System.Numerics.BigInteger(1646234245019817241L),
new System.Numerics.BigInteger(7156943613234777731L),
new System.Numerics.BigInteger(4917177673284883207L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(437339273419518460L),
new System.Numerics.BigInteger(8164535633888207682L),
new System.Numerics.BigInteger(8748406074451683988L),
new System.Numerics.BigInteger(1344459711205006932L),
},
},
            new BigIntegernumericArray1M
{
    Id = 30,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4794216905972292327L),
new System.Numerics.BigInteger(1367924577319194598L),
new System.Numerics.BigInteger(3148371038863372464L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3472794742383067602L),
new System.Numerics.BigInteger(7236124044691676605L),
new System.Numerics.BigInteger(3570292549190571731L),
new System.Numerics.BigInteger(3502567577979727875L),
},
},
            new BigIntegernumericArray1M
{
    Id = 38,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3749677463043208346L),
new System.Numerics.BigInteger(9103839172778099820L),
new System.Numerics.BigInteger(4346822057879326982L),
new System.Numerics.BigInteger(363887173580067582L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 25,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1098150864274076565L),
new System.Numerics.BigInteger(8290401352517750722L),
new System.Numerics.BigInteger(800118087286889347L),
new System.Numerics.BigInteger(4483069599272716485L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4963084110083693294L),
new System.Numerics.BigInteger(7859782753557071179L),
new System.Numerics.BigInteger(7688468020235520431L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 46,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1976197234352282184L),
new System.Numerics.BigInteger(6636304916420790339L),
new System.Numerics.BigInteger(5578387038998623260L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 54,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6071701802017586348L),
new System.Numerics.BigInteger(4406716116177326934L),
new System.Numerics.BigInteger(3090547383110347344L),
new System.Numerics.BigInteger(7999069675675215920L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 34,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6113795074588016024L),
new System.Numerics.BigInteger(861811466590286449L),
new System.Numerics.BigInteger(904333121818865190L),
new System.Numerics.BigInteger(8943881269259101848L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 62,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(672463879789471066L),
new System.Numerics.BigInteger(6820942555816584997L),
new System.Numerics.BigInteger(2041652242562689567L),
new System.Numerics.BigInteger(4627499379541232009L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 71,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5769870995855863946L),
new System.Numerics.BigInteger(3544105514114969068L),
new System.Numerics.BigInteger(7177228789621751458L),
new System.Numerics.BigInteger(6821677910012495093L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 42,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1467687435600925888L),
new System.Numerics.BigInteger(3960395029657914824L),
new System.Numerics.BigInteger(3747576376583243831L),
new System.Numerics.BigInteger(4303162545110985861L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6824310306922015277L),
new System.Numerics.BigInteger(4470618703710047135L),
new System.Numerics.BigInteger(3140977383647160186L),
new System.Numerics.BigInteger(7714371402151177462L),
},
},
            new BigIntegernumericArray1M
{
    Id = 73,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2887100694536382777L),
new System.Numerics.BigInteger(7548775171909171520L),
new System.Numerics.BigInteger(5144830450589641296L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 82,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4415578350540631397L),
new System.Numerics.BigInteger(82127149028270338L),
new System.Numerics.BigInteger(5013911117775205969L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 44,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3900068719746268612L),
new System.Numerics.BigInteger(2593601287812981984L),
new System.Numerics.BigInteger(1481781409137389111L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7608513483996121859L),
new System.Numerics.BigInteger(6769699861663110329L),
new System.Numerics.BigInteger(328757932874484291L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9014569947187485524L),
new System.Numerics.BigInteger(2524625085675289244L),
new System.Numerics.BigInteger(4489530058792754388L),
},
},
            new BigIntegernumericArray1M
{
    Id = 83,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(539002822161149072L),
new System.Numerics.BigInteger(7828634572363826533L),
new System.Numerics.BigInteger(676573096638771780L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4540617577693840938L),
new System.Numerics.BigInteger(5085122511499749417L),
new System.Numerics.BigInteger(7083166795315572950L),
new System.Numerics.BigInteger(688488037412015790L),
},
},
            new BigIntegernumericArray1M
{
    Id = 90,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8626763969109849390L),
new System.Numerics.BigInteger(1549999507917259883L),
new System.Numerics.BigInteger(2657494226582612056L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 47,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2031545056881305742L),
new System.Numerics.BigInteger(1555389378355345585L),
new System.Numerics.BigInteger(3825118310308674241L),
new System.Numerics.BigInteger(4213840957127401063L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 91,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5806489149724695270L),
new System.Numerics.BigInteger(2129663854595547857L),
new System.Numerics.BigInteger(375338502109119269L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 92,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3559683495777260332L),
new System.Numerics.BigInteger(6576003392250280061L),
new System.Numerics.BigInteger(8315364869064351701L),
new System.Numerics.BigInteger(5230134561599124386L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(205006804414486846L),
new System.Numerics.BigInteger(6895952192659306584L),
new System.Numerics.BigInteger(1383459438876368391L),
new System.Numerics.BigInteger(5856235456265630422L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8984300302272712794L),
new System.Numerics.BigInteger(2060570050242509052L),
new System.Numerics.BigInteger(1641156560190913298L),
new System.Numerics.BigInteger(6203633610497790229L),
},
},
            new BigIntegernumericArray1M
{
    Id = 99,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(90368185432660940L),
new System.Numerics.BigInteger(686758497266181882L),
new System.Numerics.BigInteger(8068041536901433155L),
new System.Numerics.BigInteger(7767729219896333240L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2315412815106231783L),
new System.Numerics.BigInteger(3527901840012222704L),
new System.Numerics.BigInteger(9055169929157527750L),
new System.Numerics.BigInteger(8140672834048333016L),
},
},
            new BigIntegernumericArray1M
{
    Id = 105,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5254194596389366969L),
new System.Numerics.BigInteger(6146053200504893253L),
new System.Numerics.BigInteger(8265262785489767726L),
new System.Numerics.BigInteger(2054086152158531239L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 61,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6792924458619018840L),
new System.Numerics.BigInteger(2431782500478735668L),
new System.Numerics.BigInteger(4319700725770289592L),
new System.Numerics.BigInteger(944223994400891788L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8784423288616211003L),
new System.Numerics.BigInteger(2200030015588798276L),
new System.Numerics.BigInteger(5164756549755195609L),
new System.Numerics.BigInteger(3596178420021346027L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 111,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8365420771621620072L),
new System.Numerics.BigInteger(3849501447078091967L),
new System.Numerics.BigInteger(4738430634035903549L),
new System.Numerics.BigInteger(1338312612944039587L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 113,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6304175850772378537L),
new System.Numerics.BigInteger(7547907885219993992L),
new System.Numerics.BigInteger(7168128871378789603L),
new System.Numerics.BigInteger(6777275552388582915L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 70,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7546949613692542443L),
new System.Numerics.BigInteger(4848148896012909400L),
new System.Numerics.BigInteger(5580496689776669496L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5136991654321156819L),
new System.Numerics.BigInteger(5505894577300405833L),
new System.Numerics.BigInteger(6274641277945046130L),
},
},
            new BigIntegernumericArray1M
{
    Id = 116,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5205683409711976353L),
new System.Numerics.BigInteger(4872548749930572266L),
new System.Numerics.BigInteger(3661627301683478159L),
new System.Numerics.BigInteger(201746852065843232L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 123,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3281516229648506478L),
new System.Numerics.BigInteger(1890579972642100905L),
new System.Numerics.BigInteger(5176349961521697190L),
new System.Numerics.BigInteger(2193032473802457158L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1241861990401565582L),
new System.Numerics.BigInteger(1100724889484939158L),
new System.Numerics.BigInteger(3332992545018603101L),
new System.Numerics.BigInteger(7853450565262375429L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1685199650927437015L),
new System.Numerics.BigInteger(4443550037506063757L),
new System.Numerics.BigInteger(105652020146391675L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 125,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5086162743857653188L),
new System.Numerics.BigInteger(5728623447971640507L),
new System.Numerics.BigInteger(7952993123724989798L),
new System.Numerics.BigInteger(152008662046959244L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(357492013662210717L),
new System.Numerics.BigInteger(6779974054072213021L),
new System.Numerics.BigInteger(7416676356022132198L),
},
},
            new BigIntegernumericArray1M
{
    Id = 132,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7476887594158848691L),
new System.Numerics.BigInteger(5799659230094160100L),
new System.Numerics.BigInteger(5644834087921883529L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 80,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7618805840228687179L),
new System.Numerics.BigInteger(5740281126264842453L),
new System.Numerics.BigInteger(408621910136025096L),
new System.Numerics.BigInteger(3919448918181576775L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4007470973824410875L),
new System.Numerics.BigInteger(20020873002016835L),
new System.Numerics.BigInteger(7437841106946892408L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 135,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4538295238805787426L),
new System.Numerics.BigInteger(5737479682824701778L),
new System.Numerics.BigInteger(3240753659421943205L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 143,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3622504417698685941L),
new System.Numerics.BigInteger(1583456579185402119L),
new System.Numerics.BigInteger(4275530874321275584L),
new System.Numerics.BigInteger(7141865628336043487L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 85,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6984944940684274126L),
new System.Numerics.BigInteger(5862246941178469201L),
new System.Numerics.BigInteger(9185196514004227351L),
new System.Numerics.BigInteger(2158979575754949238L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(304209678189367510L),
new System.Numerics.BigInteger(2752115663279892701L),
new System.Numerics.BigInteger(8857541231456883563L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 145,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1385424209566803533L),
new System.Numerics.BigInteger(5865988355422286296L),
new System.Numerics.BigInteger(7757042533392319516L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(435511464705507348L),
new System.Numerics.BigInteger(3779849586708205707L),
new System.Numerics.BigInteger(999269062980621170L),
},
},
            new BigIntegernumericArray1M
{
    Id = 153,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6641190633506074807L),
new System.Numerics.BigInteger(5249391564953192566L),
new System.Numerics.BigInteger(1079652396960518840L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 88,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7241822014333228601L),
new System.Numerics.BigInteger(5015916371310816103L),
new System.Numerics.BigInteger(551808525846713116L),
new System.Numerics.BigInteger(2027306656717279725L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7961641632763604060L),
new System.Numerics.BigInteger(6105639743409934579L),
new System.Numerics.BigInteger(5593577484050995917L),
new System.Numerics.BigInteger(8260493446028248325L),
},
},
            new BigIntegernumericArray1M
{
    Id = 160,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1697161657864177178L),
new System.Numerics.BigInteger(1100050288713688997L),
new System.Numerics.BigInteger(7271151966993522062L),
new System.Numerics.BigInteger(6608342856808082640L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 161,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3661591027446835229L),
new System.Numerics.BigInteger(2260234814557493375L),
new System.Numerics.BigInteger(5765843126199695084L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 95,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5867581585955867576L),
new System.Numerics.BigInteger(6064425981221159446L),
new System.Numerics.BigInteger(7783641405339495188L),
new System.Numerics.BigInteger(1910447109799300466L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 168,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6676154131638922277L),
new System.Numerics.BigInteger(3293449555546799521L),
new System.Numerics.BigInteger(4118456277607876602L),
new System.Numerics.BigInteger(2599725320309206657L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 170,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8032975595980002907L),
new System.Numerics.BigInteger(8153370486688951385L),
new System.Numerics.BigInteger(9032808766461357570L),
new System.Numerics.BigInteger(8193672287237691702L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 103,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4067515145846235102L),
new System.Numerics.BigInteger(2265149485476876904L),
new System.Numerics.BigInteger(3761289154070083736L),
new System.Numerics.BigInteger(4842350114035876242L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6309926049342075576L),
new System.Numerics.BigInteger(7151488145963293073L),
new System.Numerics.BigInteger(6812398150461629743L),
},
},
            new BigIntegernumericArray1M
{
    Id = 175,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4074067428149866241L),
new System.Numerics.BigInteger(179694961343411718L),
new System.Numerics.BigInteger(1727888474813167148L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 184,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7719598891254949851L),
new System.Numerics.BigInteger(1530770843144731210L),
new System.Numerics.BigInteger(7132995247061309373L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 109,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1724451498551265546L),
new System.Numerics.BigInteger(7726271356931185905L),
new System.Numerics.BigInteger(8197519652366180462L),
new System.Numerics.BigInteger(8964720741431394945L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8236699875926172890L),
new System.Numerics.BigInteger(8493561590114415939L),
new System.Numerics.BigInteger(4861860627158553166L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2201014061494204915L),
new System.Numerics.BigInteger(96487794969099756L),
new System.Numerics.BigInteger(6519095629830986343L),
},
},
            new BigIntegernumericArray1M
{
    Id = 193,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2090989003778768906L),
new System.Numerics.BigInteger(6496539681642806666L),
new System.Numerics.BigInteger(8535310350187044161L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9101227908703597515L),
new System.Numerics.BigInteger(5467286416712475747L),
new System.Numerics.BigInteger(6391660159244669025L),
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[34], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[34], false);
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 73, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 92, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[34], false);
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 145, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[34], false);
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 28, query1, 170, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 71, query1, 170, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[34], false);
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 170, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[30],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 153, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[34], false);
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 143, query1, 135, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 111, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[1], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[2], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[3], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[4], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[5], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[29],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[30],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[31],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[32],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[33],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 135, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 161);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[30], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[31], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[32], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[33], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[17], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[18], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[19], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[20], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[21], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[22], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[23], false);
                BigIntegernumericArray1M.AssertModel(models[7],_testData[24], false);
                BigIntegernumericArray1M.AssertModel(models[8],_testData[25], false);
                BigIntegernumericArray1M.AssertModel(models[9],_testData[26], false);
                BigIntegernumericArray1M.AssertModel(models[10],_testData[27], false);
                BigIntegernumericArray1M.AssertModel(models[11],_testData[28], false);
                BigIntegernumericArray1M.AssertModel(models[12],_testData[29], false);
                BigIntegernumericArray1M.AssertModel(models[13],_testData[30], false);
                BigIntegernumericArray1M.AssertModel(models[14],_testData[31], false);
                BigIntegernumericArray1M.AssertModel(models[15],_testData[32], false);
                BigIntegernumericArray1M.AssertModel(models[16],_testData[33], false);
                BigIntegernumericArray1M.AssertModel(models[17],_testData[34], false);
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

