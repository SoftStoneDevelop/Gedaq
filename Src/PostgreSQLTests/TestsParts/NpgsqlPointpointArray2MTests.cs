

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
    internal partial interface INpgsqlPointListpointArray
    {
    }
    
    internal partial class NpgsqlPointListpointArray : INpgsqlPointListpointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray2M[] _testData = new NpgsqlPointpointArray2M[]
        {
            new NpgsqlPointpointArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6097227270561737d, y: 0.9715229065369612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4506952981628596d, y: 0.5195109632964793d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6897247731917657d, y: 0.6115274771911996d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44108047389075944d, y: 0.7619637994600921d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5096581635820937d, y: 0.7014044602900061d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5159855935271145d, y: 0.06413198122521147d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9185186483126907d, y: 0.8572091569311787d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9514466670301991d, y: 0.6257551378068145d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9721236464784772d, y: 0.2705877410681332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8112625765468416d, y: 0.5368348582846993d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6867671161786876d, y: 0.36403221882369396d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7793398597121105d, y: 0.1266959446066107d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9277843896819976d, y: 0.7848869556085275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.526160947725947d, y: 0.2151636970901486d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9538735890782689d, y: 0.06155120497583255d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0033884442097804612d, y: 0.7894882773076562d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9923702202339386d, y: 0.32484838453188536d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4570448039529287d, y: 0.7178944729890693d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3152324263438092d, y: 0.4286623972129986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4184705985198177d, y: 0.6901103400009773d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0714035749555908d, y: 0.9373171363373975d),

new NpgsqlTypes.NpgsqlPoint(x: 0.493755462730883d, y: 0.9734435981243725d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5439960428041505d, y: 0.26367563850484044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008813285258074233d, y: 0.7237458017611569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13655329355472634d, y: 0.22320890765432722d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3796593530535626d, y: 0.9403003679950961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24897260996492065d, y: 0.5860781909497471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5199315518051719d, y: 0.771790256782328d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9141191549712958d, y: 0.4545170987645434d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4266314667121297d, y: 0.3786621338354115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6143975484293607d, y: 0.052315339087952384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10871925689366613d, y: 0.6957227230309552d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5513517985274412d, y: 0.3443211317067666d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8333572847883274d, y: 0.7651286094295625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48709944446918574d, y: 0.24318921560581674d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20534226262185584d, y: 0.2093170383660765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.639047398552723d, y: 0.4709754106267299d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6324737747670295d, y: 0.5701646603685143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7955659384254602d, y: 0.8042094319889489d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4746109664038284d, y: 0.36898801850684904d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8914145410487367d, y: 0.2532143898633933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4290605535822384d, y: 0.9873616949309679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22388628951913836d, y: 0.28601844051052516d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8826736265092491d, y: 0.2417381322466997d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2665313856890894d, y: 0.9115737288594985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3325321487043462d, y: 0.7762123098923898d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9577243842936075d, y: 0.6097672901565364d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5396726024293633d, y: 0.9479202691676724d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6663425379227769d, y: 0.9643280679755731d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3429210985619079d, y: 0.6903423223598205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8762620844802216d, y: 0.02860377449059215d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.595294704602438d, y: 0.9909444283409629d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6162955499081082d, y: 0.6403443162903351d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8557461313139084d, y: 0.7510089700069099d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9509195252063342d, y: 0.4009711511565004d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45259402525269155d, y: 0.6905484630059984d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7366397300478449d, y: 0.4322427991205662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8808865745773514d, y: 0.3275083941835836d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9031814237657282d, y: 0.4521308034787844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5124930342767198d, y: 0.2269972299152515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48272893350896695d, y: 0.5674448828598241d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5487523975108268d, y: 0.10502728881306378d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7024122336879588d, y: 0.31927313729254003d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5834093886980325d, y: 0.49241497505727594d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4102225096689587d, y: 0.7567740853609235d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5852953474495098d, y: 0.2983876184878952d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21592944218402854d, y: 0.5477963730073799d),

new NpgsqlTypes.NpgsqlPoint(x: 0.014813830288098129d, y: 0.3634485002156832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42732511191921885d, y: 0.28893593848619936d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8926091666870934d, y: 0.7142468036926769d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8343775028185136d, y: 0.8651586295772259d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17796052528639605d, y: 0.7345159370761158d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6717447672892362d, y: 0.25967161044789866d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4174134423550976d, y: 0.676450601035308d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04590721812643006d, y: 0.49517511619245336d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03197011208889522d, y: 0.7042220076269012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37938460217254943d, y: 0.28915711378743447d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6066082936063286d, y: 0.5027831576995575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2785577599206318d, y: 0.1296959091487967d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7130832675708609d, y: 0.27938072035621253d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8512240492605423d, y: 0.8518323434848329d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4810363443587039d, y: 0.22564776468591308d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7957340645264691d, y: 0.21133619400189385d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4222406956864523d, y: 0.8595126645366882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.045477429833197025d, y: 0.35143587692965794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.994509292816274d, y: 0.835326687854379d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9005894524818844d, y: 0.3774533222064349d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8495545138053238d, y: 0.3913896102138086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43577212362053175d, y: 0.03376204636462887d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3341188633007206d, y: 0.8658508133306644d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4432722966632269d, y: 0.9694123260703885d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2117896891003478d, y: 0.9922059805452231d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25179967056777186d, y: 0.7215345228534035d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1523482773519924d, y: 0.9385354374704833d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5063185639152209d, y: 0.45009255675084736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5486436440988866d, y: 0.6870930463479541d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8750784428895514d, y: 0.7444411338868386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8504055704184185d, y: 0.23551870393066787d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16904549562043192d, y: 0.4352177152825387d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21161499708699671d, y: 0.8999478628084311d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8697114540098179d, y: 0.1282714409314213d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21841043421148487d, y: 0.4150193957888546d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8695753016395217d, y: 0.004401344547489305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7546286817716296d, y: 0.9376446988555576d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7508218611240564d, y: 0.7469464342227772d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4425278220069295d, y: 0.37429269187564873d),

