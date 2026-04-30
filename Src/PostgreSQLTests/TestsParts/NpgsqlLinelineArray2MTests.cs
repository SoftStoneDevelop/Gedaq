

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
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.39776678282073163d, b: 0.3871250305970396d, c: 0.5701811046251799d),

new NpgsqlTypes.NpgsqlLine(a: 0.10741677280349726d, b: 0.4007109780560215d, c: 0.40116468010392714d),

new NpgsqlTypes.NpgsqlLine(a: 0.37943672014617624d, b: 0.9992092093602366d, c: 0.5511499764322876d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2549680203633007d, b: 0.9139417711167317d, c: 0.3644166809804452d),

new NpgsqlTypes.NpgsqlLine(a: 0.20936602366260038d, b: 0.2940918409165406d, c: 0.9354863179751355d),

new NpgsqlTypes.NpgsqlLine(a: 0.630703393326831d, b: 0.3918799456306117d, c: 0.5588340176566475d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5864810420715634d, b: 0.18181252428362693d, c: 0.8334246268412147d),

new NpgsqlTypes.NpgsqlLine(a: 0.25692753396202317d, b: 0.7885322802890542d, c: 0.8135212236058875d),

new NpgsqlTypes.NpgsqlLine(a: 0.4496589252447303d, b: 0.4805710652451657d, c: 0.6647617436118302d),

new NpgsqlTypes.NpgsqlLine(a: 0.9384906697561243d, b: 0.36166444977676926d, c: 0.8581096742921099d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3928567180965542d, b: 0.23909236236505926d, c: 0.17344194741830088d),

new NpgsqlTypes.NpgsqlLine(a: 0.11508003430333857d, b: 0.0471051277038913d, c: 0.640277537421454d),

new NpgsqlTypes.NpgsqlLine(a: 0.8346603385325075d, b: 0.046779950568747064d, c: 0.9913668721968991d),

new NpgsqlTypes.NpgsqlLine(a: 0.9189778273118068d, b: 0.255461662452674d, c: 0.13336462798809723d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4239792152122822d, b: 0.4802429350859244d, c: 0.6472402600762482d),

new NpgsqlTypes.NpgsqlLine(a: 0.2985834694808208d, b: 0.9648385192012231d, c: 0.8969792587052394d),

new NpgsqlTypes.NpgsqlLine(a: 0.5081637719327557d, b: 0.3974633163071023d, c: 0.15964470264540986d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17803773190094208d, b: 0.3891062048624122d, c: 0.7718403615799286d),

new NpgsqlTypes.NpgsqlLine(a: 0.6396244714078158d, b: 0.014852769986998804d, c: 0.6060519822573464d),

new NpgsqlTypes.NpgsqlLine(a: 0.1333505965581635d, b: 0.689057986060947d, c: 0.9037320052346832d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12853534050311843d, b: 0.18528026110403706d, c: 0.6042619403474312d),

new NpgsqlTypes.NpgsqlLine(a: 0.07947367140702699d, b: 0.07546874609179544d, c: 0.010668722383119222d),

new NpgsqlTypes.NpgsqlLine(a: 0.8949503572742198d, b: 0.04932079666383782d, c: 0.30580673575173434d),

new NpgsqlTypes.NpgsqlLine(a: 0.4255233590012476d, b: 0.5720579484258419d, c: 0.702701078967079d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666857427791536d, b: 0.7307077332020431d, c: 0.8001714447551058d),

new NpgsqlTypes.NpgsqlLine(a: 0.1735176552533434d, b: 0.39496530318951917d, c: 0.7884056374681666d),

new NpgsqlTypes.NpgsqlLine(a: 0.11159650890490846d, b: 0.47621545502915064d, c: 0.1754739169136147d),

new NpgsqlTypes.NpgsqlLine(a: 0.8847045769362938d, b: 0.39914616515287726d, c: 0.48421415438999615d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4154355426027194d, b: 0.9653664191045656d, c: 0.10352309503873491d),

new NpgsqlTypes.NpgsqlLine(a: 0.045085045683865954d, b: 0.7468085253096738d, c: 0.30574074385353656d),

new NpgsqlTypes.NpgsqlLine(a: 0.13958043098631134d, b: 0.6917264382459903d, c: 0.9147502944445866d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8662281733640839d, b: 0.28973037969413695d, c: 0.493481078620456d),

new NpgsqlTypes.NpgsqlLine(a: 0.9070373601000055d, b: 0.9706983880755133d, c: 0.18133123414696517d),

new NpgsqlTypes.NpgsqlLine(a: 0.970022505034384d, b: 0.7893001612172619d, c: 0.6249017992903688d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.09276195362135908d, b: 0.5945016234992904d, c: 0.3894642195658419d),

