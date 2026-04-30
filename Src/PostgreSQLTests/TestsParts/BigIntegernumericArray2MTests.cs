

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2510409411466433515L),

new System.Numerics.BigInteger(3599580663145638585L),

new System.Numerics.BigInteger(480894600284124902L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7740273504329487034L),

new System.Numerics.BigInteger(8701495496681570379L),

new System.Numerics.BigInteger(4616612678162233983L),

},
},
            new BigIntegernumericArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(964055419545823829L),

new System.Numerics.BigInteger(8522406676015749744L),

new System.Numerics.BigInteger(1980713668919765902L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(288576052085785688L),

new System.Numerics.BigInteger(5483367603341266921L),

new System.Numerics.BigInteger(1290126084889744560L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4568680972063634977L),

new System.Numerics.BigInteger(7768795450956765372L),

new System.Numerics.BigInteger(8862545495190229890L),

new System.Numerics.BigInteger(4470332999028760438L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4196618858775883052L),

new System.Numerics.BigInteger(4863364124367349183L),

new System.Numerics.BigInteger(5291848132167095178L),

new System.Numerics.BigInteger(1654661266951656997L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5290115627003325717L),

new System.Numerics.BigInteger(6900493169660082459L),

new System.Numerics.BigInteger(540058146917822401L),

new System.Numerics.BigInteger(1941261448812921095L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(571864413816664689L),

new System.Numerics.BigInteger(6242436626529319264L),

new System.Numerics.BigInteger(381728972427262829L),

new System.Numerics.BigInteger(3799734704518496677L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6464671279914765368L),

new System.Numerics.BigInteger(3448808335389618159L),

new System.Numerics.BigInteger(7667879996383824985L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5853325202133404122L),

new System.Numerics.BigInteger(2073880345457741366L),

new System.Numerics.BigInteger(3913951771791850265L),

new System.Numerics.BigInteger(9159332507926694468L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6876652635935668478L),

new System.Numerics.BigInteger(5825213862942297392L),

new System.Numerics.BigInteger(3692931203926153369L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2783786583938592948L),

new System.Numerics.BigInteger(6219262497744077321L),

new System.Numerics.BigInteger(5287667372521383162L),

},
},
            new BigIntegernumericArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9220537705031741975L),

new System.Numerics.BigInteger(5489161686671350476L),

new System.Numerics.BigInteger(2802037559090800582L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8611765540790366839L),

new System.Numerics.BigInteger(8267956615167754430L),

new System.Numerics.BigInteger(3484491490570564047L),

new System.Numerics.BigInteger(1830965539907482355L),

},
},
            new BigIntegernumericArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3319020669253530678L),

new System.Numerics.BigInteger(7266626456832197224L),

new System.Numerics.BigInteger(4783302375434013544L),

new System.Numerics.BigInteger(975698698444768483L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7360119134137939698L),

new System.Numerics.BigInteger(4048606581307966019L),

new System.Numerics.BigInteger(2884670681886275939L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2087182112133760463L),

new System.Numerics.BigInteger(975434280328560803L),

new System.Numerics.BigInteger(5968789140684696510L),

new System.Numerics.BigInteger(8609628436028783417L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7423128986365413396L),

new System.Numerics.BigInteger(8875089617021647633L),

new System.Numerics.BigInteger(4879636979876714207L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1975206036573866389L),

new System.Numerics.BigInteger(1620785435814856993L),

new System.Numerics.BigInteger(2619927608089837025L),

},
},
            new BigIntegernumericArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8391645082217903016L),

new System.Numerics.BigInteger(3082434017260373535L),

new System.Numerics.BigInteger(1409573668593760147L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(399918761584090500L),

new System.Numerics.BigInteger(6415140299826289215L),

new System.Numerics.BigInteger(8048850872700774856L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9115732033054272138L),

new System.Numerics.BigInteger(3672812680772855725L),

new System.Numerics.BigInteger(7896709054258369293L),

},
},
            new BigIntegernumericArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1392730317424389210L),

new System.Numerics.BigInteger(6387887072886410549L),

new System.Numerics.BigInteger(8109619193382644981L),

new System.Numerics.BigInteger(8076052663756653170L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4919128559060213305L),

new System.Numerics.BigInteger(3343631295706827976L),

new System.Numerics.BigInteger(1929260522070474178L),

new System.Numerics.BigInteger(4839106021316884197L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8615395726865956686L),

new System.Numerics.BigInteger(5149476189547815737L),

new System.Numerics.BigInteger(8463492981818644520L),

new System.Numerics.BigInteger(8959964128799156256L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9091623628514921770L),

new System.Numerics.BigInteger(3774392602003937768L),

