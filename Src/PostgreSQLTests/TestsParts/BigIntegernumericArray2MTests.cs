

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
new System.Numerics.BigInteger(3113652641851817599L),

new System.Numerics.BigInteger(6806949352269293577L),

new System.Numerics.BigInteger(2129443323568088926L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3424340723663406978L),

new System.Numerics.BigInteger(3529506759679866409L),

new System.Numerics.BigInteger(8181949536580503741L),

},
},
            new BigIntegernumericArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4471491350655615421L),

new System.Numerics.BigInteger(8780337359428135561L),

new System.Numerics.BigInteger(1712347969831165596L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6800787344508878685L),

new System.Numerics.BigInteger(2876165895299182550L),

new System.Numerics.BigInteger(4064770484300279420L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4009342029549209594L),

new System.Numerics.BigInteger(2996054025906411965L),

new System.Numerics.BigInteger(3987739724781297235L),

new System.Numerics.BigInteger(5340618060443333745L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5721471853529218042L),

new System.Numerics.BigInteger(9112786210169555453L),

new System.Numerics.BigInteger(8169927677353468844L),

new System.Numerics.BigInteger(2141989671483476190L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6670258181405142787L),

new System.Numerics.BigInteger(439727886638382153L),

new System.Numerics.BigInteger(2321816860856200014L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6034324354810859742L),

new System.Numerics.BigInteger(6865296076758150925L),

new System.Numerics.BigInteger(3680871807856374793L),

new System.Numerics.BigInteger(6211565366534522751L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5133408335720850571L),

new System.Numerics.BigInteger(16791047041758930L),

new System.Numerics.BigInteger(2829576645198109183L),

},
},
            new BigIntegernumericArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5365713807079612002L),

new System.Numerics.BigInteger(9095503181419559441L),

new System.Numerics.BigInteger(7472285351654355283L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(983302285160494101L),

new System.Numerics.BigInteger(8853564733990576860L),

new System.Numerics.BigInteger(1704505724922297531L),

},
},
            new BigIntegernumericArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4051682730234628702L),

new System.Numerics.BigInteger(8697293116467443454L),

new System.Numerics.BigInteger(7074697983773150891L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7869641994018077986L),

new System.Numerics.BigInteger(8452351246020871954L),

new System.Numerics.BigInteger(7710230154266747378L),

new System.Numerics.BigInteger(8472476565257009608L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5463018560217733213L),

new System.Numerics.BigInteger(8357165299333623700L),

new System.Numerics.BigInteger(2009791756322028855L),

new System.Numerics.BigInteger(6155164765605155697L),

},
},
            new BigIntegernumericArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5081617604015499804L),

new System.Numerics.BigInteger(8748729152243771807L),

new System.Numerics.BigInteger(3487329594897415298L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4907857260410290648L),

new System.Numerics.BigInteger(7183031519935681645L),

new System.Numerics.BigInteger(4094907376846175074L),

new System.Numerics.BigInteger(8089187726863349906L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(388836194172307528L),

new System.Numerics.BigInteger(9045363142396621473L),

new System.Numerics.BigInteger(2315839983132888833L),

new System.Numerics.BigInteger(1072801398849735663L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4913062945184560385L),

new System.Numerics.BigInteger(4547453774887867372L),

new System.Numerics.BigInteger(2833680915824077610L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(109699677443358294L),

new System.Numerics.BigInteger(3515510400141710783L),

new System.Numerics.BigInteger(4983809535109497022L),

},
},
            new BigIntegernumericArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7575689390558484480L),

new System.Numerics.BigInteger(2129908395963908423L),

new System.Numerics.BigInteger(368039338625882556L),

new System.Numerics.BigInteger(385265289055220316L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2046131997907556613L),

new System.Numerics.BigInteger(4741356352549201861L),

new System.Numerics.BigInteger(8087866987897663441L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8068931799413727112L),

new System.Numerics.BigInteger(8571154446927042138L),

new System.Numerics.BigInteger(5905151339267119940L),

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
new System.Numerics.BigInteger(3029526203741846199L),

new System.Numerics.BigInteger(6775100433458360780L),

new System.Numerics.BigInteger(401154391643923472L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3906385053113854865L),

new System.Numerics.BigInteger(7401365811542207896L),

new System.Numerics.BigInteger(6623855420127156589L),