new NpgsqlTypes.NpgsqlLine(a: 0.46643530187900273d, b: 0.6094527650781911d, c: 0.8795042560399303d),

new NpgsqlTypes.NpgsqlLine(a: 0.3396815399150349d, b: 0.856196459104634d, c: 0.5941901661409487d),

new NpgsqlTypes.NpgsqlLine(a: 0.5221810974241714d, b: 0.47761518308168105d, c: 0.5495483058903131d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.49148719601164625d, b: 0.2981884721172884d, c: 0.21164388093313213d),

new NpgsqlTypes.NpgsqlLine(a: 0.18332070294863112d, b: 0.797960859274056d, c: 0.2754222532166969d),

new NpgsqlTypes.NpgsqlLine(a: 0.7858627500710746d, b: 0.9868410129208699d, c: 0.26481571018914496d),

new NpgsqlTypes.NpgsqlLine(a: 0.24659130366651905d, b: 0.673195392210001d, c: 0.9820254489985532d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5581451784844d, b: 0.3424223396579239d, c: 0.45371821001009105d),

new NpgsqlTypes.NpgsqlLine(a: 0.9049190567464319d, b: 0.6543694089797034d, c: 0.43332819562000324d),

new NpgsqlTypes.NpgsqlLine(a: 0.7954003536152597d, b: 0.24260358049023778d, c: 0.7750792578069032d),

new NpgsqlTypes.NpgsqlLine(a: 0.8496585484472484d, b: 0.24687143157932423d, c: 0.21974308318159952d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9897326129230679d, b: 0.3526270042524591d, c: 0.7106343371936251d),

new NpgsqlTypes.NpgsqlLine(a: 0.48670969964338373d, b: 0.9634458680710866d, c: 0.17193963603921547d),

new NpgsqlTypes.NpgsqlLine(a: 0.8676093874737243d, b: 0.4261459361949329d, c: 0.5147019771730311d),

new NpgsqlTypes.NpgsqlLine(a: 0.2389428654343514d, b: 0.2441276360263478d, c: 0.5349037020942788d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12805532249854745d, b: 0.37776695645795233d, c: 0.07049827470933501d),

new NpgsqlTypes.NpgsqlLine(a: 0.7403711330819454d, b: 0.9625053892436269d, c: 0.900737952110165d),

new NpgsqlTypes.NpgsqlLine(a: 0.052990385437356124d, b: 0.06391732422336227d, c: 0.5680273401285695d),

new NpgsqlTypes.NpgsqlLine(a: 0.40489122185446336d, b: 0.6050176539513293d, c: 0.20598254350729772d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8607470658753332d, b: 0.11457605268217219d, c: 0.6412437830036989d),

new NpgsqlTypes.NpgsqlLine(a: 0.12999845512891295d, b: 0.685202243576821d, c: 0.3953954702811894d),

new NpgsqlTypes.NpgsqlLine(a: 0.4151306719370571d, b: 0.30047593972647857d, c: 0.7551996036083991d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2435671313379123d, b: 0.8098362975374629d, c: 0.510042266948811d),

new NpgsqlTypes.NpgsqlLine(a: 0.5278952312466169d, b: 0.7245879628396554d, c: 0.818069854935386d),

new NpgsqlTypes.NpgsqlLine(a: 0.40822220174041424d, b: 0.009233098195422285d, c: 0.827665924384646d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5507394493952906d, b: 0.0324175067396415d, c: 0.07537204860315583d),

new NpgsqlTypes.NpgsqlLine(a: 0.5028168337908976d, b: 0.046503351486259836d, c: 0.43426159183732016d),

new NpgsqlTypes.NpgsqlLine(a: 0.00020008834516960228d, b: 0.5904338562722861d, c: 0.17496306915262783d),

new NpgsqlTypes.NpgsqlLine(a: 0.6247299304980655d, b: 0.8984760613197615d, c: 0.934717771544926d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7672657951219497d, b: 0.4135776956553441d, c: 0.918999478342302d),

new NpgsqlTypes.NpgsqlLine(a: 0.40309684725739225d, b: 0.060479362685483595d, c: 0.5541407831425058d),

new NpgsqlTypes.NpgsqlLine(a: 0.5105963696887404d, b: 0.7633529667191316d, c: 0.8047989795020376d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5746251569509127d, b: 0.6651154412488225d, c: 0.8620550983226837d),

new NpgsqlTypes.NpgsqlLine(a: 0.2165735615603933d, b: 0.9123646477291821d, c: 0.2027895023239259d),

new NpgsqlTypes.NpgsqlLine(a: 0.41939454045421787d, b: 0.08984280041047621d, c: 0.6475962686941521d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5220305745454915d, b: 0.6523796071780498d, c: 0.3195016804615838d),

