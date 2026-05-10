

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
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7731814714766887185L),
new System.Numerics.BigInteger(6192503305827590179L),
new System.Numerics.BigInteger(2830886757778581419L),
new System.Numerics.BigInteger(602151858268990262L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6468168540850028781L),
new System.Numerics.BigInteger(3619140032232772396L),
new System.Numerics.BigInteger(5625434237370792771L),
new System.Numerics.BigInteger(4546194292129100535L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 5,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8097356311474952796L),
new System.Numerics.BigInteger(1057930405163991017L),
new System.Numerics.BigInteger(347891149166552428L),
new System.Numerics.BigInteger(3823883950224894195L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5283560947510070023L),
new System.Numerics.BigInteger(7370931747835698874L),
new System.Numerics.BigInteger(6827425315916555721L),
new System.Numerics.BigInteger(6987844034398533993L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 20,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2069827019733241198L),
new System.Numerics.BigInteger(8862808783942559589L),
new System.Numerics.BigInteger(6638875920759834860L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7528374788594967865L),
new System.Numerics.BigInteger(6482820260584714290L),
new System.Numerics.BigInteger(1851991838788095107L),
new System.Numerics.BigInteger(725305488748081735L),
},
},
            new BigIntegernumericArray1M
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5059788283929025738L),
new System.Numerics.BigInteger(8550838466704112717L),
new System.Numerics.BigInteger(2057331632342681565L),
new System.Numerics.BigInteger(6427602420555477617L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 7,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1041356405879709164L),
new System.Numerics.BigInteger(5754558951807814131L),
new System.Numerics.BigInteger(5221482422444124497L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7399996539765143369L),
new System.Numerics.BigInteger(7255060983877863687L),
new System.Numerics.BigInteger(4637298687351840679L),
new System.Numerics.BigInteger(287271109808615163L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5518551227535326634L),
new System.Numerics.BigInteger(5099863243935862362L),
new System.Numerics.BigInteger(7983213157827483112L),
},
},
            new BigIntegernumericArray1M
{
    Id = 32,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4062022722705170970L),
new System.Numerics.BigInteger(9041641013890768248L),
new System.Numerics.BigInteger(620591228918834264L),
new System.Numerics.BigInteger(3733399869553418677L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4048524468585372372L),
new System.Numerics.BigInteger(3848432387352394687L),
new System.Numerics.BigInteger(5437897486653060291L),
},
},
            new BigIntegernumericArray1M
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(977104462573335728L),
new System.Numerics.BigInteger(7099565066253369800L),
new System.Numerics.BigInteger(4919711781277468445L),
new System.Numerics.BigInteger(3388912695736466965L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 13,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3846065067876585027L),
new System.Numerics.BigInteger(6661482591438580030L),
new System.Numerics.BigInteger(5338265736793399987L),
new System.Numerics.BigInteger(7906488971598816257L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6774815760717920820L),
new System.Numerics.BigInteger(4109872887754438583L),
new System.Numerics.BigInteger(7006719164943385681L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3796969871053296067L),
new System.Numerics.BigInteger(7686482528055006065L),
new System.Numerics.BigInteger(4822510459271586767L),
new System.Numerics.BigInteger(2330051571692875975L),
},
},
            new BigIntegernumericArray1M
{
    Id = 37,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7827302408368297166L),
new System.Numerics.BigInteger(4926568639362309156L),
new System.Numerics.BigInteger(5154139030867184629L),
new System.Numerics.BigInteger(1741147288305647226L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7072813558173998672L),
new System.Numerics.BigInteger(2508490179657996838L),
new System.Numerics.BigInteger(8034789865316728602L),
new System.Numerics.BigInteger(7305081611728285107L),
},
},
            new BigIntegernumericArray1M
{
    Id = 45,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1309339551971437376L),
