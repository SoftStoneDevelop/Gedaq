

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
    internal partial interface INpgsqlLineListlineArray
    {
    }
    
    internal partial class NpgsqlLineListlineArray : INpgsqlLineListlineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray2M[] _testData = new NpgsqlLinelineArray2M[]
        {
            new NpgsqlLinelineArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9534108721513259d, b: 0.1392833860344096d, c: 0.29272158821129357d),

new NpgsqlTypes.NpgsqlLine(a: 0.957586627141694d, b: 0.5772413994744833d, c: 0.2962101878901999d),

new NpgsqlTypes.NpgsqlLine(a: 0.13510850550252673d, b: 0.5905625314750359d, c: 0.7366855382855396d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5985480040243677d, b: 0.5083392082715369d, c: 0.9859407435586606d),

new NpgsqlTypes.NpgsqlLine(a: 0.462874382246912d, b: 0.42131358042030076d, c: 0.4127044931026719d),

new NpgsqlTypes.NpgsqlLine(a: 0.35700241789149134d, b: 0.39605183072965167d, c: 0.9896270181251515d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3466570879246399d, b: 0.0510255844759786d, c: 0.07755232102128373d),

new NpgsqlTypes.NpgsqlLine(a: 0.47378719358932353d, b: 0.928896703170837d, c: 0.6445862303362684d),

new NpgsqlTypes.NpgsqlLine(a: 0.4462064691244345d, b: 0.5938481062186796d, c: 0.5601342647651553d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1807673255090364d, b: 0.07613972035301364d, c: 0.702737919263737d),

new NpgsqlTypes.NpgsqlLine(a: 0.30849406803140866d, b: 0.1990299611088755d, c: 0.11045735990170602d),

new NpgsqlTypes.NpgsqlLine(a: 0.8834989962243609d, b: 0.07593595177649326d, c: 0.6603646993363871d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28896912196588287d, b: 0.7889620768450573d, c: 0.18405122627333492d),

new NpgsqlTypes.NpgsqlLine(a: 0.7362843654318159d, b: 0.9090589949494906d, c: 0.6925907240988726d),

new NpgsqlTypes.NpgsqlLine(a: 0.48116246560940545d, b: 0.37132116441911234d, c: 0.4841986572788497d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.41969954283477673d, b: 0.8307047243017099d, c: 0.9266397000093857d),

new NpgsqlTypes.NpgsqlLine(a: 0.7887055551676007d, b: 0.4710964185944957d, c: 0.1812645217948653d),

new NpgsqlTypes.NpgsqlLine(a: 0.6054680642417224d, b: 0.45348684372193904d, c: 0.6846539472413412d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3359840567096386d, b: 0.0016179678546469622d, c: 0.6004586192981176d),

new NpgsqlTypes.NpgsqlLine(a: 0.11789951084654526d, b: 0.9678332629029383d, c: 0.5017716307837993d),

new NpgsqlTypes.NpgsqlLine(a: 0.4597702101011588d, b: 0.7109752631351803d, c: 0.09370399506054705d),

new NpgsqlTypes.NpgsqlLine(a: 0.20306479718471682d, b: 0.1956537428444146d, c: 0.7022737288819983d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.702355390948744d, b: 0.9284958761543101d, c: 0.6794923361427584d),

new NpgsqlTypes.NpgsqlLine(a: 0.5856234428340263d, b: 0.7043064994875519d, c: 0.4506791498434999d),

new NpgsqlTypes.NpgsqlLine(a: 0.5723268166565808d, b: 0.4323194852234411d, c: 0.2520111301473119d),

new NpgsqlTypes.NpgsqlLine(a: 0.6536677717354084d, b: 0.27041702182333094d, c: 0.12536256932519696d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26046557812228177d, b: 0.18936843729437192d, c: 0.6447544950069225d),

new NpgsqlTypes.NpgsqlLine(a: 0.18818840993742658d, b: 0.5292975263274093d, c: 0.6773303899034857d),

new NpgsqlTypes.NpgsqlLine(a: 0.606977918286799d, b: 0.5022174858608291d, c: 0.8766400116609984d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6549007901340745d, b: 0.8069632131170086d, c: 0.3527727162490013d),

new NpgsqlTypes.NpgsqlLine(a: 0.6390950828893036d, b: 0.12614451967152918d, c: 0.5556347257074694d),