new NpgsqlTypes.NpgsqlLine(a: 0.7975348561629096d, b: 0.0676145839089426d, c: 0.5257932230399557d),

new NpgsqlTypes.NpgsqlLine(a: 0.9282901327442411d, b: 0.05598737798374098d, c: 0.7763954324658136d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7684782232216756d, b: 0.8184174199404916d, c: 0.7508305934319381d),

new NpgsqlTypes.NpgsqlLine(a: 0.2436856915454063d, b: 0.17292803597704454d, c: 0.7601980234204776d),

new NpgsqlTypes.NpgsqlLine(a: 0.6993019731855288d, b: 0.07788910335881571d, c: 0.27810358740072505d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5487623754838514d, b: 0.0033347115825324014d, c: 0.4173273831512637d),

new NpgsqlTypes.NpgsqlLine(a: 0.8466162932772017d, b: 0.3690892608271992d, c: 0.13305714648128175d),

new NpgsqlTypes.NpgsqlLine(a: 0.30924219110669793d, b: 0.032074157214396215d, c: 0.9162083219626221d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22869318664541272d, b: 0.10114220185612732d, c: 0.9097180612993704d),

new NpgsqlTypes.NpgsqlLine(a: 0.47673777440207776d, b: 0.4568688184818437d, c: 0.3988139969849983d),

new NpgsqlTypes.NpgsqlLine(a: 0.1614462074145674d, b: 0.8135767319344481d, c: 0.08104786438836897d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12344374312518691d, b: 0.6350896504125473d, c: 0.893938155664515d),

new NpgsqlTypes.NpgsqlLine(a: 0.9914079873979441d, b: 0.8694986922007333d, c: 0.4393452109272592d),

new NpgsqlTypes.NpgsqlLine(a: 0.9595372733387293d, b: 0.06992476086410404d, c: 0.317116910250535d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5988176568893927d, b: 0.7328665828026153d, c: 0.49046617959213523d),

new NpgsqlTypes.NpgsqlLine(a: 0.619674582920975d, b: 0.7991113684413619d, c: 0.31122581385647563d),

new NpgsqlTypes.NpgsqlLine(a: 0.7673715313461187d, b: 0.38041882090262025d, c: 0.3440551473876081d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8426438643032959d, b: 0.38812846558457204d, c: 0.4519419141864144d),

new NpgsqlTypes.NpgsqlLine(a: 0.23565166975465368d, b: 0.24501216516133528d, c: 0.2777232807277684d),

new NpgsqlTypes.NpgsqlLine(a: 0.23396934444534d, b: 0.9211249817092497d, c: 0.28700032782658147d),

new NpgsqlTypes.NpgsqlLine(a: 0.07675731072961967d, b: 0.3228702915377002d, c: 0.2189252635974448d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08271612634047187d, b: 0.7982309472731943d, c: 0.24740641689156417d),

new NpgsqlTypes.NpgsqlLine(a: 0.47163392089069756d, b: 0.10457824851098829d, c: 0.8228239601574879d),

new NpgsqlTypes.NpgsqlLine(a: 0.5501463592957996d, b: 0.7319821150475395d, c: 0.5750703034563528d),

new NpgsqlTypes.NpgsqlLine(a: 0.26231129247700236d, b: 0.576553805693921d, c: 0.7485631681804862d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.796683309919609d, b: 0.9400228755845454d, c: 0.849560850831421d),

new NpgsqlTypes.NpgsqlLine(a: 0.10397608629031951d, b: 0.6464602775101068d, c: 0.6637816284235928d),

new NpgsqlTypes.NpgsqlLine(a: 0.5252468996970636d, b: 0.5506828699158929d, c: 0.005328245724007807d),

new NpgsqlTypes.NpgsqlLine(a: 0.13599934322952822d, b: 0.3039679103642404d, c: 0.7775882777752854d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42974585437174917d, b: 0.1846944167376482d, c: 0.6707349227443588d),

new NpgsqlTypes.NpgsqlLine(a: 0.632683066221249d, b: 0.44085731756306157d, c: 0.35336970822794955d),

new NpgsqlTypes.NpgsqlLine(a: 0.5483039556904672d, b: 0.25174410902038724d, c: 0.34069399140844303d),

new NpgsqlTypes.NpgsqlLine(a: 0.24896052962446813d, b: 0.5922568093512041d, c: 0.6405827085196775d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03032766165930867d, b: 0.4094599035775419d, c: 0.850144533289962d),

new NpgsqlTypes.NpgsqlLine(a: 0.9516497209515254d, b: 0.4408512497875041d, c: 0.5607158003340071d),

