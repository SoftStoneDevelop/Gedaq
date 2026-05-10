

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
    Id = 3,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8374374161273587083L),
new System.Numerics.BigInteger(7286205922452947823L),
new System.Numerics.BigInteger(7621243054807055186L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(78977189669213035L),
new System.Numerics.BigInteger(4843874397110461807L),
new System.Numerics.BigInteger(3476976262327204659L),
},
},
            new BigIntegernumericArray1M
{
    Id = 5,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5144061108883544789L),
new System.Numerics.BigInteger(1302424086020461782L),
new System.Numerics.BigInteger(6253650404547229351L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 8,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(570113442655566600L),
new System.Numerics.BigInteger(8999012680209239601L),
new System.Numerics.BigInteger(7773686419831472738L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4319871044875222028L),
new System.Numerics.BigInteger(1543287146650248970L),
new System.Numerics.BigInteger(6146451643957945615L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(864254766732335313L),
new System.Numerics.BigInteger(5056588286981674588L),
new System.Numerics.BigInteger(4627101835923232678L),
},
},
            new BigIntegernumericArray1M
{
    Id = 13,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1155149348138336431L),
new System.Numerics.BigInteger(8512327430874686282L),
new System.Numerics.BigInteger(8482427648917803036L),
new System.Numerics.BigInteger(8128565636126126855L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4754848929549543852L),
new System.Numerics.BigInteger(5403163722323392226L),
new System.Numerics.BigInteger(7286368731346061250L),
},
},
            new BigIntegernumericArray1M
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5036483492169856787L),
new System.Numerics.BigInteger(1294946528207049957L),
new System.Numerics.BigInteger(1249368180087522233L),
new System.Numerics.BigInteger(7624487337580478300L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6187101225559527030L),
new System.Numerics.BigInteger(3279160539458595122L),
new System.Numerics.BigInteger(2930024653035433743L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 23,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3332334959619814804L),
new System.Numerics.BigInteger(1944054338440599949L),
new System.Numerics.BigInteger(1672254563261745654L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 26,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8090740208025690784L),
new System.Numerics.BigInteger(7758492558481698045L),
new System.Numerics.BigInteger(3172785105324590728L),
new System.Numerics.BigInteger(971039749314902252L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 16,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6142815801070638037L),
new System.Numerics.BigInteger(7750934605590030088L),
new System.Numerics.BigInteger(6055355418242603837L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3986157923619044408L),
new System.Numerics.BigInteger(8217649135285398681L),
new System.Numerics.BigInteger(596320625606474823L),
new System.Numerics.BigInteger(1062979851602646551L),
},
},
            new BigIntegernumericArray1M
{
    Id = 33,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1069014889299808361L),
new System.Numerics.BigInteger(3519984162958946728L),
new System.Numerics.BigInteger(1676727097595117985L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1352825998474448683L),
new System.Numerics.BigInteger(3873494338313343765L),
new System.Numerics.BigInteger(4323478406258452168L),
},
},
            new BigIntegernumericArray1M
{
    Id = 40,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8295898654701639896L),
new System.Numerics.BigInteger(2801946414774817823L),
new System.Numerics.BigInteger(8879641355716129328L),
new System.Numerics.BigInteger(2202268666971839856L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 20,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1543622441056275208L),
new System.Numerics.BigInteger(709185584590571863L),
new System.Numerics.BigInteger(3265708204267523359L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2773170084282355027L),
new System.Numerics.BigInteger(7601976945932716750L),
new System.Numerics.BigInteger(6915007521525866844L),
new System.Numerics.BigInteger(1696190337657808012L),
},
},
            new BigIntegernumericArray1M
{
    Id = 48,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5175644365661736348L),
new System.Numerics.BigInteger(1187865713809253124L),
new System.Numerics.BigInteger(8446101865223759486L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2678638123679874959L),
new System.Numerics.BigInteger(9054163488463687514L),
new System.Numerics.BigInteger(8946497775084900148L),
},
},
            new BigIntegernumericArray1M
{
    Id = 55,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2968952856549690262L),
