

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
    internal partial interface IBigIntegerArraynumericArray
    {
    }
    
    internal partial class BigIntegerArraynumericArray : IBigIntegerArraynumericArray
    {


#region TestData

        private readonly BigIntegernumericArray1M[] _testData = new BigIntegernumericArray1M[]
        {
            new BigIntegernumericArray1M
{
    Id = 3,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7384903667136840678L),
new System.Numerics.BigInteger(6262194547365439707L),
new System.Numerics.BigInteger(2333589178350605891L),
new System.Numerics.BigInteger(7904077731190458766L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4273598584139796561L),
new System.Numerics.BigInteger(4682107796720647239L),
new System.Numerics.BigInteger(8269110733784467923L),
},
},
            new BigIntegernumericArray1M
{
    Id = 11,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7888095830061042934L),
new System.Numerics.BigInteger(6465583490011994331L),
new System.Numerics.BigInteger(183012598752509641L),
new System.Numerics.BigInteger(8220583873681106549L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 8,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2380662066233066970L),
new System.Numerics.BigInteger(4390401814779220102L),
new System.Numerics.BigInteger(7165840429652883972L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 16,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2657190999935470865L),
new System.Numerics.BigInteger(4862000317686108315L),
new System.Numerics.BigInteger(4673215603179878660L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(674905583964570266L),
new System.Numerics.BigInteger(3934558488150715468L),
new System.Numerics.BigInteger(9000748671422639062L),
new System.Numerics.BigInteger(6539404913269440835L),
},
},
            new BigIntegernumericArray1M
{
    Id = 25,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8393780471064144273L),
new System.Numerics.BigInteger(3143098798205004616L),
new System.Numerics.BigInteger(4251859121734858624L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 17,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3672705376197411584L),
new System.Numerics.BigInteger(3844013383763335726L),
new System.Numerics.BigInteger(2032865425709699100L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3633466247831769039L),
new System.Numerics.BigInteger(6749788163552554946L),
new System.Numerics.BigInteger(4800823706443057242L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8684436616167348885L),
new System.Numerics.BigInteger(5151310563743118328L),
new System.Numerics.BigInteger(2022016005086883488L),
new System.Numerics.BigInteger(3317705871646188076L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5202911647787128498L),
new System.Numerics.BigInteger(501298080598234415L),
new System.Numerics.BigInteger(6355486471626395640L),
},
},
            new BigIntegernumericArray1M
{
    Id = 33,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(743845486962338091L),
new System.Numerics.BigInteger(1456567058910714649L),
new System.Numerics.BigInteger(5324998882593990328L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 19,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(157643272485597025L),
new System.Numerics.BigInteger(5261825912843632864L),
new System.Numerics.BigInteger(6198808498130853450L),
new System.Numerics.BigInteger(8637275466562519785L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8254825035210573466L),
new System.Numerics.BigInteger(5032038521589303150L),
new System.Numerics.BigInteger(4216709354604478778L),
new System.Numerics.BigInteger(1346148773245388322L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7322752424671315170L),
new System.Numerics.BigInteger(6086338777645558728L),
new System.Numerics.BigInteger(2825632709568191604L),
},
},
            new BigIntegernumericArray1M
{
    Id = 40,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7411199821876732226L),
new System.Numerics.BigInteger(236809853379934281L),
new System.Numerics.BigInteger(4721666921027304392L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3591323518376031776L),
new System.Numerics.BigInteger(689498337334372881L),
new System.Numerics.BigInteger(6132201321194501811L),
new System.Numerics.BigInteger(1276187872488278611L),
},
},
            new BigIntegernumericArray1M
{
    Id = 47,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8802995551466494177L),