new NpgsqlTypes.NpgsqlLine(a: 0.2301914081302412d, b: 0.7732232515301066d, c: 0.3968143055967458d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5932928107335033d, b: 0.6595620793475689d, c: 0.45676097848937014d),

new NpgsqlTypes.NpgsqlLine(a: 0.7651394716516293d, b: 0.9356268456237136d, c: 0.7841173350296753d),

new NpgsqlTypes.NpgsqlLine(a: 0.7393550283472824d, b: 0.49993644530568127d, c: 0.5144566949216693d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3285665290144343d, b: 0.4685056428368418d, c: 0.6655125577701022d),

new NpgsqlTypes.NpgsqlLine(a: 0.43005689729538d, b: 0.1708422393723389d, c: 0.16633636154234466d),

new NpgsqlTypes.NpgsqlLine(a: 0.9341579640264192d, b: 0.8824324190826459d, c: 0.49196373019526907d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.773930175847187d, b: 0.6850385938395647d, c: 0.23940716524239314d),

new NpgsqlTypes.NpgsqlLine(a: 0.5809912410142435d, b: 0.8263586746813036d, c: 0.3446497780015305d),

new NpgsqlTypes.NpgsqlLine(a: 0.9540326212109612d, b: 0.024471600834933604d, c: 0.3370304244768708d),

new NpgsqlTypes.NpgsqlLine(a: 0.08642657180940394d, b: 0.8634167828886886d, c: 0.8592920000068137d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4004595180274889d, b: 0.5426463883024862d, c: 0.2146303858221742d),

new NpgsqlTypes.NpgsqlLine(a: 0.4382768468093432d, b: 0.3810064249426005d, c: 0.5088235787517652d),

new NpgsqlTypes.NpgsqlLine(a: 0.7090856085704352d, b: 0.21971028783224444d, c: 0.31918558229712024d),

new NpgsqlTypes.NpgsqlLine(a: 0.12162063683566038d, b: 0.01271955781832046d, c: 0.0459909514747836d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6816300327710173d, b: 0.716546964548396d, c: 0.5475381874233478d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386966582306843d, b: 0.9007380022930526d, c: 0.605760197583384d),

new NpgsqlTypes.NpgsqlLine(a: 0.04442313138633769d, b: 0.9673557526997806d, c: 0.7623606360116904d),

new NpgsqlTypes.NpgsqlLine(a: 0.8695943334426733d, b: 0.7215652430448432d, c: 0.3792699860585381d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.338984697134347d, b: 0.04898756547075811d, c: 0.8034878980199073d),

new NpgsqlTypes.NpgsqlLine(a: 0.5347550439301156d, b: 0.28574783157821226d, c: 0.7790647158104258d),

new NpgsqlTypes.NpgsqlLine(a: 0.3144014144617958d, b: 0.1791421457923119d, c: 0.03127543773956887d),

new NpgsqlTypes.NpgsqlLine(a: 0.12467527612646612d, b: 0.2723621118565599d, c: 0.4534016540950401d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6076548415101856d, b: 0.2721421694285584d, c: 0.8836748132101873d),

new NpgsqlTypes.NpgsqlLine(a: 0.44362807709376495d, b: 0.4458204817378113d, c: 0.35535634915010506d),

new NpgsqlTypes.NpgsqlLine(a: 0.8279468329288449d, b: 0.6575072916885258d, c: 0.8066348921303119d),

new NpgsqlTypes.NpgsqlLine(a: 0.5082193664302195d, b: 0.9929444373074156d, c: 0.3714866135855982d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.02643623177303256d, b: 0.1681350351641473d, c: 0.22008431957391794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9393086883492185d, b: 0.6300210289835281d, c: 0.5485355055358675d),

new NpgsqlTypes.NpgsqlLine(a: 0.6339266321847753d, b: 0.644094298968445d, c: 0.4783562165843134d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15397134223889208d, b: 0.5311894957788887d, c: 0.0476717734745844d),

new NpgsqlTypes.NpgsqlLine(a: 0.981351592228809d, b: 0.3354834931146229d, c: 0.621282819856902d),

new NpgsqlTypes.NpgsqlLine(a: 0.06723967909082673d, b: 0.13205143051947577d, c: 0.9823299393034726d),

new NpgsqlTypes.NpgsqlLine(a: 0.19070161742611436d, b: 0.2306477026092032d, c: 0.7324173109254696d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22849787030507107d, b: 0.17537020628845024d, c: 0.7761797026111904d),

new NpgsqlTypes.NpgsqlLine(a: 0.37482511872135793d, b: 0.5900666063616756d, c: 0.9953703238661762d),

new NpgsqlTypes.NpgsqlLine(a: 0.5777644324673875d, b: 0.9521780067743025d, c: 0.9459131804049685d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6843256382750106d, b: 0.8893100177706722d, c: 0.3934434702369478d),