new System.Numerics.BigInteger(2927670707318977598L),
new System.Numerics.BigInteger(431083113274775412L),
new System.Numerics.BigInteger(784641290404857277L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 20,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(689880940527434859L),
new System.Numerics.BigInteger(488573450628094006L),
new System.Numerics.BigInteger(4921545964880845967L),
new System.Numerics.BigInteger(1374985444363830414L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3875356902710798075L),
new System.Numerics.BigInteger(6172794007960527164L),
new System.Numerics.BigInteger(7689129710934583718L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(222214495938322479L),
new System.Numerics.BigInteger(3539740902622526352L),
new System.Numerics.BigInteger(9110691422878814163L),
},
},
            new BigIntegernumericArray1M
{
    Id = 52,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2813724017427618926L),
new System.Numerics.BigInteger(1808434848668463951L),
new System.Numerics.BigInteger(6312737461429888922L),
new System.Numerics.BigInteger(8621522093352425067L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 55,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2554542684702513808L),
new System.Numerics.BigInteger(5915835797398997937L),
new System.Numerics.BigInteger(3654964202803114303L),
new System.Numerics.BigInteger(1842640266568856469L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1784877097294833296L),
new System.Numerics.BigInteger(4171278246481630120L),
new System.Numerics.BigInteger(4562218782597439211L),
new System.Numerics.BigInteger(7587879167600965980L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7719852547138901941L),
new System.Numerics.BigInteger(4571612330369274654L),
new System.Numerics.BigInteger(1507639512635046189L),
},
},
            new BigIntegernumericArray1M
{
    Id = 64,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7059411112607568312L),
new System.Numerics.BigInteger(1916014859493598052L),
new System.Numerics.BigInteger(5686134170583709000L),
new System.Numerics.BigInteger(4774725988168215328L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5392283956849750644L),
new System.Numerics.BigInteger(3610574291434863765L),
new System.Numerics.BigInteger(3834085965553190629L),
new System.Numerics.BigInteger(5521185520904684589L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 35,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8259246034325163186L),
new System.Numerics.BigInteger(863098634230805723L),
new System.Numerics.BigInteger(4213228070744630565L),
new System.Numerics.BigInteger(8958699281097914465L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5300152212020213009L),
new System.Numerics.BigInteger(1937575896154737160L),
new System.Numerics.BigInteger(2915780487031597600L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 67,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6891292052102197179L),
new System.Numerics.BigInteger(5044403462951713339L),
new System.Numerics.BigInteger(2803059679018357409L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 69,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2672347662997727490L),
new System.Numerics.BigInteger(4120185035468497858L),
new System.Numerics.BigInteger(1435992404536250581L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 43,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3883818751180022149L),
new System.Numerics.BigInteger(4930041312361687718L),
new System.Numerics.BigInteger(1982988495412503222L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9082735315575865884L),
new System.Numerics.BigInteger(7632879882358561044L),
new System.Numerics.BigInteger(1314469356035173924L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 74,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7693238053758316137L),
new System.Numerics.BigInteger(3533665125929267523L),
new System.Numerics.BigInteger(8370696210895530576L),
new System.Numerics.BigInteger(1573299580800557111L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3738296857969719017L),
new System.Numerics.BigInteger(2774298099595945434L),
new System.Numerics.BigInteger(6631144119528679023L),
},
},
            new BigIntegernumericArray1M
{
    Id = 78,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1720717824809209032L),
new System.Numerics.BigInteger(2119950104508880340L),
new System.Numerics.BigInteger(7970978909028887618L),
new System.Numerics.BigInteger(6597238666340904657L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 50,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2421544277569354610L),
new System.Numerics.BigInteger(8271683371614577917L),
new System.Numerics.BigInteger(6116595321133576784L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 86,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8882525220379755956L),
new System.Numerics.BigInteger(8209502522520773171L),
new System.Numerics.BigInteger(455748643191131470L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6986977760906990032L),
new System.Numerics.BigInteger(3951991726969720461L),
new System.Numerics.BigInteger(7548699799828944145L),
new System.Numerics.BigInteger(4348415713395812852L),
},
},
            new BigIntegernumericArray1M
{
    Id = 94,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(204006612467172541L),
new System.Numerics.BigInteger(1575405128984122271L),
new System.Numerics.BigInteger(8733365293405366914L),
new System.Numerics.BigInteger(6662964522010831267L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 55,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3554779579392091871L),
new System.Numerics.BigInteger(24102780613040028L),
new System.Numerics.BigInteger(3429282787304713050L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(522899535833255066L),
new System.Numerics.BigInteger(1319646698140954940L),
new System.Numerics.BigInteger(6283268171612626232L),
new System.Numerics.BigInteger(5175896541890221636L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5234108229237836782L),
new System.Numerics.BigInteger(5221317363141954957L),
new System.Numerics.BigInteger(1623052111420208528L),
},
},
            new BigIntegernumericArray1M
{
    Id = 95,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3155845044849845499L),
