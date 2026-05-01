

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(136876902146993451L),

new System.Numerics.BigInteger(8128590844352768135L),

new System.Numerics.BigInteger(5533636361320263569L),

new System.Numerics.BigInteger(7661002798716500841L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3002368450195691716L),

new System.Numerics.BigInteger(546159221781208737L),

new System.Numerics.BigInteger(6566515362516919074L),

new System.Numerics.BigInteger(7182527856055973647L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2524192514294705349L),

new System.Numerics.BigInteger(8649255895159455232L),

new System.Numerics.BigInteger(966712709648035567L),

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
new System.Numerics.BigInteger(2822976534312514567L),

new System.Numerics.BigInteger(3374401962861879831L),

new System.Numerics.BigInteger(8358458574551298052L),

new System.Numerics.BigInteger(5369472498673528084L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8528699587542953323L),

new System.Numerics.BigInteger(2893006265741256489L),

new System.Numerics.BigInteger(6781758043744401614L),

},
},
            new BigIntegernumericArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3054192891152376383L),

new System.Numerics.BigInteger(4956034811047998425L),

new System.Numerics.BigInteger(9133715785638878236L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4218572655530151725L),

new System.Numerics.BigInteger(665329096837140402L),

new System.Numerics.BigInteger(212069375639088861L),

new System.Numerics.BigInteger(5048198957538955993L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7061450858961740837L),

new System.Numerics.BigInteger(5096522622971129027L),

new System.Numerics.BigInteger(6489967095912306107L),

new System.Numerics.BigInteger(3443357390640935007L),

},
},
            new BigIntegernumericArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2162552455003968350L),

new System.Numerics.BigInteger(827770213514942048L),

new System.Numerics.BigInteger(8142797123520767376L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1320818524827440876L),

new System.Numerics.BigInteger(6481767921037123771L),

new System.Numerics.BigInteger(8823206583214524386L),

new System.Numerics.BigInteger(6008360537331523266L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4395876054342607641L),

new System.Numerics.BigInteger(3823919040747971617L),

new System.Numerics.BigInteger(6083129115512628779L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7559460352766535904L),

new System.Numerics.BigInteger(1006299721063749648L),

new System.Numerics.BigInteger(4325628031522098484L),

new System.Numerics.BigInteger(4104491303710426729L),

},
},
            new BigIntegernumericArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(956654340174538575L),

new System.Numerics.BigInteger(1496761966494638814L),

new System.Numerics.BigInteger(503281279657370402L),

new System.Numerics.BigInteger(5897918034141128932L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5109577248478749899L),

new System.Numerics.BigInteger(1118937840176854028L),

new System.Numerics.BigInteger(4930816292018496762L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3925062862962056377L),

new System.Numerics.BigInteger(4794963702768679647L),

new System.Numerics.BigInteger(4714096198580689425L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7775398781383381056L),

new System.Numerics.BigInteger(7117687787395975246L),

new System.Numerics.BigInteger(7541876833998655422L),

new System.Numerics.BigInteger(2755677591350229960L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1756331666231460583L),

new System.Numerics.BigInteger(6863495467452429746L),

new System.Numerics.BigInteger(389894834022942063L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(168852081346135642L),

new System.Numerics.BigInteger(1804865653068680816L),

new System.Numerics.BigInteger(3122214085131145569L),

new System.Numerics.BigInteger(604057011641617344L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4462595125475581501L),

new System.Numerics.BigInteger(6265782336018754768L),

new System.Numerics.BigInteger(6724045364486590678L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6814167895373844855L),

new System.Numerics.BigInteger(2287199899818855315L),

new System.Numerics.BigInteger(905276104613487472L),

new System.Numerics.BigInteger(6344152760157653907L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8316022242027076698L),

new System.Numerics.BigInteger(150346773007425900L),

new System.Numerics.BigInteger(747974746511834124L),

new System.Numerics.BigInteger(4614616027218209539L),

},
},
            new BigIntegernumericArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7813203850108038489L),

new System.Numerics.BigInteger(8951832941423211728L),

new System.Numerics.BigInteger(320883242365996922L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7645530484149423103L),

new System.Numerics.BigInteger(144005806720288177L),

new System.Numerics.BigInteger(7326134502329313411L),

},
},
            new BigIntegernumericArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6918512043767482309L),

new System.Numerics.BigInteger(3713741124105243098L),

new System.Numerics.BigInteger(4746378083254720248L),