new NpgsqlTypes.NpgsqlLine(a: 0.3937635530674952d, b: 0.35370257314923126d, c: 0.687802189514004d),

new NpgsqlTypes.NpgsqlLine(a: 0.11495925384986783d, b: 0.057660596364726535d, c: 0.9516697991117179d),

new NpgsqlTypes.NpgsqlLine(a: 0.6136207594826182d, b: 0.5533563225630075d, c: 0.8194051340444747d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4299475151633293d, b: 0.9834626622625545d, c: 0.7595600453361453d),

new NpgsqlTypes.NpgsqlLine(a: 0.22675057758708905d, b: 0.04735110773365525d, c: 0.40558911032678435d),

new NpgsqlTypes.NpgsqlLine(a: 0.7964164782222536d, b: 0.4324018253702553d, c: 0.6999145520604073d),

new NpgsqlTypes.NpgsqlLine(a: 0.8166705340659998d, b: 0.9151223470650254d, c: 0.4616929133519354d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9500402235091588d, b: 0.14700864415757564d, c: 0.42722624753087957d),

new NpgsqlTypes.NpgsqlLine(a: 0.6471467565365512d, b: 0.9471705224734399d, c: 0.4393252346785306d),

new NpgsqlTypes.NpgsqlLine(a: 0.0687150470447937d, b: 0.17635510706368074d, c: 0.8495569432505147d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2286124508374039d, b: 0.8299152580831053d, c: 0.7486900861215613d),

new NpgsqlTypes.NpgsqlLine(a: 0.5082736159959468d, b: 0.6814608795943056d, c: 0.055910129718540036d),

new NpgsqlTypes.NpgsqlLine(a: 0.38213952273385066d, b: 0.8895173542482143d, c: 0.06272786310101419d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8667573191261045d, b: 0.5049550069422d, c: 0.6256438319518156d),

new NpgsqlTypes.NpgsqlLine(a: 0.31163103696845196d, b: 0.9976714355161099d, c: 0.6132239643540803d),

new NpgsqlTypes.NpgsqlLine(a: 0.394975051788206d, b: 0.027179791361860106d, c: 0.02956311819255053d),

new NpgsqlTypes.NpgsqlLine(a: 0.49319369988425277d, b: 0.6666857963534131d, c: 0.15610778432869665d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7861134666844246d, b: 0.12874258715027953d, c: 0.8856156365699756d),

new NpgsqlTypes.NpgsqlLine(a: 0.4145483861559268d, b: 0.9514373751923119d, c: 0.10862012958537226d),

new NpgsqlTypes.NpgsqlLine(a: 0.0038724060764475654d, b: 0.27103579816449463d, c: 0.9588791671330869d),

new NpgsqlTypes.NpgsqlLine(a: 0.8061522064869091d, b: 0.27901673492023227d, c: 0.9525448800684526d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.19268343404354915d, b: 0.32783720779602277d, c: 0.1091442290060558d),

new NpgsqlTypes.NpgsqlLine(a: 0.5654890677433848d, b: 0.15891758509836562d, c: 0.2500958733949298d),

new NpgsqlTypes.NpgsqlLine(a: 0.6706334574755121d, b: 0.6789647519544061d, c: 0.6293508811759183d),

new NpgsqlTypes.NpgsqlLine(a: 0.32769738839100515d, b: 0.4460580932173638d, c: 0.5807580244957296d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5815204426523831d, b: 0.15184317564837935d, c: 0.32912425052702066d),

new NpgsqlTypes.NpgsqlLine(a: 0.636401894517637d, b: 0.241390945981366d, c: 0.672985572856161d),

new NpgsqlTypes.NpgsqlLine(a: 0.6629072078104609d, b: 0.4473877638238738d, c: 0.9401965547445951d),

new NpgsqlTypes.NpgsqlLine(a: 0.9480303030142824d, b: 0.8255793223246458d, c: 0.102171852259762d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6011146377214605d, b: 0.11623830971798699d, c: 0.8304265895224981d),

new NpgsqlTypes.NpgsqlLine(a: 0.6575841300003863d, b: 0.17843511143448498d, c: 0.9066024894297616d),

new NpgsqlTypes.NpgsqlLine(a: 0.18486987786266917d, b: 0.2641889910945098d, c: 0.2996266665342794d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5960619358905551d, b: 0.6162534315956426d, c: 0.3282639423949243d),

new NpgsqlTypes.NpgsqlLine(a: 0.8812206489720601d, b: 0.13061001426593888d, c: 0.14229457652298128d),

new NpgsqlTypes.NpgsqlLine(a: 0.007154085972494562d, b: 0.4288681869601173d, c: 0.06253166094290408d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1396925721034562d, b: 0.5769370603515699d, c: 0.48801330233838847d),