new System.Numerics.BigInteger(5444068458578803922L),
new System.Numerics.BigInteger(6869808023571295291L),
new System.Numerics.BigInteger(4712886402866972447L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 25,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4569472827097162901L),
new System.Numerics.BigInteger(1388371013474231073L),
new System.Numerics.BigInteger(311971783197648527L),
new System.Numerics.BigInteger(7492207390351161709L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(613878980165612287L),
new System.Numerics.BigInteger(3258250405250949408L),
new System.Numerics.BigInteger(223809389201478452L),
},
},
            new BigIntegernumericArray1M
{
    Id = 54,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6429405601259988447L),
new System.Numerics.BigInteger(8334711540034334004L),
new System.Numerics.BigInteger(8552272844443568922L),
new System.Numerics.BigInteger(896386787637363765L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8981541759944204328L),
new System.Numerics.BigInteger(3890666713645335392L),
new System.Numerics.BigInteger(2607732972845255271L),
},
},
            new BigIntegernumericArray1M
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1848708384178565067L),
new System.Numerics.BigInteger(7214539496111472341L),
new System.Numerics.BigInteger(4419133820756873931L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 28,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3377185733648310548L),
new System.Numerics.BigInteger(3385540865604095412L),
new System.Numerics.BigInteger(317338986121422594L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8510337739844473287L),
new System.Numerics.BigInteger(1383584422716252193L),
new System.Numerics.BigInteger(6949807724276684692L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 58,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5095381491996927957L),
new System.Numerics.BigInteger(819924512229323588L),
new System.Numerics.BigInteger(2526239382687096530L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8165609424925758005L),
new System.Numerics.BigInteger(6051200406992981301L),
new System.Numerics.BigInteger(2809238462892399948L),
new System.Numerics.BigInteger(2583779446964465312L),
},
},
            new BigIntegernumericArray1M
{
    Id = 62,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2850452949968474189L),
new System.Numerics.BigInteger(149371427088958509L),
new System.Numerics.BigInteger(1163397594580682419L),
new System.Numerics.BigInteger(3797958823313590871L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 37,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3070787733529236643L),
new System.Numerics.BigInteger(4683109990447780377L),
new System.Numerics.BigInteger(4925398659292637013L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(636830876716431663L),
new System.Numerics.BigInteger(7659295943245071080L),
new System.Numerics.BigInteger(4346336786491125078L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 64,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5755647664267022211L),
new System.Numerics.BigInteger(1900263691506621291L),
new System.Numerics.BigInteger(4107508234435090475L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 71,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(252812227900830083L),
new System.Numerics.BigInteger(6663480521151079006L),
new System.Numerics.BigInteger(3269998986821388209L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 46,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4245580453938074377L),
new System.Numerics.BigInteger(8888237816778869528L),
new System.Numerics.BigInteger(6064580778441545302L),
new System.Numerics.BigInteger(3796321068886868084L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7995499576456472544L),
new System.Numerics.BigInteger(5146808810447033860L),
new System.Numerics.BigInteger(447236984437886937L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 72,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(979015149739268531L),
new System.Numerics.BigInteger(3187062189325749004L),
new System.Numerics.BigInteger(403707477526055553L),
new System.Numerics.BigInteger(6559925644348188859L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6931069913380568471L),
new System.Numerics.BigInteger(708835313390676358L),
new System.Numerics.BigInteger(3051891950889805095L),
},
},
            new BigIntegernumericArray1M
{
    Id = 77,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5040989207772190873L),
new System.Numerics.BigInteger(1333229282414941478L),
new System.Numerics.BigInteger(584204019825282882L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 47,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1086585440620157979L),
new System.Numerics.BigInteger(79036132300939691L),
new System.Numerics.BigInteger(5028493691440876291L),
new System.Numerics.BigInteger(5590116349852150088L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5481460868498046523L),
new System.Numerics.BigInteger(4506774000443065998L),
new System.Numerics.BigInteger(9222563980094395842L),
new System.Numerics.BigInteger(57019569254460790L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 82,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3477748111801390682L),
new System.Numerics.BigInteger(8387024875589663276L),
new System.Numerics.BigInteger(6282904804903387229L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 86,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3913499265666827157L),
new System.Numerics.BigInteger(6592320918469793058L),
new System.Numerics.BigInteger(6188845246954066657L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(168873475088930759L),
new System.Numerics.BigInteger(3898969994779683855L),
new System.Numerics.BigInteger(8686871374445517524L),
new System.Numerics.BigInteger(8256330183220825077L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5892839402272047620L),
new System.Numerics.BigInteger(3443894598920375795L),
new System.Numerics.BigInteger(2254726057907524319L),
new System.Numerics.BigInteger(4225838178647311206L),
},
},
            new BigIntegernumericArray1M
{
    Id = 95,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5920165424796107062L),
