

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
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2548927091884221206L),

new System.Numerics.BigInteger(8114391601735929817L),

new System.Numerics.BigInteger(7179672026810369092L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3802963906888514236L),

new System.Numerics.BigInteger(4870373183284521172L),

new System.Numerics.BigInteger(5491770265955516209L),

new System.Numerics.BigInteger(5434557558855914739L),

},
},
            new BigIntegernumericArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2168601742014261311L),

new System.Numerics.BigInteger(5021908181571149862L),

new System.Numerics.BigInteger(5103516493329904453L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7184789347591308020L),

new System.Numerics.BigInteger(2551309079082701108L),

new System.Numerics.BigInteger(59990827648519240L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2533112143651625165L),

new System.Numerics.BigInteger(5689556447348585758L),

new System.Numerics.BigInteger(7442466358060141154L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2686112468195576840L),

new System.Numerics.BigInteger(5915513954001655497L),

new System.Numerics.BigInteger(308577391048894219L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(950877962912269799L),

new System.Numerics.BigInteger(7274043208784760727L),

new System.Numerics.BigInteger(7374412920444841579L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1445766947006956030L),

new System.Numerics.BigInteger(4375792991980841512L),

new System.Numerics.BigInteger(2963405293039706614L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4074875222643133477L),

new System.Numerics.BigInteger(4745972856149787502L),

new System.Numerics.BigInteger(6812674147769679466L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5466051989479740284L),

new System.Numerics.BigInteger(9068404477414928058L),

new System.Numerics.BigInteger(8321353726728659338L),

new System.Numerics.BigInteger(7385727114759429847L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(885057872017979331L),

new System.Numerics.BigInteger(9222248871784413549L),

new System.Numerics.BigInteger(1488812673753619721L),

new System.Numerics.BigInteger(5681575616476418744L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7850485559045750662L),

new System.Numerics.BigInteger(8224200237370739136L),

new System.Numerics.BigInteger(3953230021799436876L),

new System.Numerics.BigInteger(8078325092567455510L),

},
},
            new BigIntegernumericArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4266413875294112383L),

new System.Numerics.BigInteger(8290200553622846486L),

new System.Numerics.BigInteger(289385585294149511L),

new System.Numerics.BigInteger(6767045838059166184L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7697531431937723941L),

new System.Numerics.BigInteger(177372635353678821L),

new System.Numerics.BigInteger(7808133784084581163L),

new System.Numerics.BigInteger(8971817008210432329L),

},
},
            new BigIntegernumericArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2724242007243532930L),

new System.Numerics.BigInteger(8917660315879280226L),

new System.Numerics.BigInteger(1797615048904704290L),

new System.Numerics.BigInteger(8092927055094289232L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(169171681727855618L),

new System.Numerics.BigInteger(3623622281861907837L),

new System.Numerics.BigInteger(7570954644487262456L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8090360444258003274L),

new System.Numerics.BigInteger(5594559482638514400L),

new System.Numerics.BigInteger(2478935751798512330L),

new System.Numerics.BigInteger(5060055734113871734L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5247679357367136031L),

new System.Numerics.BigInteger(2433605856122499501L),

new System.Numerics.BigInteger(4261233027544511528L),

new System.Numerics.BigInteger(8605150853769195056L),

},
},
            new BigIntegernumericArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4962267222222927611L),

new System.Numerics.BigInteger(5653408540592385489L),

new System.Numerics.BigInteger(853676734719752160L),

new System.Numerics.BigInteger(810644473015191629L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7808013898736901579L),

new System.Numerics.BigInteger(7501064534038830348L),

new System.Numerics.BigInteger(6933020438177478239L),

},
},
            new BigIntegernumericArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4698631686659482495L),

new System.Numerics.BigInteger(4647543938386843257L),

new System.Numerics.BigInteger(7240245006733773388L),

new System.Numerics.BigInteger(4763680928257820190L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5476411458651648416L),

new System.Numerics.BigInteger(4967924127634533080L),

new System.Numerics.BigInteger(2445930179179897347L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5588477380034224012L),

new System.Numerics.BigInteger(7134340408526479936L),

new System.Numerics.BigInteger(3110649707374520845L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(661582045740181269L),

new System.Numerics.BigInteger(517301727151487782L),

new System.Numerics.BigInteger(8721044019261375060L),

new System.Numerics.BigInteger(8331750678653888793L),

},
},
            new BigIntegernumericArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8038085342187564545L),

new System.Numerics.BigInteger(4152856918315146686L),

new System.Numerics.BigInteger(8667693345538379171L),

new System.Numerics.BigInteger(9148257025867792159L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8713602002423640245L),

new System.Numerics.BigInteger(7765010901521133502L),

new System.Numerics.BigInteger(2407638230411681227L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7059639568233934000L),

new System.Numerics.BigInteger(1151814191524418224L),