new NpgsqlTypes.NpgsqlLine(a: 0.8411679072874708d, b: 0.3055349377016152d, c: 0.12829556236540207d),

new NpgsqlTypes.NpgsqlLine(a: 0.4934428593070983d, b: 0.13120646011656878d, c: 0.20916250838979733d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7093639524482964d, b: 0.9207140398684671d, c: 0.6290980503008355d),

new NpgsqlTypes.NpgsqlLine(a: 0.7252031061483308d, b: 0.4408258598255925d, c: 0.9628203615806142d),

new NpgsqlTypes.NpgsqlLine(a: 0.9860297382849836d, b: 0.13711489480534134d, c: 0.46738128101720045d),

new NpgsqlTypes.NpgsqlLine(a: 0.3897497937954152d, b: 0.37659151978607397d, c: 0.535004804799326d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8403343724682631d, b: 0.08956888738076274d, c: 0.15216815006041207d),

new NpgsqlTypes.NpgsqlLine(a: 0.8627982409893559d, b: 0.4548135360861063d, c: 0.8379327146935861d),

new NpgsqlTypes.NpgsqlLine(a: 0.06362449874997089d, b: 0.44690427718085957d, c: 0.8993020194842789d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6811185435950897d, b: 0.7576441522576889d, c: 0.7830295395596092d),

new NpgsqlTypes.NpgsqlLine(a: 0.620300824738084d, b: 0.7200387945580056d, c: 0.5184986646571489d),

new NpgsqlTypes.NpgsqlLine(a: 0.2456050955722774d, b: 0.6733198961915079d, c: 0.5056733886854687d),

new NpgsqlTypes.NpgsqlLine(a: 0.40083941475234164d, b: 0.0124080899909077d, c: 0.27102392425966837d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6518428047416135d, b: 0.9347718678185095d, c: 0.209040535141801d),

new NpgsqlTypes.NpgsqlLine(a: 0.5523178371847757d, b: 0.8706335764492648d, c: 0.5260741588014012d),

new NpgsqlTypes.NpgsqlLine(a: 0.32807787390052734d, b: 0.06677839683643993d, c: 0.38133296206703693d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7387557824656195d, b: 0.05346897684466778d, c: 0.013132503607220958d),

new NpgsqlTypes.NpgsqlLine(a: 0.2287589816558162d, b: 0.13594860842224332d, c: 0.579058365510739d),

new NpgsqlTypes.NpgsqlLine(a: 0.03971193001461193d, b: 0.9386798821318291d, c: 0.8568801027064263d),

new NpgsqlTypes.NpgsqlLine(a: 0.8644508683425534d, b: 0.6957244987406672d, c: 0.2312298460389648d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.889517288154401d, b: 0.2609150376662073d, c: 0.8572334393186894d),

new NpgsqlTypes.NpgsqlLine(a: 0.24897436375600357d, b: 0.3760898939699795d, c: 0.7210572965878953d),

new NpgsqlTypes.NpgsqlLine(a: 0.6445043932548553d, b: 0.09481960359230646d, c: 0.7751526505893953d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14935643520273123d, b: 0.9806612458776498d, c: 0.6722532591981559d),

new NpgsqlTypes.NpgsqlLine(a: 0.05531678721534394d, b: 0.5997359472484612d, c: 0.28039306887557514d),

new NpgsqlTypes.NpgsqlLine(a: 0.2894360842316266d, b: 0.11117435669146303d, c: 0.2913691349330009d),

new NpgsqlTypes.NpgsqlLine(a: 0.3265517404839776d, b: 0.7575581599297653d, c: 0.3337476673447437d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.542178863837509d, b: 0.04716899389675455d, c: 0.9472733276331627d),

new NpgsqlTypes.NpgsqlLine(a: 0.49833848147200666d, b: 0.057932576555494886d, c: 0.35563198222352777d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289837079210509d, b: 0.4469149014587509d, c: 0.3994013206037418d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5986655825841518d, b: 0.017829202004645772d, c: 0.1020539754658244d),

new NpgsqlTypes.NpgsqlLine(a: 0.7018091157676956d, b: 0.32422613177025206d, c: 0.9417021176837648d),

new NpgsqlTypes.NpgsqlLine(a: 0.2379979839105374d, b: 0.8677638479062244d, c: 0.1705611424750184d),

new NpgsqlTypes.NpgsqlLine(a: 0.4387143094692172d, b: 0.9448168167814673d, c: 0.5937240443986447d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6009407749745134d, b: 0.9767510365463702d, c: 0.95869466194445d),

new NpgsqlTypes.NpgsqlLine(a: 0.2593900544759613d, b: 0.051592973236370465d, c: 0.5329506905355047d),

