

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
    internal partial interface INpgsqlCircleListcircleListD1
    {
    }
    
    internal partial class NpgsqlCircleListcircleListD1 : INpgsqlCircleListcircleListD1
    {


#region TestData

        private readonly NpgsqlCirclecircleListD1E2M[] _testData = new NpgsqlCirclecircleListD1E2M[]
        {
            new NpgsqlCirclecircleListD1E2M
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8441086619938933d, y: 0.6899585233374023d), radius: 0.428892305385279d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.507680579161543d, y: 0.6709101275788566d), radius: 0.5418520241457888d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8748656788774108d, y: 0.43287710646200306d), radius: 0.8667024736410963d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7808776292257146d, y: 0.718220268874192d), radius: 0.043935936994839d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39719776929866835d, y: 0.43848229234915315d), radius: 0.9297430075644896d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08602653022783768d, y: 0.10686613941428569d), radius: 0.19187671461597533d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28669112253103446d, y: 0.15988421931783126d), radius: 0.1766841185509913d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0377832042891425d, y: 0.14928751963006248d), radius: 0.7892739551942944d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5798703556633579d, y: 0.3808170038774972d), radius: 0.8966942044402697d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11154918149799975d, y: 0.41684933284995185d), radius: 0.5973489235799717d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962499075195427d, y: 0.12478662527206463d), radius: 0.4424497710775298d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2647083655749789d, y: 0.2683530418115847d), radius: 0.4074216331037481d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9743333084852017d, y: 0.6896089485652068d), radius: 0.5227976655807236d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12317074278714357d, y: 0.8568834777682102d), radius: 0.5263588575330483d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5409727287480033d, y: 0.09129029433940494d), radius: 0.4871740666598442d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30687575608890705d, y: 0.87747317135982d), radius: 0.1247623385752532d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6952202455955201d, y: 0.8380367572780869d), radius: 0.755234840778857d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9473360110587203d, y: 0.4928126678951845d), radius: 0.5667921477989903d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6608121686970686d, y: 0.5788844640423664d), radius: 0.29218098144181415d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5823700590591874d, y: 0.3206756303605025d), radius: 0.761489369027331d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4064507036618662d, y: 0.5790729634455202d), radius: 0.06625324870333271d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.724827148401958d, y: 0.9767068843009248d), radius: 0.716558706283641d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2056558260716571d, y: 0.42489609786808347d), radius: 0.5620679754017958d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5383175147816146d, y: 0.8009919167982452d), radius: 0.4710847334596012d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7975073718690415d, y: 0.3982278520405458d), radius: 0.7760752442659135d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9669867192794502d, y: 0.2611153831783649d), radius: 0.9126436031485976d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6930858072718963d, y: 0.484710431182119d), radius: 0.7734165413052043d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13631888238001855d, y: 0.4434856548194266d), radius: 0.8845203447074469d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7512634549428878d, y: 0.6116078766828609d), radius: 0.24806469506628237d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.68220732739098d, y: 0.061592630873953724d), radius: 0.969584887973925d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8264950188934435d, y: 0.9921180645620321d), radius: 0.1376739879588217d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5094203834871134d, y: 0.6938916799711959d), radius: 0.22553523164634348d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2129329056109458d, y: 0.5080706208128565d), radius: 0.6372988770484285d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5264854217963898d, y: 0.6699695855837119d), radius: 0.5184431257868938d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7538283609075629d, y: 0.05069224035732045d), radius: 0.019601038116325076d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9721035341385192d, y: 0.9438904819973879d), radius: 0.11058704928889806d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.866988974403608d, y: 0.30782371908778217d), radius: 0.001334421384010076d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28457251237738246d, y: 0.5213222640275531d), radius: 0.3039913496128215d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.797448819347691d, y: 0.602339355828354d), radius: 0.6206886922622695d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.504511059436961d, y: 0.12725379360597577d), radius: 0.016980435453705867d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2915984633886448d, y: 0.033453768502921366d), radius: 0.6022510606566007d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9069308414222317d, y: 0.25646878953499574d), radius: 0.6677560793648967d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45775880783578093d, y: 0.798262661111034d), radius: 0.9075136330415282d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9593071460159996d, y: 0.12879427875739546d), radius: 0.26536658931548973d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23431006383087105d, y: 0.7534812187867099d), radius: 0.6769108877300845d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47610000263745533d, y: 0.07649554462340868d), radius: 0.3434820972904653d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16057855448985148d, y: 0.3270601865736158d), radius: 0.9478211223908585d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6616749516840023d, y: 0.1357151236335452d), radius: 0.43391022182165495d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7521167880006863d, y: 0.7974186532962377d), radius: 0.14453218734932438d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.006180899770154125d, y: 0.5599351463995093d), radius: 0.6844151569887638d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47915427501049435d, y: 0.44499860447695383d), radius: 0.2960076995790929d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2581460534055108d, y: 0.7303008460767979d), radius: 0.4645479324151002d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1863309286402851d, y: 0.1049889925495302d), radius: 0.8840845219016039d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8106074919220726d, y: 0.13337036449552808d), radius: 0.4033636324351997d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6476007105656263d, y: 0.09683148378917217d), radius: 0.73936068448994d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7012093656760415d, y: 0.833761694136182d), radius: 0.6148329770254175d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44017525064492025d, y: 0.8129173804062361d), radius: 0.639440495411707d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3121511842114434d, y: 0.5278870230683361d), radius: 0.5827334938989932d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36283295856225783d, y: 0.35169638128665726d), radius: 0.9900737905441013d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23586854203119856d, y: 0.9313720247751872d), radius: 0.08661009582672285d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3044689146215025d, y: 0.4753168276435549d), radius: 0.9644789751492387d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03466560910953076d, y: 0.011323122418492315d), radius: 0.2078307281794417d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6423817019943152d, y: 0.09359576272975378d), radius: 0.3921105996842764d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11058768337464975d, y: 0.6706148118349716d), radius: 0.32564416827374854d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44574961646558997d, y: 0.41046051606456846d), radius: 0.4805458415618249d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5368002701988785d, y: 0.5467391645366366d), radius: 0.890668888699227d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07431322865583467d, y: 0.5480545740233291d), radius: 0.598161027397486d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39267567344811216d, y: 0.5054186728571037d), radius: 0.43209024346178515d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5427903581220808d, y: 0.036926339249544804d), radius: 0.5015275224208117d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1491455045729786d, y: 0.3652180697493387d), radius: 0.6551241652264358d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6512044813892457d, y: 0.2723570424636169d), radius: 0.3236582055338899d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3198017713984127d, y: 0.6802803158240345d), radius: 0.9896901642253046d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2768751589948554d, y: 0.4621578201447739d), radius: 0.9772536331792842d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007778965130796789d, y: 0.7868578907176843d), radius: 0.6658306505529784d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5590082385906997d, y: 0.639945777275298d), radius: 0.8546735247469365d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8113899632705154d, y: 0.41429213376944163d), radius: 0.49560530722344087d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18901533049592667d, y: 0.9376455314124204d), radius: 0.7465191337469979d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4526566312252108d, y: 0.1850071737182385d), radius: 0.44371102882431546d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46242184184894497d, y: 0.023561136471398347d), radius: 0.33786397004368285d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5003161749407092d, y: 0.22369071438840893d), radius: 0.2692878898515163d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7081024938734263d, y: 0.0996763807037907d), radius: 0.0034384041688783062d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25660909213684424d, y: 0.4850327899715767d), radius: 0.3751808650890831d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0819874289960405d, y: 0.2852075891265171d), radius: 0.11779901527122516d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.704265640879542d, y: 0.2411046997088151d), radius: 0.37665135922095927d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13365748430364133d, y: 0.1567351078101954d), radius: 0.4110710910612019d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8664801805600179d, y: 0.587770295077504d), radius: 0.8755728874841322d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46309255200253163d, y: 0.7271148589203799d), radius: 0.6474481657488401d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6276770414934069d, y: 0.11606913944210695d), radius: 0.5075252410710911d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7151627228843318d, y: 0.8011626568978172d), radius: 0.683489847340087d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9238530910360965d, y: 0.26529318031488147d), radius: 0.47975759168911214d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7230787617881683d, y: 0.3785163889511276d), radius: 0.7330507917538778d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9194044049330492d, y: 0.8024888505438422d), radius: 0.33556326780668466d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35995690792001067d, y: 0.5753425554685954d), radius: 0.5296948810757027d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7969533777704919d, y: 0.9868303517439901d), radius: 0.23904403201297064d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6419636732454831d, y: 0.10308693272346403d), radius: 0.5455386068785146d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48174783430042223d, y: 0.1886353086570196d), radius: 0.19439506116555028d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6893144504596097d, y: 0.16161936426781442d), radius: 0.22045150356818277d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6104932868591453d, y: 0.02257832977374341d), radius: 0.907410292843554d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7097030219009435d, y: 0.09944244719823647d), radius: 0.615838660795028d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2993413856555912d, y: 0.35078998773804226d), radius: 0.05750656970060797d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0003005021196808011d, y: 0.6593604925398261d), radius: 0.3311115780284044d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.617416459653745d, y: 0.30762752828793305d), radius: 0.5345313659789708d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8965683224641264d, y: 0.9676230306441529d), radius: 0.06529319107037812d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7967136760926942d, y: 0.06683300053247765d), radius: 0.8904854038396821d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37551152602659654d, y: 0.2334402834171524d), radius: 0.19734050158653493d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7334715461111413d, y: 0.10208756172316624d), radius: 0.8723093672028028d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23912192073966643d, y: 0.6402807920231528d), radius: 0.5030958812945046d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2877313235605605d, y: 0.8984512885806751d), radius: 0.5104225334381963d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4693578997132418d, y: 0.5878530260613827d), radius: 0.3492560796975438d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5908349016805975d, y: 0.4109550990632378d), radius: 0.08869436851414192d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8545443565487618d, y: 0.6478988866431296d), radius: 0.3970517654580472d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13580243888369392d, y: 0.8161634301550106d), radius: 0.18453953444037774d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7796623581514218d, y: 0.9486001468749597d), radius: 0.2415183426928944d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2581553696211758d, y: 0.3984920244012803d), radius: 0.8903434950090644d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8146261434966335d, y: 0.0035283994609469627d), radius: 0.5933925364823843d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07624260861391952d, y: 0.6485929835351436d), radius: 0.8390986586436268d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02901416231765863d, y: 0.7848900522015188d), radius: 0.9208667317557848d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4939493920056226d, y: 0.29382167332932907d), radius: 0.20316191603749456d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33280717747872324d, y: 0.585623901062821d), radius: 0.01988869745754207d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8797926280858968d, y: 0.3233247129017768d), radius: 0.027841795060656427d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9029467786590015d, y: 0.043410084407776606d), radius: 0.7274291708381003d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4451802095642483d, y: 0.34655666970342003d), radius: 0.44647818720376464d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3680530824411651d, y: 0.8995539538900604d), radius: 0.877244088198905d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11172092988939497d, y: 0.07110918665790644d), radius: 0.4062592939997013d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.457299212290864d, y: 0.3837420463530975d), radius: 0.9762611048552212d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24559082304665902d, y: 0.646760729437957d), radius: 0.9348216579726125d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7815709075790095d, y: 0.7611137563531277d), radius: 0.6629931609961126d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18002765568987278d, y: 0.9138217701491125d), radius: 0.4840240165385655d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6470835299243622d, y: 0.3628326582056114d), radius: 0.5767735819233765d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8447525520095771d, y: 0.8839299397618787d), radius: 0.6493282185487164d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19435683563821526d, y: 0.9368620291341425d), radius: 0.7484369124398593d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8279711621015866d, y: 0.5820953993092182d), radius: 0.9452366985947884d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7789001841822206d, y: 0.37401534896376076d), radius: 0.4481495963006654d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6262880837869363d, y: 0.9573962547579095d), radius: 0.4760944388151187d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9215038364715641d, y: 0.24648898094592397d), radius: 0.5295464186425124d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14748586530015628d, y: 0.8365063176318478d), radius: 0.8264291276076046d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2349779729060355d, y: 0.3135532241811986d), radius: 0.7081963964398473d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5756163426597406d, y: 0.8114708216335071d), radius: 0.5640560298464674d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7520964689851243d, y: 0.27780431787055593d), radius: 0.40803143417194065d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08621000735555395d, y: 0.0696215642558431d), radius: 0.8447094941060815d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6639764888152646d, y: 0.9925969432890958d), radius: 0.3470406689267599d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7487595002308924d, y: 0.49108473634571215d), radius: 0.43706880912671164d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4335161479234009d, y: 0.38184506083491343d), radius: 0.8870185777766625d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18465980613705524d, y: 0.5014278754851944d), radius: 0.7995485426173098d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2977015582204854d, y: 0.39625597829033765d), radius: 0.8705426779421458d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22516233695810872d, y: 0.17380841891792842d), radius: 0.0291932811454938d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9239050907944522d, y: 0.7012310585150529d), radius: 0.40312305342172805d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9866087909829144d, y: 0.14637980456029964d), radius: 0.5127578563652461d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5010367163414546d, y: 0.7318614110287802d), radius: 0.2696331023898224d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42723199218941876d, y: 0.5607307716930531d), radius: 0.11747200834713523d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8980566421793144d, y: 0.2986394145621679d), radius: 0.41603186407962667d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6597216751126304d, y: 0.17586841725816005d), radius: 0.6495054443697408d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15798137094934694d, y: 0.7414806745503942d), radius: 0.212487782646972d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39596219654377696d, y: 0.9139658283141553d), radius: 0.7969440508398534d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9711355221349215d, y: 0.9206988041479786d), radius: 0.6730800364730687d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33345614289393377d, y: 0.6001644380998951d), radius: 0.7403480395806485d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17592827561949476d, y: 0.6107374820262303d), radius: 0.4225318160756951d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04362298548459598d, y: 0.5956499284612602d), radius: 0.8770288303608754d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14498356086584718d, y: 0.6243369088997544d), radius: 0.5202584288777199d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6182008417113397d, y: 0.5199341568346465d), radius: 0.17951130656283676d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08940438626945002d, y: 0.08907785756236863d), radius: 0.3205779524583867d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1488914583654778d, y: 0.15816974155952268d), radius: 0.917590008870969d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16638302367155744d, y: 0.38086344578668396d), radius: 0.6309062149871734d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9191485397828709d, y: 0.5769136246223878d), radius: 0.6717867870145953d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3752246352199736d, y: 0.020339556667392067d), radius: 0.03310852836776712d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9904111665621359d, y: 0.5775849521340831d), radius: 0.9777766175650023d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.050590477504005915d, y: 0.6338172808094978d), radius: 0.029745995268050107d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43993775766994303d, y: 0.5623321251851447d), radius: 0.2420907313069829d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30139788986528093d, y: 0.2912081903833862d), radius: 0.19703865469230852d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28741334900431426d, y: 0.7632889709888948d), radius: 0.9974447262488652d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.039673033126061186d, y: 0.07879493802110848d), radius: 0.781008303837016d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3896012645758852d, y: 0.3714072124655705d), radius: 0.9145054813732643d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09741203936602483d, y: 0.22123271999135752d), radius: 0.6456146239567856d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44034616225058776d, y: 0.49633117567242535d), radius: 0.47681326853949935d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5193091802700506d, y: 0.25569665587517265d), radius: 0.20630102444655452d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.046094003060586974d, y: 0.5393289984162125d), radius: 0.8688092475004559d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.014795524002623406d, y: 0.11989359795020393d), radius: 0.24596901461275622d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20162022834940174d, y: 0.9215608654665957d), radius: 0.2562794537358477d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.038759638229373006d, y: 0.0013386737219934775d), radius: 0.965707146723952d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7345918104059301d, y: 0.9116269855579593d), radius: 0.1883562766447192d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1732236174002042d, y: 0.6893468190203625d), radius: 0.4991371389866799d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6847301765958653d, y: 0.8576028150636749d), radius: 0.4290414988107589d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6833994559523531d, y: 0.8833749956767825d), radius: 0.693737671615217d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6069327372182334d, y: 0.1333521671331086d), radius: 0.6115711909322326d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.205378928479503d, y: 0.204440630090585d), radius: 0.11166519579842782d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21766855466838397d, y: 0.6231042627723287d), radius: 0.39091955297857417d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8727405308762053d, y: 0.3785019090464513d), radius: 0.6710467402165285d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5050229461645633d, y: 0.5742236438779942d), radius: 0.6674687721247138d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4080970128717114d, y: 0.6533882875363851d), radius: 0.6042457912028446d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6478005053851942d, y: 0.6628240748736504d), radius: 0.43690607593812025d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04870239610341576d, y: 0.9563400314512527d), radius: 0.1197614731574187d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09368190328374104d, y: 0.6123430244888506d), radius: 0.40572458057602767d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09893726463363972d, y: 0.365018306332039d), radius: 0.1403967217387737d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.094916806476397d, y: 0.08579371555551896d), radius: 0.18462152627185946d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8327825988490254d, y: 0.27971078202918054d), radius: 0.15347465851554587d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6803545228586855d, y: 0.5473018517605285d), radius: 0.7090663206864111d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35931238128075293d, y: 0.18529829881577042d), radius: 0.4509198871508894d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5744420764090735d, y: 0.8141326817453876d), radius: 0.1912333858292169d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6356420374769939d, y: 0.731827358163906d), radius: 0.7796316298929197d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6525198460939304d, y: 0.22769613010807854d), radius: 0.9408121052766639d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3013462560377973d, y: 0.1186149727253557d), radius: 0.33721494597802304d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7961579578213404d, y: 0.06644523185106954d), radius: 0.8967333800744699d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9896159447321935d, y: 0.750842951495395d), radius: 0.42211050422043095d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22545085482418203d, y: 0.6202004516445939d), radius: 0.7897127122181027d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4704507187194146d, y: 0.9570963346185755d), radius: 0.7168157005392929d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.009713704346599794d, y: 0.6805378145565444d), radius: 0.3122203298433984d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28967250138987655d, y: 0.18909752155667048d), radius: 0.0804496280608169d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.893225779449858d, y: 0.3935885180289579d), radius: 0.33559379677881884d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3105372801121806d, y: 0.47295106639679607d), radius: 0.14157357512383162d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9234721258592522d, y: 0.5781420733625771d), radius: 0.7384922565840789d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33872027505804747d, y: 0.3138255545278855d), radius: 0.0010527690411923363d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5832600308999915d, y: 0.6012322463980013d), radius: 0.8361760641720078d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8065555958166354d, y: 0.08646219076185979d), radius: 0.5613937066418637d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3146811151432105d, y: 0.7913338034134568d), radius: 0.04547487362348568d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5723489494184867d, y: 0.9390072323127238d), radius: 0.661011514261253d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9414011942997174d, y: 0.3571465736670467d), radius: 0.45980405896157495d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39074991079982946d, y: 0.8393218536021693d), radius: 0.8040168638067694d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5376357609577911d, y: 0.7393216560766654d), radius: 0.9289252315587823d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23498044477174262d, y: 0.38822383251837966d), radius: 0.012375701559724228d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4440327413652897d, y: 0.7354754589645125d), radius: 0.619815370996726d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14215361073968935d, y: 0.09831097768828201d), radius: 0.4574970464483239d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8704392257717322d, y: 0.7375340734871887d), radius: 0.019448486771426632d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7552459183852276d, y: 0.9122135451874025d), radius: 0.3492954735240409d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9435562062832036d, y: 0.9831624575294557d), radius: 0.8623809169149717d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4172636764881623d, y: 0.4106316989362392d), radius: 0.6610613300810745d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7647818320672817d, y: 0.5083956491082892d), radius: 0.42803207914449903d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42679004966068146d, y: 0.2556343191800712d), radius: 0.3490948763181605d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33692801909302295d, y: 0.2477382143369491d), radius: 0.9917231956773054d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3580480495956675d, y: 0.7951137918606953d), radius: 0.34261311157641905d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6850015482219237d, y: 0.3410460318362578d), radius: 0.9425103523085491d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.954865460638017d, y: 0.20405055517788295d), radius: 0.6913044488145771d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4510421702689128d, y: 0.17218171162767126d), radius: 0.5815786092789007d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6907784660437147d, y: 0.19329628901530793d), radius: 0.973496065391895d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0928933228507054d, y: 0.2764162249183374d), radius: 0.66094272893884d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1349812241700079d, y: 0.3554825930722173d), radius: 0.23134386183954747d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.005300430144893564d, y: 0.7233383751051824d), radius: 0.6511521971297799d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5477568105096802d, y: 0.11167834751936934d), radius: 0.029402661498030502d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6593986915220863d, y: 0.37514608032500985d), radius: 0.1999649473432995d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5994364237883133d, y: 0.7653691750585502d), radius: 0.578351242727147d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13636230329835686d, y: 0.5941744916370145d), radius: 0.9220181244796628d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08470851897749676d, y: 0.6435715252783616d), radius: 0.5341165473118374d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3382624295453551d, y: 0.24719820168895656d), radius: 0.2118971677668362d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.029101400815414458d, y: 0.5706279034762918d), radius: 0.28803657061885946d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8651895395229089d, y: 0.5785147134837774d), radius: 0.04687858723140481d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00680974755411301d, y: 0.4075403483215472d), radius: 0.5754778134855338d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9734721861425973d, y: 0.21804171748954804d), radius: 0.6081095788473035d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6297634381646158d, y: 0.48739022842748414d), radius: 0.6786770934180396d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7539932835199125d, y: 0.2642088577353384d), radius: 0.5761778212710607d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7997816817957132d, y: 0.41862667890274075d), radius: 0.880371469157275d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7920347363565016d, y: 0.18396980647657157d), radius: 0.40692803749461914d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2791182405821604d, y: 0.028860293295590034d), radius: 0.7439578315830037d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3222110250907638d, y: 0.6491478614711813d), radius: 0.37153377172905744d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8997594512226166d, y: 0.045499409489675346d), radius: 0.5988398553876029d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44383302670941427d, y: 0.5066636023427469d), radius: 0.12350267056058395d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40908110398683506d, y: 0.15605932180779059d), radius: 0.04671557355796241d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11041578849826084d, y: 0.0254087686461667d), radius: 0.5558872610398358d),

},
    ModelInner = new NpgsqlCirclecircleListD12MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7211236069948227d, y: 0.4594899878023234d), radius: 0.7548111034094889d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11435317466013917d, y: 0.5121376810467778d), radius: 0.594934753477435d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7742279778571776d, y: 0.6705593519270393d), radius: 0.9440750870833985d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.033588187489905774d, y: 0.4202087472188255d), radius: 0.5848802752005273d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8728696038191738d, y: 0.9066431871574505d), radius: 0.047986185482329136d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40367093308470003d, y: 0.049845945072356956d), radius: 0.7850115889614573d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.188727601118735d, y: 0.8592041549731935d), radius: 0.5709892881678162d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.596464512334393d, y: 0.769000796411907d), radius: 0.027148930966731877d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9751282764506282d, y: 0.19231574363271575d), radius: 0.054215115535040104d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7423631913355362d, y: 0.9966963673205365d), radius: 0.6938729247544793d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.669088190002678d, y: 0.13313775793862903d), radius: 0.5098868679353775d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6305284417144588d, y: 0.7074258562630024d), radius: 0.5633723230430142d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5641322364751109d, y: 0.018582754034623505d), radius: 0.43477734891546804d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06373982966784153d, y: 0.5501916513550059d), radius: 0.7188898835787941d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13537544347432062d, y: 0.9012075660675337d), radius: 0.10947625063910005d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd12mi(
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd12mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclelistd12mi_id
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclelistd12mi_id", 
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
                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclelistd12mi_id
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
    npgsqlcirclecirclelistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclelistd12mi_id
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
    npgsqlcirclecirclelistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclelistd12mi_id", 
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
                List<NpgsqlCirclecircleListD1E2M> models = null;

                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleListD1E2M> models = null;

                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd12mi mi ON mi.id = m.npgsqlcirclecirclelistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd12mi mi ON mi.id = m.npgsqlcirclecirclelistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleListcircleListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 101;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd12mi mi ON mi.id = m.npgsqlcirclecirclelistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 72, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 25, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 138, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 122, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 153, query1, 72, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 148, query1, 5, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 148, query1, 1, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 5, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd12mi mi ON mi.id = m.npgsqlcirclecirclelistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 86, 72))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelBatch(connection, 25, 44))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleListcircleListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleListcircleListD1)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models = await ((INpgsqlCircleListcircleListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[8], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[9], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[10], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[11], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[12], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[13], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[14], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[15], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[16], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[17], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[18], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[19], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[20], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[21], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[22], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[23], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[24], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[25], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[26], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[27], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[28], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[29], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[30], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[31], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[32], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[33], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleListD1)this).SetDbConnectionSelectModelParametrs(cmd, 5);
                var models =  ((INpgsqlCircleListcircleListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[2], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[3], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[4], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[5], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[6], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[7], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[8], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[9], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[10], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[11], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[12], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[13], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[14], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[15], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[16], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[17], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[18], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[19], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[20], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[21], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[22], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[23], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[24], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[25], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[26], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[27], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[28], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[29], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[30], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[29],_testData[31], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[30],_testData[32], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[31],_testData[33], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[32],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclelistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD12MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD12MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD12MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD12MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclelistd12mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
FROM public.binary_npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.binary_npgsqlcirclecirclelistd12mi mi ON mi.id = m.npgsqlcirclecirclelistd12mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclelistd12mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models =  ((INpgsqlCircleListcircleListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD12MIWA), typeof(NpgsqlCirclecircleListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleListD12MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD12MIWA>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD12MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD12MIWA>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclelistd12mi
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
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclelistd12mi
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
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD12MIWA), typeof(NpgsqlCirclecircleListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models1 = new List<NpgsqlCirclecircleListD12MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD12MIWA>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD12MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD12MIWA>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclelistd12mi
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
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclelistd12mi
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
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclelistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD12MI), typeof(NpgsqlCirclecircleListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleListD12MI>();
                var models2 = new List<NpgsqlCirclecircleListD12MI>();
                await ((INpgsqlCircleListcircleListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD12MI>();
                var models2 = new List<NpgsqlCirclecircleListD12MI>();
                ((INpgsqlCircleListcircleListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleListcircleListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD12MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclelistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD12MIWA), typeof(NpgsqlCirclecircleListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models1 = new List<NpgsqlCirclecircleListD12MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD12MIWA>();
                await ((INpgsqlCircleListcircleListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD12MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD12MIWA>();
                ((INpgsqlCircleListcircleListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models = await ((INpgsqlCircleListcircleListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