new System.Numerics.BigInteger(5982231958903386491L),
new System.Numerics.BigInteger(1650694923115278458L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 21,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2045743609819547649L),
new System.Numerics.BigInteger(1688720277563817162L),
new System.Numerics.BigInteger(7074275021251107904L),
new System.Numerics.BigInteger(823216542511083330L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1576364884943082665L),
new System.Numerics.BigInteger(5719607722359107986L),
new System.Numerics.BigInteger(2073765070432126525L),
new System.Numerics.BigInteger(5079065839826877361L),
},
},
            new BigIntegernumericArray1M
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1812104590526067464L),
new System.Numerics.BigInteger(7795741257568686616L),
new System.Numerics.BigInteger(9124403064409539532L),
new System.Numerics.BigInteger(7240691845556898006L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 60,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3466257881175761632L),
new System.Numerics.BigInteger(1359339904095484098L),
new System.Numerics.BigInteger(6537667676256745576L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 25,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1041644401388062082L),
new System.Numerics.BigInteger(6290942126257161175L),
new System.Numerics.BigInteger(1218953928020893433L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3036355184746907181L),
new System.Numerics.BigInteger(6780291885000755578L),
new System.Numerics.BigInteger(7092737093700876654L),
new System.Numerics.BigInteger(9152963429422471936L),
},
},
            new BigIntegernumericArray1M
{
    Id = 69,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1560271616658253644L),
new System.Numerics.BigInteger(5304097129023951353L),
new System.Numerics.BigInteger(2361864875707381400L),
new System.Numerics.BigInteger(3939406773919725790L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6606050922334916162L),
new System.Numerics.BigInteger(7469747707706704234L),
new System.Numerics.BigInteger(7311163281670043855L),
new System.Numerics.BigInteger(310936271050204689L),
},
},
            new BigIntegernumericArray1M
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8224212564993976608L),
new System.Numerics.BigInteger(1452756505467336417L),
new System.Numerics.BigInteger(3144417417936519029L),
new System.Numerics.BigInteger(1559602698973160251L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 32,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6658614410446586334L),
new System.Numerics.BigInteger(5881352398567710547L),
new System.Numerics.BigInteger(2797019325299427547L),
new System.Numerics.BigInteger(8704503719765520779L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6311598736534333569L),
new System.Numerics.BigInteger(1677322703326768703L),
new System.Numerics.BigInteger(5166514488784677186L),
new System.Numerics.BigInteger(3262217003362091424L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 83,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2322830399765635276L),
new System.Numerics.BigInteger(3113337651100163203L),
new System.Numerics.BigInteger(5367775460979765538L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 86,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3613535448341323939L),
new System.Numerics.BigInteger(8096930367862926597L),
new System.Numerics.BigInteger(6631013301073115639L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 33,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4398095856359039463L),
new System.Numerics.BigInteger(8495010596396168130L),
new System.Numerics.BigInteger(1680296335921288354L),
new System.Numerics.BigInteger(1622231713684171862L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2081121047935687925L),
new System.Numerics.BigInteger(5107451553717556025L),
new System.Numerics.BigInteger(6978639459368827486L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6402279022355716246L),
new System.Numerics.BigInteger(4667117739005737946L),
new System.Numerics.BigInteger(3440077149390160452L),
new System.Numerics.BigInteger(1953049570030187668L),
},
},
            new BigIntegernumericArray1M
{
    Id = 93,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(40107349343827749L),
new System.Numerics.BigInteger(5259630569698621541L),
new System.Numerics.BigInteger(8043372473002639491L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 95,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(708301460760727042L),
new System.Numerics.BigInteger(212641284250356336L),
new System.Numerics.BigInteger(7719974667530414906L),
new System.Numerics.BigInteger(5862260331411204025L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 42,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7992143142487743046L),
new System.Numerics.BigInteger(9217990711565375110L),
new System.Numerics.BigInteger(7814720964403318876L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6116966311937057847L),
new System.Numerics.BigInteger(4457517339220168537L),
new System.Numerics.BigInteger(7303948303477498437L),
},
},
            new BigIntegernumericArray1M
{
    Id = 104,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6727867589183902695L),