new System.Numerics.BigInteger(3805427836375544619L),
new System.Numerics.BigInteger(4975668413591746568L),
new System.Numerics.BigInteger(352850552425801466L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 104,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5685915197939159544L),
new System.Numerics.BigInteger(925457679421947542L),
new System.Numerics.BigInteger(3143114981166768859L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 59,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2819974567593141420L),
new System.Numerics.BigInteger(2708191586254011568L),
new System.Numerics.BigInteger(484622826548063974L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4085910133563187083L),
new System.Numerics.BigInteger(4378740586920188345L),
new System.Numerics.BigInteger(5550670347319946798L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 113,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5180282391427533721L),
new System.Numerics.BigInteger(1950086804370182066L),
new System.Numerics.BigInteger(8803403894901550881L),
new System.Numerics.BigInteger(2014950660478201016L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7031429982354082261L),
new System.Numerics.BigInteger(7593780123840660611L),
new System.Numerics.BigInteger(5703376565966525928L),
new System.Numerics.BigInteger(6399724652101123689L),
},
},
            new BigIntegernumericArray1M
{
    Id = 120,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2174247450433995709L),
new System.Numerics.BigInteger(945476569416348917L),
new System.Numerics.BigInteger(2050037141866591186L),
new System.Numerics.BigInteger(6504099715744571109L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 66,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6158519664269644791L),
new System.Numerics.BigInteger(7249068531024009955L),
new System.Numerics.BigInteger(5285723966910036401L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3123470706102432908L),
new System.Numerics.BigInteger(6004864726630881726L),
new System.Numerics.BigInteger(1876770348517166855L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2698639076817055195L),
new System.Numerics.BigInteger(656812689143197396L),
new System.Numerics.BigInteger(6523675226859109239L),
},
},
            new BigIntegernumericArray1M
{
    Id = 121,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9102499652998896654L),
new System.Numerics.BigInteger(1882474962611952601L),
new System.Numerics.BigInteger(4601444324983974254L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(767826078973028385L),
new System.Numerics.BigInteger(7919257139295680675L),
new System.Numerics.BigInteger(296167682888561766L),
},
},
            new BigIntegernumericArray1M
{
    Id = 122,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1927885508499898484L),
new System.Numerics.BigInteger(816025933125808232L),
new System.Numerics.BigInteger(2603976448511886509L),
new System.Numerics.BigInteger(8403079504101152225L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 70,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5112881214811346755L),
new System.Numerics.BigInteger(7684854728833557904L),
new System.Numerics.BigInteger(2506846340119972665L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1315178321020350862L),
new System.Numerics.BigInteger(2581928218046490075L),
new System.Numerics.BigInteger(8697692219714844886L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4406560246140542774L),
new System.Numerics.BigInteger(1796898562709900952L),
new System.Numerics.BigInteger(1564881656279222224L),
new System.Numerics.BigInteger(8248635342201379054L),
},
},
            new BigIntegernumericArray1M
{
    Id = 125,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(371735870393658071L),
new System.Numerics.BigInteger(8622525171959252047L),
new System.Numerics.BigInteger(8970679218184844782L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5346732334021325187L),
new System.Numerics.BigInteger(6872682283487237573L),
new System.Numerics.BigInteger(1009866375641094602L),
new System.Numerics.BigInteger(2301152861087692073L),
},
},
            new BigIntegernumericArray1M
{
    Id = 130,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4141698967940319753L),