new System.Numerics.BigInteger(5774306390135850600L),
new System.Numerics.BigInteger(6917829957567314282L),
new System.Numerics.BigInteger(1778022196852993499L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 101,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8315125754800315267L),
new System.Numerics.BigInteger(4570320947688265333L),
new System.Numerics.BigInteger(159944401858078749L),
new System.Numerics.BigInteger(3685973220810678864L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 59,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3641039470574881984L),
new System.Numerics.BigInteger(4164286492306382038L),
new System.Numerics.BigInteger(7913516234273738011L),
new System.Numerics.BigInteger(2231117161411312500L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 105,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5031149364194533076L),
new System.Numerics.BigInteger(1687853189757746553L),
new System.Numerics.BigInteger(3651563538116567636L),
new System.Numerics.BigInteger(5587599429301840484L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1733299891783699538L),
new System.Numerics.BigInteger(8497059941297473759L),
new System.Numerics.BigInteger(1074905520553996081L),
new System.Numerics.BigInteger(6638904866556061619L),
},
},
            new BigIntegernumericArray1M
{
    Id = 109,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2672374499428019443L),
new System.Numerics.BigInteger(6542677219974579548L),
new System.Numerics.BigInteger(3089807880350536802L),
new System.Numerics.BigInteger(6769315305878318469L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 68,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4718310685631891208L),
new System.Numerics.BigInteger(4322052657010675233L),
new System.Numerics.BigInteger(8527055781293544578L),
new System.Numerics.BigInteger(4292225815733454373L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5611256492487359302L),
new System.Numerics.BigInteger(735492771861107135L),
new System.Numerics.BigInteger(4725140756837678679L),
new System.Numerics.BigInteger(7775320786232897347L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4392523399726221614L),
new System.Numerics.BigInteger(2259477934077159359L),
new System.Numerics.BigInteger(7978155602477172717L),
new System.Numerics.BigInteger(6549577561347668899L),
},
},
            new BigIntegernumericArray1M
{
    Id = 110,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6146316970210404219L),
new System.Numerics.BigInteger(1109848253026268531L),
new System.Numerics.BigInteger(4797376340728052635L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 119,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8723453314194578297L),
new System.Numerics.BigInteger(6851346646718391142L),
new System.Numerics.BigInteger(8673158341324280568L),
new System.Numerics.BigInteger(6762996933558824866L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6621609068834277481L),
new System.Numerics.BigInteger(8808609521652170914L),
new System.Numerics.BigInteger(680742591238870217L),
new System.Numerics.BigInteger(2700185897640364852L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5379310247639924911L),
new System.Numerics.BigInteger(4706484116162736745L),
new System.Numerics.BigInteger(3662601724496656121L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8010704165358604250L),
new System.Numerics.BigInteger(3358932076376388726L),
new System.Numerics.BigInteger(3652698746815591073L),
new System.Numerics.BigInteger(1909423646119479794L),
},
},
            new BigIntegernumericArray1M
{
    Id = 128,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8186734764353543322L),