new System.Numerics.BigInteger(3795014875001144759L),
new System.Numerics.BigInteger(2410037044149486943L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 106,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6885799285652425140L),
new System.Numerics.BigInteger(4344499672388653037L),
new System.Numerics.BigInteger(6168637835423463483L),
new System.Numerics.BigInteger(8672351862704770553L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 46,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1030342935012166540L),
new System.Numerics.BigInteger(7970543623651562237L),
new System.Numerics.BigInteger(6549221928271511968L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4794875469282492954L),
new System.Numerics.BigInteger(7456501606738114808L),
new System.Numerics.BigInteger(6954654362576000351L),
},
},
            new BigIntegernumericArray1M
{
    Id = 109,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6279341085099496224L),
new System.Numerics.BigInteger(324088189748920380L),
new System.Numerics.BigInteger(2172708730393169264L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 118,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4750303879864638691L),
new System.Numerics.BigInteger(4327828540561440406L),
new System.Numerics.BigInteger(3098884965822786453L),
new System.Numerics.BigInteger(1659692192428380948L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 53,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(625878761929442256L),
new System.Numerics.BigInteger(6185815344602566089L),
new System.Numerics.BigInteger(3930718704909911856L),
new System.Numerics.BigInteger(1474775384314721438L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7725568917734196071L),
new System.Numerics.BigInteger(2276414658331792426L),
new System.Numerics.BigInteger(3459905261984837928L),
new System.Numerics.BigInteger(4299190685254915180L),
},
},
            new BigIntegernumericArray1M
{
    Id = 122,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3127718913238315620L),
new System.Numerics.BigInteger(4372318029862728761L),
new System.Numerics.BigInteger(6166318224766938650L),
new System.Numerics.BigInteger(6037467708154590549L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4987823892251959741L),
new System.Numerics.BigInteger(1628292519015698034L),
new System.Numerics.BigInteger(1739851500997372202L),
new System.Numerics.BigInteger(7105178568176805936L),
},
},
            new BigIntegernumericArray1M
{
    Id = 130,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5450301455802037969L),
new System.Numerics.BigInteger(4754409042661687849L),
new System.Numerics.BigInteger(1174859044322888825L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6152898805378696484L),
new System.Numerics.BigInteger(5293840218156981086L),
new System.Numerics.BigInteger(7391747208313430191L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1683250673626149674L),
new System.Numerics.BigInteger(4295237692707142053L),
new System.Numerics.BigInteger(8616863750757425427L),
},
},
            new BigIntegernumericArray1M
{
    Id = 139,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7731812405698467664L),
new System.Numerics.BigInteger(66622738583093232L),
new System.Numerics.BigInteger(8718199566900651446L),
new System.Numerics.BigInteger(8961423551608822615L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 148,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(281815522679727290L),
new System.Numerics.BigInteger(3759564008443615921L),
new System.Numerics.BigInteger(5334180893409050911L),
new System.Numerics.BigInteger(1830518147077204575L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 63,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1796103840081777666L),
new System.Numerics.BigInteger(7178906606376312706L),
new System.Numerics.BigInteger(551662901719517508L),
new System.Numerics.BigInteger(5470539854065431789L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5595886353201978192L),
new System.Numerics.BigInteger(404035713102221403L),
new System.Numerics.BigInteger(4836108325125637183L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 156,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3651480794875948225L),
new System.Numerics.BigInteger(33093133087344570L),
new System.Numerics.BigInteger(3079060077468527088L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8163762831975702674L),
new System.Numerics.BigInteger(1816153020461720713L),
new System.Numerics.BigInteger(2486582219536484580L),
new System.Numerics.BigInteger(7337739262229885570L),
},
},
            new BigIntegernumericArray1M
{
    Id = 165,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4500684042384010025L),
new System.Numerics.BigInteger(8129957090206107235L),
new System.Numerics.BigInteger(4361806041282394127L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 67,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8627633128298688916L),
new System.Numerics.BigInteger(7677807983722747187L),
new System.Numerics.BigInteger(2601272622282826818L),
new System.Numerics.BigInteger(3122419595530180941L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5913487053933073724L),
new System.Numerics.BigInteger(5294167132139622862L),
new System.Numerics.BigInteger(3878691437677211642L),
new System.Numerics.BigInteger(3348424198031314674L),
},
},
            new BigIntegernumericArray1M
{
    Id = 168,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8082452190559674535L),