new NpgsqlTypes.NpgsqlLine(a: 0.6247871113114136d, b: 0.10843443947400244d, c: 0.7619810456214086d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24792990147155614d, b: 0.48400190355282346d, c: 0.8487021547850692d),

new NpgsqlTypes.NpgsqlLine(a: 0.5649713876652742d, b: 0.5999109706166096d, c: 0.7599061900752175d),

new NpgsqlTypes.NpgsqlLine(a: 0.5370698350219377d, b: 0.8055215552252019d, c: 0.3791223957361609d),

new NpgsqlTypes.NpgsqlLine(a: 0.6701150224450795d, b: 0.4310979571847119d, c: 0.8439932276466741d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6035318852897193d, b: 0.6347179472185509d, c: 0.6226231935238613d),

new NpgsqlTypes.NpgsqlLine(a: 0.30186778934952996d, b: 0.4236371435497319d, c: 0.8876013729260281d),

new NpgsqlTypes.NpgsqlLine(a: 0.9393108162163686d, b: 0.5798063825802072d, c: 0.12305694579069526d),

new NpgsqlTypes.NpgsqlLine(a: 0.4264776691455796d, b: 0.12196686947683932d, c: 0.5007167171725995d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16886774068623944d, b: 0.6567327189144838d, c: 0.942657262683967d),

new NpgsqlTypes.NpgsqlLine(a: 0.945142958063254d, b: 0.9866581605712181d, c: 0.304000723765974d),

new NpgsqlTypes.NpgsqlLine(a: 0.13032653023522422d, b: 0.9049022478101059d, c: 0.5116959694466122d),

new NpgsqlTypes.NpgsqlLine(a: 0.6715459128332915d, b: 0.6051687671736478d, c: 0.8158677718762725d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.30817682853566586d, b: 0.36243480494967983d, c: 0.19047249677582423d),

new NpgsqlTypes.NpgsqlLine(a: 0.779882608695026d, b: 0.35734176396809714d, c: 0.20518490542168688d),

new NpgsqlTypes.NpgsqlLine(a: 0.513402719139539d, b: 0.10540718826136053d, c: 0.021040968181366027d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.883227099242255d, b: 0.34303905208292207d, c: 0.3736268622224983d),

new NpgsqlTypes.NpgsqlLine(a: 0.8031040538448715d, b: 0.3302937303150546d, c: 0.8122467089865184d),

new NpgsqlTypes.NpgsqlLine(a: 0.9995066831858909d, b: 0.6409000358389592d, c: 0.6343613279895284d),

new NpgsqlTypes.NpgsqlLine(a: 0.19206435561713897d, b: 0.4683783394563914d, c: 0.12619486571396055d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5562312078360768d, b: 0.9279427488227178d, c: 0.061802361728022115d),

new NpgsqlTypes.NpgsqlLine(a: 0.828504074222251d, b: 0.5137965567178964d, c: 0.2866914122368107d),

new NpgsqlTypes.NpgsqlLine(a: 0.3628863535407929d, b: 0.07853657074176568d, c: 0.27657263749422645d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17313620489934112d, b: 0.3299741374543925d, c: 0.4400875249092411d),

new NpgsqlTypes.NpgsqlLine(a: 0.6898922064518236d, b: 0.9604884127947086d, c: 0.19243983771899542d),

new NpgsqlTypes.NpgsqlLine(a: 0.7306017009057566d, b: 0.4892446103987508d, c: 0.9420267661225298d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2133420183302801d, b: 0.9980020598542758d, c: 0.14465696943934225d),

new NpgsqlTypes.NpgsqlLine(a: 0.0681341839089642d, b: 0.14341929123290997d, c: 0.8904993370044952d),

new NpgsqlTypes.NpgsqlLine(a: 0.7875414618616695d, b: 0.10441263325843819d, c: 0.2512901793005796d),

new NpgsqlTypes.NpgsqlLine(a: 0.9111794969150326d, b: 0.10577074028773659d, c: 0.7042359335026954d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.38906177899079075d, b: 0.9448476554458636d, c: 0.08877440745298648d),

new NpgsqlTypes.NpgsqlLine(a: 0.9262958968882085d, b: 0.14269152335421775d, c: 0.10562051798174033d),

new NpgsqlTypes.NpgsqlLine(a: 0.9898021222383493d, b: 0.8506960862791417d, c: 0.8378482890460279d),