new System.Numerics.BigInteger(7628006551348010291L),
new System.Numerics.BigInteger(2813564285495637494L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1378935795356040585L),
new System.Numerics.BigInteger(2473617669715165721L),
new System.Numerics.BigInteger(2853425460948457229L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7409925035798626779L),
new System.Numerics.BigInteger(659617415029324464L),
new System.Numerics.BigInteger(6717982261526083670L),
new System.Numerics.BigInteger(3901204576095645088L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3671753711123845435L),
new System.Numerics.BigInteger(1562731386674425075L),
new System.Numerics.BigInteger(4565726320197096643L),
new System.Numerics.BigInteger(9144645784570741750L),
},
},
            new BigIntegernumericArray1M
{
    Id = 138,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5632847513556832660L),
new System.Numerics.BigInteger(2321528097714037002L),
new System.Numerics.BigInteger(910176277148168533L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4249471739496309588L),
new System.Numerics.BigInteger(1896813459775008554L),
new System.Numerics.BigInteger(3198734136407319981L),
new System.Numerics.BigInteger(8139245628934714806L),
},
},
            new BigIntegernumericArray1M
{
    Id = 141,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2183668957624042075L),
new System.Numerics.BigInteger(3528167940660839477L),
new System.Numerics.BigInteger(6231484570042494664L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 84,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5910286108306620090L),
new System.Numerics.BigInteger(3211960814911487910L),
new System.Numerics.BigInteger(6659745579885977592L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(357050038437086237L),
new System.Numerics.BigInteger(6600517235529694211L),
new System.Numerics.BigInteger(8369420149554266134L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 149,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(906998318566272755L),
new System.Numerics.BigInteger(3551350471449661614L),
new System.Numerics.BigInteger(3115914935681789680L),
new System.Numerics.BigInteger(8840571670712544344L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(668240374041576613L),
new System.Numerics.BigInteger(1812870246991972317L),
new System.Numerics.BigInteger(8525497993752874393L),
new System.Numerics.BigInteger(3982713726900687175L),
},
},
            new BigIntegernumericArray1M
{
    Id = 158,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8355579992361891183L),
new System.Numerics.BigInteger(5743098274416081585L),
new System.Numerics.BigInteger(462478349268161577L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 88,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8056688445618273563L),
new System.Numerics.BigInteger(4030176491967677533L),
new System.Numerics.BigInteger(5940447656729415982L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 166,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3635053259866578719L),
new System.Numerics.BigInteger(1613439009953679392L),
new System.Numerics.BigInteger(5857231469249167582L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 171,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8947505338632578755L),
new System.Numerics.BigInteger(7910948256884962838L),
new System.Numerics.BigInteger(8766762444288371069L),
new System.Numerics.BigInteger(2813312806473254511L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 93,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5384848685569808956L),
new System.Numerics.BigInteger(3095290992776828401L),
new System.Numerics.BigInteger(1784726101426442048L),
new System.Numerics.BigInteger(7072751777949986788L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(125733411213894356L),
new System.Numerics.BigInteger(1757509050169023087L),
new System.Numerics.BigInteger(7111093172714210674L),
new System.Numerics.BigInteger(4237502215594404564L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 174,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8501628416126155990L),
new System.Numerics.BigInteger(4709187467509081114L),
new System.Numerics.BigInteger(6581994685944709922L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5978725326254265610L),
new System.Numerics.BigInteger(8406199512682538785L),
new System.Numerics.BigInteger(2059301838380173129L),
},
},
            new BigIntegernumericArray1M
{
    Id = 178,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6919652290435571554L),