new System.Numerics.BigInteger(6520678616769460879L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5329897622786832229L),

new System.Numerics.BigInteger(107382208311025165L),

new System.Numerics.BigInteger(445629822156733454L),

new System.Numerics.BigInteger(5697653144167396211L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3140216376442518711L),

new System.Numerics.BigInteger(8686843648548869472L),

new System.Numerics.BigInteger(2867909834188924108L),

new System.Numerics.BigInteger(8263590839023294563L),

},
},
            new BigIntegernumericArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7900708591090983866L),

new System.Numerics.BigInteger(5615957574360476881L),

new System.Numerics.BigInteger(5713644565486158794L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5514370860028519210L),

new System.Numerics.BigInteger(516314750551584239L),

new System.Numerics.BigInteger(7521926229084472569L),

new System.Numerics.BigInteger(5835711715025919157L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4137662330447509876L),

new System.Numerics.BigInteger(5884832629129295121L),

new System.Numerics.BigInteger(6074346413744932923L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2560369350942419428L),

new System.Numerics.BigInteger(842624516011976830L),

new System.Numerics.BigInteger(8953368693393745842L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3362834701027250945L),

new System.Numerics.BigInteger(8104807704906713682L),

new System.Numerics.BigInteger(7635499384999991867L),

new System.Numerics.BigInteger(12838260225478469L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6104026398436588584L),

new System.Numerics.BigInteger(5302294374496965851L),

new System.Numerics.BigInteger(5857608429246898606L),

new System.Numerics.BigInteger(5994786623675800991L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(403573620439540359L),

new System.Numerics.BigInteger(2255790492364819624L),

new System.Numerics.BigInteger(1004333281972001665L),

new System.Numerics.BigInteger(7340388054836687897L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9010075190599044228L),

new System.Numerics.BigInteger(4719280639597052629L),

new System.Numerics.BigInteger(4554993354137748430L),

},
},
            new BigIntegernumericArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1279554595638263766L),

new System.Numerics.BigInteger(6623692986957176050L),

new System.Numerics.BigInteger(5500415047208339316L),

new System.Numerics.BigInteger(2617671380793689227L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3922020598953009596L),

new System.Numerics.BigInteger(7903664076264815716L),

new System.Numerics.BigInteger(2387042072968929282L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(92279851591226842L),

new System.Numerics.BigInteger(2656233134382168913L),

new System.Numerics.BigInteger(2561396087594763943L),

new System.Numerics.BigInteger(6538460587596071404L),

},
},
            new BigIntegernumericArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4624205992605921969L),

new System.Numerics.BigInteger(206294935216320490L),

new System.Numerics.BigInteger(5671541328068785622L),

new System.Numerics.BigInteger(2541033311266640851L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(65241640799658943L),

new System.Numerics.BigInteger(350537362822940719L),

new System.Numerics.BigInteger(2311745249434348039L),

},
},
            new BigIntegernumericArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6261847784903573394L),

new System.Numerics.BigInteger(2950049987194740268L),

new System.Numerics.BigInteger(4653971962180084679L),

new System.Numerics.BigInteger(7900840501310429327L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4260453195764101646L),

new System.Numerics.BigInteger(4322655975082330870L),

new System.Numerics.BigInteger(1027477709689912718L),

new System.Numerics.BigInteger(2900673914343960710L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6236296575049269708L),

new System.Numerics.BigInteger(343044122704036618L),

new System.Numerics.BigInteger(1734049343901333869L),

new System.Numerics.BigInteger(2974312921068610636L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(439720303119112402L),

new System.Numerics.BigInteger(3241992758599995434L),

new System.Numerics.BigInteger(1680000533949079848L),

},
},
            new BigIntegernumericArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2130311993117414457L),

new System.Numerics.BigInteger(9102598675214449038L),

new System.Numerics.BigInteger(3939271853390397823L),

new System.Numerics.BigInteger(3112530464098358573L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8805081017187042093L),

new System.Numerics.BigInteger(8325584891874902274L),

new System.Numerics.BigInteger(875044941570113908L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1690485339992207471L),

new System.Numerics.BigInteger(4482513590695543619L),

new System.Numerics.BigInteger(422915277375812132L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(954580795228271951L),

new System.Numerics.BigInteger(7208991238359800625L),

new System.Numerics.BigInteger(5643041725379202917L),

new System.Numerics.BigInteger(5471751455128940749L),

},
},
            new BigIntegernumericArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6645785101748128229L),