new NpgsqlTypes.NpgsqlLine(a: 0.5176493694986811d, b: 0.609221002395687d, c: 0.6281458520858272d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9401234772955205d, b: 0.9554339137229819d, c: 0.07672396773714618d),

new NpgsqlTypes.NpgsqlLine(a: 0.7033276412222821d, b: 0.5803673344825424d, c: 0.3243888320038737d),

new NpgsqlTypes.NpgsqlLine(a: 0.26949131937236137d, b: 0.18964345311402864d, c: 0.3872939518534959d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04808134322171986d, b: 0.33862275865753577d, c: 0.08949819339219889d),

new NpgsqlTypes.NpgsqlLine(a: 0.044420785583930034d, b: 0.800528114347089d, c: 0.25540474511221967d),

new NpgsqlTypes.NpgsqlLine(a: 0.5255030612927025d, b: 0.6501381833705565d, c: 0.5880248274554988d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17243477077871683d, b: 0.06586340724889217d, c: 0.46295948500964157d),

new NpgsqlTypes.NpgsqlLine(a: 0.22565088193512783d, b: 0.33102854502483947d, c: 0.9602390830453404d),

new NpgsqlTypes.NpgsqlLine(a: 0.4905432375475829d, b: 0.3128890095598452d, c: 0.08337441471782547d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4212739715838485d, b: 0.5446293176780603d, c: 0.20994468341467543d),

new NpgsqlTypes.NpgsqlLine(a: 0.8465757922101722d, b: 0.024685785741585864d, c: 0.2854645040956214d),

new NpgsqlTypes.NpgsqlLine(a: 0.07040207152835531d, b: 0.8775301711595611d, c: 0.5079724420141702d),

new NpgsqlTypes.NpgsqlLine(a: 0.7895958903941114d, b: 0.2522488028949186d, c: 0.8619178644947839d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2026373692997926d, b: 0.6885692659794742d, c: 0.5874368886558065d),

new NpgsqlTypes.NpgsqlLine(a: 0.8510594112427112d, b: 0.4269722517282851d, c: 0.5689699152785591d),

new NpgsqlTypes.NpgsqlLine(a: 0.31567097141154943d, b: 0.5264170949015367d, c: 0.09785288491223398d),

new NpgsqlTypes.NpgsqlLine(a: 0.8945546796087972d, b: 0.8479117049231217d, c: 0.18666015221161925d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9804102513450214d, b: 0.9467319471298675d, c: 0.5234502674615324d),

new NpgsqlTypes.NpgsqlLine(a: 0.9764329494726183d, b: 0.12089937159531428d, c: 0.29575629985175333d),

new NpgsqlTypes.NpgsqlLine(a: 0.2604768772866938d, b: 0.20993072371689858d, c: 0.20510869492038852d),

new NpgsqlTypes.NpgsqlLine(a: 0.5781513108163396d, b: 0.7673019312020106d, c: 0.5132545053454727d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4708432024549921d, b: 0.11060948961476591d, c: 0.9837114859609658d),

new NpgsqlTypes.NpgsqlLine(a: 0.17497391533595363d, b: 0.685771909782348d, c: 0.3351229800970291d),

new NpgsqlTypes.NpgsqlLine(a: 0.3341388214170564d, b: 0.7951197711621805d, c: 0.6491696416888636d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3617535063431089d, b: 0.5761225083000302d, c: 0.874805043304966d),

new NpgsqlTypes.NpgsqlLine(a: 0.7379233372643228d, b: 0.8616692946703175d, c: 0.7298153865801889d),

new NpgsqlTypes.NpgsqlLine(a: 0.5767368872121436d, b: 0.7946687288700224d, c: 0.023116755061703187d),

new NpgsqlTypes.NpgsqlLine(a: 0.0713392629400984d, b: 0.7911967221314176d, c: 0.4563880784992915d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23223176046608163d, b: 0.1706729001922962d, c: 0.20475509788160795d),

new NpgsqlTypes.NpgsqlLine(a: 0.1996835820542623d, b: 0.39038765953806365d, c: 0.8946990212146018d),

new NpgsqlTypes.NpgsqlLine(a: 0.12075383902626569d, b: 0.6251184585530116d, c: 0.2487856221298148d),

