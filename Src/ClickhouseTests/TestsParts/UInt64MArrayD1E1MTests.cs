

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
    internal partial interface IUInt64MArrayMArrayD1
    {
    }
    
    internal partial class UInt64MArrayMArrayD1 : IUInt64MArrayMArrayD1
    {


#region TestData

        private readonly UInt64MArrayD1E1M[] _testData = new UInt64MArrayD1E1M[]
        {
            new UInt64MArrayD1E1M
{
    Id = 4,
    Value = 
new System.UInt64[4]
{
3986508637198414879L,
862547547418449755L,
6913397817457326311L,
8437001203817744639L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 6,
    Value = 
new System.UInt64[3]
{
3236998412112485915L,
5159025612368223225L,
101069184089000134L,
},
    NullableValue = 
new System.UInt64[3]
{
2833661629047197217L,
4283931818308733812L,
8366242022478047220L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 11,
    Value = 
new System.UInt64[4]
{
9164634337137728675L,
1111167640090174761L,
8175428624502366169L,
4007128597571630297L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 10,
    Value = 
new System.UInt64[4]
{
6315200302957365371L,
4127431450927177060L,
914271596373201134L,
8238066082750638120L,
},
    NullableValue = 
new System.UInt64[4]
{
900713169297573389L,
7321447765706035527L,
9043063925221522764L,
424198479157603953L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 20,
    Value = 
new System.UInt64[4]
{
1161914627686605564L,
3739019777223623749L,
393689453896488510L,
6719765585341042808L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 13,
    Value = 
new System.UInt64[4]
{
466598741575710735L,
2118859775924982339L,
833229341134487481L,
732663774914573037L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 28,
    Value = 
new System.UInt64[4]
{
6116981962502591730L,
4659694808049916890L,
1914795688259558959L,
3115796840924268733L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 19,
    Value = 
new System.UInt64[4]
{
1827131958599955629L,
6270503545306901184L,
3867760383302093768L,
2623011729839287772L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 33,
    Value = 
new System.UInt64[3]
{
4165982127618754200L,
6854947575329971846L,
142570227730789536L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 23,
    Value = 
new System.UInt64[4]
{
6150442216935758903L,
4128135684651971231L,
4805123658632173660L,
5038924033031280030L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 36,
    Value = 
new System.UInt64[4]
{
3012866357832479058L,
1609125774607437357L,
1861620239784688179L,
6138434323850767994L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 31,
    Value = 
new System.UInt64[4]
{
301073991727198451L,
6013025757101504529L,
2764477783610340332L,
2044839244156130296L,
},
    NullableValue = 
new System.UInt64[4]
{
9140742637133791356L,
4424485637103345283L,
2957835848256404176L,
957253571413269972L,
},
},
    NullableValue = 
new System.UInt64[3]
{
2388499297883364610L,
628164644443329662L,
5543150629322370343L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 44,
    Value = 
new System.UInt64[4]
{
5255084709983797869L,
19819046798662241L,
1184958666708514441L,
7499890182438314218L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 34,
    Value = 
new System.UInt64[4]
{
287859331691477550L,
2786292879793665969L,
1787796553676591357L,
180467210155169288L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 53,
    Value = 
new System.UInt64[4]
{
3549086308689402783L,
4108937842052623538L,
4533373823583528459L,
6944471905848946794L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 40,
    Value = 
new System.UInt64[3]
{
4091646930106880311L,
2844932917921155089L,
682157575467149988L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
4752836728104222617L,
6995666124648231485L,
7551242160893969372L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 58,
    Value = 
new System.UInt64[4]
{
4250770080016584174L,
9157516813943576738L,
4245120587531675576L,
2805723845061172778L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 42,
    Value = 
new System.UInt64[3]
{
5718730632945884445L,
4816528666360169200L,
6376066129162094150L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
8593915562941473123L,
5528372029453686947L,
4402722168421080070L,
8274362420052460048L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 63,
    Value = 
new System.UInt64[4]
{
975531933349743491L,
7316533965213503315L,
7477236023645847195L,
8583868740936265883L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 50,
    Value = 
new System.UInt64[3]
{
6594885138360556765L,
8914994447194334490L,
800667072946818495L,
},
    NullableValue = 
new System.UInt64[4]
{
7118439460212160299L,
2143017890033482121L,
4320072856692385534L,
1753746837972976230L,
},
},
    NullableValue = 
new System.UInt64[4]
{
7221317525138053801L,
7535702864516477263L,
6430554841233271044L,
907487583629469938L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 70,
    Value = 
new System.UInt64[4]
{
7047725943998510463L,
7292151295657283947L,
9017061065783227146L,
6482337986069140900L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 56,
    Value = 
new System.UInt64[3]
{
256805319790215833L,
5585042186082677885L,
2867068384457090240L,
},
    NullableValue = 
new System.UInt64[3]
{
1887601821620651681L,
2857993801186050482L,
7473003054850544668L,
},
},
    NullableValue = 
new System.UInt64[4]
{
4231792130399975185L,
5091077634837384638L,
8352974683299237366L,
2844608796279897621L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 76,
    Value = 
new System.UInt64[4]
{
2583595957520997701L,
3977735703238315133L,
5924235419644011883L,
614626193211065277L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 60,
    Value = 
new System.UInt64[4]
{
3917625321452277732L,
6098672651898945025L,
7817113601580837894L,
8680410669820682764L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
2056419125615536003L,
5549775373793685198L,
7542250526157450269L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 81,
    Value = 
new System.UInt64[3]
{
6171581676657421556L,
5409066388478464846L,
2791395719928240532L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 67,
    Value = 
new System.UInt64[4]
{
1240662221125125698L,
202127377683705848L,
4277662025589747350L,
4333417695646352850L,
},
    NullableValue = 
new System.UInt64[4]
{
2816117175247026433L,
2447283791713829504L,
530335112105191416L,
2538735086201587031L,
},
},
    NullableValue = 
new System.UInt64[4]
{
6411458967612601717L,
1380435122650402801L,
1485064650139294896L,
2914943040265806097L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 88,
    Value = 
new System.UInt64[3]
{
546109311823562995L,
7322980521995013789L,
6466139408552873834L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 76,
    Value = 
new System.UInt64[4]
{
693064325460284439L,
4632938722405952952L,
5492396069781978575L,
6636870507252775154L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
3378023902310536855L,
5783804752761462282L,
520737706389490058L,
1176796874331803476L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 94,
    Value = 
new System.UInt64[3]
{
6211164347520547867L,
4612816628102184845L,
7753717352023730270L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 82,
    Value = 
new System.UInt64[4]
{
1944077853357618667L,
2221906064890238237L,
2597005989960257660L,
5757171451913656660L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
6186045471827031844L,
8333898857221368204L,
3587266816897225480L,
2919289290148290192L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 98,
    Value = 
new System.UInt64[3]
{
2774455557282921155L,
6907265529299023258L,
4883361630835306764L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.UInt64[3]
{
6833574534450759982L,
2563163165438056012L,
4999331792326190895L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
4206195396201773199L,
2773109196938108326L,
6243780366059009837L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 107,
    Value = 
new System.UInt64[3]
{
4439058015247559552L,
5147431297392673332L,
8793133306100535925L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 92,
    Value = 
new System.UInt64[3]
{
6864804240813422475L,
7651486150690249727L,
126802782511147165L,
},
    NullableValue = 
new System.UInt64[3]
{
1986708868031259140L,
3212493397215040188L,
90464171126358213L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 108,
    Value = 
new System.UInt64[4]
{
3469700610061612321L,
7070106435465546467L,
773403180467529238L,
264301804823242699L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 99,
    Value = 
new System.UInt64[4]
{
6047525766063498527L,
7326690449655454525L,
6079436126630820392L,
4340127533368769944L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 116,
    Value = 
new System.UInt64[4]
{
3988469898251684548L,
4154627280187562722L,
8330355677119540605L,
8095620397377610625L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 107,
    Value = 
new System.UInt64[4]
{
5838767909761640326L,
7708013528413885864L,
305342761048130037L,
6577800236624344576L,
},
    NullableValue = 
new System.UInt64[4]
{
7437308968063029613L,
7909095634768437773L,
8871099275538320432L,
5681315354678583646L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 124,
    Value = 
new System.UInt64[3]
{
4019457208227145074L,
5091575685630655213L,
4419110813760030918L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 108,
    Value = 
new System.UInt64[3]
{
940001539393376179L,
1125610002956320409L,
4171220819597777731L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
8960048671530503971L,
8064732475068469721L,
3446217419481037525L,
8991100742583397895L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 132,
    Value = 
new System.UInt64[3]
{
5918697987680150078L,
2590678112430068546L,
1493345327551501236L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 113,
    Value = 
new System.UInt64[4]
{
7428415433414247304L,
1296929815871500561L,
4605925672995842006L,
3749003534092188770L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 141,
    Value = 
new System.UInt64[3]
{
4606444991010104987L,
903347119661023690L,
7082953446474338588L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 118,
    Value = 
new System.UInt64[4]
{
3283376356115391537L,
1575001196069845297L,
3193616164154994772L,
4116106099027136690L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
4679895875619622200L,
5746565861685142921L,
8371863810645031965L,
397868969113336454L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 145,
    Value = 
new System.UInt64[3]
{
6664431363350372048L,
6763711214962852561L,
576496408364152246L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 123,
    Value = 
new System.UInt64[3]
{
3781653048725532409L,
7119197448288679181L,
2133087994484334813L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
2351837143658297552L,
3701241652463889492L,
1694392260413511231L,
8301833777984870108L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 154,
    Value = 
new System.UInt64[4]
{
3288256053326623092L,
7751415657231763339L,
3422853357866105972L,
6889504526668760119L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 128,
    Value = 
new System.UInt64[4]
{
4565727063866326867L,
925621066027458624L,
4345949492761908478L,
7513151132258871548L,
},
    NullableValue = 
new System.UInt64[3]
{
1743117488602984631L,
181759748363367991L,
278829662410665132L,
},
},
    NullableValue = 
new System.UInt64[3]
{
4116798095799779076L,
7466764054412916688L,
8693565441956123485L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 156,
    Value = 
new System.UInt64[4]
{
9019191905771266525L,
2545018112894859229L,
7098817788436512432L,
440874139353411329L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 130,
    Value = 
new System.UInt64[4]
{
7500697046961631842L,
7747838952483515693L,
5049880015429184591L,
8985452581061825913L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
3687397123075028113L,
4610352916650329610L,
6847144160048502464L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 160,
    Value = 
new System.UInt64[4]
{
3915938144552246696L,
3534859280788921640L,
6143014606535958821L,
604494302602889201L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 134,
    Value = 
new System.UInt64[4]
{
1443222253833084136L,
2725702753601179358L,
1991220064334818831L,
6254606738044955614L,
},
    NullableValue = 
new System.UInt64[3]
{
5601263752568082757L,
5708726250973564313L,
4258153327421138302L,
},
},
    NullableValue = 
new System.UInt64[3]
{
4151783368874690311L,
3983653973674550707L,
1476188429952140974L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 167,
    Value = 
new System.UInt64[4]
{
7340273996485041490L,
7664889795911420981L,
2509830790340245279L,
3321112415364706989L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 143,
    Value = 
new System.UInt64[3]
{
5181395269385583553L,
7787354767078980003L,
3903466368424186552L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
1993258211588367091L,
2473390942537390960L,
44585202208980830L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 175,
    Value = 
new System.UInt64[3]
{
973111684480892606L,
7838434233718862023L,
8005221214050484023L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 150,
    Value = 
new System.UInt64[3]
{
7733209986055017474L,
2067121491767105522L,
8266364346851930263L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 182,
    Value = 
new System.UInt64[4]
{
3377031593952738683L,
4017594156886569521L,
5688759494565918658L,
1667801084961654587L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 151,
    Value = 
new System.UInt64[4]
{
42167368138798402L,
9217476925301475984L,
8080285509601152362L,
8284152295510512572L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
8950076572564572501L,
2718957921983530132L,
1575859311503805094L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 189,
    Value = 
new System.UInt64[4]
{
1375666901223547514L,
5144858377136865196L,
6569526922245961970L,
7850086876627523910L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 155,
    Value = 
new System.UInt64[4]
{
4187873108583096358L,
3932582751142868117L,
8482448847020198231L,
4380276164943005707L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
6711302744854167914L,
9004173836087867491L,
41194196749949135L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 197,
    Value = 
new System.UInt64[4]
{
1798874573350104853L,
6424263957576251995L,
850133518565826562L,
3994638952582336263L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 158,
    Value = 
new System.UInt64[4]
{
8937644658781267949L,
904248031245971298L,
6464651599138827582L,
5896607353675426246L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 205,
    Value = 
new System.UInt64[3]
{
2830169103434090162L,
1808111902781111030L,
1849567357198477547L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 163,
    Value = 
new System.UInt64[4]
{
7329721392863943266L,
5430212711243308360L,
4372203168186236284L,
2109666750004367702L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
4804336390587288491L,
3888871093819826547L,
69638551664990516L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 211,
    Value = 
new System.UInt64[4]
{
5051654843864534277L,
55447524475573437L,
1668990408295530889L,
3895455935697509055L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 165,
    Value = 
new System.UInt64[4]
{
3199641593317452271L,
6636594444242455663L,
6512913050114681116L,
7287438000812287723L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
7699227532262936153L,
712786779525506942L,
525526524482982456L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 212,
    Value = 
new System.UInt64[4]
{
3179704371934176807L,
4351255230953750502L,
4524977777508777241L,
760301274909158181L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 169,
    Value = 
new System.UInt64[4]
{
8645572428880456417L,
2757166731368062349L,
8281989364849321327L,
3518077958470340987L,
},
    NullableValue = 
new System.UInt64[4]
{
551977963969096326L,
7713577738726423664L,
6835820321804490203L,
2511295768331948754L,
},
},
    NullableValue = 
new System.UInt64[4]
{
1250066912199203799L,
2385486888781456459L,
4429146868429208098L,
3458147911550339637L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 221,
    Value = 
new System.UInt64[3]
{
6945028041414771921L,
6862474970755733814L,
654488741574989769L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 177,
    Value = 
new System.UInt64[3]
{
6800626405202526921L,
3311158842269616366L,
6080641988279711333L,
},
    NullableValue = null,
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
INSERT INTO gedaqtests.uint64marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UInt64)}, 
    {mi_id:Int32},
    {mi_value:Array(UInt64)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[]), 
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
                    await ((IUInt64MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IUInt64MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.uint64marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD1)),
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
                    var models = await ((IUInt64MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt64MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

