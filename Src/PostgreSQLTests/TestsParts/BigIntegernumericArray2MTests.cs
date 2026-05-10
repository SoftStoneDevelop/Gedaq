

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
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1676924178304741022L),

new System.Numerics.BigInteger(1851214630745345189L),

new System.Numerics.BigInteger(6371794360788143783L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2181099418782633916L),

new System.Numerics.BigInteger(8482757886830177105L),

new System.Numerics.BigInteger(4084266420779973167L),

new System.Numerics.BigInteger(9173237588947028404L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8266676522037692733L),

new System.Numerics.BigInteger(6612663825140409872L),

new System.Numerics.BigInteger(5594446623032668611L),

new System.Numerics.BigInteger(6177552884953139730L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8522611763717840430L),

new System.Numerics.BigInteger(4497546459834442276L),

new System.Numerics.BigInteger(4855080284301451222L),

new System.Numerics.BigInteger(1570748478196172852L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6370848549648408811L),

new System.Numerics.BigInteger(7606334549260247705L),

new System.Numerics.BigInteger(1621620055456938498L),

new System.Numerics.BigInteger(6105488695167462888L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7456539394797006420L),

new System.Numerics.BigInteger(7924244563988739445L),

new System.Numerics.BigInteger(1787666642579454666L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5060714258255579127L),

new System.Numerics.BigInteger(5569725157595220133L),

new System.Numerics.BigInteger(4318399918764170900L),

new System.Numerics.BigInteger(1402030094978543478L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1600700153474854780L),

new System.Numerics.BigInteger(9096725215683906978L),

new System.Numerics.BigInteger(7443975896279473716L),

new System.Numerics.BigInteger(8189013689719140117L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1983540825893871017L),

new System.Numerics.BigInteger(666837177021305086L),

new System.Numerics.BigInteger(1011669337377526160L),

new System.Numerics.BigInteger(5395611031256890608L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4907582468691793645L),

new System.Numerics.BigInteger(435435311678358703L),

new System.Numerics.BigInteger(3443765014870883924L),

new System.Numerics.BigInteger(3882558040045351780L),

},
},
            new BigIntegernumericArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(529623439862760171L),

new System.Numerics.BigInteger(9222966160231458403L),

new System.Numerics.BigInteger(7211736569897407133L),

new System.Numerics.BigInteger(6027441954330478686L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7512335305434880104L),

new System.Numerics.BigInteger(4539539333177017153L),

new System.Numerics.BigInteger(127694636471603695L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4506844106970525504L),

new System.Numerics.BigInteger(992521909878225957L),

new System.Numerics.BigInteger(6135844260924626477L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3459569077443323191L),

new System.Numerics.BigInteger(5340050532561041649L),

new System.Numerics.BigInteger(4000302910625908454L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2236254582661706366L),

new System.Numerics.BigInteger(4246162907217181687L),

new System.Numerics.BigInteger(6658842845046228218L),

new System.Numerics.BigInteger(1793232480250738033L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3829440079000066269L),

new System.Numerics.BigInteger(7320524931627621950L),

new System.Numerics.BigInteger(6527416265195492310L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6446797768701717892L),

new System.Numerics.BigInteger(176144026022442476L),

new System.Numerics.BigInteger(1237431259253355468L),

},
},
            new BigIntegernumericArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1326795638066585141L),

new System.Numerics.BigInteger(3414415132025746991L),

new System.Numerics.BigInteger(7873567288529303895L),

new System.Numerics.BigInteger(1556052254302582580L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4657194739000333170L),

new System.Numerics.BigInteger(815911838434857818L),

new System.Numerics.BigInteger(7368021575098949587L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6030846061563177013L),

new System.Numerics.BigInteger(4236926178886047861L),

new System.Numerics.BigInteger(7160029415491869837L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7529391382636392909L),

new System.Numerics.BigInteger(1046328387255809704L),

new System.Numerics.BigInteger(2884650196097703619L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4943839811362170816L),

new System.Numerics.BigInteger(3111620577942376890L),

new System.Numerics.BigInteger(2349153209664228327L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3660442295981531309L),

new System.Numerics.BigInteger(7490900364318263944L),

new System.Numerics.BigInteger(7024710588889384427L),

new System.Numerics.BigInteger(1199733297852719580L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1910493148100031707L),

new System.Numerics.BigInteger(5853544644463935206L),

new System.Numerics.BigInteger(811242773517631962L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4906130581852793986L),

new System.Numerics.BigInteger(8343248302649088404L),

new System.Numerics.BigInteger(8756076092009750279L),

new System.Numerics.BigInteger(7613563280472299330L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2875662897175867738L),

new System.Numerics.BigInteger(8093830554212676084L),

new System.Numerics.BigInteger(7256274249981240175L),

},
},
            new BigIntegernumericArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(41885758606367221L),