new System.Numerics.BigInteger(7058889320460067877L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(72696631116189201L),

new System.Numerics.BigInteger(275460116398371955L),

new System.Numerics.BigInteger(5938262788476439990L),

new System.Numerics.BigInteger(4217675539734075431L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3232978020196369785L),

new System.Numerics.BigInteger(6328211366082640466L),

new System.Numerics.BigInteger(6766124929899047096L),

new System.Numerics.BigInteger(8334535376091069534L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5576802726790280217L),

new System.Numerics.BigInteger(7790304869276604419L),

new System.Numerics.BigInteger(7567315021047172663L),

},
},
            new BigIntegernumericArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8171707566172977576L),

new System.Numerics.BigInteger(3563421217342251776L),

new System.Numerics.BigInteger(4070305077274280227L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6133624118354276205L),

new System.Numerics.BigInteger(4057944054581539081L),

new System.Numerics.BigInteger(2225128892506136576L),

new System.Numerics.BigInteger(5162859284568577736L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4657559056797278964L),

new System.Numerics.BigInteger(6239426827511628216L),

new System.Numerics.BigInteger(117279803122169321L),

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
new System.Numerics.BigInteger(60504107818357044L),

new System.Numerics.BigInteger(2982541309627315201L),

new System.Numerics.BigInteger(5106039793588366651L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(720042489347768029L),

new System.Numerics.BigInteger(5847114942666358406L),

new System.Numerics.BigInteger(6108990502243620143L),

new System.Numerics.BigInteger(9024759302118706404L),

},
},
            new BigIntegernumericArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4862375071625730515L),

new System.Numerics.BigInteger(2429678665961881879L),

new System.Numerics.BigInteger(1710526122567060334L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8627031564882048524L),

new System.Numerics.BigInteger(54506449594227700L),

new System.Numerics.BigInteger(8166458328465085961L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8857553640295312746L),

new System.Numerics.BigInteger(548062753378426051L),

new System.Numerics.BigInteger(6003327464071571812L),

new System.Numerics.BigInteger(7328988051268202050L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(364011920533781409L),

new System.Numerics.BigInteger(7537249051813280402L),

new System.Numerics.BigInteger(1339141946428504234L),

new System.Numerics.BigInteger(1488815167077938161L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8321589389372633726L),

new System.Numerics.BigInteger(6211685460450690164L),

new System.Numerics.BigInteger(1162889900860455827L),

new System.Numerics.BigInteger(8853488180261497517L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6660353570595155007L),

new System.Numerics.BigInteger(6607138670678251750L),

new System.Numerics.BigInteger(256302565210366162L),

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
new System.Numerics.BigInteger(3863121338006661043L),

new System.Numerics.BigInteger(774722786930913509L),

new System.Numerics.BigInteger(6178780671207333253L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2715510702467810649L),

new System.Numerics.BigInteger(4935991564532862757L),

new System.Numerics.BigInteger(3673860887178216571L),

new System.Numerics.BigInteger(7044489434344702566L),

},
},
            new BigIntegernumericArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8532636362365506460L),

new System.Numerics.BigInteger(7245008740085161145L),

new System.Numerics.BigInteger(3546746357582445358L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5888306483953891675L),

new System.Numerics.BigInteger(9105654658757515443L),

new System.Numerics.BigInteger(6305628089391322401L),

new System.Numerics.BigInteger(47315602145036576L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6183274782472554102L),

new System.Numerics.BigInteger(2371565255442690394L),

new System.Numerics.BigInteger(3277575102462979029L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5290816625362013136L),

new System.Numerics.BigInteger(7080139981572595979L),

new System.Numerics.BigInteger(5846895139971561313L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1893720113529955243L),

new System.Numerics.BigInteger(3986648452833537512L),

new System.Numerics.BigInteger(408350006148903948L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2892440740611416609L),

new System.Numerics.BigInteger(5406849204817349781L),

new System.Numerics.BigInteger(3591725284379604074L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4030939515487930968L),

new System.Numerics.BigInteger(6940417332914889496L),

new System.Numerics.BigInteger(6886078925840496609L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2809618397895611957L),

new System.Numerics.BigInteger(1791782946196729869L),

new System.Numerics.BigInteger(3186744987768908916L),

},
},
            new BigIntegernumericArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4426334034431328898L),

new System.Numerics.BigInteger(82402344845335598L),

new System.Numerics.BigInteger(4414402575364682038L),

new System.Numerics.BigInteger(2293879910849223812L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2414663446760974709L),

new System.Numerics.BigInteger(8846119033092755147L),

new System.Numerics.BigInteger(4258067443410068942L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4365737063009509243L),

new System.Numerics.BigInteger(9029547747267544990L),

new System.Numerics.BigInteger(3433721649851806727L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4948845150490563535L),