new System.Numerics.BigInteger(8992033479320791431L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2194783198793567661L),

new System.Numerics.BigInteger(7096142337716427249L),

new System.Numerics.BigInteger(7281203220251315785L),

new System.Numerics.BigInteger(3318474186491815000L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6159035884874454655L),

new System.Numerics.BigInteger(8955111549964549763L),

new System.Numerics.BigInteger(2432086887433041256L),

new System.Numerics.BigInteger(8960622368260365239L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3383275565120025736L),

new System.Numerics.BigInteger(2557629346724541977L),

new System.Numerics.BigInteger(1045871722401472220L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8560553250536860857L),

new System.Numerics.BigInteger(3512721975224651459L),

new System.Numerics.BigInteger(5024187156930254597L),

new System.Numerics.BigInteger(5559215704001637636L),

},
},
            new BigIntegernumericArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2768190940739545966L),

new System.Numerics.BigInteger(783638384981886204L),

new System.Numerics.BigInteger(3299453123733160522L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8604267909220361707L),

new System.Numerics.BigInteger(8667802347772737083L),

new System.Numerics.BigInteger(8156680429130494517L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4904802609479118560L),

new System.Numerics.BigInteger(73560725653278864L),

new System.Numerics.BigInteger(197127087225950969L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2228137443052354366L),

new System.Numerics.BigInteger(7365559644951921593L),

new System.Numerics.BigInteger(3284460010883236218L),

new System.Numerics.BigInteger(2317981257497732696L),

},
},
            new BigIntegernumericArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4865395348453246208L),

new System.Numerics.BigInteger(3138476603816736495L),

new System.Numerics.BigInteger(8099028872522134017L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8517299001005533913L),

new System.Numerics.BigInteger(5444465635909342712L),

new System.Numerics.BigInteger(5121584436843050775L),

new System.Numerics.BigInteger(2895076569287715437L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6610802421034176607L),

new System.Numerics.BigInteger(9067433758141198309L),

new System.Numerics.BigInteger(1634352196224005776L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6200130943816471540L),

new System.Numerics.BigInteger(1998571594987485876L),

new System.Numerics.BigInteger(7821510311353890673L),

new System.Numerics.BigInteger(8352885776486731087L),

},
},
            new BigIntegernumericArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3441103763772639854L),

new System.Numerics.BigInteger(7263632317883735144L),

new System.Numerics.BigInteger(6684866091928645040L),

new System.Numerics.BigInteger(5832634974170801793L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1202471470198618901L),

new System.Numerics.BigInteger(1140773710520096447L),

new System.Numerics.BigInteger(7225073279562520860L),

new System.Numerics.BigInteger(6541188561449826328L),

},
},
            new BigIntegernumericArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8675935343890585292L),

new System.Numerics.BigInteger(1994176690519756319L),

new System.Numerics.BigInteger(6676638540713601793L),

new System.Numerics.BigInteger(1516978153157928056L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6809001157080650385L),

new System.Numerics.BigInteger(3590727581674926280L),

new System.Numerics.BigInteger(1938659292669495351L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8999821410085136159L),

new System.Numerics.BigInteger(6893829019211684677L),

new System.Numerics.BigInteger(5562110239227979234L),

new System.Numerics.BigInteger(4879926873541022145L),

},
},
            new BigIntegernumericArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4571963966344696568L),

new System.Numerics.BigInteger(7165707183613207500L),

new System.Numerics.BigInteger(9184589404392606645L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1279860287632447761L),

new System.Numerics.BigInteger(7331065755823597793L),

new System.Numerics.BigInteger(1747951173289136167L),

new System.Numerics.BigInteger(6059986809124939777L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6890075731739892923L),

new System.Numerics.BigInteger(6800094356627251061L),

new System.Numerics.BigInteger(8400371857223458375L),

new System.Numerics.BigInteger(6856481076452604496L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7742979593448460061L),

new System.Numerics.BigInteger(3424653410627495288L),

new System.Numerics.BigInteger(5186843170663039919L),

},
},
            new BigIntegernumericArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6120082729759545560L),

new System.Numerics.BigInteger(3891569822219214478L),

new System.Numerics.BigInteger(3468582197017767555L),

new System.Numerics.BigInteger(6623554882212054027L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4562834024002607816L),

new System.Numerics.BigInteger(5385560132977287272L),

new System.Numerics.BigInteger(3850188675292415742L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1163655540283925577L),

new System.Numerics.BigInteger(6964946544261594020L),

new System.Numerics.BigInteger(365487088332845635L),

new System.Numerics.BigInteger(1580646697828127004L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1733090890888109576L),

new System.Numerics.BigInteger(751639472237814382L),

new System.Numerics.BigInteger(4527570515207157641L),

new System.Numerics.BigInteger(5725687039762723496L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1971162230555732962L),