new System.Numerics.BigInteger(2980516792204837911L),

new System.Numerics.BigInteger(2112557952138553247L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3539252909410292462L),

new System.Numerics.BigInteger(7458592931866102811L),

new System.Numerics.BigInteger(585632647441039774L),

new System.Numerics.BigInteger(2349885542282464550L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4394550776862192483L),

new System.Numerics.BigInteger(3061357027004708558L),

new System.Numerics.BigInteger(8504524945055639700L),

new System.Numerics.BigInteger(2703544067428790323L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(889546226796578107L),

new System.Numerics.BigInteger(5950948980032575430L),

new System.Numerics.BigInteger(6719681840665469326L),

},
},
            new BigIntegernumericArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5151519580373723543L),

new System.Numerics.BigInteger(6457738609943734962L),

new System.Numerics.BigInteger(2106490346998289095L),

new System.Numerics.BigInteger(1307498807705702269L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8456050594076113076L),

new System.Numerics.BigInteger(166350030016458723L),

new System.Numerics.BigInteger(6980892202424450099L),

new System.Numerics.BigInteger(8243424285548422801L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8974185935974518107L),

new System.Numerics.BigInteger(7152542648594431379L),

new System.Numerics.BigInteger(1817332268848788416L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5329191580379555914L),

new System.Numerics.BigInteger(889707575680185262L),

new System.Numerics.BigInteger(8401574061087507136L),

new System.Numerics.BigInteger(3141199025800505579L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(24269757267285630L),

new System.Numerics.BigInteger(976691069891055478L),

new System.Numerics.BigInteger(3538991115514643841L),

new System.Numerics.BigInteger(3954207217962484770L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5381341929035867936L),

new System.Numerics.BigInteger(1523881041792357053L),

new System.Numerics.BigInteger(5838365382642236795L),

new System.Numerics.BigInteger(9018469298976997607L),

},
},
            new BigIntegernumericArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9191490666933836896L),

new System.Numerics.BigInteger(3173906684830820157L),

new System.Numerics.BigInteger(3128018990829760340L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6951547772696214515L),

new System.Numerics.BigInteger(2161375757308705828L),

new System.Numerics.BigInteger(160123141887505130L),

new System.Numerics.BigInteger(5828679676690832569L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5755698264324791771L),

new System.Numerics.BigInteger(494937672264391508L),

new System.Numerics.BigInteger(7400874885229708973L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2058797778826022923L),

new System.Numerics.BigInteger(2237458336497972495L),

new System.Numerics.BigInteger(2626402614724971597L),

new System.Numerics.BigInteger(530375406922353149L),

},
},
            new BigIntegernumericArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7752193387377261792L),

new System.Numerics.BigInteger(2831878672381582723L),

new System.Numerics.BigInteger(8937308308021474494L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4938133181897434482L),

new System.Numerics.BigInteger(162981196758486948L),

new System.Numerics.BigInteger(1722884423676266802L),

new System.Numerics.BigInteger(3397503222578279773L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7212046500666720129L),

new System.Numerics.BigInteger(9043454379695373294L),

new System.Numerics.BigInteger(7102654551238937613L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1458711644192548881L),

new System.Numerics.BigInteger(1946158445399433583L),

new System.Numerics.BigInteger(8842737016506773758L),

},
},
            new BigIntegernumericArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7554474543642249317L),

new System.Numerics.BigInteger(5373608656706756329L),

new System.Numerics.BigInteger(305855526954242074L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(957596785078740102L),

new System.Numerics.BigInteger(7360622851423649276L),

new System.Numerics.BigInteger(2820937944835594688L),

new System.Numerics.BigInteger(2742922461517132600L),

},
},
            new BigIntegernumericArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3157725696835352039L),

new System.Numerics.BigInteger(3192304762774227529L),

new System.Numerics.BigInteger(2419481386697251174L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8523234054246852329L),

new System.Numerics.BigInteger(1759690042908589455L),

new System.Numerics.BigInteger(1096116962978686582L),

new System.Numerics.BigInteger(4238597708370819707L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5791815632244413654L),

new System.Numerics.BigInteger(4508734762382169445L),

new System.Numerics.BigInteger(7070300995187589125L),

new System.Numerics.BigInteger(4100415267942236431L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8817436501208518848L),

new System.Numerics.BigInteger(6150216586232144940L),

new System.Numerics.BigInteger(4396959068354470280L),

},
},
            new BigIntegernumericArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1834253704634799171L),

new System.Numerics.BigInteger(248481045063032300L),

new System.Numerics.BigInteger(1227538511710871731L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(696555887083645832L),

new System.Numerics.BigInteger(6960434417605974652L),

new System.Numerics.BigInteger(5257241134191360906L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8006391208977996903L),

new System.Numerics.BigInteger(7462765792624722210L),

new System.Numerics.BigInteger(3959853017344304546L),

},
},
            new BigIntegernumericArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1458976287508451861L),

