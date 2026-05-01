

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
    internal partial interface INpgsqlPolygonSingleTypepolygon
    {
    }
    
    internal partial class NpgsqlPolygonSingleTypepolygon : INpgsqlPolygonSingleTypepolygon
    {


#region TestData

        private readonly NpgsqlPolygonpolygon0M[] _testData = new NpgsqlPolygonpolygon0M[]
        {
            new NpgsqlPolygonpolygon0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4900782895785515d, y: 0.3319339531450023d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009107027157231329d, y: 0.9219881329828955d), new NpgsqlTypes.NpgsqlPoint(x: 0.610640560390245d, y: 0.8006355635775618d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13123336145445774d, y: 0.25382092372277787d), new NpgsqlTypes.NpgsqlPoint(x: 0.28212355872154304d, y: 0.6947889828042457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7909231401474724d, y: 0.6545786926863193d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24036110838090852d, y: 0.9432784777678007d), new NpgsqlTypes.NpgsqlPoint(x: 0.40792356111470474d, y: 0.8157505297210575d), new NpgsqlTypes.NpgsqlPoint(x: 0.8988614670792355d, y: 0.5842892143438725d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9779225610804251d, y: 0.32157677543874297d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549435957492465d, y: 0.5752970241217451d), new NpgsqlTypes.NpgsqlPoint(x: 0.7889319472335905d, y: 0.865985717873796d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05607009400593932d, y: 0.0336188492504792d), new NpgsqlTypes.NpgsqlPoint(x: 0.21393831397475827d, y: 0.35068315762418534d), new NpgsqlTypes.NpgsqlPoint(x: 0.48970689752735175d, y: 0.0027041224514104956d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7720643117106678d, y: 0.6099970719895423d), new NpgsqlTypes.NpgsqlPoint(x: 0.09573007069511474d, y: 0.6948068437076397d), new NpgsqlTypes.NpgsqlPoint(x: 0.013141219006178262d, y: 0.23262963442280493d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7239116183303227d, y: 0.8606192581969938d), new NpgsqlTypes.NpgsqlPoint(x: 0.21627960287093306d, y: 0.3247479558928831d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552816112596152d, y: 0.20942023176935665d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12228612785822712d, y: 0.29335956610789515d), new NpgsqlTypes.NpgsqlPoint(x: 0.48840766912383204d, y: 0.5018375523449916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6966068256888637d, y: 0.8375377807635652d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.849187650099178d, y: 0.6934138907268377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8378756221638489d, y: 0.7315837106529705d), new NpgsqlTypes.NpgsqlPoint(x: 0.6476526355398156d, y: 0.3378608668423755d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7242523049262612d, y: 0.261489343700281d), new NpgsqlTypes.NpgsqlPoint(x: 0.22203366848950257d, y: 0.5797748014600053d), new NpgsqlTypes.NpgsqlPoint(x: 0.58470196121083d, y: 0.869080027681391d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43193269704867476d, y: 0.2458899293188609d), new NpgsqlTypes.NpgsqlPoint(x: 0.43313739806762375d, y: 0.9202643361267944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236249464003762d, y: 0.4010798515955516d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6016479157951646d, y: 0.5084729016721896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914662976437645d, y: 0.05369017024706679d), new NpgsqlTypes.NpgsqlPoint(x: 0.8038267361443413d, y: 0.7248554859456058d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.803879588092114d, y: 0.8339049845924222d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395880042683217d, y: 0.07306512373242013d), new NpgsqlTypes.NpgsqlPoint(x: 0.12535354680501454d, y: 0.5096142251475264d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5317303454408214d, y: 0.41790843886368056d), new NpgsqlTypes.NpgsqlPoint(x: 0.2838062756101034d, y: 0.12917522029116646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728511301473465d, y: 0.4361934638543927d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20380629879055923d, y: 0.5280176077448171d), new NpgsqlTypes.NpgsqlPoint(x: 0.22464640910366307d, y: 0.952940508628351d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359270759206732d, y: 0.8226567019033102d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.990228791003145d, y: 0.11034549497787027d), new NpgsqlTypes.NpgsqlPoint(x: 0.9726904466908823d, y: 0.7776560510208805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8653972206563035d, y: 0.6871931694739697d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7280631496621216d, y: 0.41425474739691415d), new NpgsqlTypes.NpgsqlPoint(x: 0.13660887961187118d, y: 0.9584830898782194d), new NpgsqlTypes.NpgsqlPoint(x: 0.12717471253121748d, y: 0.6136309634709671d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03052829497299614d, y: 0.2996465907097582d), new NpgsqlTypes.NpgsqlPoint(x: 0.597142731180192d, y: 0.5505445045188373d), new NpgsqlTypes.NpgsqlPoint(x: 0.03906417323731626d, y: 0.9679087336450192d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12982054778738317d, y: 0.2778942583371068d), new NpgsqlTypes.NpgsqlPoint(x: 0.10049814104091692d, y: 0.9400543397520817d), new NpgsqlTypes.NpgsqlPoint(x: 0.01411701607611382d, y: 0.1432724683205605d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8490199075001053d, y: 0.026670494903985986d), new NpgsqlTypes.NpgsqlPoint(x: 0.9698485134680088d, y: 0.7668349119169567d), new NpgsqlTypes.NpgsqlPoint(x: 0.10974074208408557d, y: 0.44388956267644597d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2726208705441764d, y: 0.8194073807832392d), new NpgsqlTypes.NpgsqlPoint(x: 0.9876077239790845d, y: 0.3457738451125929d), new NpgsqlTypes.NpgsqlPoint(x: 0.39313616866801393d, y: 0.702295115219939d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1632650601939668d, y: 0.16327363688832075d), new NpgsqlTypes.NpgsqlPoint(x: 0.3118438589354765d, y: 0.7974624125400496d), new NpgsqlTypes.NpgsqlPoint(x: 0.7610849459377597d, y: 0.47749168687106247d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30549630085607304d, y: 0.18671109635357241d), new NpgsqlTypes.NpgsqlPoint(x: 0.5567820866304624d, y: 0.14409109680931842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8938868896473864d, y: 0.22824875185308746d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8860928305033361d, y: 0.9622878226734582d), new NpgsqlTypes.NpgsqlPoint(x: 0.9062246748448853d, y: 0.047308640913380606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274664417992314d, y: 0.31751451893136995d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.748537510719904d, y: 0.31036501693297325d), new NpgsqlTypes.NpgsqlPoint(x: 0.1700625541742814d, y: 0.5322526008218234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781950547782601d, y: 0.5507949766181108d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08759579713069965d, y: 0.4244174334636015d), new NpgsqlTypes.NpgsqlPoint(x: 0.44223606578131436d, y: 0.6808841032169776d), new NpgsqlTypes.NpgsqlPoint(x: 0.8987891048168025d, y: 0.6417316610756846d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5926736104643859d, y: 0.9833275627566825d), new NpgsqlTypes.NpgsqlPoint(x: 0.1890064481165551d, y: 0.7923627116255687d), new NpgsqlTypes.NpgsqlPoint(x: 0.6476071053038169d, y: 0.18081291750353745d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.70692796913552d, y: 0.15350852642151436d), new NpgsqlTypes.NpgsqlPoint(x: 0.8679960806931815d, y: 0.6775525891990318d), new NpgsqlTypes.NpgsqlPoint(x: 0.4781245436907441d, y: 0.015237450159581889d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5778350470987188d, y: 0.9668440793270077d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183025527343148d, y: 0.6087175618229874d), new NpgsqlTypes.NpgsqlPoint(x: 0.007020783584552492d, y: 0.6276112638318688d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.788256981336714d, y: 0.18069049937682213d), new NpgsqlTypes.NpgsqlPoint(x: 0.5452851515291628d, y: 0.97355281395185d), new NpgsqlTypes.NpgsqlPoint(x: 0.5294443161946188d, y: 0.4998630978259172d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9560189942336165d, y: 0.9221703614505008d), new NpgsqlTypes.NpgsqlPoint(x: 0.7726710593653594d, y: 0.8997693220956899d), new NpgsqlTypes.NpgsqlPoint(x: 0.4809245581731919d, y: 0.3718002950223708d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7918614272755783d, y: 0.873634021858731d), new NpgsqlTypes.NpgsqlPoint(x: 0.5981258210379905d, y: 0.043574239694682104d), new NpgsqlTypes.NpgsqlPoint(x: 0.8586947746741457d, y: 0.11103325586399448d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004873387164492704d, y: 0.464297695003257d), new NpgsqlTypes.NpgsqlPoint(x: 0.9394470372613158d, y: 0.34785636719056856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5133179383641631d, y: 0.5999245809819066d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9301721015661365d, y: 0.12033647917404844d), new NpgsqlTypes.NpgsqlPoint(x: 0.7873310838862461d, y: 0.6132979764998485d), new NpgsqlTypes.NpgsqlPoint(x: 0.4708872657977179d, y: 0.038247138516282364d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4832919861571865d, y: 0.4410149461144379d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744802617516087d, y: 0.2590358989391538d), new NpgsqlTypes.NpgsqlPoint(x: 0.05599968635502195d, y: 0.8792607731392147d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9814374646041201d, y: 0.0036094149525596197d), new NpgsqlTypes.NpgsqlPoint(x: 0.5167391408973204d, y: 0.3677819552361501d), new NpgsqlTypes.NpgsqlPoint(x: 0.20694312892839906d, y: 0.178198166758063d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5887845359518071d, y: 0.770875106567326d), new NpgsqlTypes.NpgsqlPoint(x: 0.06896261830194295d, y: 0.8037008981090223d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503104561197665d, y: 0.4760509463388618d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5065917884899259d, y: 0.7950415296322738d), new NpgsqlTypes.NpgsqlPoint(x: 0.4378979478196513d, y: 0.20744453226442405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8973201432648072d, y: 0.6690200861087049d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4625622391586327d, y: 0.4198563827298668d), new NpgsqlTypes.NpgsqlPoint(x: 0.4622324571734375d, y: 0.15546838384669226d), new NpgsqlTypes.NpgsqlPoint(x: 0.9068323307887111d, y: 0.5840729815590147d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6840772899396147d, y: 0.22249250212920035d), new NpgsqlTypes.NpgsqlPoint(x: 0.11072512405598223d, y: 0.6000961529746507d), new NpgsqlTypes.NpgsqlPoint(x: 0.052090864506071255d, y: 0.08009958560709951d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.020295545000490467d, y: 0.8780093481642839d), new NpgsqlTypes.NpgsqlPoint(x: 0.7876910825589069d, y: 0.6615369052048337d), new NpgsqlTypes.NpgsqlPoint(x: 0.9739550828375005d, y: 0.6494871201687527d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14718442150852362d, y: 0.037673217495569844d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789815603279125d, y: 0.5166785442732982d), new NpgsqlTypes.NpgsqlPoint(x: 0.22836557946471103d, y: 0.48472172281778536d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6099395551241178d, y: 0.8596946464747794d), new NpgsqlTypes.NpgsqlPoint(x: 0.6290914405988995d, y: 0.4830730702571251d), new NpgsqlTypes.NpgsqlPoint(x: 0.6570599947562439d, y: 0.22441509315397368d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0025722451860221707d, y: 0.8095677235040669d), new NpgsqlTypes.NpgsqlPoint(x: 0.07387596943964658d, y: 0.05083940462768599d), new NpgsqlTypes.NpgsqlPoint(x: 0.23889913922444161d, y: 0.7296859299636069d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.047048632170421545d, y: 0.383534200845035d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528340116172758d, y: 0.6707941354257609d), new NpgsqlTypes.NpgsqlPoint(x: 0.6414878330934348d, y: 0.7719030326316246d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5320171722049604d, y: 0.8970404019477106d), new NpgsqlTypes.NpgsqlPoint(x: 0.668961643592948d, y: 0.8034799404019272d), new NpgsqlTypes.NpgsqlPoint(x: 0.12420452234165047d, y: 0.4894670816963711d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5281712930053619d, y: 0.14100612240496369d), new NpgsqlTypes.NpgsqlPoint(x: 0.9915524977395795d, y: 0.9258893722984759d), new NpgsqlTypes.NpgsqlPoint(x: 0.6701007317135652d, y: 0.16408097054637416d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5143060025828261d, y: 0.7682215443310643d), new NpgsqlTypes.NpgsqlPoint(x: 0.3475101305836721d, y: 0.6638477375152091d), new NpgsqlTypes.NpgsqlPoint(x: 0.3926766255159281d, y: 0.290216895570681d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2361220008996624d, y: 0.09833109613410329d), new NpgsqlTypes.NpgsqlPoint(x: 0.027700287133139767d, y: 0.18621634350753802d), new NpgsqlTypes.NpgsqlPoint(x: 0.06039435431983198d, y: 0.33689560424755716d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5795228063801363d, y: 0.8948535051254878d), new NpgsqlTypes.NpgsqlPoint(x: 0.7020122049770945d, y: 0.7924033052077993d), new NpgsqlTypes.NpgsqlPoint(x: 0.8910937565496909d, y: 0.734843529433418d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23069492677308856d, y: 0.23965941792654755d), new NpgsqlTypes.NpgsqlPoint(x: 0.24652305681641729d, y: 0.05786483889580518d), new NpgsqlTypes.NpgsqlPoint(x: 0.7606722957109854d, y: 0.7769944993221763d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2731605171579198d, y: 0.62932554032678d), new NpgsqlTypes.NpgsqlPoint(x: 0.8046627276982049d, y: 0.17543303048683112d), new NpgsqlTypes.NpgsqlPoint(x: 0.12001350980136538d, y: 0.9624379876019409d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9509073500274186d, y: 0.673101488928434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296099813527215d, y: 0.01540911951851387d), new NpgsqlTypes.NpgsqlPoint(x: 0.027869489674484216d, y: 0.9753738690680329d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35079348043438296d, y: 0.8655700092104778d), new NpgsqlTypes.NpgsqlPoint(x: 0.92572364776057d, y: 0.657252440655544d), new NpgsqlTypes.NpgsqlPoint(x: 0.879400590499496d, y: 0.9419754274295379d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9018312480855982d, y: 0.06316283330957018d), new NpgsqlTypes.NpgsqlPoint(x: 0.15394009787047958d, y: 0.07409226889535359d), new NpgsqlTypes.NpgsqlPoint(x: 0.8568191774757254d, y: 0.9934563367907665d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7937548371098994d, y: 0.9405381784869439d), new NpgsqlTypes.NpgsqlPoint(x: 0.8679121408746345d, y: 0.9975027565424364d), new NpgsqlTypes.NpgsqlPoint(x: 0.483413341446568d, y: 0.6559017495369369d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04726089544119538d, y: 0.06508092531346032d), new NpgsqlTypes.NpgsqlPoint(x: 0.1836064285207557d, y: 0.8367383187943721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128196032870325d, y: 0.9072457551975479d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6499411433252286d, y: 0.369072191090573d), new NpgsqlTypes.NpgsqlPoint(x: 0.3444489220113576d, y: 0.9524166846351461d), new NpgsqlTypes.NpgsqlPoint(x: 0.845969648778128d, y: 0.7862247942484171d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7560498473933822d, y: 0.7616841388297828d), new NpgsqlTypes.NpgsqlPoint(x: 0.9657240407103103d, y: 0.14555324718034357d), new NpgsqlTypes.NpgsqlPoint(x: 0.6356316591654002d, y: 0.9063240086327274d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.058255881994425995d, y: 0.048710811464950265d), new NpgsqlTypes.NpgsqlPoint(x: 0.2641577104006798d, y: 0.6996847815538172d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010778801074923d, y: 0.9302791821619111d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5389743694826306d, y: 0.7420772200940986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5647539106494148d, y: 0.4528085006977923d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313207821332302d, y: 0.8877445831440155d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028829545139570034d, y: 0.8622757667749201d), new NpgsqlTypes.NpgsqlPoint(x: 0.03999490352370061d, y: 0.7809435471053304d), new NpgsqlTypes.NpgsqlPoint(x: 0.8267372180517851d, y: 0.5959060548423054d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13514891768292603d, y: 0.6198797379037417d), new NpgsqlTypes.NpgsqlPoint(x: 0.47572010677950227d, y: 0.5469515965972087d), new NpgsqlTypes.NpgsqlPoint(x: 0.39256260578763646d, y: 0.35352254952598616d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5451850481156569d, y: 0.9839095088073613d), new NpgsqlTypes.NpgsqlPoint(x: 0.007899611879614632d, y: 0.03212779733530102d), new NpgsqlTypes.NpgsqlPoint(x: 0.1845140129155337d, y: 0.9343799621509821d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20403917614379186d, y: 0.5796728591875158d), new NpgsqlTypes.NpgsqlPoint(x: 0.4624884436400022d, y: 0.8250883247131074d), new NpgsqlTypes.NpgsqlPoint(x: 0.07964811877136124d, y: 0.08960230870791086d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2765891427606739d, y: 0.2344098270266871d), new NpgsqlTypes.NpgsqlPoint(x: 0.653434924597298d, y: 0.9206136782039728d), new NpgsqlTypes.NpgsqlPoint(x: 0.8477683969151198d, y: 0.7661456957472345d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23845484091203673d, y: 0.6697033833272749d), new NpgsqlTypes.NpgsqlPoint(x: 0.14356912946484246d, y: 0.4714923981894644d), new NpgsqlTypes.NpgsqlPoint(x: 0.5635134757795229d, y: 0.9893525684641851d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18898961371673784d, y: 0.6663058080530121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528660100700558d, y: 0.7250527939313195d), new NpgsqlTypes.NpgsqlPoint(x: 0.8006609709925242d, y: 0.5307439579790644d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8530299891351183d, y: 0.2602461555525013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5204777203816354d, y: 0.8415866843326743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5495302110414062d, y: 0.700835916645135d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.622003094276256d, y: 0.13339729314506477d), new NpgsqlTypes.NpgsqlPoint(x: 0.32397791090772476d, y: 0.8505242283677491d), new NpgsqlTypes.NpgsqlPoint(x: 0.3711959300618849d, y: 0.40167258264058325d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 159,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7530305294240627d, y: 0.8608527150312879d), new NpgsqlTypes.NpgsqlPoint(x: 0.48174217898695826d, y: 0.3895070007954483d), new NpgsqlTypes.NpgsqlPoint(x: 0.32413359872366765d, y: 0.3460827240567276d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 166,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7681152332716091d, y: 0.43265721939235613d), new NpgsqlTypes.NpgsqlPoint(x: 0.6927766348723078d, y: 0.4810585823255451d), new NpgsqlTypes.NpgsqlPoint(x: 0.8373660381822832d, y: 0.6918869549188741d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7501726355414364d, y: 0.7868729789832869d), new NpgsqlTypes.NpgsqlPoint(x: 0.6369938454718419d, y: 0.5216331152388651d), new NpgsqlTypes.NpgsqlPoint(x: 0.7980610305264939d, y: 0.19444286093106378d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37857159587544176d, y: 0.463492734052133d), new NpgsqlTypes.NpgsqlPoint(x: 0.25421634379756053d, y: 0.7680510977088798d), new NpgsqlTypes.NpgsqlPoint(x: 0.7997643987563663d, y: 0.3926194761057339d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 171,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40886222444748077d, y: 0.9340954755048257d), new NpgsqlTypes.NpgsqlPoint(x: 0.49541791452306605d, y: 0.8493784235643093d), new NpgsqlTypes.NpgsqlPoint(x: 0.24482865351131589d, y: 0.2887077260211842d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28608892762461535d, y: 0.2973819161304009d), new NpgsqlTypes.NpgsqlPoint(x: 0.33362893087867873d, y: 0.27011093931634134d), new NpgsqlTypes.NpgsqlPoint(x: 0.10541912766600092d, y: 0.013129029393935343d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 177,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49086945374501556d, y: 0.8804870861855377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8062648439452682d, y: 0.8521873815719181d), new NpgsqlTypes.NpgsqlPoint(x: 0.536170814343778d, y: 0.7288934989091658d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5753729865868736d, y: 0.0893149627973383d), new NpgsqlTypes.NpgsqlPoint(x: 0.21873325719485348d, y: 0.5946675305596606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5045655148362329d, y: 0.0033704441495795434d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6163631525634501d, y: 0.16838080061302207d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843472283258902d, y: 0.1269960450676172d), new NpgsqlTypes.NpgsqlPoint(x: 0.7513096776006675d, y: 0.2734269827102289d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 181,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016736255637952002d, y: 0.6708409439599794d), new NpgsqlTypes.NpgsqlPoint(x: 0.46027396087335315d, y: 0.5831887252402566d), new NpgsqlTypes.NpgsqlPoint(x: 0.45010002469044164d, y: 0.3821959149689811d)),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43193269704867476d, y: 0.2458899293188609d), new NpgsqlTypes.NpgsqlPoint(x: 0.43313739806762375d, y: 0.9202643361267944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236249464003762d, y: 0.4010798515955516d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.990228791003145d, y: 0.11034549497787027d), new NpgsqlTypes.NpgsqlPoint(x: 0.9726904466908823d, y: 0.7776560510208805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8653972206563035d, y: 0.6871931694739697d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2726208705441764d, y: 0.8194073807832392d), new NpgsqlTypes.NpgsqlPoint(x: 0.9876077239790845d, y: 0.3457738451125929d), new NpgsqlTypes.NpgsqlPoint(x: 0.39313616866801393d, y: 0.702295115219939d))));
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8860928305033361d, y: 0.9622878226734582d), new NpgsqlTypes.NpgsqlPoint(x: 0.9062246748448853d, y: 0.047308640913380606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274664417992314d, y: 0.31751451893136995d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5778350470987188d, y: 0.9668440793270077d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183025527343148d, y: 0.6087175618229874d), new NpgsqlTypes.NpgsqlPoint(x: 0.007020783584552492d, y: 0.6276112638318688d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpolygonpolygon0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpolygonpolygon0mi_id", 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 78;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 87;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 166;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 20;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 20, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 78, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 30, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 171, query1, 171, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 76, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[32],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 112, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 18, query1, 112, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 77, query1, 53, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 112, 20))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 78, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 155);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[30], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[31], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[32], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[33], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[30], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[31], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[32], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[33], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4900782895785515d, y: 0.3319339531450023d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009107027157231329d, y: 0.9219881329828955d), new NpgsqlTypes.NpgsqlPoint(x: 0.610640560390245d, y: 0.8006355635775618d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13123336145445774d, y: 0.25382092372277787d), new NpgsqlTypes.NpgsqlPoint(x: 0.28212355872154304d, y: 0.6947889828042457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7909231401474724d, y: 0.6545786926863193d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24036110838090852d, y: 0.9432784777678007d), new NpgsqlTypes.NpgsqlPoint(x: 0.40792356111470474d, y: 0.8157505297210575d), new NpgsqlTypes.NpgsqlPoint(x: 0.8988614670792355d, y: 0.5842892143438725d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9779225610804251d, y: 0.32157677543874297d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549435957492465d, y: 0.5752970241217451d), new NpgsqlTypes.NpgsqlPoint(x: 0.7889319472335905d, y: 0.865985717873796d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05607009400593932d, y: 0.0336188492504792d), new NpgsqlTypes.NpgsqlPoint(x: 0.21393831397475827d, y: 0.35068315762418534d), new NpgsqlTypes.NpgsqlPoint(x: 0.48970689752735175d, y: 0.0027041224514104956d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7720643117106678d, y: 0.6099970719895423d), new NpgsqlTypes.NpgsqlPoint(x: 0.09573007069511474d, y: 0.6948068437076397d), new NpgsqlTypes.NpgsqlPoint(x: 0.013141219006178262d, y: 0.23262963442280493d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7239116183303227d, y: 0.8606192581969938d), new NpgsqlTypes.NpgsqlPoint(x: 0.21627960287093306d, y: 0.3247479558928831d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552816112596152d, y: 0.20942023176935665d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12228612785822712d, y: 0.29335956610789515d), new NpgsqlTypes.NpgsqlPoint(x: 0.48840766912383204d, y: 0.5018375523449916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6966068256888637d, y: 0.8375377807635652d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.849187650099178d, y: 0.6934138907268377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8378756221638489d, y: 0.7315837106529705d), new NpgsqlTypes.NpgsqlPoint(x: 0.6476526355398156d, y: 0.3378608668423755d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7242523049262612d, y: 0.261489343700281d), new NpgsqlTypes.NpgsqlPoint(x: 0.22203366848950257d, y: 0.5797748014600053d), new NpgsqlTypes.NpgsqlPoint(x: 0.58470196121083d, y: 0.869080027681391d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43193269704867476d, y: 0.2458899293188609d), new NpgsqlTypes.NpgsqlPoint(x: 0.43313739806762375d, y: 0.9202643361267944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236249464003762d, y: 0.4010798515955516d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6016479157951646d, y: 0.5084729016721896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914662976437645d, y: 0.05369017024706679d), new NpgsqlTypes.NpgsqlPoint(x: 0.8038267361443413d, y: 0.7248554859456058d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.803879588092114d, y: 0.8339049845924222d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395880042683217d, y: 0.07306512373242013d), new NpgsqlTypes.NpgsqlPoint(x: 0.12535354680501454d, y: 0.5096142251475264d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5317303454408214d, y: 0.41790843886368056d), new NpgsqlTypes.NpgsqlPoint(x: 0.2838062756101034d, y: 0.12917522029116646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728511301473465d, y: 0.4361934638543927d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20380629879055923d, y: 0.5280176077448171d), new NpgsqlTypes.NpgsqlPoint(x: 0.22464640910366307d, y: 0.952940508628351d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359270759206732d, y: 0.8226567019033102d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.990228791003145d, y: 0.11034549497787027d), new NpgsqlTypes.NpgsqlPoint(x: 0.9726904466908823d, y: 0.7776560510208805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8653972206563035d, y: 0.6871931694739697d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7280631496621216d, y: 0.41425474739691415d), new NpgsqlTypes.NpgsqlPoint(x: 0.13660887961187118d, y: 0.9584830898782194d), new NpgsqlTypes.NpgsqlPoint(x: 0.12717471253121748d, y: 0.6136309634709671d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03052829497299614d, y: 0.2996465907097582d), new NpgsqlTypes.NpgsqlPoint(x: 0.597142731180192d, y: 0.5505445045188373d), new NpgsqlTypes.NpgsqlPoint(x: 0.03906417323731626d, y: 0.9679087336450192d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12982054778738317d, y: 0.2778942583371068d), new NpgsqlTypes.NpgsqlPoint(x: 0.10049814104091692d, y: 0.9400543397520817d), new NpgsqlTypes.NpgsqlPoint(x: 0.01411701607611382d, y: 0.1432724683205605d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8490199075001053d, y: 0.026670494903985986d), new NpgsqlTypes.NpgsqlPoint(x: 0.9698485134680088d, y: 0.7668349119169567d), new NpgsqlTypes.NpgsqlPoint(x: 0.10974074208408557d, y: 0.44388956267644597d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2726208705441764d, y: 0.8194073807832392d), new NpgsqlTypes.NpgsqlPoint(x: 0.9876077239790845d, y: 0.3457738451125929d), new NpgsqlTypes.NpgsqlPoint(x: 0.39313616866801393d, y: 0.702295115219939d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1632650601939668d, y: 0.16327363688832075d), new NpgsqlTypes.NpgsqlPoint(x: 0.3118438589354765d, y: 0.7974624125400496d), new NpgsqlTypes.NpgsqlPoint(x: 0.7610849459377597d, y: 0.47749168687106247d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30549630085607304d, y: 0.18671109635357241d), new NpgsqlTypes.NpgsqlPoint(x: 0.5567820866304624d, y: 0.14409109680931842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8938868896473864d, y: 0.22824875185308746d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8860928305033361d, y: 0.9622878226734582d), new NpgsqlTypes.NpgsqlPoint(x: 0.9062246748448853d, y: 0.047308640913380606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274664417992314d, y: 0.31751451893136995d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.748537510719904d, y: 0.31036501693297325d), new NpgsqlTypes.NpgsqlPoint(x: 0.1700625541742814d, y: 0.5322526008218234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781950547782601d, y: 0.5507949766181108d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08759579713069965d, y: 0.4244174334636015d), new NpgsqlTypes.NpgsqlPoint(x: 0.44223606578131436d, y: 0.6808841032169776d), new NpgsqlTypes.NpgsqlPoint(x: 0.8987891048168025d, y: 0.6417316610756846d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5926736104643859d, y: 0.9833275627566825d), new NpgsqlTypes.NpgsqlPoint(x: 0.1890064481165551d, y: 0.7923627116255687d), new NpgsqlTypes.NpgsqlPoint(x: 0.6476071053038169d, y: 0.18081291750353745d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.70692796913552d, y: 0.15350852642151436d), new NpgsqlTypes.NpgsqlPoint(x: 0.8679960806931815d, y: 0.6775525891990318d), new NpgsqlTypes.NpgsqlPoint(x: 0.4781245436907441d, y: 0.015237450159581889d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5778350470987188d, y: 0.9668440793270077d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183025527343148d, y: 0.6087175618229874d), new NpgsqlTypes.NpgsqlPoint(x: 0.007020783584552492d, y: 0.6276112638318688d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.788256981336714d, y: 0.18069049937682213d), new NpgsqlTypes.NpgsqlPoint(x: 0.5452851515291628d, y: 0.97355281395185d), new NpgsqlTypes.NpgsqlPoint(x: 0.5294443161946188d, y: 0.4998630978259172d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9560189942336165d, y: 0.9221703614505008d), new NpgsqlTypes.NpgsqlPoint(x: 0.7726710593653594d, y: 0.8997693220956899d), new NpgsqlTypes.NpgsqlPoint(x: 0.4809245581731919d, y: 0.3718002950223708d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7918614272755783d, y: 0.873634021858731d), new NpgsqlTypes.NpgsqlPoint(x: 0.5981258210379905d, y: 0.043574239694682104d), new NpgsqlTypes.NpgsqlPoint(x: 0.8586947746741457d, y: 0.11103325586399448d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004873387164492704d, y: 0.464297695003257d), new NpgsqlTypes.NpgsqlPoint(x: 0.9394470372613158d, y: 0.34785636719056856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5133179383641631d, y: 0.5999245809819066d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9301721015661365d, y: 0.12033647917404844d), new NpgsqlTypes.NpgsqlPoint(x: 0.7873310838862461d, y: 0.6132979764998485d), new NpgsqlTypes.NpgsqlPoint(x: 0.4708872657977179d, y: 0.038247138516282364d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4832919861571865d, y: 0.4410149461144379d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744802617516087d, y: 0.2590358989391538d), new NpgsqlTypes.NpgsqlPoint(x: 0.05599968635502195d, y: 0.8792607731392147d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9814374646041201d, y: 0.0036094149525596197d), new NpgsqlTypes.NpgsqlPoint(x: 0.5167391408973204d, y: 0.3677819552361501d), new NpgsqlTypes.NpgsqlPoint(x: 0.20694312892839906d, y: 0.178198166758063d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5887845359518071d, y: 0.770875106567326d), new NpgsqlTypes.NpgsqlPoint(x: 0.06896261830194295d, y: 0.8037008981090223d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503104561197665d, y: 0.4760509463388618d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5065917884899259d, y: 0.7950415296322738d), new NpgsqlTypes.NpgsqlPoint(x: 0.4378979478196513d, y: 0.20744453226442405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8973201432648072d, y: 0.6690200861087049d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4625622391586327d, y: 0.4198563827298668d), new NpgsqlTypes.NpgsqlPoint(x: 0.4622324571734375d, y: 0.15546838384669226d), new NpgsqlTypes.NpgsqlPoint(x: 0.9068323307887111d, y: 0.5840729815590147d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6840772899396147d, y: 0.22249250212920035d), new NpgsqlTypes.NpgsqlPoint(x: 0.11072512405598223d, y: 0.6000961529746507d), new NpgsqlTypes.NpgsqlPoint(x: 0.052090864506071255d, y: 0.08009958560709951d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.020295545000490467d, y: 0.8780093481642839d), new NpgsqlTypes.NpgsqlPoint(x: 0.7876910825589069d, y: 0.6615369052048337d), new NpgsqlTypes.NpgsqlPoint(x: 0.9739550828375005d, y: 0.6494871201687527d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14718442150852362d, y: 0.037673217495569844d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789815603279125d, y: 0.5166785442732982d), new NpgsqlTypes.NpgsqlPoint(x: 0.22836557946471103d, y: 0.48472172281778536d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6099395551241178d, y: 0.8596946464747794d), new NpgsqlTypes.NpgsqlPoint(x: 0.6290914405988995d, y: 0.4830730702571251d), new NpgsqlTypes.NpgsqlPoint(x: 0.6570599947562439d, y: 0.22441509315397368d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0025722451860221707d, y: 0.8095677235040669d), new NpgsqlTypes.NpgsqlPoint(x: 0.07387596943964658d, y: 0.05083940462768599d), new NpgsqlTypes.NpgsqlPoint(x: 0.23889913922444161d, y: 0.7296859299636069d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.047048632170421545d, y: 0.383534200845035d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528340116172758d, y: 0.6707941354257609d), new NpgsqlTypes.NpgsqlPoint(x: 0.6414878330934348d, y: 0.7719030326316246d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5320171722049604d, y: 0.8970404019477106d), new NpgsqlTypes.NpgsqlPoint(x: 0.668961643592948d, y: 0.8034799404019272d), new NpgsqlTypes.NpgsqlPoint(x: 0.12420452234165047d, y: 0.4894670816963711d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5281712930053619d, y: 0.14100612240496369d), new NpgsqlTypes.NpgsqlPoint(x: 0.9915524977395795d, y: 0.9258893722984759d), new NpgsqlTypes.NpgsqlPoint(x: 0.6701007317135652d, y: 0.16408097054637416d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5143060025828261d, y: 0.7682215443310643d), new NpgsqlTypes.NpgsqlPoint(x: 0.3475101305836721d, y: 0.6638477375152091d), new NpgsqlTypes.NpgsqlPoint(x: 0.3926766255159281d, y: 0.290216895570681d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2361220008996624d, y: 0.09833109613410329d), new NpgsqlTypes.NpgsqlPoint(x: 0.027700287133139767d, y: 0.18621634350753802d), new NpgsqlTypes.NpgsqlPoint(x: 0.06039435431983198d, y: 0.33689560424755716d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5795228063801363d, y: 0.8948535051254878d), new NpgsqlTypes.NpgsqlPoint(x: 0.7020122049770945d, y: 0.7924033052077993d), new NpgsqlTypes.NpgsqlPoint(x: 0.8910937565496909d, y: 0.734843529433418d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23069492677308856d, y: 0.23965941792654755d), new NpgsqlTypes.NpgsqlPoint(x: 0.24652305681641729d, y: 0.05786483889580518d), new NpgsqlTypes.NpgsqlPoint(x: 0.7606722957109854d, y: 0.7769944993221763d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2731605171579198d, y: 0.62932554032678d), new NpgsqlTypes.NpgsqlPoint(x: 0.8046627276982049d, y: 0.17543303048683112d), new NpgsqlTypes.NpgsqlPoint(x: 0.12001350980136538d, y: 0.9624379876019409d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9509073500274186d, y: 0.673101488928434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296099813527215d, y: 0.01540911951851387d), new NpgsqlTypes.NpgsqlPoint(x: 0.027869489674484216d, y: 0.9753738690680329d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35079348043438296d, y: 0.8655700092104778d), new NpgsqlTypes.NpgsqlPoint(x: 0.92572364776057d, y: 0.657252440655544d), new NpgsqlTypes.NpgsqlPoint(x: 0.879400590499496d, y: 0.9419754274295379d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9018312480855982d, y: 0.06316283330957018d), new NpgsqlTypes.NpgsqlPoint(x: 0.15394009787047958d, y: 0.07409226889535359d), new NpgsqlTypes.NpgsqlPoint(x: 0.8568191774757254d, y: 0.9934563367907665d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7937548371098994d, y: 0.9405381784869439d), new NpgsqlTypes.NpgsqlPoint(x: 0.8679121408746345d, y: 0.9975027565424364d), new NpgsqlTypes.NpgsqlPoint(x: 0.483413341446568d, y: 0.6559017495369369d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04726089544119538d, y: 0.06508092531346032d), new NpgsqlTypes.NpgsqlPoint(x: 0.1836064285207557d, y: 0.8367383187943721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128196032870325d, y: 0.9072457551975479d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6499411433252286d, y: 0.369072191090573d), new NpgsqlTypes.NpgsqlPoint(x: 0.3444489220113576d, y: 0.9524166846351461d), new NpgsqlTypes.NpgsqlPoint(x: 0.845969648778128d, y: 0.7862247942484171d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7560498473933822d, y: 0.7616841388297828d), new NpgsqlTypes.NpgsqlPoint(x: 0.9657240407103103d, y: 0.14555324718034357d), new NpgsqlTypes.NpgsqlPoint(x: 0.6356316591654002d, y: 0.9063240086327274d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.058255881994425995d, y: 0.048710811464950265d), new NpgsqlTypes.NpgsqlPoint(x: 0.2641577104006798d, y: 0.6996847815538172d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010778801074923d, y: 0.9302791821619111d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5389743694826306d, y: 0.7420772200940986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5647539106494148d, y: 0.4528085006977923d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313207821332302d, y: 0.8877445831440155d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028829545139570034d, y: 0.8622757667749201d), new NpgsqlTypes.NpgsqlPoint(x: 0.03999490352370061d, y: 0.7809435471053304d), new NpgsqlTypes.NpgsqlPoint(x: 0.8267372180517851d, y: 0.5959060548423054d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13514891768292603d, y: 0.6198797379037417d), new NpgsqlTypes.NpgsqlPoint(x: 0.47572010677950227d, y: 0.5469515965972087d), new NpgsqlTypes.NpgsqlPoint(x: 0.39256260578763646d, y: 0.35352254952598616d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5451850481156569d, y: 0.9839095088073613d), new NpgsqlTypes.NpgsqlPoint(x: 0.007899611879614632d, y: 0.03212779733530102d), new NpgsqlTypes.NpgsqlPoint(x: 0.1845140129155337d, y: 0.9343799621509821d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20403917614379186d, y: 0.5796728591875158d), new NpgsqlTypes.NpgsqlPoint(x: 0.4624884436400022d, y: 0.8250883247131074d), new NpgsqlTypes.NpgsqlPoint(x: 0.07964811877136124d, y: 0.08960230870791086d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2765891427606739d, y: 0.2344098270266871d), new NpgsqlTypes.NpgsqlPoint(x: 0.653434924597298d, y: 0.9206136782039728d), new NpgsqlTypes.NpgsqlPoint(x: 0.8477683969151198d, y: 0.7661456957472345d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23845484091203673d, y: 0.6697033833272749d), new NpgsqlTypes.NpgsqlPoint(x: 0.14356912946484246d, y: 0.4714923981894644d), new NpgsqlTypes.NpgsqlPoint(x: 0.5635134757795229d, y: 0.9893525684641851d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18898961371673784d, y: 0.6663058080530121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528660100700558d, y: 0.7250527939313195d), new NpgsqlTypes.NpgsqlPoint(x: 0.8006609709925242d, y: 0.5307439579790644d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8530299891351183d, y: 0.2602461555525013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5204777203816354d, y: 0.8415866843326743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5495302110414062d, y: 0.700835916645135d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.622003094276256d, y: 0.13339729314506477d), new NpgsqlTypes.NpgsqlPoint(x: 0.32397791090772476d, y: 0.8505242283677491d), new NpgsqlTypes.NpgsqlPoint(x: 0.3711959300618849d, y: 0.40167258264058325d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7530305294240627d, y: 0.8608527150312879d), new NpgsqlTypes.NpgsqlPoint(x: 0.48174217898695826d, y: 0.3895070007954483d), new NpgsqlTypes.NpgsqlPoint(x: 0.32413359872366765d, y: 0.3460827240567276d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7681152332716091d, y: 0.43265721939235613d), new NpgsqlTypes.NpgsqlPoint(x: 0.6927766348723078d, y: 0.4810585823255451d), new NpgsqlTypes.NpgsqlPoint(x: 0.8373660381822832d, y: 0.6918869549188741d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7501726355414364d, y: 0.7868729789832869d), new NpgsqlTypes.NpgsqlPoint(x: 0.6369938454718419d, y: 0.5216331152388651d), new NpgsqlTypes.NpgsqlPoint(x: 0.7980610305264939d, y: 0.19444286093106378d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37857159587544176d, y: 0.463492734052133d), new NpgsqlTypes.NpgsqlPoint(x: 0.25421634379756053d, y: 0.7680510977088798d), new NpgsqlTypes.NpgsqlPoint(x: 0.7997643987563663d, y: 0.3926194761057339d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40886222444748077d, y: 0.9340954755048257d), new NpgsqlTypes.NpgsqlPoint(x: 0.49541791452306605d, y: 0.8493784235643093d), new NpgsqlTypes.NpgsqlPoint(x: 0.24482865351131589d, y: 0.2887077260211842d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28608892762461535d, y: 0.2973819161304009d), new NpgsqlTypes.NpgsqlPoint(x: 0.33362893087867873d, y: 0.27011093931634134d), new NpgsqlTypes.NpgsqlPoint(x: 0.10541912766600092d, y: 0.013129029393935343d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49086945374501556d, y: 0.8804870861855377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8062648439452682d, y: 0.8521873815719181d), new NpgsqlTypes.NpgsqlPoint(x: 0.536170814343778d, y: 0.7288934989091658d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((103)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5753729865868736d, y: 0.0893149627973383d), new NpgsqlTypes.NpgsqlPoint(x: 0.21873325719485348d, y: 0.5946675305596606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5045655148362329d, y: 0.0033704441495795434d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6163631525634501d, y: 0.16838080061302207d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843472283258902d, y: 0.1269960450676172d), new NpgsqlTypes.NpgsqlPoint(x: 0.7513096776006675d, y: 0.2734269827102289d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016736255637952002d, y: 0.6708409439599794d), new NpgsqlTypes.NpgsqlPoint(x: 0.46027396087335315d, y: 0.5831887252402566d), new NpgsqlTypes.NpgsqlPoint(x: 0.45010002469044164d, y: 0.3821959149689811d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4900782895785515d, y: 0.3319339531450023d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009107027157231329d, y: 0.9219881329828955d), new NpgsqlTypes.NpgsqlPoint(x: 0.610640560390245d, y: 0.8006355635775618d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13123336145445774d, y: 0.25382092372277787d), new NpgsqlTypes.NpgsqlPoint(x: 0.28212355872154304d, y: 0.6947889828042457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7909231401474724d, y: 0.6545786926863193d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24036110838090852d, y: 0.9432784777678007d), new NpgsqlTypes.NpgsqlPoint(x: 0.40792356111470474d, y: 0.8157505297210575d), new NpgsqlTypes.NpgsqlPoint(x: 0.8988614670792355d, y: 0.5842892143438725d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9779225610804251d, y: 0.32157677543874297d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549435957492465d, y: 0.5752970241217451d), new NpgsqlTypes.NpgsqlPoint(x: 0.7889319472335905d, y: 0.865985717873796d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05607009400593932d, y: 0.0336188492504792d), new NpgsqlTypes.NpgsqlPoint(x: 0.21393831397475827d, y: 0.35068315762418534d), new NpgsqlTypes.NpgsqlPoint(x: 0.48970689752735175d, y: 0.0027041224514104956d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7720643117106678d, y: 0.6099970719895423d), new NpgsqlTypes.NpgsqlPoint(x: 0.09573007069511474d, y: 0.6948068437076397d), new NpgsqlTypes.NpgsqlPoint(x: 0.013141219006178262d, y: 0.23262963442280493d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7239116183303227d, y: 0.8606192581969938d), new NpgsqlTypes.NpgsqlPoint(x: 0.21627960287093306d, y: 0.3247479558928831d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552816112596152d, y: 0.20942023176935665d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12228612785822712d, y: 0.29335956610789515d), new NpgsqlTypes.NpgsqlPoint(x: 0.48840766912383204d, y: 0.5018375523449916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6966068256888637d, y: 0.8375377807635652d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.849187650099178d, y: 0.6934138907268377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8378756221638489d, y: 0.7315837106529705d), new NpgsqlTypes.NpgsqlPoint(x: 0.6476526355398156d, y: 0.3378608668423755d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7242523049262612d, y: 0.261489343700281d), new NpgsqlTypes.NpgsqlPoint(x: 0.22203366848950257d, y: 0.5797748014600053d), new NpgsqlTypes.NpgsqlPoint(x: 0.58470196121083d, y: 0.869080027681391d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43193269704867476d, y: 0.2458899293188609d), new NpgsqlTypes.NpgsqlPoint(x: 0.43313739806762375d, y: 0.9202643361267944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236249464003762d, y: 0.4010798515955516d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6016479157951646d, y: 0.5084729016721896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914662976437645d, y: 0.05369017024706679d), new NpgsqlTypes.NpgsqlPoint(x: 0.8038267361443413d, y: 0.7248554859456058d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.803879588092114d, y: 0.8339049845924222d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395880042683217d, y: 0.07306512373242013d), new NpgsqlTypes.NpgsqlPoint(x: 0.12535354680501454d, y: 0.5096142251475264d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5317303454408214d, y: 0.41790843886368056d), new NpgsqlTypes.NpgsqlPoint(x: 0.2838062756101034d, y: 0.12917522029116646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728511301473465d, y: 0.4361934638543927d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20380629879055923d, y: 0.5280176077448171d), new NpgsqlTypes.NpgsqlPoint(x: 0.22464640910366307d, y: 0.952940508628351d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359270759206732d, y: 0.8226567019033102d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.990228791003145d, y: 0.11034549497787027d), new NpgsqlTypes.NpgsqlPoint(x: 0.9726904466908823d, y: 0.7776560510208805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8653972206563035d, y: 0.6871931694739697d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7280631496621216d, y: 0.41425474739691415d), new NpgsqlTypes.NpgsqlPoint(x: 0.13660887961187118d, y: 0.9584830898782194d), new NpgsqlTypes.NpgsqlPoint(x: 0.12717471253121748d, y: 0.6136309634709671d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03052829497299614d, y: 0.2996465907097582d), new NpgsqlTypes.NpgsqlPoint(x: 0.597142731180192d, y: 0.5505445045188373d), new NpgsqlTypes.NpgsqlPoint(x: 0.03906417323731626d, y: 0.9679087336450192d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12982054778738317d, y: 0.2778942583371068d), new NpgsqlTypes.NpgsqlPoint(x: 0.10049814104091692d, y: 0.9400543397520817d), new NpgsqlTypes.NpgsqlPoint(x: 0.01411701607611382d, y: 0.1432724683205605d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8490199075001053d, y: 0.026670494903985986d), new NpgsqlTypes.NpgsqlPoint(x: 0.9698485134680088d, y: 0.7668349119169567d), new NpgsqlTypes.NpgsqlPoint(x: 0.10974074208408557d, y: 0.44388956267644597d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2726208705441764d, y: 0.8194073807832392d), new NpgsqlTypes.NpgsqlPoint(x: 0.9876077239790845d, y: 0.3457738451125929d), new NpgsqlTypes.NpgsqlPoint(x: 0.39313616866801393d, y: 0.702295115219939d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1632650601939668d, y: 0.16327363688832075d), new NpgsqlTypes.NpgsqlPoint(x: 0.3118438589354765d, y: 0.7974624125400496d), new NpgsqlTypes.NpgsqlPoint(x: 0.7610849459377597d, y: 0.47749168687106247d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30549630085607304d, y: 0.18671109635357241d), new NpgsqlTypes.NpgsqlPoint(x: 0.5567820866304624d, y: 0.14409109680931842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8938868896473864d, y: 0.22824875185308746d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8860928305033361d, y: 0.9622878226734582d), new NpgsqlTypes.NpgsqlPoint(x: 0.9062246748448853d, y: 0.047308640913380606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274664417992314d, y: 0.31751451893136995d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.748537510719904d, y: 0.31036501693297325d), new NpgsqlTypes.NpgsqlPoint(x: 0.1700625541742814d, y: 0.5322526008218234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781950547782601d, y: 0.5507949766181108d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08759579713069965d, y: 0.4244174334636015d), new NpgsqlTypes.NpgsqlPoint(x: 0.44223606578131436d, y: 0.6808841032169776d), new NpgsqlTypes.NpgsqlPoint(x: 0.8987891048168025d, y: 0.6417316610756846d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5926736104643859d, y: 0.9833275627566825d), new NpgsqlTypes.NpgsqlPoint(x: 0.1890064481165551d, y: 0.7923627116255687d), new NpgsqlTypes.NpgsqlPoint(x: 0.6476071053038169d, y: 0.18081291750353745d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.70692796913552d, y: 0.15350852642151436d), new NpgsqlTypes.NpgsqlPoint(x: 0.8679960806931815d, y: 0.6775525891990318d), new NpgsqlTypes.NpgsqlPoint(x: 0.4781245436907441d, y: 0.015237450159581889d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5778350470987188d, y: 0.9668440793270077d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183025527343148d, y: 0.6087175618229874d), new NpgsqlTypes.NpgsqlPoint(x: 0.007020783584552492d, y: 0.6276112638318688d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.788256981336714d, y: 0.18069049937682213d), new NpgsqlTypes.NpgsqlPoint(x: 0.5452851515291628d, y: 0.97355281395185d), new NpgsqlTypes.NpgsqlPoint(x: 0.5294443161946188d, y: 0.4998630978259172d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9560189942336165d, y: 0.9221703614505008d), new NpgsqlTypes.NpgsqlPoint(x: 0.7726710593653594d, y: 0.8997693220956899d), new NpgsqlTypes.NpgsqlPoint(x: 0.4809245581731919d, y: 0.3718002950223708d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7918614272755783d, y: 0.873634021858731d), new NpgsqlTypes.NpgsqlPoint(x: 0.5981258210379905d, y: 0.043574239694682104d), new NpgsqlTypes.NpgsqlPoint(x: 0.8586947746741457d, y: 0.11103325586399448d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004873387164492704d, y: 0.464297695003257d), new NpgsqlTypes.NpgsqlPoint(x: 0.9394470372613158d, y: 0.34785636719056856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5133179383641631d, y: 0.5999245809819066d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9301721015661365d, y: 0.12033647917404844d), new NpgsqlTypes.NpgsqlPoint(x: 0.7873310838862461d, y: 0.6132979764998485d), new NpgsqlTypes.NpgsqlPoint(x: 0.4708872657977179d, y: 0.038247138516282364d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4832919861571865d, y: 0.4410149461144379d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744802617516087d, y: 0.2590358989391538d), new NpgsqlTypes.NpgsqlPoint(x: 0.05599968635502195d, y: 0.8792607731392147d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9814374646041201d, y: 0.0036094149525596197d), new NpgsqlTypes.NpgsqlPoint(x: 0.5167391408973204d, y: 0.3677819552361501d), new NpgsqlTypes.NpgsqlPoint(x: 0.20694312892839906d, y: 0.178198166758063d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5887845359518071d, y: 0.770875106567326d), new NpgsqlTypes.NpgsqlPoint(x: 0.06896261830194295d, y: 0.8037008981090223d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503104561197665d, y: 0.4760509463388618d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5065917884899259d, y: 0.7950415296322738d), new NpgsqlTypes.NpgsqlPoint(x: 0.4378979478196513d, y: 0.20744453226442405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8973201432648072d, y: 0.6690200861087049d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4625622391586327d, y: 0.4198563827298668d), new NpgsqlTypes.NpgsqlPoint(x: 0.4622324571734375d, y: 0.15546838384669226d), new NpgsqlTypes.NpgsqlPoint(x: 0.9068323307887111d, y: 0.5840729815590147d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6840772899396147d, y: 0.22249250212920035d), new NpgsqlTypes.NpgsqlPoint(x: 0.11072512405598223d, y: 0.6000961529746507d), new NpgsqlTypes.NpgsqlPoint(x: 0.052090864506071255d, y: 0.08009958560709951d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.020295545000490467d, y: 0.8780093481642839d), new NpgsqlTypes.NpgsqlPoint(x: 0.7876910825589069d, y: 0.6615369052048337d), new NpgsqlTypes.NpgsqlPoint(x: 0.9739550828375005d, y: 0.6494871201687527d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14718442150852362d, y: 0.037673217495569844d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789815603279125d, y: 0.5166785442732982d), new NpgsqlTypes.NpgsqlPoint(x: 0.22836557946471103d, y: 0.48472172281778536d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6099395551241178d, y: 0.8596946464747794d), new NpgsqlTypes.NpgsqlPoint(x: 0.6290914405988995d, y: 0.4830730702571251d), new NpgsqlTypes.NpgsqlPoint(x: 0.6570599947562439d, y: 0.22441509315397368d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0025722451860221707d, y: 0.8095677235040669d), new NpgsqlTypes.NpgsqlPoint(x: 0.07387596943964658d, y: 0.05083940462768599d), new NpgsqlTypes.NpgsqlPoint(x: 0.23889913922444161d, y: 0.7296859299636069d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.047048632170421545d, y: 0.383534200845035d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528340116172758d, y: 0.6707941354257609d), new NpgsqlTypes.NpgsqlPoint(x: 0.6414878330934348d, y: 0.7719030326316246d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5320171722049604d, y: 0.8970404019477106d), new NpgsqlTypes.NpgsqlPoint(x: 0.668961643592948d, y: 0.8034799404019272d), new NpgsqlTypes.NpgsqlPoint(x: 0.12420452234165047d, y: 0.4894670816963711d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5281712930053619d, y: 0.14100612240496369d), new NpgsqlTypes.NpgsqlPoint(x: 0.9915524977395795d, y: 0.9258893722984759d), new NpgsqlTypes.NpgsqlPoint(x: 0.6701007317135652d, y: 0.16408097054637416d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5143060025828261d, y: 0.7682215443310643d), new NpgsqlTypes.NpgsqlPoint(x: 0.3475101305836721d, y: 0.6638477375152091d), new NpgsqlTypes.NpgsqlPoint(x: 0.3926766255159281d, y: 0.290216895570681d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2361220008996624d, y: 0.09833109613410329d), new NpgsqlTypes.NpgsqlPoint(x: 0.027700287133139767d, y: 0.18621634350753802d), new NpgsqlTypes.NpgsqlPoint(x: 0.06039435431983198d, y: 0.33689560424755716d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5795228063801363d, y: 0.8948535051254878d), new NpgsqlTypes.NpgsqlPoint(x: 0.7020122049770945d, y: 0.7924033052077993d), new NpgsqlTypes.NpgsqlPoint(x: 0.8910937565496909d, y: 0.734843529433418d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23069492677308856d, y: 0.23965941792654755d), new NpgsqlTypes.NpgsqlPoint(x: 0.24652305681641729d, y: 0.05786483889580518d), new NpgsqlTypes.NpgsqlPoint(x: 0.7606722957109854d, y: 0.7769944993221763d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2731605171579198d, y: 0.62932554032678d), new NpgsqlTypes.NpgsqlPoint(x: 0.8046627276982049d, y: 0.17543303048683112d), new NpgsqlTypes.NpgsqlPoint(x: 0.12001350980136538d, y: 0.9624379876019409d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9509073500274186d, y: 0.673101488928434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296099813527215d, y: 0.01540911951851387d), new NpgsqlTypes.NpgsqlPoint(x: 0.027869489674484216d, y: 0.9753738690680329d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35079348043438296d, y: 0.8655700092104778d), new NpgsqlTypes.NpgsqlPoint(x: 0.92572364776057d, y: 0.657252440655544d), new NpgsqlTypes.NpgsqlPoint(x: 0.879400590499496d, y: 0.9419754274295379d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9018312480855982d, y: 0.06316283330957018d), new NpgsqlTypes.NpgsqlPoint(x: 0.15394009787047958d, y: 0.07409226889535359d), new NpgsqlTypes.NpgsqlPoint(x: 0.8568191774757254d, y: 0.9934563367907665d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7937548371098994d, y: 0.9405381784869439d), new NpgsqlTypes.NpgsqlPoint(x: 0.8679121408746345d, y: 0.9975027565424364d), new NpgsqlTypes.NpgsqlPoint(x: 0.483413341446568d, y: 0.6559017495369369d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04726089544119538d, y: 0.06508092531346032d), new NpgsqlTypes.NpgsqlPoint(x: 0.1836064285207557d, y: 0.8367383187943721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128196032870325d, y: 0.9072457551975479d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6499411433252286d, y: 0.369072191090573d), new NpgsqlTypes.NpgsqlPoint(x: 0.3444489220113576d, y: 0.9524166846351461d), new NpgsqlTypes.NpgsqlPoint(x: 0.845969648778128d, y: 0.7862247942484171d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7560498473933822d, y: 0.7616841388297828d), new NpgsqlTypes.NpgsqlPoint(x: 0.9657240407103103d, y: 0.14555324718034357d), new NpgsqlTypes.NpgsqlPoint(x: 0.6356316591654002d, y: 0.9063240086327274d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.058255881994425995d, y: 0.048710811464950265d), new NpgsqlTypes.NpgsqlPoint(x: 0.2641577104006798d, y: 0.6996847815538172d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010778801074923d, y: 0.9302791821619111d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5389743694826306d, y: 0.7420772200940986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5647539106494148d, y: 0.4528085006977923d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313207821332302d, y: 0.8877445831440155d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028829545139570034d, y: 0.8622757667749201d), new NpgsqlTypes.NpgsqlPoint(x: 0.03999490352370061d, y: 0.7809435471053304d), new NpgsqlTypes.NpgsqlPoint(x: 0.8267372180517851d, y: 0.5959060548423054d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13514891768292603d, y: 0.6198797379037417d), new NpgsqlTypes.NpgsqlPoint(x: 0.47572010677950227d, y: 0.5469515965972087d), new NpgsqlTypes.NpgsqlPoint(x: 0.39256260578763646d, y: 0.35352254952598616d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5451850481156569d, y: 0.9839095088073613d), new NpgsqlTypes.NpgsqlPoint(x: 0.007899611879614632d, y: 0.03212779733530102d), new NpgsqlTypes.NpgsqlPoint(x: 0.1845140129155337d, y: 0.9343799621509821d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20403917614379186d, y: 0.5796728591875158d), new NpgsqlTypes.NpgsqlPoint(x: 0.4624884436400022d, y: 0.8250883247131074d), new NpgsqlTypes.NpgsqlPoint(x: 0.07964811877136124d, y: 0.08960230870791086d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2765891427606739d, y: 0.2344098270266871d), new NpgsqlTypes.NpgsqlPoint(x: 0.653434924597298d, y: 0.9206136782039728d), new NpgsqlTypes.NpgsqlPoint(x: 0.8477683969151198d, y: 0.7661456957472345d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23845484091203673d, y: 0.6697033833272749d), new NpgsqlTypes.NpgsqlPoint(x: 0.14356912946484246d, y: 0.4714923981894644d), new NpgsqlTypes.NpgsqlPoint(x: 0.5635134757795229d, y: 0.9893525684641851d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18898961371673784d, y: 0.6663058080530121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528660100700558d, y: 0.7250527939313195d), new NpgsqlTypes.NpgsqlPoint(x: 0.8006609709925242d, y: 0.5307439579790644d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8530299891351183d, y: 0.2602461555525013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5204777203816354d, y: 0.8415866843326743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5495302110414062d, y: 0.700835916645135d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.622003094276256d, y: 0.13339729314506477d), new NpgsqlTypes.NpgsqlPoint(x: 0.32397791090772476d, y: 0.8505242283677491d), new NpgsqlTypes.NpgsqlPoint(x: 0.3711959300618849d, y: 0.40167258264058325d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7530305294240627d, y: 0.8608527150312879d), new NpgsqlTypes.NpgsqlPoint(x: 0.48174217898695826d, y: 0.3895070007954483d), new NpgsqlTypes.NpgsqlPoint(x: 0.32413359872366765d, y: 0.3460827240567276d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7681152332716091d, y: 0.43265721939235613d), new NpgsqlTypes.NpgsqlPoint(x: 0.6927766348723078d, y: 0.4810585823255451d), new NpgsqlTypes.NpgsqlPoint(x: 0.8373660381822832d, y: 0.6918869549188741d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7501726355414364d, y: 0.7868729789832869d), new NpgsqlTypes.NpgsqlPoint(x: 0.6369938454718419d, y: 0.5216331152388651d), new NpgsqlTypes.NpgsqlPoint(x: 0.7980610305264939d, y: 0.19444286093106378d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37857159587544176d, y: 0.463492734052133d), new NpgsqlTypes.NpgsqlPoint(x: 0.25421634379756053d, y: 0.7680510977088798d), new NpgsqlTypes.NpgsqlPoint(x: 0.7997643987563663d, y: 0.3926194761057339d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40886222444748077d, y: 0.9340954755048257d), new NpgsqlTypes.NpgsqlPoint(x: 0.49541791452306605d, y: 0.8493784235643093d), new NpgsqlTypes.NpgsqlPoint(x: 0.24482865351131589d, y: 0.2887077260211842d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28608892762461535d, y: 0.2973819161304009d), new NpgsqlTypes.NpgsqlPoint(x: 0.33362893087867873d, y: 0.27011093931634134d), new NpgsqlTypes.NpgsqlPoint(x: 0.10541912766600092d, y: 0.013129029393935343d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49086945374501556d, y: 0.8804870861855377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8062648439452682d, y: 0.8521873815719181d), new NpgsqlTypes.NpgsqlPoint(x: 0.536170814343778d, y: 0.7288934989091658d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((103)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5753729865868736d, y: 0.0893149627973383d), new NpgsqlTypes.NpgsqlPoint(x: 0.21873325719485348d, y: 0.5946675305596606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5045655148362329d, y: 0.0033704441495795434d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6163631525634501d, y: 0.16838080061302207d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843472283258902d, y: 0.1269960450676172d), new NpgsqlTypes.NpgsqlPoint(x: 0.7513096776006675d, y: 0.2734269827102289d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016736255637952002d, y: 0.6708409439599794d), new NpgsqlTypes.NpgsqlPoint(x: 0.46027396087335315d, y: 0.5831887252402566d), new NpgsqlTypes.NpgsqlPoint(x: 0.45010002469044164d, y: 0.3821959149689811d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygon0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
FROM public.binary_npgsqlpolygonpolygon0m m
LEFT JOIN public.binary_npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI), typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