new System.Numerics.BigInteger(3214438112738942749L),

new System.Numerics.BigInteger(900282881251644893L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4511524778976133130L),

new System.Numerics.BigInteger(9039611829148382313L),

new System.Numerics.BigInteger(1460525997518856077L),

new System.Numerics.BigInteger(4334666094503294971L),

},
},
            new BigIntegernumericArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6068894758586831742L),

new System.Numerics.BigInteger(4226094717671167079L),

new System.Numerics.BigInteger(3553499422805888041L),

new System.Numerics.BigInteger(2450511080267379093L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4511242721042271717L),

new System.Numerics.BigInteger(3597281045347504635L),

new System.Numerics.BigInteger(2813131252419489594L),

new System.Numerics.BigInteger(2634922943217464686L),

},
},
            new BigIntegernumericArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1788478489058902063L),

new System.Numerics.BigInteger(6623253863947843587L),

new System.Numerics.BigInteger(6625910507166481751L),

new System.Numerics.BigInteger(3781377110170640722L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(487588412336104057L),

new System.Numerics.BigInteger(2360095352229092346L),

new System.Numerics.BigInteger(228823223179611292L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1505084847317291780L),

new System.Numerics.BigInteger(7679981459258177843L),

new System.Numerics.BigInteger(1266475109886239615L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4391074530368890617L),

new System.Numerics.BigInteger(1231396126107902629L),

new System.Numerics.BigInteger(6602440524004956017L),

new System.Numerics.BigInteger(3324046870802095361L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7630029552434419204L),

new System.Numerics.BigInteger(8829799874743200751L),

new System.Numerics.BigInteger(3991936191424575904L),

new System.Numerics.BigInteger(4280969984151671459L),

},
},
            new BigIntegernumericArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5370164202134225077L),

new System.Numerics.BigInteger(5325680498960470131L),

new System.Numerics.BigInteger(7985168373472116176L),

new System.Numerics.BigInteger(4210085328927685874L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5521541385107098660L),

new System.Numerics.BigInteger(6001196921164235705L),

new System.Numerics.BigInteger(7011521476359295459L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5597201551619417402L),

new System.Numerics.BigInteger(6685869221950360888L),

new System.Numerics.BigInteger(7502391052212374371L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3656626173407408309L),

new System.Numerics.BigInteger(6284294775753378970L),

new System.Numerics.BigInteger(3694968698314584834L),

new System.Numerics.BigInteger(174363946111490433L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1332808951058463773L),

new System.Numerics.BigInteger(7970810838932039706L),

new System.Numerics.BigInteger(5446538353000509039L),

new System.Numerics.BigInteger(9087719473883881958L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8053130763270942532L),

new System.Numerics.BigInteger(9109232319840579516L),

new System.Numerics.BigInteger(5159748154241663600L),

},
},
            new BigIntegernumericArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1774590446098835931L),

new System.Numerics.BigInteger(677720033545859132L),

new System.Numerics.BigInteger(4581265803720477L),

new System.Numerics.BigInteger(6762454602224564500L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5491732164444135763L),

new System.Numerics.BigInteger(1868876387649964935L),

new System.Numerics.BigInteger(4067887113339660569L),

},
},
            new BigIntegernumericArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3212689501300848240L),

new System.Numerics.BigInteger(1105401847042279734L),

new System.Numerics.BigInteger(3837503669937423371L),

new System.Numerics.BigInteger(5853819623071742328L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8794848873277384307L),

new System.Numerics.BigInteger(4602264023720147331L),

new System.Numerics.BigInteger(8694507657878205902L),

new System.Numerics.BigInteger(4860923377494856890L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2479899775473508054L),

new System.Numerics.BigInteger(5396350209041981024L),

new System.Numerics.BigInteger(4954879616441510466L),

new System.Numerics.BigInteger(4880563682189832442L),

},
},
            new BigIntegernumericArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3656648905782371486L),

new System.Numerics.BigInteger(8152792645560530429L),

new System.Numerics.BigInteger(7627851177143379473L),

new System.Numerics.BigInteger(511956858249389239L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6114358577504554754L),

new System.Numerics.BigInteger(4975087855285940429L),

new System.Numerics.BigInteger(2106977494414593869L),

new System.Numerics.BigInteger(6331506648935031417L),

},
},
            new BigIntegernumericArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6791967276354776670L),

new System.Numerics.BigInteger(4847929167134224922L),

new System.Numerics.BigInteger(2785617738752625884L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6068293199318725860L),

new System.Numerics.BigInteger(7952866447264253888L),

new System.Numerics.BigInteger(2566901744901715968L),