new NpgsqlTypes.NpgsqlPoint(x: 0.020802863185652942d, y: 0.04234269437148652d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11618046907532598d, y: 0.29272373085431647d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15565423955391922d, y: 0.98483733301323d),

new NpgsqlTypes.NpgsqlPoint(x: 0.917578587677091d, y: 0.3865585955861254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6389313125726683d, y: 0.8666031067327209d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3250759909302755d, y: 0.7810850253914157d),

new NpgsqlTypes.NpgsqlPoint(x: 0.990256001461083d, y: 0.7542796879264435d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6577736958128525d, y: 0.8224783034823606d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1017452961411639d, y: 0.9421554274930187d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4413666854627819d, y: 0.6182924571722621d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8238683970216387d, y: 0.2254064516472124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.676769099931608d, y: 0.22852944436279898d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2075091969555518d, y: 0.7412374005697779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33552266736255143d, y: 0.9374880859258176d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9515477145235102d, y: 0.4675892038926167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3552650696657803d, y: 0.9019936315410237d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.742860244063706d, y: 0.4760863439087337d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30443263788791264d, y: 0.21568152645064487d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4021882771419558d, y: 0.5373759191041386d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6950341514610812d, y: 0.18431196960527774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4939474426306455d, y: 0.05263187854887885d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1904913808142129d, y: 0.8264343861359876d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7753718540608168d, y: 0.07314244685160509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7038484250359925d, y: 0.9726926841132628d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4740291970969145d, y: 0.4662940663105438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35195029125684785d, y: 0.14141750480442117d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15791250015180203d, y: 0.028917991424019296d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22795951665658665d, y: 0.9651297005676277d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6587429892552277d, y: 0.8026462410333796d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8505690539927833d, y: 0.821883594407263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9838009367342758d, y: 0.8035036144344199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7561278982765686d, y: 0.5367788119216155d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4686672771121069d, y: 0.05068870294646988d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7151520606090764d, y: 0.8286803850734237d),

new NpgsqlTypes.NpgsqlPoint(x: 0.413115865299715d, y: 0.855267558723648d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24862626075981786d, y: 0.11303404732076061d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.854158961491996d, y: 0.0990593148855563d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28442997480315657d, y: 0.9784911011535525d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6835536203438604d, y: 0.5590598821571976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33233386530556164d, y: 0.9032467488696053d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1569894142753937d, y: 0.25023841713893924d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392029054663922d, y: 0.4832157286751477d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8255922143374099d, y: 0.20432157545626362d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3738514517815542d, y: 0.29411101647819926d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8367946594051175d, y: 0.06489243820680402d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36210240624384593d, y: 0.8964872990004332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4652749717834386d, y: 0.9646442710752162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8480083669480578d, y: 0.41220891790836156d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4481886995946802d, y: 0.9127813571490375d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8298276257788973d, y: 0.05366850097257847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3339897067297146d, y: 0.08521369219561692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3267819163408895d, y: 0.8881738389676016d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.543280219864113d, y: 0.7927901924701654d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14456121362395824d, y: 0.5170924342823899d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22385106837352675d, y: 0.20806006956631462d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.34592080354976085d, y: 0.662509620796327d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21517163617539026d, y: 0.4797995187548154d),

new NpgsqlTypes.NpgsqlPoint(x: 0.737877252151725d, y: 0.4418936178466938d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17139807228868298d, y: 0.2956430395677635d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3680392057653692d, y: 0.35397583423909995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41061699272977903d, y: 0.5504073669765002d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9138712265153758d, y: 0.6725359526255449d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3817224868734036d, y: 0.14448316874811873d),

new NpgsqlTypes.NpgsqlPoint(x: 0.929611567277735d, y: 0.22780580992758004d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2935577159048227d, y: 0.657156564996577d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8665285896817319d, y: 0.04502793395623583d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5420611633282565d, y: 0.7004888069794732d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4714189105999598d, y: 0.6110026237265224d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6394760707145541d, y: 0.5848043332949108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7162023118449876d, y: 0.9263181180933919d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23502825597288368d, y: 0.5480243662787451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5436324346035495d, y: 0.4916819517831761d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.27275036943256004d, y: 0.7427348341497397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5882437048238949d, y: 0.47670470446400515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7469656274700668d, y: 0.6523110141018519d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4012361972197087d, y: 0.42771884867365884d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15948391244968918d, y: 0.8145584523665105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.017405969163810764d, y: 0.8716718775451019d),