new NpgsqlTypes.NpgsqlLine(a: 0.6212241866797596d, b: 0.556360254212799d, c: 0.010281971802472478d),

new NpgsqlTypes.NpgsqlLine(a: 0.8240026834299514d, b: 0.8331067238480111d, c: 0.9764293551700706d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13664722487545977d, b: 0.5096648426775858d, c: 0.2673441177807935d),

new NpgsqlTypes.NpgsqlLine(a: 0.7851813442634958d, b: 0.3532975246469573d, c: 0.6679045766635453d),

new NpgsqlTypes.NpgsqlLine(a: 0.559088018975528d, b: 0.5108022319081245d, c: 0.6921370533012002d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9332069435197d, b: 0.9342492730363922d, c: 0.04513917625359043d),

new NpgsqlTypes.NpgsqlLine(a: 0.7390898213042635d, b: 0.4830870939101465d, c: 0.41789319980859785d),

new NpgsqlTypes.NpgsqlLine(a: 0.7835767910742147d, b: 0.6675050325976237d, c: 0.6664623081296829d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7331874116035042d, b: 0.8208003658891477d, c: 0.7452564970630494d),

new NpgsqlTypes.NpgsqlLine(a: 0.9847367248587641d, b: 0.627195968039234d, c: 0.4207405763028872d),

new NpgsqlTypes.NpgsqlLine(a: 0.271325072333199d, b: 0.5187713438897269d, c: 0.9919315622849715d),

new NpgsqlTypes.NpgsqlLine(a: 0.1684090883219168d, b: 0.5655402285383935d, c: 0.7220715044272488d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10576769356660876d, b: 0.22375343436579131d, c: 0.06548436096951693d),

new NpgsqlTypes.NpgsqlLine(a: 0.43797110432699005d, b: 0.25269830005777405d, c: 0.8100859691351623d),

new NpgsqlTypes.NpgsqlLine(a: 0.17238607939727124d, b: 0.3833844320141736d, c: 0.5677242960471357d),

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
new NpgsqlTypes.NpgsqlLine(a: 0.06582294018183099d, b: 0.8821170729970839d, c: 0.5326409518308972d),

new NpgsqlTypes.NpgsqlLine(a: 0.7293854905901725d, b: 0.19772144351422116d, c: 0.20495940778595378d),

new NpgsqlTypes.NpgsqlLine(a: 0.022693857036725995d, b: 0.05735909753576385d, c: 0.4063188284959076d),

new NpgsqlTypes.NpgsqlLine(a: 0.07877783773810365d, b: 0.9329774606606108d, c: 0.5062538001976807d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20948211600652933d, b: 0.594865552087384d, c: 0.3004597538905446d),

new NpgsqlTypes.NpgsqlLine(a: 0.35904593418268815d, b: 0.63697794309698d, c: 0.2704410909435674d),

new NpgsqlTypes.NpgsqlLine(a: 0.722897726054918d, b: 0.7254066144492787d, c: 0.3604659327516416d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5907002806301294d, b: 0.1816384740308078d, c: 0.4891248848791151d),

new NpgsqlTypes.NpgsqlLine(a: 0.7626005577777741d, b: 0.9150490448492621d, c: 0.07775319570642936d),

new NpgsqlTypes.NpgsqlLine(a: 0.42155273551464956d, b: 0.671401884295538d, c: 0.8129572516453437d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9011307620562149d, b: 0.6264183443924577d, c: 0.8705523930588165d),

new NpgsqlTypes.NpgsqlLine(a: 0.841064085034019d, b: 0.2260291928551429d, c: 0.2475998412322531d),

new NpgsqlTypes.NpgsqlLine(a: 0.8334318470009503d, b: 0.4897851207329119d, c: 0.5503329538559663d),

new NpgsqlTypes.NpgsqlLine(a: 0.7267556387223104d, b: 0.31565959819570744d, c: 0.3894088294206154d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3609939157343621d, b: 0.5089586328074792d, c: 0.2998892126276729d),

new NpgsqlTypes.NpgsqlLine(a: 0.25788272337147533d, b: 0.2103531953156249d, c: 0.9568905965142065d),

new NpgsqlTypes.NpgsqlLine(a: 0.06631000224629757d, b: 0.9309178650169146d, c: 0.2932666345924754d),

new NpgsqlTypes.NpgsqlLine(a: 0.033526459488394944d, b: 0.4471745277184761d, c: 0.14900630539102777d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4936072163088544d, b: 0.17283814973958467d, c: 0.02455182284633095d),

new NpgsqlTypes.NpgsqlLine(a: 0.2559987885912305d, b: 0.540534583327985d, c: 0.6397516557394637d),