new System.Numerics.BigInteger(2221543893099122661L),
new System.Numerics.BigInteger(8827628378899388769L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4979374794448129479L),
new System.Numerics.BigInteger(8044535541373190321L),
new System.Numerics.BigInteger(2254362465970373249L),
},
},
            new BigIntegernumericArray1M
{
    Id = 173,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1680442537429672253L),
new System.Numerics.BigInteger(1739111489943133273L),
new System.Numerics.BigInteger(2115430606410707435L),
new System.Numerics.BigInteger(6865576641370132231L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 70,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7795403247894728013L),
new System.Numerics.BigInteger(2277295377614876020L),
new System.Numerics.BigInteger(7114565451695029673L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2948979445198680632L),
new System.Numerics.BigInteger(1124889855942586007L),
new System.Numerics.BigInteger(5225604045063510980L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8166559938497546159L),
new System.Numerics.BigInteger(2618780228893229674L),
new System.Numerics.BigInteger(8695903145589605945L),
new System.Numerics.BigInteger(369408550456128048L),
},
},
            new BigIntegernumericArray1M
{
    Id = 179,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1141091302100654039L),
new System.Numerics.BigInteger(4758447267427215374L),
new System.Numerics.BigInteger(7158734845445427225L),
new System.Numerics.BigInteger(8500867150441328078L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 182,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4106619943681153226L),
new System.Numerics.BigInteger(3996125122300038947L),
new System.Numerics.BigInteger(6531471297285300368L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 71,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(433522034319298680L),
new System.Numerics.BigInteger(6167501408782575429L),
new System.Numerics.BigInteger(245340421042882753L),
new System.Numerics.BigInteger(789089616529269942L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(187733091325822450L),
new System.Numerics.BigInteger(5295588598862106281L),
new System.Numerics.BigInteger(208906717975386639L),
},
},
            new BigIntegernumericArray1M
{
    Id = 190,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3689412083738924718L),
new System.Numerics.BigInteger(6855010538238160205L),
new System.Numerics.BigInteger(6939487569249410944L),
new System.Numerics.BigInteger(1668319573348557123L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2558836194369528567L),
new System.Numerics.BigInteger(1690911323329818106L),
new System.Numerics.BigInteger(9128958422632476545L),
},
},
            new BigIntegernumericArray1M
{
    Id = 194,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3568557956189656589L),
new System.Numerics.BigInteger(3082042222072677557L),
new System.Numerics.BigInteger(7129972601470302652L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2924135126988223636L),
new System.Numerics.BigInteger(6152514811483761364L),
new System.Numerics.BigInteger(5700658084283998279L),
new System.Numerics.BigInteger(4031898802490098667L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2406180438763025199L),
new System.Numerics.BigInteger(1158664547877937710L),
new System.Numerics.BigInteger(7880440463174068061L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8041006417806304113L),
new System.Numerics.BigInteger(4298072485744057049L),
new System.Numerics.BigInteger(173569507230470868L),
},
},
            new BigIntegernumericArray1M
{
    Id = 199,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7979008059660498059L),
new System.Numerics.BigInteger(1276522631620967414L),
new System.Numerics.BigInteger(5095737372942623681L),
},
    ModelInner = null,
    NullableValue = null,
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 190;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[34], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[34], false);
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
                parametr1.Value = 40;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[2], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[3], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[4], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[5], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[29],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[30],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[31],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 40, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[34], false);
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 3, query1, 179, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 56, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 13, query1, 168, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 83, query1, 182, query2))
                {
                    if(++resultIndex == 1)
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 118, query1, 75, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 86, query1, 130, query2))
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[34], false);
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 165, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 3, 130))
                {
                    if(++resultIndex == 1)
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 48, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[34], false);
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
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 139);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 173);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[30], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[31], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[32], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[33], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[34], false);
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