new NpgsqlTypes.NpgsqlLine(a: 0.3649151942356804d, b: 0.3233740611934326d, c: 0.6547962294672539d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1787279044731399d, b: 0.024097054408087182d, c: 0.7242363115815499d),

new NpgsqlTypes.NpgsqlLine(a: 0.09524911446649464d, b: 0.7410730991363428d, c: 0.6930074096598549d),

new NpgsqlTypes.NpgsqlLine(a: 0.026827540965229657d, b: 0.36842033651309936d, c: 0.46281118828377266d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9395491714619635d, b: 0.8930395904163057d, c: 0.011349058805735224d),

new NpgsqlTypes.NpgsqlLine(a: 0.7719515537082275d, b: 0.7620337140258494d, c: 0.15550424800983553d),

new NpgsqlTypes.NpgsqlLine(a: 0.958052281596039d, b: 0.0018576192861772256d, c: 0.2711141606043215d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15276488814025502d, b: 0.046614468528217934d, c: 0.06996045848752652d),

new NpgsqlTypes.NpgsqlLine(a: 0.1535115455462851d, b: 0.15601844087147776d, c: 0.6453278004952995d),

new NpgsqlTypes.NpgsqlLine(a: 0.14910174568573853d, b: 0.5374108992188544d, c: 0.6142320349738035d),

new NpgsqlTypes.NpgsqlLine(a: 0.0005220554838905045d, b: 0.2197637228474445d, c: 0.7745925257908922d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14355396521902608d, b: 0.8911257449622257d, c: 0.30245680359215377d),

new NpgsqlTypes.NpgsqlLine(a: 0.8941846466956126d, b: 0.7109355638319725d, c: 0.8414223870032742d),

new NpgsqlTypes.NpgsqlLine(a: 0.981994016715503d, b: 0.6267203875626096d, c: 0.7562228182777374d),

new NpgsqlTypes.NpgsqlLine(a: 0.15048197256473317d, b: 0.6409218799769086d, c: 0.8854555755107578d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.011813391457313971d, b: 0.7915051484412678d, c: 0.5979038073859415d),

new NpgsqlTypes.NpgsqlLine(a: 0.4569028811248551d, b: 0.8434194856214062d, c: 0.2408555074641925d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480832480625399d, b: 0.3787731313569427d, c: 0.22002402355862827d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4947347719901435d, b: 0.8259733534900852d, c: 0.1559693146451403d),

new NpgsqlTypes.NpgsqlLine(a: 0.6593130041534755d, b: 0.7148491433484545d, c: 0.9988337846922125d),

new NpgsqlTypes.NpgsqlLine(a: 0.7216977063697324d, b: 0.7729686430769942d, c: 0.7207038707848581d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4192963221025807d, b: 0.12160293597363792d, c: 0.9013312351838124d),

new NpgsqlTypes.NpgsqlLine(a: 0.1616686360173134d, b: 0.7217207621118447d, c: 0.6744821884284014d),

new NpgsqlTypes.NpgsqlLine(a: 0.8207185468744052d, b: 0.34457573248428996d, c: 0.5227954931098557d),

new NpgsqlTypes.NpgsqlLine(a: 0.8791536680736278d, b: 0.7311280815689353d, c: 0.13938404830580864d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3908542505893001d, b: 0.6678490895251843d, c: 0.20007972753230707d),

new NpgsqlTypes.NpgsqlLine(a: 0.3154112850730326d, b: 0.1776117134064058d, c: 0.0755292389466996d),

new NpgsqlTypes.NpgsqlLine(a: 0.1741547555376377d, b: 0.994580588027737d, c: 0.8305759434675479d),

new NpgsqlTypes.NpgsqlLine(a: 0.7763055318128728d, b: 0.5982182417408439d, c: 0.3215333441003587d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.612879945000878d, b: 0.48819144788036806d, c: 0.5220561644358122d),

new NpgsqlTypes.NpgsqlLine(a: 0.08737397727599183d, b: 0.38435988659604947d, c: 0.2619233543399715d),

new NpgsqlTypes.NpgsqlLine(a: 0.833793888070002d, b: 0.8042175804673626d, c: 0.9123283022288303d),

new NpgsqlTypes.NpgsqlLine(a: 0.9214991957656486d, b: 0.19957667128121337d, c: 0.02884140321738582d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6979860094426886d, b: 0.0857295754276266d, c: 0.29666969384045294d),