new System.Numerics.BigInteger(7098664947858620786L),

new System.Numerics.BigInteger(6576012224448629808L),

},
},
            new BigIntegernumericArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9038478808414007460L),

new System.Numerics.BigInteger(524416194686863448L),

new System.Numerics.BigInteger(2708139028316167055L),

new System.Numerics.BigInteger(4767544184286199518L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6016364199346354392L),

new System.Numerics.BigInteger(141203724719700254L),

new System.Numerics.BigInteger(4439060782434231090L),

new System.Numerics.BigInteger(576988477889211362L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2781229907844703715L),

new System.Numerics.BigInteger(5659006103787442778L),

new System.Numerics.BigInteger(7761505437443597598L),

new System.Numerics.BigInteger(3113141112500228306L),

},
},
            new BigIntegernumericArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5124719808915010222L),

new System.Numerics.BigInteger(2969137509045938127L),

new System.Numerics.BigInteger(2160290314673682195L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5749518354130778745L),

new System.Numerics.BigInteger(666421840722104414L),

new System.Numerics.BigInteger(154741808998965379L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1221557038151748439L),

new System.Numerics.BigInteger(5133334694466644724L),

new System.Numerics.BigInteger(1831563462021234441L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7052538898586039028L),

new System.Numerics.BigInteger(5461508493025224718L),

new System.Numerics.BigInteger(5994302987926060363L),

new System.Numerics.BigInteger(4564157369608392189L),

},
},
            new BigIntegernumericArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3439872355367749800L),

new System.Numerics.BigInteger(8464017377605667729L),

new System.Numerics.BigInteger(7792026871026348593L),

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
new System.Numerics.BigInteger(4137457397732252564L),

new System.Numerics.BigInteger(3157974871008683248L),

new System.Numerics.BigInteger(1385811888576289475L),

new System.Numerics.BigInteger(4961214997585871056L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2320136068476317144L),

new System.Numerics.BigInteger(6246174864157536291L),

new System.Numerics.BigInteger(3326427847574898727L),

new System.Numerics.BigInteger(1716044598645696062L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5334918143476963642L),

new System.Numerics.BigInteger(7436436821458855656L),

new System.Numerics.BigInteger(2078409570854359967L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(120824882709784092L),

new System.Numerics.BigInteger(8391662024337154692L),

new System.Numerics.BigInteger(6613440698327045829L),

new System.Numerics.BigInteger(8538665527311236567L),

},
},
            new BigIntegernumericArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(223236384791601868L),

new System.Numerics.BigInteger(6888067162111539738L),

new System.Numerics.BigInteger(6710359278431638612L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5098753138732353307L),

new System.Numerics.BigInteger(8755967719860221823L),

new System.Numerics.BigInteger(933838695147262894L),

},
},
            new BigIntegernumericArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(114607896419905038L),

new System.Numerics.BigInteger(8078108181116791985L),

new System.Numerics.BigInteger(3925456057555084157L),

new System.Numerics.BigInteger(609952006987656200L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6986172420480669900L),

new System.Numerics.BigInteger(8446079108209948635L),

new System.Numerics.BigInteger(3156442136280624767L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(899254756962688159L),

new System.Numerics.BigInteger(1025256565593634557L),

new System.Numerics.BigInteger(8930743294463364855L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7176437897887725918L),

new System.Numerics.BigInteger(2663507303762358354L),

new System.Numerics.BigInteger(8514840745993425141L),

new System.Numerics.BigInteger(6937079857091239946L),

},
},
            new BigIntegernumericArray2M
{
    Id = 192,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4449296750131439784L),

new System.Numerics.BigInteger(5143899153959895560L),

new System.Numerics.BigInteger(1457957409883871051L),

new System.Numerics.BigInteger(8608653069935941769L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5636218519280657146L),

new System.Numerics.BigInteger(3941801956427797034L),

new System.Numerics.BigInteger(9038526626881385660L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5938035116503371746L),

new System.Numerics.BigInteger(602320982753725326L),

new System.Numerics.BigInteger(650146006580141059L),

new System.Numerics.BigInteger(391265279049417982L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 200,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1414707234372224682L),

new System.Numerics.BigInteger(4242093934760142313L),

new System.Numerics.BigInteger(4101383376541414968L),

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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
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
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[34], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[34], false);
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
                parametr1.Value = 66;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[28],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[29],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[30],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[31],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 15, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[32],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 45, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 162, query1, 162, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 45, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 27, query1, 152, query2))
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 41, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 71, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 48, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 51, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 48, 86))
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[34], false);
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
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 132);
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
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 155);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
BigIntegernumericArray2M.AssertModel(models[0],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[29], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[30], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[31], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[32], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[33], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[34], false);
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
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
            dbTypes: null,
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
            dbTypes: null,
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
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
            dbTypes: null,
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
            dbTypes: null,
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