new System.Numerics.BigInteger(4576629095781355738L),
new System.Numerics.BigInteger(6049893303454919440L),
new System.Numerics.BigInteger(4707862010994414640L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 99,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5814386036798204480L),
new System.Numerics.BigInteger(3209296185228373905L),
new System.Numerics.BigInteger(2872770080736643037L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6600908127962051555L),
new System.Numerics.BigInteger(7667455376576235321L),
new System.Numerics.BigInteger(5091590293735446675L),
},
},
            new BigIntegernumericArray1M
{
    Id = 182,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1813396855810649958L),
new System.Numerics.BigInteger(5477848174269310815L),
new System.Numerics.BigInteger(3136207613060790985L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2384643653786321878L),
new System.Numerics.BigInteger(2547188722129486981L),
new System.Numerics.BigInteger(3548154401044001833L),
new System.Numerics.BigInteger(7269823479555606946L),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
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

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
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
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
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
                List<BigIntegernumericArray1M> models = null;

                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
                parametr2.Value = 33;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[34], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[4], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[5], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[29],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 141, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 27, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 125, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 130, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 40, query1, 174, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 40, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 86, query1, 3, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[33],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 16, query1, 58, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 141, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[34], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 158, 158))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 71);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[14], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[15], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[16], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[17], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[18], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[19], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[20], false);
                BigIntegernumericArray1M.AssertModel(models[7],_testData[21], false);
                BigIntegernumericArray1M.AssertModel(models[8],_testData[22], false);
                BigIntegernumericArray1M.AssertModel(models[9],_testData[23], false);
                BigIntegernumericArray1M.AssertModel(models[10],_testData[24], false);
                BigIntegernumericArray1M.AssertModel(models[11],_testData[25], false);
                BigIntegernumericArray1M.AssertModel(models[12],_testData[26], false);
                BigIntegernumericArray1M.AssertModel(models[13],_testData[27], false);
                BigIntegernumericArray1M.AssertModel(models[14],_testData[28], false);
                BigIntegernumericArray1M.AssertModel(models[15],_testData[29], false);
                BigIntegernumericArray1M.AssertModel(models[16],_testData[30], false);
                BigIntegernumericArray1M.AssertModel(models[17],_testData[31], false);
                BigIntegernumericArray1M.AssertModel(models[18],_testData[32], false);
                BigIntegernumericArray1M.AssertModel(models[19],_testData[33], false);
                BigIntegernumericArray1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 71);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[14], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[15], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[16], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[17], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[18], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[19], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[20], false);
                BigIntegernumericArray1M.AssertModel(models[7],_testData[21], false);
                BigIntegernumericArray1M.AssertModel(models[8],_testData[22], false);
                BigIntegernumericArray1M.AssertModel(models[9],_testData[23], false);
                BigIntegernumericArray1M.AssertModel(models[10],_testData[24], false);
                BigIntegernumericArray1M.AssertModel(models[11],_testData[25], false);
                BigIntegernumericArray1M.AssertModel(models[12],_testData[26], false);
                BigIntegernumericArray1M.AssertModel(models[13],_testData[27], false);
                BigIntegernumericArray1M.AssertModel(models[14],_testData[28], false);
                BigIntegernumericArray1M.AssertModel(models[15],_testData[29], false);
                BigIntegernumericArray1M.AssertModel(models[16],_testData[30], false);
                BigIntegernumericArray1M.AssertModel(models[17],_testData[31], false);
                BigIntegernumericArray1M.AssertModel(models[18],_testData[32], false);
                BigIntegernumericArray1M.AssertModel(models[19],_testData[33], false);
                BigIntegernumericArray1M.AssertModel(models[20],_testData[34], false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MI),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericArray1M),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
FROM public.binary_bigintegernumericarray1m m
LEFT JOIN public.binary_bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models =  ((IBigIntegerArraynumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI), typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models1 = new List<BigIntegernumericArray1MI>();
                var models2 = new List<BigIntegernumericArray1MI>();
                await ((IBigIntegerArraynumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MI>();
                var models2 = new List<BigIntegernumericArray1MI>();
                ((IBigIntegerArraynumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