new System.Numerics.BigInteger(864435464813437446L),

new System.Numerics.BigInteger(4594813320450492610L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(608290373979905025L),

new System.Numerics.BigInteger(8922285431246610627L),

new System.Numerics.BigInteger(6951806171994351700L),

new System.Numerics.BigInteger(8108261849528664315L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(887565326060018680L),

new System.Numerics.BigInteger(7100331681068041768L),

new System.Numerics.BigInteger(7853454678910877588L),

new System.Numerics.BigInteger(2653540207397857782L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4130050903145869115L),

new System.Numerics.BigInteger(4998992421559720397L),

new System.Numerics.BigInteger(5340180265227168100L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2189049117002367746L),

new System.Numerics.BigInteger(2295808308536409620L),

new System.Numerics.BigInteger(4311299578210190680L),

new System.Numerics.BigInteger(7202609059870576123L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7733151200270987502L),

new System.Numerics.BigInteger(9115600798908563256L),

new System.Numerics.BigInteger(6953086710520935300L),

},
},
            new BigIntegernumericArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4657714053944746755L),

new System.Numerics.BigInteger(7124762665462706136L),

new System.Numerics.BigInteger(1349436274424597053L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6527718678558287051L),

new System.Numerics.BigInteger(4977562795951110353L),

new System.Numerics.BigInteger(344701622543722629L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1848371094479105781L),

new System.Numerics.BigInteger(7860966726152223201L),

new System.Numerics.BigInteger(6343985338503104878L),

new System.Numerics.BigInteger(539314778564360308L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8291644611817782566L),

new System.Numerics.BigInteger(6178413727516561446L),

new System.Numerics.BigInteger(2678074736207874022L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(947364236458298585L),

new System.Numerics.BigInteger(1767827519872717384L),

new System.Numerics.BigInteger(3532087877683048092L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8035187969918527961L),

new System.Numerics.BigInteger(5961798298781936714L),

new System.Numerics.BigInteger(8618159077154112997L),

new System.Numerics.BigInteger(9141673555920852410L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3984939100237084815L),

new System.Numerics.BigInteger(7690544277661736634L),

new System.Numerics.BigInteger(525433622695078242L),

new System.Numerics.BigInteger(3803057971654646878L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1811039436172606960L),

new System.Numerics.BigInteger(3023192258846004792L),

new System.Numerics.BigInteger(9001144648293471822L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8556508901992114620L),

new System.Numerics.BigInteger(2139559411030893257L),

new System.Numerics.BigInteger(443106486013971238L),

new System.Numerics.BigInteger(5964469449653532564L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8198659126812994879L),

new System.Numerics.BigInteger(7950356131960184049L),

new System.Numerics.BigInteger(5514615647838142727L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7630501005345000291L),

new System.Numerics.BigInteger(5979097903668563878L),

new System.Numerics.BigInteger(6841507285418707875L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2683082878453238939L),

new System.Numerics.BigInteger(7212861806879317100L),

new System.Numerics.BigInteger(512147566122859513L),

new System.Numerics.BigInteger(2664214117963265844L),

},
},
            new BigIntegernumericArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8562122034100444304L),

new System.Numerics.BigInteger(7477032144086863801L),

new System.Numerics.BigInteger(5931949406921942123L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(555312848544962086L),

new System.Numerics.BigInteger(5766444156633059956L),

new System.Numerics.BigInteger(3587589410228565353L),

new System.Numerics.BigInteger(6935485873283423971L),

},
},
            new BigIntegernumericArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6295954736354922871L),

new System.Numerics.BigInteger(3758189686267335881L),

new System.Numerics.BigInteger(1178602775537242440L),

new System.Numerics.BigInteger(5976470378836050117L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7743057745882862735L),

new System.Numerics.BigInteger(8238629754081040542L),

new System.Numerics.BigInteger(9212661183458450770L),

new System.Numerics.BigInteger(4612848860423186328L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6155908121561855268L),

new System.Numerics.BigInteger(3441724447685571762L),

new System.Numerics.BigInteger(8612033071105411372L),

},
},
            new BigIntegernumericArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3522128754615382204L),

new System.Numerics.BigInteger(373172306213030297L),