new System.Numerics.BigInteger(856689514264135807L),

new System.Numerics.BigInteger(79876309227365646L),

new System.Numerics.BigInteger(6737899658352056809L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3605573669304286152L),

new System.Numerics.BigInteger(1285656923179627578L),

new System.Numerics.BigInteger(5192116482694759436L),

new System.Numerics.BigInteger(3435516122555221472L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2958234467804729005L),

new System.Numerics.BigInteger(2484833491239901701L),

new System.Numerics.BigInteger(3819531037864583619L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6475327615955185017L),

new System.Numerics.BigInteger(6595348924095486781L),

new System.Numerics.BigInteger(5791742752659027241L),

new System.Numerics.BigInteger(4945069569246001820L),

},
},
            new BigIntegernumericArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2440920478322172609L),

new System.Numerics.BigInteger(8304312279618806053L),

new System.Numerics.BigInteger(9014945929369196052L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5517735800440875038L),

new System.Numerics.BigInteger(2146401198210503503L),

new System.Numerics.BigInteger(1586006563372991067L),

new System.Numerics.BigInteger(3065370409877211284L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7977627249990143522L),

new System.Numerics.BigInteger(132669394481364116L),

new System.Numerics.BigInteger(3306583021967894478L),

new System.Numerics.BigInteger(2339290881340216796L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3270175525435860837L),

new System.Numerics.BigInteger(1205172948482520648L),

new System.Numerics.BigInteger(8660814099785669174L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8753379070816983937L),

new System.Numerics.BigInteger(8736636716217489787L),

new System.Numerics.BigInteger(4309143366137078510L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3227058500509881150L),

new System.Numerics.BigInteger(2310730871019363932L),

new System.Numerics.BigInteger(606507184616842704L),

new System.Numerics.BigInteger(6376926085941676348L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7865438408655306525L),

new System.Numerics.BigInteger(5352280932249279263L),

new System.Numerics.BigInteger(141343018083356492L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7591398933926438654L),

new System.Numerics.BigInteger(8130456713366418789L),

new System.Numerics.BigInteger(5473634400820402780L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7215861115029462032L),

new System.Numerics.BigInteger(79189914479421164L),

new System.Numerics.BigInteger(444947170959481710L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5448410812190830152L),

new System.Numerics.BigInteger(6547732386084957376L),

new System.Numerics.BigInteger(8883165012001456032L),

},
},
            new BigIntegernumericArray2M
{
    Id = 187,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1023327134527499353L),

new System.Numerics.BigInteger(1901866080367882992L),

new System.Numerics.BigInteger(4682168327393689098L),

new System.Numerics.BigInteger(1263053337053880939L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(320218219123022352L),

new System.Numerics.BigInteger(6676036915897289909L),

new System.Numerics.BigInteger(8962333231709713401L),

new System.Numerics.BigInteger(6476105036747565184L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(762724788341553544L),

new System.Numerics.BigInteger(8575269963632829649L),

new System.Numerics.BigInteger(6303890982552548454L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4352890160893685490L),

new System.Numerics.BigInteger(705498649148403148L),

new System.Numerics.BigInteger(6617161580720363549L),

},
},
            new BigIntegernumericArray2M
{
    Id = 188,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(663216963819823268L),

new System.Numerics.BigInteger(342018885446314681L),

new System.Numerics.BigInteger(4915830539886984113L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3399246666435913106L),

new System.Numerics.BigInteger(6945342198053883060L),

new System.Numerics.BigInteger(7557519174146588987L),

new System.Numerics.BigInteger(3868724209654434023L),

},
},
            new BigIntegernumericArray2M
{
    Id = 195,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2447870155781449948L),

new System.Numerics.BigInteger(4229928273936706478L),

new System.Numerics.BigInteger(50475808325027915L),

new System.Numerics.BigInteger(5122942747284330382L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5576526159804738380L),

new System.Numerics.BigInteger(683333234719863192L),

new System.Numerics.BigInteger(3198244648247253042L),

new System.Numerics.BigInteger(1095102536105471838L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 198,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1371675651645611207L),

new System.Numerics.BigInteger(1350456405262483247L),

new System.Numerics.BigInteger(5216681851135318020L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7124595509443705007L),

new System.Numerics.BigInteger(8349412017188023966L),

new System.Numerics.BigInteger(8894294719820808559L),

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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 179;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 178;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[34], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
                parametr1.Value = 179;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 106, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 119, query1, 178, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 130, query1, 166, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 22, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 22, query1, 40, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[27],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[28],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 92, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 65, query1, 130, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 96, query1, 187, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
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
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 96, 162))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 173, 188))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[34], false);
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
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 162);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[27], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[28], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[29], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[30], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[31], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[32], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[33], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 188);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[33], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[34], false);
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

