

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
    internal partial interface IBigIntegerMArraynumericMMArrayD2
    {
    }
    
    internal partial class BigIntegerMArraynumericMMArrayD2 : IBigIntegerMArraynumericMMArrayD2
    {


#region TestData

        private readonly BigIntegernumericMMArrayD2E1M[] _testData = new BigIntegernumericMMArrayD2E1M[]
        {
            new BigIntegernumericMMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(594360133262146862L), new System.Numerics.BigInteger(2425527649192592945L), }, { new System.Numerics.BigInteger(4030861693776249660L), new System.Numerics.BigInteger(7085573545018225516L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 18,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7583393831512635300L), new System.Numerics.BigInteger(6934558897149549449L), }, { new System.Numerics.BigInteger(2279403158347269436L), new System.Numerics.BigInteger(7922129299730633531L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 5,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(184083826720059890L), new System.Numerics.BigInteger(6441055633642185971L), }, { new System.Numerics.BigInteger(6434033951739491234L), new System.Numerics.BigInteger(7514358700780011814L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3624444269579837219L), new System.Numerics.BigInteger(4944838513473921436L), }, { new System.Numerics.BigInteger(6917695743282881719L), new System.Numerics.BigInteger(9186808032275552229L), }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 23,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2675952135057971706L), new System.Numerics.BigInteger(890388546344591751L), }, { new System.Numerics.BigInteger(5689096813863089642L), new System.Numerics.BigInteger(5031266445074197037L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(9068318148758611791L), new System.Numerics.BigInteger(3079334405205258041L), }, { new System.Numerics.BigInteger(4656236108726742887L), new System.Numerics.BigInteger(4812355494149727653L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 24,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(9047793374520671031L), new System.Numerics.BigInteger(2084691104287927263L), }, { new System.Numerics.BigInteger(7110497101934302458L), new System.Numerics.BigInteger(378049257045828099L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8238157645482037776L), new System.Numerics.BigInteger(6064375740016845863L), }, { new System.Numerics.BigInteger(5160686412120780854L), new System.Numerics.BigInteger(8735894928200915314L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6431289114076529705L), new System.Numerics.BigInteger(3781565470541194953L), }, { new System.Numerics.BigInteger(6420319251845234616L), new System.Numerics.BigInteger(5782616575309855522L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5641287114607209185L), new System.Numerics.BigInteger(5597969238903397599L), }, { new System.Numerics.BigInteger(9054502274946938260L), new System.Numerics.BigInteger(234536802865304728L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 26,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5202872946706048355L), new System.Numerics.BigInteger(5089203514347735448L), }, { new System.Numerics.BigInteger(3991641825912805088L), new System.Numerics.BigInteger(5305602126442444093L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6780613561672825487L), new System.Numerics.BigInteger(3691149227001797236L), }, { new System.Numerics.BigInteger(4521859790825564107L), new System.Numerics.BigInteger(7372657075848048923L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 31,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6667516183799586836L), new System.Numerics.BigInteger(1972538058142150836L), }, { new System.Numerics.BigInteger(1055566099626711912L), new System.Numerics.BigInteger(627646798773493929L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1833783775715071178L), new System.Numerics.BigInteger(7533100255377886283L), }, { new System.Numerics.BigInteger(2404304866531486310L), new System.Numerics.BigInteger(3100431949137820937L), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 34,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1369994659664898301L), new System.Numerics.BigInteger(7817320708353539064L), }, { new System.Numerics.BigInteger(188566694985901796L), new System.Numerics.BigInteger(5049457322843462755L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6050884470366549008L), new System.Numerics.BigInteger(1478811079844666233L), }, { new System.Numerics.BigInteger(5044902932875395450L), new System.Numerics.BigInteger(302905841105659465L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 40,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1595931861702653317L), new System.Numerics.BigInteger(3587291283465938528L), }, { new System.Numerics.BigInteger(1429479462766320995L), new System.Numerics.BigInteger(7475747661875464881L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1315581979547542178L), new System.Numerics.BigInteger(4567814845208450790L), }, { new System.Numerics.BigInteger(2537820996526623028L), new System.Numerics.BigInteger(305373815960435607L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1591280641414516498L), new System.Numerics.BigInteger(555175441294833173L), }, { new System.Numerics.BigInteger(8746379273703553189L), new System.Numerics.BigInteger(2484073353640445613L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 49,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4793590540254410101L), new System.Numerics.BigInteger(4581541836072334108L), }, { new System.Numerics.BigInteger(144153654354657564L), new System.Numerics.BigInteger(4633291708862763163L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8820165567565328481L), new System.Numerics.BigInteger(4386062194161180452L), }, { new System.Numerics.BigInteger(2300812164936035155L), new System.Numerics.BigInteger(5325648807418005838L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 58,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4563126055859224344L), new System.Numerics.BigInteger(1315607859878531920L), }, { new System.Numerics.BigInteger(7617074632863318679L), new System.Numerics.BigInteger(6030110168017837717L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6294514427606631042L), new System.Numerics.BigInteger(4476156027833707737L), }, { new System.Numerics.BigInteger(6569648280741465730L), new System.Numerics.BigInteger(7151049138860558860L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(761773199718176010L), new System.Numerics.BigInteger(391802807997815254L), }, { new System.Numerics.BigInteger(3744367440087031713L), new System.Numerics.BigInteger(2633083700502840339L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3529613226741263340L), new System.Numerics.BigInteger(2558896730088808997L), }, { new System.Numerics.BigInteger(14859280553329240L), new System.Numerics.BigInteger(707921846342380705L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 59,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6929764008494280061L), new System.Numerics.BigInteger(1470353822688710851L), }, { new System.Numerics.BigInteger(5066526035547558286L), new System.Numerics.BigInteger(3910454673661106262L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3978718831774357411L), new System.Numerics.BigInteger(3683238225638817906L), }, { new System.Numerics.BigInteger(2037625074847206487L), new System.Numerics.BigInteger(9107763239601436496L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 67,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5738944033164303480L), new System.Numerics.BigInteger(4960342293358261837L), }, { new System.Numerics.BigInteger(4535716802544886976L), new System.Numerics.BigInteger(3585413848932306548L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8906897786794416333L), new System.Numerics.BigInteger(1845850639198525341L), }, { new System.Numerics.BigInteger(7701403549627252113L), new System.Numerics.BigInteger(6328337721276188700L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8388963797995809656L), new System.Numerics.BigInteger(1565198758007442490L), }, { new System.Numerics.BigInteger(9126105317770688001L), new System.Numerics.BigInteger(3278141382420947965L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5445217199491099913L), new System.Numerics.BigInteger(4754522362258876550L), }, { new System.Numerics.BigInteger(6227915545279445078L), new System.Numerics.BigInteger(687563621349319932L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2767610393782234307L), new System.Numerics.BigInteger(7937041142221660246L), }, { new System.Numerics.BigInteger(2830431280001692800L), new System.Numerics.BigInteger(5807493957612089054L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6361911424190832769L), new System.Numerics.BigInteger(5365757691515963825L), }, { new System.Numerics.BigInteger(670829843947948849L), new System.Numerics.BigInteger(1626287667941517632L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5901629562077597501L), new System.Numerics.BigInteger(1091748427868499819L), }, { new System.Numerics.BigInteger(3837366664098985429L), new System.Numerics.BigInteger(1364506128694093971L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1277989111511618374L), new System.Numerics.BigInteger(770327165780827450L), }, { new System.Numerics.BigInteger(6640607679526944055L), new System.Numerics.BigInteger(7730865999539769514L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2820361617245834262L), new System.Numerics.BigInteger(8725662572465060188L), }, { new System.Numerics.BigInteger(5544460929707399101L), new System.Numerics.BigInteger(7401783299269914657L), }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7408384847609373965L), new System.Numerics.BigInteger(6775036012483663513L), }, { new System.Numerics.BigInteger(2074262234251542198L), new System.Numerics.BigInteger(4707341104530257422L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 85,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2285825393789237587L), new System.Numerics.BigInteger(9138471893008472778L), }, { new System.Numerics.BigInteger(3047194190826006131L), new System.Numerics.BigInteger(1394540012515846841L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 29,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6808814716218123828L), new System.Numerics.BigInteger(6923064094232098969L), }, { new System.Numerics.BigInteger(2850912761807118541L), new System.Numerics.BigInteger(8256209680763531591L), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 90,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4397644816374293015L), new System.Numerics.BigInteger(8085100923608323234L), }, { new System.Numerics.BigInteger(2188971214474767669L), new System.Numerics.BigInteger(7008949478097461322L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 99,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7412407114899189773L), new System.Numerics.BigInteger(711411168749095285L), }, { new System.Numerics.BigInteger(8738396063644807637L), new System.Numerics.BigInteger(7729765661085475121L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2732783837689347758L), new System.Numerics.BigInteger(33460946349137858L), }, { new System.Numerics.BigInteger(4492110940833187100L), new System.Numerics.BigInteger(8256367898412590496L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5810423177076743073L), new System.Numerics.BigInteger(1066154289581057186L), }, { new System.Numerics.BigInteger(7418936131073297175L), new System.Numerics.BigInteger(7826391607533373712L), }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 108,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4321174492853073326L), new System.Numerics.BigInteger(3675721938726226061L), }, { new System.Numerics.BigInteger(1890278990077387940L), new System.Numerics.BigInteger(5176201200898054909L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 112,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7849867722671347115L), new System.Numerics.BigInteger(4261021457577571915L), }, { new System.Numerics.BigInteger(1460137145051162066L), new System.Numerics.BigInteger(1325980624186873698L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8519994932058939L), new System.Numerics.BigInteger(8669361673365289310L), }, { new System.Numerics.BigInteger(8117670744333520400L), new System.Numerics.BigInteger(7166315162815229597L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(9001434517672485642L), new System.Numerics.BigInteger(8904129383422612647L), }, { new System.Numerics.BigInteger(8773318510243512421L), new System.Numerics.BigInteger(4318802129158396626L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2972654873972617764L), new System.Numerics.BigInteger(8171444100056383436L), }, { new System.Numerics.BigInteger(9109316157716584550L), new System.Numerics.BigInteger(8045860790672293497L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6832554398805924552L), new System.Numerics.BigInteger(2533373306418289672L), }, { new System.Numerics.BigInteger(3481353565988839250L), new System.Numerics.BigInteger(249852540551118012L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8443452911565627804L), new System.Numerics.BigInteger(391505267014988409L), }, { new System.Numerics.BigInteger(8905579935709075477L), new System.Numerics.BigInteger(4208094574859857519L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 115,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7606452241327922300L), new System.Numerics.BigInteger(5785782359332899353L), }, { new System.Numerics.BigInteger(4053530403904614451L), new System.Numerics.BigInteger(4649686729039296930L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2348218410173060839L), new System.Numerics.BigInteger(7627192785554839889L), }, { new System.Numerics.BigInteger(5450969617026330574L), new System.Numerics.BigInteger(848662180986899126L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6742845061884827424L), new System.Numerics.BigInteger(1376662739664297529L), }, { new System.Numerics.BigInteger(2722384347307533475L), new System.Numerics.BigInteger(1231038957949590897L), }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6454407048826219805L), new System.Numerics.BigInteger(2883942593107734740L), }, { new System.Numerics.BigInteger(4651216725983364942L), new System.Numerics.BigInteger(1141529999928302998L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 124,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6978876627828222043L), new System.Numerics.BigInteger(259630798333095098L), }, { new System.Numerics.BigInteger(4370618391689829745L), new System.Numerics.BigInteger(900862703000114915L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5412510050944136918L), new System.Numerics.BigInteger(5640077657992278694L), }, { new System.Numerics.BigInteger(8136013969596826734L), new System.Numerics.BigInteger(1970633892205695139L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3611832152796729753L), new System.Numerics.BigInteger(2190279839658593055L), }, { new System.Numerics.BigInteger(275426876345494847L), new System.Numerics.BigInteger(3451359699748668423L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 132,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2068315752047266501L), new System.Numerics.BigInteger(2309624667643246982L), }, { new System.Numerics.BigInteger(2335680601103286213L), new System.Numerics.BigInteger(1120607172837456821L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 133,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4512732053219010193L), new System.Numerics.BigInteger(5566728795656038850L), }, { new System.Numerics.BigInteger(1771971715220870524L), new System.Numerics.BigInteger(8521333834686116697L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7342935359249690590L), new System.Numerics.BigInteger(7152421153970081229L), }, { new System.Numerics.BigInteger(9216126657714184414L), new System.Numerics.BigInteger(2484828820653270683L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1303941014496015445L), new System.Numerics.BigInteger(8370821992964890226L), }, { new System.Numerics.BigInteger(7501231884550044999L), new System.Numerics.BigInteger(3436737385134349795L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 142,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(236843576673929886L), new System.Numerics.BigInteger(1335675032375093519L), }, { new System.Numerics.BigInteger(2867141801068771676L), new System.Numerics.BigInteger(7846524288374148188L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 149,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6190594615941846807L), new System.Numerics.BigInteger(8209616311194189680L), }, { new System.Numerics.BigInteger(5064466841157217597L), new System.Numerics.BigInteger(5194143044662460321L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2144395637228639749L), new System.Numerics.BigInteger(6242587602042630195L), }, { new System.Numerics.BigInteger(114294629459054321L), new System.Numerics.BigInteger(8785354649144953824L), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 152,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6552550409544914093L), new System.Numerics.BigInteger(4593849950903127981L), }, { new System.Numerics.BigInteger(1652644435969973229L), new System.Numerics.BigInteger(9012800140759410232L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8549896677162829778L), new System.Numerics.BigInteger(2369561921106644834L), }, { new System.Numerics.BigInteger(5768981299435326340L), new System.Numerics.BigInteger(5659607047188373662L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8237617177456320141L), new System.Numerics.BigInteger(134876449732124015L), }, { new System.Numerics.BigInteger(8619421614160879476L), new System.Numerics.BigInteger(1516880110654551614L), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 157,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(899238314543598027L), new System.Numerics.BigInteger(2373601623860429120L), }, { new System.Numerics.BigInteger(4778386118949711600L), new System.Numerics.BigInteger(914460386296054770L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4359314687017565907L), new System.Numerics.BigInteger(7018483090182631885L), }, { new System.Numerics.BigInteger(1080253817309146072L), new System.Numerics.BigInteger(2702185775643262074L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 165,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5848784483968214543L), new System.Numerics.BigInteger(523355607569245300L), }, { new System.Numerics.BigInteger(4128656653981709954L), new System.Numerics.BigInteger(2462640882971550616L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2431906205174823185L), new System.Numerics.BigInteger(3921250328614924441L), }, { new System.Numerics.BigInteger(99395305941055872L), new System.Numerics.BigInteger(1664041941840745286L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7065906818022132301L), new System.Numerics.BigInteger(6208592194896445982L), }, { new System.Numerics.BigInteger(3678781621650805995L), new System.Numerics.BigInteger(5991806487767157594L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5938017820223869800L), new System.Numerics.BigInteger(547266007314097211L), }, { new System.Numerics.BigInteger(3957682898737109534L), new System.Numerics.BigInteger(2572877814716080328L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 173,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6994355389797035886L), new System.Numerics.BigInteger(295758112235150908L), }, { new System.Numerics.BigInteger(1182763866850113271L), new System.Numerics.BigInteger(39827240425117108L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 177,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6417569563357892968L), new System.Numerics.BigInteger(3952613084830658376L), }, { new System.Numerics.BigInteger(523616477829235394L), new System.Numerics.BigInteger(5344469653487326285L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1187541354266906310L), new System.Numerics.BigInteger(6066623642492060064L), }, { new System.Numerics.BigInteger(5189847349671405882L), new System.Numerics.BigInteger(863364392152784187L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2587321117034386739L), new System.Numerics.BigInteger(2527669500417947524L), }, { new System.Numerics.BigInteger(61317084039803038L), new System.Numerics.BigInteger(2359596177801742456L), }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 184,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5492164393668098157L), new System.Numerics.BigInteger(4901333035449936749L), }, { new System.Numerics.BigInteger(5442132947235500063L), new System.Numerics.BigInteger(431970321898423954L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2434029902041004981L), new System.Numerics.BigInteger(1355783128549125485L), }, { new System.Numerics.BigInteger(5871954099875726709L), new System.Numerics.BigInteger(2200337083935503326L), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1mi(
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1mi(
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
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
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

                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmmarrayd2e1mi_id", 
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
                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmmarrayd2e1mi_id", 
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
                List<BigIntegernumericMMArrayD2E1M> models = null;

                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericMMArrayD2E1M> models = null;

                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 173;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 9, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 85, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 40, query1, 165, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 49, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 40, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 153, query1, 142, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 49, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 142, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 152, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 112, 108))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 157);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models =  ((IBigIntegerMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MI),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1M),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
FROM public.binary_bigintegernumericmmarrayd2e1m m
LEFT JOIN public.binary_bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models =  ((IBigIntegerMArraynumericMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI), typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MI>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MI>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