new System.Numerics.BigInteger(2510930907563008141L),
new System.Numerics.BigInteger(1333383107762902331L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 135,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5555423563458290291L),
new System.Numerics.BigInteger(5402445012088614106L),
new System.Numerics.BigInteger(3121762322181697147L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 80,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(9124203240471114612L),
new System.Numerics.BigInteger(6844275357402312130L),
new System.Numerics.BigInteger(5403664901194976239L),
new System.Numerics.BigInteger(6866740576735165616L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 136,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2043985413885156497L),
new System.Numerics.BigInteger(4701390639102795751L),
new System.Numerics.BigInteger(5317074178116046816L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(381457558476613362L),
new System.Numerics.BigInteger(1769480836963293600L),
new System.Numerics.BigInteger(662448454898377745L),
},
},
            new BigIntegernumericArray1M
{
    Id = 141,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3946308538874459921L),
new System.Numerics.BigInteger(7053532043912257197L),
new System.Numerics.BigInteger(6894689471063963554L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 82,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6783633719409137839L),
new System.Numerics.BigInteger(2932086057818887195L),
new System.Numerics.BigInteger(901854294431029944L),
new System.Numerics.BigInteger(5649924547952120905L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8295387769426875037L),
new System.Numerics.BigInteger(4309530906086697180L),
new System.Numerics.BigInteger(1435905535350081330L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8523601636708688343L),
new System.Numerics.BigInteger(6572932986727465718L),
new System.Numerics.BigInteger(8607239983494775940L),
},
},
            new BigIntegernumericArray1M
{
    Id = 147,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1196462865723127269L),
new System.Numerics.BigInteger(1526992414715379440L),
new System.Numerics.BigInteger(6760492491545876527L),
new System.Numerics.BigInteger(134429435926669947L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 153,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4317635840737131232L),
new System.Numerics.BigInteger(5289477195327113295L),
new System.Numerics.BigInteger(6299106077744858185L),
new System.Numerics.BigInteger(6291505834693249777L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 85,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(224607098844398047L),
new System.Numerics.BigInteger(7121893610359349300L),
new System.Numerics.BigInteger(5637258062786732652L),
new System.Numerics.BigInteger(6729213386223771787L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 156,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(142425048478651712L),
new System.Numerics.BigInteger(8718228059298814038L),
new System.Numerics.BigInteger(2682592906457403404L),
new System.Numerics.BigInteger(5974468070939985182L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 159,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6306844067719899293L),
new System.Numerics.BigInteger(8767292691727956328L),
new System.Numerics.BigInteger(6555417519720470191L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 89,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291144455133966827L),
new System.Numerics.BigInteger(3316268570916595733L),
new System.Numerics.BigInteger(3800178630646669068L),
new System.Numerics.BigInteger(3836398149484406217L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 165,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3278558403875378298L),
new System.Numerics.BigInteger(6103710337509455359L),
new System.Numerics.BigInteger(3279521514786964268L),
new System.Numerics.BigInteger(5165183070257364509L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(68688725150283340L),
new System.Numerics.BigInteger(3848406272283007488L),
new System.Numerics.BigInteger(1602872630502669930L),
new System.Numerics.BigInteger(3130380656404204768L),
},
},
            new BigIntegernumericArray1M
{
    Id = 169,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(9208306049904129895L),
new System.Numerics.BigInteger(7230833550814890259L),
new System.Numerics.BigInteger(7298884905115208230L),
new System.Numerics.BigInteger(3575991637455311717L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 92,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6622920169931430845L),
new System.Numerics.BigInteger(3422697303182096493L),
new System.Numerics.BigInteger(2505610673927543057L),
new System.Numerics.BigInteger(8829040450063301703L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(589578850973795270L),
new System.Numerics.BigInteger(1372077537896505137L),
new System.Numerics.BigInteger(7255792370852720048L),
new System.Numerics.BigInteger(8484890033575434000L),
},
},
            new BigIntegernumericArray1M
{
    Id = 171,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7087102832808351336L),
new System.Numerics.BigInteger(1268780686983044025L),
new System.Numerics.BigInteger(4334369452435904188L),
new System.Numerics.BigInteger(239166648401309911L),
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr2.Value = 52;
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[34], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 9, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 55, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 9, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 141, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 36, query1, 9, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[33],_testData[34], false);
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 74, query1, 20, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 52, query1, 55, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 36, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 65, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 20, 52))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[30], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[31], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[32], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[33], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