new NpgsqlTypes.NpgsqlLine(a: 0.6628169275123509d, b: 0.7428698676383537d, c: 0.8758748270100475d),

new NpgsqlTypes.NpgsqlLine(a: 0.07449257275448795d, b: 0.7159315721349341d, c: 0.5949027562397573d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3831453741125086d, b: 0.18573969426843095d, c: 0.6324032033658128d),

new NpgsqlTypes.NpgsqlLine(a: 0.5303284851130314d, b: 0.6454711371714551d, c: 0.6929666279779843d),

new NpgsqlTypes.NpgsqlLine(a: 0.6175178056330762d, b: 0.3332954393612073d, c: 0.18521774394402724d),

new NpgsqlTypes.NpgsqlLine(a: 0.3117068326322733d, b: 0.5316184769545272d, c: 0.7516840781210677d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1474790369874438d, b: 0.41752226920749125d, c: 0.8056185762855181d),

new NpgsqlTypes.NpgsqlLine(a: 0.3464836092557574d, b: 0.9006451354091248d, c: 0.5460988699740834d),

new NpgsqlTypes.NpgsqlLine(a: 0.00676381902354628d, b: 0.49603798821270106d, c: 0.21384386563708002d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9311365710587627d, b: 0.10090234263801434d, c: 0.9754095505238397d),

new NpgsqlTypes.NpgsqlLine(a: 0.21107626465281482d, b: 0.5551278227512149d, c: 0.0402378031277667d),

new NpgsqlTypes.NpgsqlLine(a: 0.06918327591650297d, b: 0.5008931292970856d, c: 0.3113095556836225d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42643133502442787d, b: 0.713702373363886d, c: 0.04734796549172615d),

new NpgsqlTypes.NpgsqlLine(a: 0.7166463998489934d, b: 0.9354677843221765d, c: 0.8235898106424464d),

new NpgsqlTypes.NpgsqlLine(a: 0.5534625730947969d, b: 0.4871229256702041d, c: 0.13939559490457487d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.40089618722178355d, b: 0.22113044047148211d, c: 0.10034931566835403d),

new NpgsqlTypes.NpgsqlLine(a: 0.9291669674726468d, b: 0.20260185590840463d, c: 0.3786250399657106d),

new NpgsqlTypes.NpgsqlLine(a: 0.2661463521913773d, b: 0.5856888807957005d, c: 0.41983734127443995d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6685118446065089d, b: 0.011598200511040546d, c: 0.7321905920293679d),

new NpgsqlTypes.NpgsqlLine(a: 0.3742661728855773d, b: 0.29787024729920264d, c: 0.4518133185795453d),

new NpgsqlTypes.NpgsqlLine(a: 0.9652146751102784d, b: 0.016620851095065836d, c: 0.5987561534692479d),

new NpgsqlTypes.NpgsqlLine(a: 0.6714498561479179d, b: 0.19483005674065035d, c: 0.2980024495415513d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15628951327062846d, b: 0.6761420644374806d, c: 0.5789161901847114d),

new NpgsqlTypes.NpgsqlLine(a: 0.016363862932963436d, b: 0.8359086853258397d, c: 0.03710705762235689d),

new NpgsqlTypes.NpgsqlLine(a: 0.7901481904203056d, b: 0.20849757007072567d, c: 0.035036268829495176d),

new NpgsqlTypes.NpgsqlLine(a: 0.584082974153761d, b: 0.848172804038757d, c: 0.38077958993849015d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2745564645004138d, b: 0.7661446190854423d, c: 0.18143601190271896d),

new NpgsqlTypes.NpgsqlLine(a: 0.6554634595113825d, b: 0.4059083546032709d, c: 0.2601809658234403d),

new NpgsqlTypes.NpgsqlLine(a: 0.5475684698840714d, b: 0.7584224286363398d, c: 0.9879537376971784d),

new NpgsqlTypes.NpgsqlLine(a: 0.6610638769408436d, b: 0.20285305115867935d, c: 0.18312614049870424d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04627098541169139d, b: 0.36627701551815905d, c: 0.30922629667311075d),

new NpgsqlTypes.NpgsqlLine(a: 0.4776659266538519d, b: 0.6129168945796015d, c: 0.4552227775862654d),

new NpgsqlTypes.NpgsqlLine(a: 0.7727004499572184d, b: 0.3753205556571936d, c: 0.37090900302210617d),