new System.Numerics.BigInteger(2695921532716012564L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8093904159585220309L),

new System.Numerics.BigInteger(1910947905155895678L),

new System.Numerics.BigInteger(8934490689066491597L),

new System.Numerics.BigInteger(7673294975279206028L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7722597608915807652L),

new System.Numerics.BigInteger(7639257561102533833L),

new System.Numerics.BigInteger(6983472934765347203L),

new System.Numerics.BigInteger(8842319899693272901L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4485390048534989402L),

new System.Numerics.BigInteger(4666680419471341305L),

new System.Numerics.BigInteger(7142101988750359130L),

},
},
            new BigIntegernumericArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2442645408994369465L),

new System.Numerics.BigInteger(6002146143779040504L),

new System.Numerics.BigInteger(490604457668093499L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7576851301929499162L),

new System.Numerics.BigInteger(8721534254601250656L),

new System.Numerics.BigInteger(2871155443042473945L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3588694479797330036L),

new System.Numerics.BigInteger(1553777182644973680L),

new System.Numerics.BigInteger(3276056448002666740L),

new System.Numerics.BigInteger(1865616987128731138L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7706887632392932484L),

new System.Numerics.BigInteger(4603943113716886495L),

new System.Numerics.BigInteger(1335957684473296604L),

new System.Numerics.BigInteger(3624906362760452583L),

},
},
            new BigIntegernumericArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7973127109382228247L),

new System.Numerics.BigInteger(7160220816449915393L),

new System.Numerics.BigInteger(2204904247957503445L),

new System.Numerics.BigInteger(7217513095993583268L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8467889739768384196L),

new System.Numerics.BigInteger(5711689041564181049L),

new System.Numerics.BigInteger(5260412438911934782L),

},
},
            new BigIntegernumericArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(643495356902616263L),

new System.Numerics.BigInteger(5025279803351329488L),

new System.Numerics.BigInteger(2441951139174870557L),

new System.Numerics.BigInteger(470610965010978241L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6732126107884757988L),

new System.Numerics.BigInteger(5134571097991709005L),

new System.Numerics.BigInteger(372640341090735732L),

new System.Numerics.BigInteger(4382220815087741127L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3843359967827497465L),

new System.Numerics.BigInteger(3524836076412897523L),

new System.Numerics.BigInteger(7441867710064095302L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3383500678935936678L),

new System.Numerics.BigInteger(3097023593817111432L),

new System.Numerics.BigInteger(6125889371957089844L),

new System.Numerics.BigInteger(1068033192779395542L),

},
},
            new BigIntegernumericArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1871051409095038649L),

new System.Numerics.BigInteger(4820205240229393271L),

new System.Numerics.BigInteger(176217562840861328L),

new System.Numerics.BigInteger(6180577516185528448L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(563172356084398571L),

new System.Numerics.BigInteger(2479340330190091802L),

new System.Numerics.BigInteger(73520656280352726L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9180517345985112666L),

new System.Numerics.BigInteger(6393462286374816736L),

new System.Numerics.BigInteger(1882290218245174548L),

new System.Numerics.BigInteger(7276906515245316428L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4876571664027997776L),

new System.Numerics.BigInteger(6748606058210032866L),

new System.Numerics.BigInteger(5170497711121317406L),

},
},
            new BigIntegernumericArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(755978528726374276L),

new System.Numerics.BigInteger(6077924040811850074L),

new System.Numerics.BigInteger(7086309708624759125L),

new System.Numerics.BigInteger(3328980766697469430L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4955502706271861676L),

new System.Numerics.BigInteger(3363828413657914365L),

new System.Numerics.BigInteger(2590274036832343163L),

new System.Numerics.BigInteger(8708057757758096698L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5482752504720396700L),

new System.Numerics.BigInteger(4463799896700885577L),

new System.Numerics.BigInteger(1618683602788609393L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6755315461588542555L),

new System.Numerics.BigInteger(3974635499214944864L),

new System.Numerics.BigInteger(6601783909850970142L),

},
},
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                var models = ((IBigIntegerListnumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models = ((IBigIntegerListnumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 140;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 50;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[29], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[5], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[6], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 24, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[29], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 57, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 108, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[29], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 81, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 32, query1, 32, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 128, query1, 93, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 35, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

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
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 81, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 35, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 50, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[29], false);
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
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 64);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
BigIntegernumericArray2M.AssertModel(models[0],_testData[12], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 93);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
BigIntegernumericArray2M.AssertModel(models[0],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[29], false);
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 0; i < 6; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
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

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 4; i < 10; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectImportModelInner(connection);
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<BigIntegernumericArray2MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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