new System.Numerics.BigInteger(4918271260838609182L),

new System.Numerics.BigInteger(4899258747294502237L),

new System.Numerics.BigInteger(1712067773341781197L),

},
},
            new BigIntegernumericArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9001020066552572565L),

new System.Numerics.BigInteger(6181382307922801636L),

new System.Numerics.BigInteger(7999443127173279531L),

new System.Numerics.BigInteger(2559615676400729543L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4897540503674580199L),

new System.Numerics.BigInteger(491555279516765606L),

new System.Numerics.BigInteger(2201696975740837089L),

new System.Numerics.BigInteger(4855841747469662798L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7587418575603314457L),

new System.Numerics.BigInteger(8806410028455360915L),

new System.Numerics.BigInteger(2858113003617139456L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1973294517124198776L),

new System.Numerics.BigInteger(6404474475741915126L),

new System.Numerics.BigInteger(956055833823898189L),

new System.Numerics.BigInteger(6855518015975695184L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8111044756422838441L),

new System.Numerics.BigInteger(1888915631152754909L),

new System.Numerics.BigInteger(638561295831112110L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1960702470510300774L),

new System.Numerics.BigInteger(258999552880818002L),

new System.Numerics.BigInteger(6602841850378648930L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5552479436822010473L),

new System.Numerics.BigInteger(3989809280394955716L),

new System.Numerics.BigInteger(664720474546260544L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8792325039214483445L),

new System.Numerics.BigInteger(1507348541036494472L),

new System.Numerics.BigInteger(4579123717005671314L),

new System.Numerics.BigInteger(4038391127202462427L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3754885045363659855L),

new System.Numerics.BigInteger(1925001500450223990L),

new System.Numerics.BigInteger(2187506069522130462L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1041699695174542293L),

new System.Numerics.BigInteger(989282392615582503L),

new System.Numerics.BigInteger(4580204398625697034L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7680468778457074019L),

new System.Numerics.BigInteger(211989730440638634L),

new System.Numerics.BigInteger(6273095502625260634L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7151525483618828852L),

new System.Numerics.BigInteger(5453557226599737056L),

new System.Numerics.BigInteger(2453675108932524481L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(182907399663915090L),

new System.Numerics.BigInteger(6330608580919824888L),

new System.Numerics.BigInteger(8415931616361887009L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7795167364149171827L),

new System.Numerics.BigInteger(3291616652614108579L),

new System.Numerics.BigInteger(5260288759143704290L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4573271497164867620L),

new System.Numerics.BigInteger(3145849689118938269L),

new System.Numerics.BigInteger(7372377615120573364L),

},
},
            new BigIntegernumericArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9003160887041289239L),

new System.Numerics.BigInteger(2006799694239933393L),

new System.Numerics.BigInteger(7847136353014768750L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4564675826766596334L),

new System.Numerics.BigInteger(6074899119520946709L),

new System.Numerics.BigInteger(1980211053804557804L),

new System.Numerics.BigInteger(967692901253580935L),

},
},
            new BigIntegernumericArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(752663518849270761L),

new System.Numerics.BigInteger(3304771042153296279L),

new System.Numerics.BigInteger(4380594786990725306L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7154821548131899352L),

new System.Numerics.BigInteger(4406665560170894587L),

new System.Numerics.BigInteger(320867591078668474L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5153983397158385360L),

new System.Numerics.BigInteger(5418045072118499293L),

new System.Numerics.BigInteger(7238532720804907370L),

new System.Numerics.BigInteger(9028237377158324870L),

},
    ModelInner = null,
    NullableValue = null,
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
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                parametr1.Value = 20;
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
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[34], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[27],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[28],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[29],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[27],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[28],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[29],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[34], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[27],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[28],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[29],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 141, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 46, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 9, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 37, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 121, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 34, query1, 130, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 37, query1, 130, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 31, query1, 156, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 92, 165))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 156, 9))
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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
BigIntegernumericArray2M.AssertModel(models[0],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[29], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[30], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[31], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[32], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[33], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 41);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
BigIntegernumericArray2M.AssertModel(models[0],_testData[9], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[10], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[11], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[12], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[17],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[18],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[19],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[20],_testData[29], false);BigIntegernumericArray2M.AssertModel(models[21],_testData[30], false);BigIntegernumericArray2M.AssertModel(models[22],_testData[31], false);BigIntegernumericArray2M.AssertModel(models[23],_testData[32], false);BigIntegernumericArray2M.AssertModel(models[24],_testData[33], false);BigIntegernumericArray2M.AssertModel(models[25],_testData[34], false);
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