new NpgsqlTypes.NpgsqlLine(a: 0.5859617652257235d, b: 0.659468308165282d, c: 0.9759654858468892d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8422538154810109d, b: 0.07219046970000742d, c: 0.008917589770061962d),

new NpgsqlTypes.NpgsqlLine(a: 0.5129986795367015d, b: 0.8345059570623574d, c: 0.1556959088761708d),

new NpgsqlTypes.NpgsqlLine(a: 0.20342717986824455d, b: 0.7597890598266089d, c: 0.509590241694258d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9444235530737145d, b: 0.96274420332081d, c: 0.3774477743785506d),

new NpgsqlTypes.NpgsqlLine(a: 0.6125525068032319d, b: 0.6343643483907762d, c: 0.030361120218123316d),

new NpgsqlTypes.NpgsqlLine(a: 0.04844337806159804d, b: 0.9051766378491165d, c: 0.1030921420919867d),

new NpgsqlTypes.NpgsqlLine(a: 0.4724169477119683d, b: 0.40062434377222d, c: 0.12715143012164376d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7863786121852739d, b: 0.03770382977450004d, c: 0.3202784997585476d),

new NpgsqlTypes.NpgsqlLine(a: 0.3843545295327361d, b: 0.951697069856911d, c: 0.8396079093384868d),

new NpgsqlTypes.NpgsqlLine(a: 0.7158514708065713d, b: 0.9461487717976043d, c: 0.6086622427430121d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6942447027444593d, b: 0.27281209278392526d, c: 0.0075622105620534175d),

new NpgsqlTypes.NpgsqlLine(a: 0.7240489970661063d, b: 0.8072442612492804d, c: 0.6050707419892973d),

new NpgsqlTypes.NpgsqlLine(a: 0.0689509919707878d, b: 0.3413534845579391d, c: 0.09287435187696746d),

new NpgsqlTypes.NpgsqlLine(a: 0.35303032043939486d, b: 0.4090023694826951d, c: 0.610274948093171d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32012409036839273d, b: 0.8144475549233335d, c: 0.5487062286076615d),

new NpgsqlTypes.NpgsqlLine(a: 0.771763548941786d, b: 0.4170752006013062d, c: 0.5209699082826124d),

new NpgsqlTypes.NpgsqlLine(a: 0.933015531410739d, b: 0.7461942691998172d, c: 0.32345592024617886d),

new NpgsqlTypes.NpgsqlLine(a: 0.5858904176417217d, b: 0.01581858073538589d, c: 0.6815626603538015d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10348212631596765d, b: 0.00346493974151707d, c: 0.6294586227541433d),

new NpgsqlTypes.NpgsqlLine(a: 0.3291871488511957d, b: 0.0028143768873746255d, c: 0.48299762020460624d),

new NpgsqlTypes.NpgsqlLine(a: 0.7512876866456952d, b: 0.11319980100738702d, c: 0.6233730570224985d),

new NpgsqlTypes.NpgsqlLine(a: 0.8580954500928529d, b: 0.024144194196686675d, c: 0.8061812696964881d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8309875271418447d, b: 0.19893324524097378d, c: 0.6885925932148459d),

new NpgsqlTypes.NpgsqlLine(a: 0.7163705382858413d, b: 0.5617246540548336d, c: 0.5271329818503091d),

new NpgsqlTypes.NpgsqlLine(a: 0.9794839378658289d, b: 0.5740969608719583d, c: 0.1681069753964205d),

new NpgsqlTypes.NpgsqlLine(a: 0.4363832460652928d, b: 0.1884681952273357d, c: 0.7447435415558928d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7394269164437759d, b: 0.3457324942634381d, c: 0.1405266380715099d),

new NpgsqlTypes.NpgsqlLine(a: 0.752947617979903d, b: 0.8872996432873677d, c: 0.5460012300775718d),

new NpgsqlTypes.NpgsqlLine(a: 0.5331613663464468d, b: 0.7861839328640153d, c: 0.3022853489550915d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6770388957674665d, b: 0.17665097984345257d, c: 0.6881166473612884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4728683858314501d, b: 0.4747761721767275d, c: 0.368457252144229d),

new NpgsqlTypes.NpgsqlLine(a: 0.5175316602631289d, b: 0.2332257912153699d, c: 0.5976784494487711d),