new NpgsqlTypes.NpgsqlPoint(x: 0.017032944509529302d, y: 0.05214560426741999d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5194863243703884d, y: 0.5720585016995229d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6725005560689662d, y: 0.6796744107303253d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9616950456925499d, y: 0.38323039939675074d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39030098304443495d, y: 0.8634708672005987d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46402931603076436d, y: 0.8900799029483986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11019418064355824d, y: 0.1325005353416452d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4605378654942043d, y: 0.10807255162330087d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07997361345072851d, y: 0.6655346646058922d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19118420000996483d, y: 0.5900791707467045d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3074456493026586d, y: 0.15524853173143494d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9628304175921465d, y: 0.9874471171889692d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7775439254872422d, y: 0.1554989297879873d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47269267303857987d, y: 0.41937974416031454d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07835460306831621d, y: 0.8620353710037814d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11995329713276359d, y: 0.7059576554624859d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8927145676546734d, y: 0.8252036892321483d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8790936200614348d, y: 0.1454189234226314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9886699887044467d, y: 0.9611302401862952d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2598089968116287d, y: 0.6487031711205701d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3300233616777062d, y: 0.9847034379354919d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5223570546862621d, y: 0.37719681123596716d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36199887811285525d, y: 0.3359078933535544d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3704531025952573d, y: 0.4612698167658792d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8610920845853786d, y: 0.9190903067997079d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6670458123897136d, y: 0.1561315153076911d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4423682148332567d, y: 0.6838435829519999d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8390609897588842d, y: 0.8832038705901d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5663218775093899d, y: 0.5978319643950181d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3668617820758304d, y: 0.8055021893705232d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11310317936450454d, y: 0.5524466588000586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5774195627146208d, y: 0.7949256276140736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.544140883906109d, y: 0.6630040170203151d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9281608159263636d, y: 0.4672645732052799d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4872546867533304d, y: 0.18950491300750727d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7487777710347487d, y: 0.9171251212327839d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14011037453691255d, y: 0.599911237386734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31576493890569424d, y: 0.35943405222241d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4356784616159042d, y: 0.4056187607927205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22033130314883964d, y: 0.29712809808443175d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3483701543394978d, y: 0.024794128797575476d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1857313636871104d, y: 0.434150099316426d),

new NpgsqlTypes.NpgsqlPoint(x: 0.025736272416151285d, y: 0.08783913037440705d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7693930402485727d, y: 0.6848341618699264d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12260653328785354d, y: 0.013221505879977169d),

new NpgsqlTypes.NpgsqlPoint(x: 0.524731897032163d, y: 0.8699228065645143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04828820007319801d, y: 0.27308481339123714d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17571872053896176d, y: 0.8086363749247603d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8101708155037873d, y: 0.5137813582917021d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5089393703491577d, y: 0.8608899026315238d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08515837810682858d, y: 0.9292065462814008d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04347127954897079d, y: 0.609594976144003d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29415740104332433d, y: 0.35900097228946093d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9111422003340185d, y: 0.481735738341985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08015472578460392d, y: 0.8417587913257832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4002540251220873d, y: 0.1230407297076982d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9576560784591376d, y: 0.4337863646526784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5248384688396472d, y: 0.15944765045963694d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5372996892170492d, y: 0.27720362720328273d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7713029139239024d, y: 0.9285352246707379d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1250219751583076d, y: 0.18808446789781175d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15045014403182833d, y: 0.6150778536214119d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42115175950180483d, y: 0.784585743433298d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16777977321904314d, y: 0.6462258106960166d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6363517038156203d, y: 0.5764157097458836d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8107898203448863d, y: 0.7457938154183452d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5446250880759611d, y: 0.8430779835034142d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2718560036833687d, y: 0.4826376239708624d),

new NpgsqlTypes.NpgsqlPoint(x: 0.727121834504065d, y: 0.8305744162974388d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9042733513233019d, y: 0.7494293918738585d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5784558395853778d, y: 0.6557802050147592d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6010980590752449d, y: 0.6628457871083497d),

},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
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

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                List<NpgsqlPointpointArray2M> models = null;

                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray2M> models = null;

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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

                var models = await ((INpgsqlPointListpointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlPointListpointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPointListpointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointListpointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[29], false);
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

                var models =  ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 147, query1, 161, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 147, query1, 5, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[2], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[3], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[4], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[5], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[6], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[7], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[8], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[9], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelBatchAsync(connection, 5, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[2], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[3], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[4], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[25],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[26],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[29], false);
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
                var models =  ((INpgsqlPointListpointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSelectModelBatch(connection, 61, 133))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 159);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPointListpointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((INpgsqlPointListpointArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPointListpointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
FROM public.binary_npgsqlpointpointarray2m m
LEFT JOIN public.binary_npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray2M>(15);

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
                ((INpgsqlPointListpointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointListpointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointListpointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointListpointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