new System.Numerics.BigInteger(5727534732466476768L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6680349682454683179L),

new System.Numerics.BigInteger(5311090051841883005L),

new System.Numerics.BigInteger(8547922716331789140L),

new System.Numerics.BigInteger(814758383229879866L),

},
},
            new BigIntegernumericArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3422393058716928419L),

new System.Numerics.BigInteger(4009688246180927796L),

new System.Numerics.BigInteger(8434583295581425099L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8046925075317029419L),

new System.Numerics.BigInteger(645269287540889356L),

new System.Numerics.BigInteger(2142533540335490370L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6312236826745341635L),

new System.Numerics.BigInteger(8558112143465847217L),

new System.Numerics.BigInteger(1306716090440481648L),

new System.Numerics.BigInteger(6973005832334728663L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8902172995242889347L),

new System.Numerics.BigInteger(9080727140199998601L),

new System.Numerics.BigInteger(3549374561636740006L),

new System.Numerics.BigInteger(3255763627899182857L),

},
},
            new BigIntegernumericArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8347216553440672428L),

new System.Numerics.BigInteger(884976816612245265L),

new System.Numerics.BigInteger(3660293707325158351L),

new System.Numerics.BigInteger(6072970302125853691L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3238518078639001914L),

new System.Numerics.BigInteger(3446979980650870351L),

new System.Numerics.BigInteger(414543413313639234L),

new System.Numerics.BigInteger(8115803677412017292L),

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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[34], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[32],_testData[34], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[27],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 124, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 104, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
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
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 40, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 104, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
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
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 134, query1, 104, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 127, query1, 114, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
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
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 148, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 128, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 136, 89))
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 25, 145))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

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
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[27],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[28],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[34], false);
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
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[4], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[5], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[6], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[7], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[8], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[9], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[10], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[11], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[12], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[13], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[14], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[15], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[16], false);
                BigIntegernumericArray2M.AssertModel(models[13],_testData[17], false);
                BigIntegernumericArray2M.AssertModel(models[14],_testData[18], false);
                BigIntegernumericArray2M.AssertModel(models[15],_testData[19], false);
                BigIntegernumericArray2M.AssertModel(models[16],_testData[20], false);
                BigIntegernumericArray2M.AssertModel(models[17],_testData[21], false);
                BigIntegernumericArray2M.AssertModel(models[18],_testData[22], false);
                BigIntegernumericArray2M.AssertModel(models[19],_testData[23], false);
                BigIntegernumericArray2M.AssertModel(models[20],_testData[24], false);
                BigIntegernumericArray2M.AssertModel(models[21],_testData[25], false);
                BigIntegernumericArray2M.AssertModel(models[22],_testData[26], false);
                BigIntegernumericArray2M.AssertModel(models[23],_testData[27], false);
                BigIntegernumericArray2M.AssertModel(models[24],_testData[28], false);
                BigIntegernumericArray2M.AssertModel(models[25],_testData[29], false);
                BigIntegernumericArray2M.AssertModel(models[26],_testData[30], false);
                BigIntegernumericArray2M.AssertModel(models[27],_testData[31], false);
                BigIntegernumericArray2M.AssertModel(models[28],_testData[32], false);
                BigIntegernumericArray2M.AssertModel(models[29],_testData[33], false);
                BigIntegernumericArray2M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 56);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[12], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[13], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[14], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[15], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[16], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[17], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[18], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[19], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[20], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[21], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[22], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[23], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[24], false);
                BigIntegernumericArray2M.AssertModel(models[13],_testData[25], false);
                BigIntegernumericArray2M.AssertModel(models[14],_testData[26], false);
                BigIntegernumericArray2M.AssertModel(models[15],_testData[27], false);
                BigIntegernumericArray2M.AssertModel(models[16],_testData[28], false);
                BigIntegernumericArray2M.AssertModel(models[17],_testData[29], false);
                BigIntegernumericArray2M.AssertModel(models[18],_testData[30], false);
                BigIntegernumericArray2M.AssertModel(models[19],_testData[31], false);
                BigIntegernumericArray2M.AssertModel(models[20],_testData[32], false);
                BigIntegernumericArray2M.AssertModel(models[21],_testData[33], false);
                BigIntegernumericArray2M.AssertModel(models[22],_testData[34], false);
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