new NpgsqlTypes.NpgsqlLine(a: 0.7398205595702894d, b: 0.3840745385161358d, c: 0.12846554976072933d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1457726101283856d, b: 0.5550678387932806d, c: 0.774196565039489d),

new NpgsqlTypes.NpgsqlLine(a: 0.6083331430462381d, b: 0.577439732624428d, c: 0.7711398469003381d),

new NpgsqlTypes.NpgsqlLine(a: 0.7698867657322139d, b: 0.08897679806664638d, c: 0.47637842738135794d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.09288771961983078d, b: 0.36834861891217385d, c: 0.08593891888922389d),

new NpgsqlTypes.NpgsqlLine(a: 0.3113160122058719d, b: 0.8154640499865887d, c: 0.22185965612955716d),

new NpgsqlTypes.NpgsqlLine(a: 0.7747638273244619d, b: 0.8849579494533132d, c: 0.6052618214392192d),

new NpgsqlTypes.NpgsqlLine(a: 0.6129344620973509d, b: 0.5456387677679156d, c: 0.6734822236412347d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22940932018786953d, b: 0.7137071508770529d, c: 0.3915630361930429d),

new NpgsqlTypes.NpgsqlLine(a: 0.2752172645230806d, b: 0.15375954930636837d, c: 0.8054188656461816d),

new NpgsqlTypes.NpgsqlLine(a: 0.2799737496731568d, b: 0.9912196895634192d, c: 0.5411096491192671d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8474156067170919d, b: 0.025417744017691812d, c: 0.6521952964495944d),

new NpgsqlTypes.NpgsqlLine(a: 0.6474357327855691d, b: 0.5096047941966797d, c: 0.9834654986746714d),

new NpgsqlTypes.NpgsqlLine(a: 0.5439068100005735d, b: 0.04213381836846719d, c: 0.7134835578297636d),

new NpgsqlTypes.NpgsqlLine(a: 0.6500555202305496d, b: 0.2316883052985118d, c: 0.49837968159780033d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9562366767266803d, b: 0.1492934634191102d, c: 0.9424341620608885d),

new NpgsqlTypes.NpgsqlLine(a: 0.47221415373549325d, b: 0.17916599433794733d, c: 0.1753909344495983d),

new NpgsqlTypes.NpgsqlLine(a: 0.06352001133654517d, b: 0.061667867015427036d, c: 0.21536141804567555d),

new NpgsqlTypes.NpgsqlLine(a: 0.28100714559254525d, b: 0.2060513460246619d, c: 0.30918993456233457d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.09609873116527612d, b: 0.6856405199646006d, c: 0.4463218867640042d),

new NpgsqlTypes.NpgsqlLine(a: 0.31651841665211855d, b: 0.19531200740418753d, c: 0.5928770073082912d),

new NpgsqlTypes.NpgsqlLine(a: 0.7305179175959738d, b: 0.7232410911441921d, c: 0.4827639316946625d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4230805308141755d, b: 0.8845269818866858d, c: 0.05428813620895889d),

new NpgsqlTypes.NpgsqlLine(a: 0.697287760851115d, b: 0.06322564057038338d, c: 0.8775534371118566d),

new NpgsqlTypes.NpgsqlLine(a: 0.4144164466171607d, b: 0.36177480035582077d, c: 0.34904736661623703d),

new NpgsqlTypes.NpgsqlLine(a: 0.2780031279435248d, b: 0.126772637240525d, c: 0.4479990099537272d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11549790438778995d, b: 0.33332186566744004d, c: 0.8160739410594076d),

new NpgsqlTypes.NpgsqlLine(a: 0.5214896639142936d, b: 0.6705971323661758d, c: 0.444041578316297d),

new NpgsqlTypes.NpgsqlLine(a: 0.043279579892165354d, b: 0.33593611895482833d, c: 0.18385042209147906d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.41247097255747867d, b: 0.23904979430732032d, c: 0.968936675127977d),

new NpgsqlTypes.NpgsqlLine(a: 0.7739866494582406d, b: 0.05149488862610774d, c: 0.25481087783886314d),

new NpgsqlTypes.NpgsqlLine(a: 0.2962139882547835d, b: 0.3521998006559902d, c: 0.04813233388953786d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.569100393705877d, b: 0.6404016869158594d, c: 0.17451449527236917d),

new NpgsqlTypes.NpgsqlLine(a: 0.012936070994619908d, b: 0.22437115049501177d, c: 0.1136201062309452d),

