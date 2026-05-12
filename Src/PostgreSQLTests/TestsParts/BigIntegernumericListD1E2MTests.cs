

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7719499144194725802L),

new System.Numerics.BigInteger(8472006126478651568L),

new System.Numerics.BigInteger(2599907537619987760L),

new System.Numerics.BigInteger(8008942936525257081L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(979418935753884058L),

new System.Numerics.BigInteger(914948707621203554L),

new System.Numerics.BigInteger(8564527675526737136L),

new System.Numerics.BigInteger(6317252838568691125L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8092358903451739015L),

new System.Numerics.BigInteger(7943033452647421784L),

new System.Numerics.BigInteger(8025852209385443942L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3491939525290502197L),

new System.Numerics.BigInteger(2610997993291594030L),

new System.Numerics.BigInteger(2728972357961918074L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(419896166129908126L),

new System.Numerics.BigInteger(1529016548820878392L),

new System.Numerics.BigInteger(8750797232563308146L),

new System.Numerics.BigInteger(9019445354365293848L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(397625939326514674L),

new System.Numerics.BigInteger(3799428589445351358L),

new System.Numerics.BigInteger(8410303752569973123L),

new System.Numerics.BigInteger(8532241607697025424L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7314501874778132104L),

new System.Numerics.BigInteger(5034919587432501935L),

new System.Numerics.BigInteger(7058008426815264181L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3687247230239884141L),

new System.Numerics.BigInteger(4409976994525537769L),

new System.Numerics.BigInteger(7946441257562238616L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8333891367889120089L),

new System.Numerics.BigInteger(4146589218091855843L),

new System.Numerics.BigInteger(2164924424571013587L),

new System.Numerics.BigInteger(1741633847942922114L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3643973857214177015L),

new System.Numerics.BigInteger(7067949202225176753L),

new System.Numerics.BigInteger(5189978021034606942L),

new System.Numerics.BigInteger(2564769267777131017L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6760191694288463619L),

new System.Numerics.BigInteger(2534695070111829649L),

new System.Numerics.BigInteger(4251084619777839351L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4900417045915169801L),

new System.Numerics.BigInteger(5299575873232592265L),

new System.Numerics.BigInteger(1427997053572875576L),

new System.Numerics.BigInteger(4434405284277109859L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4696848875976227240L),

new System.Numerics.BigInteger(1431690888603190862L),

new System.Numerics.BigInteger(3566347418727104316L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5989258258368723878L),

new System.Numerics.BigInteger(8426025158958440965L),

new System.Numerics.BigInteger(319197345932401524L),

new System.Numerics.BigInteger(5808385511471330343L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3544108442358647813L),

new System.Numerics.BigInteger(9031981320155502825L),

new System.Numerics.BigInteger(2293797611567831524L),

new System.Numerics.BigInteger(7869822744843935890L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3583143693445450990L),

new System.Numerics.BigInteger(807307079104026968L),

new System.Numerics.BigInteger(1820933348233916594L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2897847962696183202L),

new System.Numerics.BigInteger(2836274597977100893L),

new System.Numerics.BigInteger(7032152202391663401L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1883597535136602685L),

new System.Numerics.BigInteger(4644079860283287029L),

new System.Numerics.BigInteger(1276917255975879511L),

new System.Numerics.BigInteger(775757744887270341L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3944709066537956470L),

new System.Numerics.BigInteger(3705580986675756250L),

new System.Numerics.BigInteger(5764165606854175190L),

new System.Numerics.BigInteger(8615939109713244459L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2457828739527535295L),

new System.Numerics.BigInteger(6851605181767715776L),

new System.Numerics.BigInteger(5049776642164690586L),

new System.Numerics.BigInteger(8450071202858211637L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8586529901157275660L),

new System.Numerics.BigInteger(5929280390313105731L),

new System.Numerics.BigInteger(8234211992372945265L),

new System.Numerics.BigInteger(3779019641238367598L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3865462191549798551L),

new System.Numerics.BigInteger(8458432919479508492L),

new System.Numerics.BigInteger(2245900508996862678L),

new System.Numerics.BigInteger(744368422422226317L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(976192306936119534L),

new System.Numerics.BigInteger(2030617365118982031L),

new System.Numerics.BigInteger(8618814778961103732L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6285772485000077971L),

new System.Numerics.BigInteger(3755502989357174381L),

new System.Numerics.BigInteger(4597810044534963158L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7243454042559873616L),

new System.Numerics.BigInteger(3274237216053828378L),

new System.Numerics.BigInteger(5677892804158629179L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3323073614616010637L),

new System.Numerics.BigInteger(5407594483384776795L),

new System.Numerics.BigInteger(7988943702868683804L),

new System.Numerics.BigInteger(9153513238993882819L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3145404117828273555L),

new System.Numerics.BigInteger(5924929822926364353L),

new System.Numerics.BigInteger(6314577844953698935L),

new System.Numerics.BigInteger(1952499769818969025L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2317373076208176562L),

new System.Numerics.BigInteger(2289630852765837583L),

new System.Numerics.BigInteger(1976087118333323191L),

new System.Numerics.BigInteger(1985816342185577770L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5998030036551875853L),

new System.Numerics.BigInteger(1327884837952568548L),

new System.Numerics.BigInteger(1324497968648002279L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5378272757882254760L),

new System.Numerics.BigInteger(2945282271715072009L),

new System.Numerics.BigInteger(1551197632995159479L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2066349197378814820L),

new System.Numerics.BigInteger(4764502182922583210L),

new System.Numerics.BigInteger(8038295105465168645L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7737335785693734908L),

new System.Numerics.BigInteger(4803899934075187841L),

new System.Numerics.BigInteger(6629240071604874408L),

new System.Numerics.BigInteger(4651021548744287940L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6788905978496811474L),

new System.Numerics.BigInteger(3280180377027444298L),

new System.Numerics.BigInteger(5688235218490258191L),

new System.Numerics.BigInteger(4481708232224761649L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1258486577552988910L),

new System.Numerics.BigInteger(5035361301162609970L),

new System.Numerics.BigInteger(3160985130742556091L),

new System.Numerics.BigInteger(8110057038758864190L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7392661533401760334L),

new System.Numerics.BigInteger(5676647651691472333L),

new System.Numerics.BigInteger(5891986455875186238L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8659740352787687686L),

new System.Numerics.BigInteger(602765975170156422L),

new System.Numerics.BigInteger(6003995736873808771L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1017588248313904750L),

new System.Numerics.BigInteger(3501052050536190479L),

new System.Numerics.BigInteger(6097999179541367360L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5441909410233023822L),

new System.Numerics.BigInteger(6931671784387622539L),

new System.Numerics.BigInteger(54619043273780342L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5634183273651295841L),

new System.Numerics.BigInteger(3035549231424058683L),

new System.Numerics.BigInteger(5685630445652339949L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4681301835648623883L),

new System.Numerics.BigInteger(3371150442005110280L),

new System.Numerics.BigInteger(2952234946561662146L),

new System.Numerics.BigInteger(5242031862147816143L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8754796532961371873L),

new System.Numerics.BigInteger(873155073337104853L),

new System.Numerics.BigInteger(593280340017894192L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5162378639404156828L),

new System.Numerics.BigInteger(8633725864077175018L),

new System.Numerics.BigInteger(3367201621855585873L),

new System.Numerics.BigInteger(6184843947383138886L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1870810088526548954L),

new System.Numerics.BigInteger(1239129923319902554L),

new System.Numerics.BigInteger(613806935105872055L),

new System.Numerics.BigInteger(1389259608672313151L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3846396270993339264L),

new System.Numerics.BigInteger(3079557235012294384L),

new System.Numerics.BigInteger(1642414856427426614L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(308082885093154918L),

new System.Numerics.BigInteger(2772867209551309913L),

new System.Numerics.BigInteger(5236765392643217206L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2551154581236148766L),

new System.Numerics.BigInteger(9080290592975188183L),

new System.Numerics.BigInteger(2188460878389010908L),

new System.Numerics.BigInteger(2069572717394552901L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2939492384326509485L),

new System.Numerics.BigInteger(579553258917214439L),

new System.Numerics.BigInteger(3497662814246638368L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6949923995085554670L),

new System.Numerics.BigInteger(4289828028004182123L),

new System.Numerics.BigInteger(2408935955005024313L),

new System.Numerics.BigInteger(2667560003657757843L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4057366026490957248L),

new System.Numerics.BigInteger(3094825198965916860L),

new System.Numerics.BigInteger(1115282586721580063L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2382529185777285208L),

new System.Numerics.BigInteger(284669945656308452L),

new System.Numerics.BigInteger(8925314942022011562L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7178500697727746315L),

new System.Numerics.BigInteger(5665814811870386078L),

new System.Numerics.BigInteger(2036551415115263014L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7347843241489026538L),

new System.Numerics.BigInteger(3616421162043063603L),

new System.Numerics.BigInteger(1032385767707640337L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9133732880238439853L),

new System.Numerics.BigInteger(1540897631959305751L),

new System.Numerics.BigInteger(5900645733135549102L),

new System.Numerics.BigInteger(6501658225669938608L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6459086746891203268L),

new System.Numerics.BigInteger(6036710063177645240L),

new System.Numerics.BigInteger(1316386658189130787L),

new System.Numerics.BigInteger(7122024894238542817L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4841427298462224116L),

new System.Numerics.BigInteger(1295995680205912314L),

new System.Numerics.BigInteger(6877532497785016183L),

new System.Numerics.BigInteger(5708441472012161410L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(636920235125609417L),

new System.Numerics.BigInteger(7437411852677658670L),

new System.Numerics.BigInteger(2665929914800355643L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2423348320459245681L),

new System.Numerics.BigInteger(2029132339840083620L),

new System.Numerics.BigInteger(1092464814660377326L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6021019230019976157L),

new System.Numerics.BigInteger(9159803789230029781L),

new System.Numerics.BigInteger(780604834769192538L),

new System.Numerics.BigInteger(1010912608976053037L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2476553634211276687L),

new System.Numerics.BigInteger(8716836476262904919L),

new System.Numerics.BigInteger(4452451623448709611L),

new System.Numerics.BigInteger(8031258339513243656L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6748251164511731602L),

new System.Numerics.BigInteger(5001971146116711583L),

new System.Numerics.BigInteger(1219003245945124768L),

new System.Numerics.BigInteger(7283512847036407305L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4059554239635991752L),

new System.Numerics.BigInteger(3230791431359102579L),

new System.Numerics.BigInteger(2413235045241279761L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4885262246955470734L),

new System.Numerics.BigInteger(9075433525278019827L),

new System.Numerics.BigInteger(2821183699334736313L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4593378731935998018L),

new System.Numerics.BigInteger(3012445653537340377L),

new System.Numerics.BigInteger(5832765041212938117L),

new System.Numerics.BigInteger(6291213795666378674L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2411857094228306274L),

new System.Numerics.BigInteger(7765198655014628904L),

new System.Numerics.BigInteger(7885291352605693774L),

new System.Numerics.BigInteger(3312017468874609701L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4261985427889761477L),

new System.Numerics.BigInteger(500082608512719342L),

new System.Numerics.BigInteger(3849900015044019026L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6087938585187782969L),

new System.Numerics.BigInteger(3693375808331170975L),

new System.Numerics.BigInteger(4670231703800379223L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(866306244126135527L),

new System.Numerics.BigInteger(6349442267177032736L),

new System.Numerics.BigInteger(3185150550621760791L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1194069168068849341L),

new System.Numerics.BigInteger(3069066124846258622L),

new System.Numerics.BigInteger(1243613262919879416L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5479707530827684423L),

new System.Numerics.BigInteger(3861783942135438490L),

new System.Numerics.BigInteger(6408964186913381210L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6762997924441077392L),

new System.Numerics.BigInteger(6317062233826524327L),

new System.Numerics.BigInteger(1871654922617637702L),

new System.Numerics.BigInteger(5664647483498381594L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3642077590453689415L),

new System.Numerics.BigInteger(668425018329743541L),

new System.Numerics.BigInteger(2561772243996857538L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9207071348488211358L),

new System.Numerics.BigInteger(1267242562520858739L),

new System.Numerics.BigInteger(7440046856587560692L),

new System.Numerics.BigInteger(5910357281878520571L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4597067666306697390L),

new System.Numerics.BigInteger(4452230553610136160L),

new System.Numerics.BigInteger(5648056673131727850L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5269895676670613400L),

new System.Numerics.BigInteger(8809119190948876571L),

new System.Numerics.BigInteger(5792422654117244786L),

new System.Numerics.BigInteger(8522636447488374289L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3880115374940192899L),

new System.Numerics.BigInteger(8494972959698333412L),

new System.Numerics.BigInteger(4729593302756337779L),

new System.Numerics.BigInteger(2846403952850152044L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2242568215857012499L),

new System.Numerics.BigInteger(8107470421186018524L),

new System.Numerics.BigInteger(4579516947000007145L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3137631979270862188L),

new System.Numerics.BigInteger(6987401428734943147L),

new System.Numerics.BigInteger(4083323676781657769L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2685792758571135442L),

new System.Numerics.BigInteger(4908537674278409683L),

new System.Numerics.BigInteger(7039134746932515312L),

new System.Numerics.BigInteger(4242427728779028763L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6449835899205915390L),

new System.Numerics.BigInteger(4068445304170646979L),

new System.Numerics.BigInteger(2058934599776303350L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1138750259126240359L),

new System.Numerics.BigInteger(5807102534349687660L),

new System.Numerics.BigInteger(6244940267680481363L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8995859642530048262L),

new System.Numerics.BigInteger(311150580035493723L),

new System.Numerics.BigInteger(2743344935530960743L),

new System.Numerics.BigInteger(8272614400193049978L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8324663296943894115L),

new System.Numerics.BigInteger(1488830514828130629L),

new System.Numerics.BigInteger(9164056048932675809L),

new System.Numerics.BigInteger(4372352429168845391L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5136955524653922651L),

new System.Numerics.BigInteger(789264584707732528L),

new System.Numerics.BigInteger(127808527954562763L),

new System.Numerics.BigInteger(584165419044627584L),

},
    ModelInner = null,
    NullableValue = null,
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
                parametr1.Value = 169;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
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
                parametr1.Value = 162;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[26],_testData[34], false);
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
                parametr2.Value = 169;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[34], false);
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
                await ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 169, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
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
                await ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 125, query1, 169, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
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
                 ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 56, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
                 ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 65, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 119, query1, 96, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 158, query1, 36, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 147, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[34], false);
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
                 ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 162, query1, 93, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 29, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[5], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[6], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[7], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[27],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[28],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[1], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[2], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[3], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[4], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[5], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[6], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[7], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[27],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[28],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[29],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[30],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[31],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[32],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[33],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatch(connection, 174, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[34], false);
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
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 158);
                var models = await ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[30], false);
                BigIntegernumericListD1E2M.AssertModel(models[1],_testData[31], false);
                BigIntegernumericListD1E2M.AssertModel(models[2],_testData[32], false);
                BigIntegernumericListD1E2M.AssertModel(models[3],_testData[33], false);
                BigIntegernumericListD1E2M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models =  ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[15], false);
                BigIntegernumericListD1E2M.AssertModel(models[1],_testData[16], false);
                BigIntegernumericListD1E2M.AssertModel(models[2],_testData[17], false);
                BigIntegernumericListD1E2M.AssertModel(models[3],_testData[18], false);
                BigIntegernumericListD1E2M.AssertModel(models[4],_testData[19], false);
                BigIntegernumericListD1E2M.AssertModel(models[5],_testData[20], false);
                BigIntegernumericListD1E2M.AssertModel(models[6],_testData[21], false);
                BigIntegernumericListD1E2M.AssertModel(models[7],_testData[22], false);
                BigIntegernumericListD1E2M.AssertModel(models[8],_testData[23], false);
                BigIntegernumericListD1E2M.AssertModel(models[9],_testData[24], false);
                BigIntegernumericListD1E2M.AssertModel(models[10],_testData[25], false);
                BigIntegernumericListD1E2M.AssertModel(models[11],_testData[26], false);
                BigIntegernumericListD1E2M.AssertModel(models[12],_testData[27], false);
                BigIntegernumericListD1E2M.AssertModel(models[13],_testData[28], false);
                BigIntegernumericListD1E2M.AssertModel(models[14],_testData[29], false);
                BigIntegernumericListD1E2M.AssertModel(models[15],_testData[30], false);
                BigIntegernumericListD1E2M.AssertModel(models[16],_testData[31], false);
                BigIntegernumericListD1E2M.AssertModel(models[17],_testData[32], false);
                BigIntegernumericListD1E2M.AssertModel(models[18],_testData[33], false);
                BigIntegernumericListD1E2M.AssertModel(models[19],_testData[34], false);
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