new NpgsqlTypes.NpgsqlLine(a: 0.17662679933725045d, b: 0.6585171071993041d, c: 0.1950102075020974d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14968350437472944d, b: 0.8836911377250947d, c: 0.8896566252051569d),

new NpgsqlTypes.NpgsqlLine(a: 0.5388292873409755d, b: 0.2173741292133844d, c: 0.2529063427605268d),

new NpgsqlTypes.NpgsqlLine(a: 0.18815532170694282d, b: 0.45191270110407467d, c: 0.6509031997070931d),

new NpgsqlTypes.NpgsqlLine(a: 0.6324331752291174d, b: 0.07394454199591882d, c: 0.20029931865232797d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9043742425360878d, b: 0.4114569071344103d, c: 0.012519842295166561d),

new NpgsqlTypes.NpgsqlLine(a: 0.2584204117766915d, b: 0.0306715649600533d, c: 0.14013697397018754d),

new NpgsqlTypes.NpgsqlLine(a: 0.3993853772217507d, b: 0.48004085218094306d, c: 0.1970693680927027d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4886425123162924d, b: 0.2300229754220665d, c: 0.03383566095323498d),

new NpgsqlTypes.NpgsqlLine(a: 0.5625143391071591d, b: 0.6522285210581564d, c: 0.6304934601205918d),

new NpgsqlTypes.NpgsqlLine(a: 0.677902014516425d, b: 0.6704684278943365d, c: 0.660584070752529d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5770609807637661d, b: 0.6454073914571465d, c: 0.7234875832827323d),

new NpgsqlTypes.NpgsqlLine(a: 0.8314635713852174d, b: 0.7034513070689059d, c: 0.5351540898911259d),

new NpgsqlTypes.NpgsqlLine(a: 0.45698429515036965d, b: 0.4540573520148341d, c: 0.5119223381970368d),

new NpgsqlTypes.NpgsqlLine(a: 0.1660016114034948d, b: 0.11306177718214727d, c: 0.3860023409048364d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7740009225003555d, b: 0.30015344596600135d, c: 0.3529586944864066d),

new NpgsqlTypes.NpgsqlLine(a: 0.09935538233446117d, b: 0.6133103277113405d, c: 0.4878019007878738d),

new NpgsqlTypes.NpgsqlLine(a: 0.39498160956822437d, b: 0.8858035991100897d, c: 0.8699902781873898d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.009220423146007795d, b: 0.22745833194004894d, c: 0.22742186303775125d),

new NpgsqlTypes.NpgsqlLine(a: 0.6137645931535489d, b: 0.51084941708742d, c: 0.7818003220855003d),

new NpgsqlTypes.NpgsqlLine(a: 0.7921711805302989d, b: 0.8946198883609283d, c: 0.6404124293793608d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1869742603992922d, b: 0.5868373160151686d, c: 0.38400824018522417d),

new NpgsqlTypes.NpgsqlLine(a: 0.6258573928065123d, b: 0.7875739853867292d, c: 0.8796132268622266d),

new NpgsqlTypes.NpgsqlLine(a: 0.3613583984856956d, b: 0.6661569042637904d, c: 0.19421021657034665d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6548410040470747d, b: 0.3363669602114102d, c: 0.011374771939447026d),

new NpgsqlTypes.NpgsqlLine(a: 0.012059841581894326d, b: 0.6377491635173984d, c: 0.080285063489274d),

new NpgsqlTypes.NpgsqlLine(a: 0.7997132105916215d, b: 0.03111770175078521d, c: 0.7866759518750012d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7631411371750292d, b: 0.6928788497084127d, c: 0.22787220261223207d),

new NpgsqlTypes.NpgsqlLine(a: 0.46060648259011194d, b: 0.11799011073969845d, c: 0.08104852870992985d),

new NpgsqlTypes.NpgsqlLine(a: 0.758760156123947d, b: 0.3418721767235233d, c: 0.4938490825505145d),

new NpgsqlTypes.NpgsqlLine(a: 0.5262358226342962d, b: 0.46987941956688306d, c: 0.8874785587320612d),

},
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[34], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[34], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 23;
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
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[34], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[33],_testData[34], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 118, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 118, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[34], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 158, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[34], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 99, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 131, query1, 138, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[34], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 138, query1, 131, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 23, query1, 142, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 126, query1, 38, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 82, 131))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 23, 93))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[34], false);
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
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[29], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[30], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[31], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[32], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[33], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[29], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[30], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[31], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[32], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[33], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[34], false);
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
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            dbTypes: null,
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlLineListlineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlLineListlineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI), typeof(NpgsqlLinelineArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                await ((INpgsqlLineListlineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                ((INpgsqlLineListlineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
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
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
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
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlLineListlineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            dbTypes: null,
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
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
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