new NpgsqlTypes.NpgsqlLine(a: 0.35084857960962623d, b: 0.4424915851930129d, c: 0.0685190291723129d),

new NpgsqlTypes.NpgsqlLine(a: 0.7160603440008472d, b: 0.6371714088043744d, c: 0.5905345407158992d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.09624475201955562d, b: 0.3537978880766327d, c: 0.052695684832879675d),

new NpgsqlTypes.NpgsqlLine(a: 0.07625969628906237d, b: 0.42990771067840694d, c: 0.04768605222392197d),

new NpgsqlTypes.NpgsqlLine(a: 0.12620096212443732d, b: 0.09080557941993461d, c: 0.31542506525124714d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6302647394290337d, b: 0.5881076976474835d, c: 0.4081858210883865d),

new NpgsqlTypes.NpgsqlLine(a: 0.5131418985054296d, b: 0.11459835328568135d, c: 0.306079662759948d),

new NpgsqlTypes.NpgsqlLine(a: 0.275802195520494d, b: 0.9926111003243562d, c: 0.8906455800660696d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5001424491852222d, b: 0.7998652970556802d, c: 0.3101749096678317d),

new NpgsqlTypes.NpgsqlLine(a: 0.4754011805999028d, b: 0.2098486596178477d, c: 0.23359632191788238d),

new NpgsqlTypes.NpgsqlLine(a: 0.3522487274004352d, b: 0.7799842787790824d, c: 0.3392408383765996d),

new NpgsqlTypes.NpgsqlLine(a: 0.06716638727915858d, b: 0.13781283278643996d, c: 0.8130734442866586d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22279527224865103d, b: 0.15520016982291296d, c: 0.39761940543408947d),

new NpgsqlTypes.NpgsqlLine(a: 0.5587719247549204d, b: 0.20560809719254136d, c: 0.04749534763809948d),

new NpgsqlTypes.NpgsqlLine(a: 0.5891018476686216d, b: 0.39240968610276694d, c: 0.8262150154354918d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.487419589968926d, b: 0.661928253644621d, c: 0.6115596825808859d),

new NpgsqlTypes.NpgsqlLine(a: 0.2429995083466936d, b: 0.7510884966512716d, c: 0.154629205736332d),

new NpgsqlTypes.NpgsqlLine(a: 0.8025980423816841d, b: 0.6889723805790602d, c: 0.5651900513383376d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3180109329952613d, b: 0.04111495435320145d, c: 0.6380044799107185d),

new NpgsqlTypes.NpgsqlLine(a: 0.748873516026867d, b: 0.8761131700447157d, c: 0.6349067797474606d),

new NpgsqlTypes.NpgsqlLine(a: 0.31763920078916197d, b: 0.7598034594871843d, c: 0.8158248490309818d),

new NpgsqlTypes.NpgsqlLine(a: 0.3460012977988628d, b: 0.02811496991089535d, c: 0.03213902966687432d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6131427244319209d, b: 0.039292950876193555d, c: 0.03572593038367278d),

new NpgsqlTypes.NpgsqlLine(a: 0.6768879099766533d, b: 0.3646438376238229d, c: 0.49219314726244523d),

new NpgsqlTypes.NpgsqlLine(a: 0.26285461585273917d, b: 0.14692762045283092d, c: 0.5339302156287574d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6084969946214212d, b: 0.1092865568233371d, c: 0.007023485782160499d),

new NpgsqlTypes.NpgsqlLine(a: 0.24802744406977373d, b: 0.03745301137719159d, c: 0.5788582968217957d),

new NpgsqlTypes.NpgsqlLine(a: 0.1467121994011693d, b: 0.2863815398564401d, c: 0.8864473761799768d),

new NpgsqlTypes.NpgsqlLine(a: 0.31753087721586315d, b: 0.8751708849464247d, c: 0.2639214180783922d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                List<NpgsqlLinelineArray2M> models = null;

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray2M> models = null;

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 84;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 14;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 75;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[30],_testData[34], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 98, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 42, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 114, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 55, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 15, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 10, query1, 114, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 13, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 106, query1, 31, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 69, 145))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 91, 31))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 145);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[33], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[29], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[30], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[31], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[32], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[33], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[34], false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
FROM public.binary_npgsqllinelinearray2m m
LEFT JOIN public.binary_npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlLineListlineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

