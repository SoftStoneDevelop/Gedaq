

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.011265414114753347d, y: 0.023682833844388185d), radius: 0.9306056273968878d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10496464003810457d, y: 0.00037886480462501204d), radius: 0.29699147425761563d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3500469377132198d, y: 0.32158784606147073d), radius: 0.40006118808104596d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8907220958366975d, y: 0.7287051732430188d), radius: 0.21532537872244217d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17012258763145127d, y: 0.18641021607057373d), radius: 0.26177829582239986d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9795749604395054d, y: 0.4002532123829171d), radius: 0.3559317390197334d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7373148532669728d, y: 0.3162093669683823d), radius: 0.6637911907473937d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9235482197856013d, y: 0.9877557944135222d), radius: 0.2998278140934494d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08709332453436536d, y: 0.7731159115902588d), radius: 0.6380590182474342d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38690220837553213d, y: 0.7902088486463249d), radius: 0.7245850577326223d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6263221867208086d, y: 0.26883618042122703d), radius: 0.2064838227939767d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8135111537780912d, y: 0.15917542403569251d), radius: 0.3287180050828017d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11997541351217011d, y: 0.4379341716268321d), radius: 0.6310911521541434d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1319329668827599d, y: 0.006340744048923153d), radius: 0.7529112177745602d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.036108300780917646d, y: 0.6793469874967732d), radius: 0.7550910901236885d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.896345634617551d, y: 0.093570074425259d), radius: 0.8930690031100605d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4095429858076385d, y: 0.6712843929147281d), radius: 0.31735632954832516d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25568648383131987d, y: 0.7566030782610026d), radius: 0.7803013724618356d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13822427324843956d, y: 0.5098030152732461d), radius: 0.28519581067989486d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3322151779178226d, y: 0.15380945899529774d), radius: 0.22504370215438363d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4682174086957168d, y: 0.9905888301058907d), radius: 0.9039268963036281d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06844543634543399d, y: 0.3513701184006395d), radius: 0.03219742338170195d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9756422302414517d, y: 0.842142886315975d), radius: 0.034679069816548336d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.741555251172227d, y: 0.8886423698778867d), radius: 0.5085084712964145d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.740938007348697d, y: 0.6440877464676242d), radius: 0.7739138066866397d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.413741630081216d, y: 0.6398744974088344d), radius: 0.20031116350116007d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01149524499792609d, y: 0.7585411133052893d), radius: 0.15422795358734342d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8416163643248259d, y: 0.7084010157900718d), radius: 0.9193364608888096d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37501207422134397d, y: 0.11441593386411864d), radius: 0.4289956015510763d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3746186742406862d, y: 0.12169381463943085d), radius: 0.922250370964092d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7252643932610274d, y: 0.7723895842770987d), radius: 0.655712969049046d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07243159367622953d, y: 0.882006605610352d), radius: 0.24752648757241447d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5053333211281047d, y: 0.01920540889465039d), radius: 0.4034500935274752d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5978740875409715d, y: 0.27831067409060806d), radius: 0.3310679810538226d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21218791132670412d, y: 0.03782031017152532d), radius: 0.2878402693408656d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9447676598959439d, y: 0.6667050650843399d), radius: 0.2811250642715284d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.677242197447509d, y: 0.6712850044048979d), radius: 0.47645559801428594d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.389910847382544d, y: 0.8634279751385776d), radius: 0.3312707849441885d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8177788228288974d, y: 0.5382745602613933d), radius: 0.5674205544744314d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8561304253504914d, y: 0.6597186430305245d), radius: 0.14113267019477616d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29085117068177413d, y: 0.061989703733220325d), radius: 0.14943797419671556d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7165207464892661d, y: 0.9947320785264884d), radius: 0.12312400076476981d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40082008066824004d, y: 0.8160349597132253d), radius: 0.16815595011297013d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8802549799959021d, y: 0.41519079232016476d), radius: 0.11791303768173866d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8715087682530286d, y: 0.9931311543811858d), radius: 0.026475358090671364d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8455181011532517d, y: 0.5315568680137789d), radius: 0.7018234240070844d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10454470608758437d, y: 0.9874052773515605d), radius: 0.9033059143345838d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3049581218273587d, y: 0.5210818224478732d), radius: 0.007505569984051386d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1174490841890169d, y: 0.3029283431373113d), radius: 0.2833999999635278d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19346723181038517d, y: 0.16134257693039344d), radius: 0.23419754271966586d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4369795064305887d, y: 0.06598720521201196d), radius: 0.5527034582881297d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3988173664821567d, y: 0.9494181709744169d), radius: 0.8121500548663583d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6989619001334834d, y: 0.5883098707605939d), radius: 0.5382569152001689d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11850389039681275d, y: 0.5793193329538445d), radius: 0.4796733379371301d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06685502286013578d, y: 0.9403815342544386d), radius: 0.5662904446960395d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16020601616651198d, y: 0.4682536642220245d), radius: 0.7050662133865004d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37892748838086865d, y: 0.5532599868716039d), radius: 0.4321793460653369d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9173965210071467d, y: 0.11949890634018145d), radius: 0.5819739495737372d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1988343905645863d, y: 0.14284471503571983d), radius: 0.06633731194804915d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14580074471901538d, y: 0.3285279089968718d), radius: 0.4219086964337797d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32989979125947466d, y: 0.18147571913681504d), radius: 0.2319804274297308d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9200494235887227d, y: 0.10095535877448458d), radius: 0.9206193022535907d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28202140598831005d, y: 0.08332663947141672d), radius: 0.4337467671347417d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6474016974739342d, y: 0.26930445956724625d), radius: 0.6777208985728704d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.201760678226669d, y: 0.35051886488344486d), radius: 0.9478192592889249d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7774504209581916d, y: 0.5088429956807174d), radius: 0.07700972991131538d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02587345523498552d, y: 0.37104694789394055d), radius: 0.9743154424898823d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5082887151855774d, y: 0.8449362880443544d), radius: 0.1322812800597135d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.031043070498343983d, y: 0.22126602250657168d), radius: 0.26312314836913153d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9894913004237931d, y: 0.8754420778923585d), radius: 0.3154754267868001d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4998207674370856d, y: 0.051473914245068864d), radius: 0.5380931109730833d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19892529263750025d, y: 0.9681247344827953d), radius: 0.286643072304403d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.491654307413935d, y: 0.7819081771344681d), radius: 0.143105044135175d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9931708600179414d, y: 0.742046023723154d), radius: 0.6907546801117529d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5696962379107549d, y: 0.6489475039797934d), radius: 0.20435983850742556d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24874931700076608d, y: 0.9738477036097498d), radius: 0.803105381844292d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9465999737668768d, y: 0.3881700538301537d), radius: 0.6150220616627774d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.062135237347942573d, y: 0.501666203335839d), radius: 0.4147397537147931d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23301581636105684d, y: 0.19084962538827577d), radius: 0.8614317506564917d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8907555594743226d, y: 0.649459548099223d), radius: 0.7332651028496487d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18855371864265702d, y: 0.12931784674897373d), radius: 0.4165462077379041d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07025559871798848d, y: 0.6608986975523589d), radius: 0.5660203366738518d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7069705403413472d, y: 0.019187683846439874d), radius: 0.6812030365664403d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6932359319169283d, y: 0.6675678958695799d), radius: 0.22097203892175665d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4489866362915741d, y: 0.5982954038022241d), radius: 0.9161461483672934d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9928310709879313d, y: 0.5081369258458542d), radius: 0.778518696667078d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.693700109300721d, y: 0.05378264590163573d), radius: 0.421079227169182d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9502568810784557d, y: 0.4516471028338205d), radius: 0.8101938821163992d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6837112171588192d, y: 0.014886063683597683d), radius: 0.5233610542209387d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7037870982203197d, y: 0.6782297927741948d), radius: 0.22980371097857755d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02534718137524572d, y: 0.3753011654471794d), radius: 0.4779454419537671d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9416373583841441d, y: 0.9643248611428987d), radius: 0.2687745019405984d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2967750926736804d, y: 0.5810786464554355d), radius: 0.7662956766308195d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7537650443557206d, y: 0.08996385188573153d), radius: 0.6787490080456731d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2542909792691107d, y: 0.9185459952582871d), radius: 0.26227897254136123d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8106722237316137d, y: 0.4111085489155415d), radius: 0.4087820104232355d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32707061072815125d, y: 0.6382909814296194d), radius: 0.7667386675533742d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9388161182763838d, y: 0.6427656461843496d), radius: 0.2698982581610361d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4560651019349169d, y: 0.3704304898691819d), radius: 0.7122237309569384d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8939725398484736d, y: 0.2699638880234322d), radius: 0.827806499992215d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5731416031115256d, y: 0.5123145801627415d), radius: 0.9102623128292281d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5022567859224d, y: 0.29035757588843136d), radius: 0.9563837829212237d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9095637926305905d, y: 0.8600704737623225d), radius: 0.27323514946703653d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39128353935126825d, y: 0.6036923831948086d), radius: 0.039366492979637124d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4926850069629274d, y: 0.49278936076225544d), radius: 0.7409951104594885d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3327582364560432d, y: 0.24679769098015125d), radius: 0.7349781404796212d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9597608436593208d, y: 0.27399116937592705d), radius: 0.7829702081241783d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12136559446371797d, y: 0.00940958678491055d), radius: 0.6053981878801743d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7626522833651753d, y: 0.8933364702840473d), radius: 0.9216789861548986d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6980809091441549d, y: 0.2991414507207232d), radius: 0.33104517252335064d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5258625088200612d, y: 0.6260003886208161d), radius: 0.39253961577485286d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.032924179865144954d, y: 0.866768383539955d), radius: 0.5408109038220761d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3617721380747638d, y: 0.5078886564171365d), radius: 0.6900778886729807d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8338962677941748d, y: 0.8712089430945609d), radius: 0.8204087805481366d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08399936690140841d, y: 0.004516468165464582d), radius: 0.9651534244134118d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6562724600716067d, y: 0.36223849440717026d), radius: 0.3042919232155119d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5870664796321189d, y: 0.4826294511767695d), radius: 0.08544980738708052d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8127616652045527d, y: 0.6242298308557922d), radius: 0.6181738872118919d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7927355149410342d, y: 0.4049474707067714d), radius: 0.6108833706427879d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9643860461332988d, y: 0.7873742166235331d), radius: 0.45525826873645225d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29881741256037153d, y: 0.18075504241625984d), radius: 0.29839072067459316d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9072115912609457d, y: 0.9303735159550036d), radius: 0.09709535401458724d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46917612353527294d, y: 0.06643383926862889d), radius: 0.38901502279730615d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4621844905958514d, y: 0.20595370391467183d), radius: 0.88451133004292d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45592012407312243d, y: 0.361959413142805d), radius: 0.8360443888251137d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4056682792238042d, y: 0.4925203618953857d), radius: 0.01037434286177008d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7785667642567787d, y: 0.7105456136625377d), radius: 0.20587872416823638d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6722782040774964d, y: 0.3398568644488321d), radius: 0.0745218209634172d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8641053007882289d, y: 0.4077277029560996d), radius: 0.9601706692007796d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.060114508640517816d, y: 0.9293753862816538d), radius: 0.2716189712543663d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10793403941984947d, y: 0.8217329217133461d), radius: 0.29562011345246875d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5531715790572053d, y: 0.13247002958476806d), radius: 0.5503983572247194d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08284931064916012d, y: 0.6260464639942581d), radius: 0.49985713348071825d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2947409814174955d, y: 0.4929705070086198d), radius: 0.19535657389550176d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3465221134300589d, y: 0.258764590131881d), radius: 0.18207945146234994d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42448678398011586d, y: 0.13053844767557954d), radius: 0.09974459121058898d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9375560253686726d, y: 0.5740936748651706d), radius: 0.29341972891239854d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19567112263842823d, y: 0.9302074791639295d), radius: 0.6028486907314183d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2526497785080517d, y: 0.46277095914794075d), radius: 0.7694674048798594d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6953417789355345d, y: 0.10141568436007764d), radius: 0.668856012574066d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28212276558476557d, y: 0.9912529099889869d), radius: 0.8098432125034251d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23572847782701523d, y: 0.24273450848071831d), radius: 0.3112630448130257d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14689465366993704d, y: 0.7840373945145035d), radius: 0.4422125334170669d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5197512445663051d, y: 0.36030931387434095d), radius: 0.15038835888376512d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8679490077672947d, y: 0.10932766668021521d), radius: 0.7984476013594703d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3150074895831839d, y: 0.7450292086662338d), radius: 0.7418869449702171d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9770430291341665d, y: 0.02719006502521215d), radius: 0.33273835094658877d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6075454875155517d, y: 0.821277675588455d), radius: 0.6217134222025721d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9204374928238241d, y: 0.8379960328424751d), radius: 0.762025342657922d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6372411240920488d, y: 0.17959554463648342d), radius: 0.7272193337789786d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17709738340782555d, y: 0.8337027448370845d), radius: 0.8517605206428129d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2796708397433796d, y: 0.6707016454541072d), radius: 0.8930845409711239d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8846741601839527d, y: 0.38091821458352193d), radius: 0.500654472383894d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37852900912527343d, y: 0.26979420617365335d), radius: 0.9408534439960015d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.566249556748029d, y: 0.03840324146599294d), radius: 0.3852703382010053d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9636660433362697d, y: 0.2755367269487493d), radius: 0.04593893811706384d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16166228280503614d, y: 0.5864965259138174d), radius: 0.5746638259303217d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8616636482302904d, y: 0.32996914903826513d), radius: 0.9285487438978248d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7380120543640655d, y: 0.38663171053304435d), radius: 0.9842019576882188d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9416172604680964d, y: 0.01089462644256789d), radius: 0.07198439040521853d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9828589807723426d, y: 0.856763494579872d), radius: 0.25719854693858d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36342471209462746d, y: 0.9961499826154636d), radius: 0.9417619062063863d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5614162328480375d, y: 0.47788458134059886d), radius: 0.6561767971387995d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08575962699338235d, y: 0.9636472625029968d), radius: 0.8512888095655158d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7134955173618578d, y: 0.2701573924697357d), radius: 0.7187477810972338d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5782374618318561d, y: 0.6890447809394228d), radius: 0.054545757238051884d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2681130907680952d, y: 0.5214404778850786d), radius: 0.8874556934812384d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18593096617326077d, y: 0.5284970773728247d), radius: 0.3054734709246758d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5646807023668421d, y: 0.678328055302616d), radius: 0.7007943271884614d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24935669588290266d, y: 0.6002816019900747d), radius: 0.7832030480110556d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14725161687611443d, y: 0.5695864597229062d), radius: 0.21547097758218292d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21458922409386316d, y: 0.9475981115094837d), radius: 0.7183652459708431d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7559800369651137d, y: 0.29400350330088154d), radius: 0.7834481921645555d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9043449430516259d, y: 0.6919118546657727d), radius: 0.19296153047372844d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1542234905358274d, y: 0.28642450606343683d), radius: 0.19283248465706337d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8424443976977702d, y: 0.5057744225084116d), radius: 0.4282115955916064d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2340091367458642d, y: 0.7604782964889581d), radius: 0.8873103428968471d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5204770684889205d, y: 0.8534024073137557d), radius: 0.11480937673547142d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3544272287191198d, y: 0.7363949307004112d), radius: 0.5752963214145908d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8780596090451561d, y: 0.9847957582678969d), radius: 0.4705524484352267d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5814518996248125d, y: 0.6040578828966622d), radius: 0.6883118427432492d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6437966609111058d, y: 0.11555703580186327d), radius: 0.75233890258561d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7467142688505675d, y: 0.00793722731289459d), radius: 0.039983262955513466d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9370434867728518d, y: 0.527346171964617d), radius: 0.2707316967914487d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4820009470332377d, y: 0.6497603843776465d), radius: 0.49303007566061874d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17336613328237904d, y: 0.6565692895417689d), radius: 0.23789865567303747d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4028586000758323d, y: 0.12267596994622698d), radius: 0.8941909230592682d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9456015117461497d, y: 0.918233408441252d), radius: 0.5947519401788419d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.742706113922909d, y: 0.9041873697760354d), radius: 0.9292099623595836d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7728729254299694d, y: 0.38820550925311126d), radius: 0.10887543742696726d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4589524877023631d, y: 0.7866470227164708d), radius: 0.6707781257508844d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32465143852259304d, y: 0.23794594853826057d), radius: 0.9256051787909341d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2077158768345998d, y: 0.9957549822441938d), radius: 0.5402719458676648d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8242571154845298d, y: 0.9190418412200907d), radius: 0.45941578916200754d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9073892600425443d, y: 0.819803514723058d), radius: 0.4146150483168922d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5045817563495603d, y: 0.2973256474179906d), radius: 0.7811962605375156d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.012102034811737217d, y: 0.5556565267914889d), radius: 0.1661130562318448d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9101464563154028d, y: 0.29878878451724455d), radius: 0.48686272748529213d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.019304224444901652d, y: 0.38870117788313696d), radius: 0.9984536658347026d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23114962075387868d, y: 0.7881289334706613d), radius: 0.21010745234933892d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3606213357241589d, y: 0.08129118534409807d), radius: 0.5759248623665651d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5325387282175863d, y: 0.9533468933805236d), radius: 0.18623095535976741d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9405265017565579d, y: 0.6539960431377213d), radius: 0.6220247992688508d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8602276060322239d, y: 0.23450005050081768d), radius: 0.3325330217680368d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26946658232270637d, y: 0.2338563145784286d), radius: 0.30975876080473674d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6556169312593325d, y: 0.9575084990277921d), radius: 0.8707906277753985d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9203232545061569d, y: 0.35538546631045886d), radius: 0.19755612158682456d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1485687226241731d, y: 0.46225441075574514d), radius: 0.1993051901207843d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7783426453653194d, y: 0.326645607192265d), radius: 0.9681078299051213d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9502185023519782d, y: 0.8377815783165917d), radius: 0.6649935651614484d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41310847577458876d, y: 0.2259232636232138d), radius: 0.20937225665089265d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09795718516866248d, y: 0.2746159140429306d), radius: 0.0036419449848220653d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23389048616853403d, y: 0.9260569277263421d), radius: 0.8209702438158939d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35009870991919956d, y: 0.6210809464549517d), radius: 0.3755104510524008d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8391135548892666d, y: 0.34213520781638973d), radius: 0.5357997152016211d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8210525434008601d, y: 0.22522562008762037d), radius: 0.25606882689668886d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.430928171111867d, y: 0.2462639805013468d), radius: 0.045624464104281115d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2908333825031917d, y: 0.12885540471327006d), radius: 0.5997752729263518d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6210860168310082d, y: 0.11968634534667633d), radius: 0.040682419416441795d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3248682525110126d, y: 0.8945126654399203d), radius: 0.8775348116151973d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.041945846369890294d, y: 0.8670650043738173d), radius: 0.6042571481195355d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2655936276202714d, y: 0.3060039466680019d), radius: 0.8153759801785052d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8978351992422399d, y: 0.5339978492652498d), radius: 0.2080820424990939d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.799144408201964d, y: 0.12409598426024693d), radius: 0.1720444621393571d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4091622705779062d, y: 0.3126955378653775d), radius: 0.744388095875138d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22273150537494524d, y: 0.034799634841907956d), radius: 0.8183611151928503d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9155525006390809d, y: 0.4196649358820417d), radius: 0.44348953734158436d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1841821092821878d, y: 0.46129300047337607d), radius: 0.2436508397619046d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1475955290482126d, y: 0.2686778387770401d), radius: 0.8274253495408198d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9361715799968485d, y: 0.0766191107323182d), radius: 0.21747975442103462d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30814273887479915d, y: 0.1310355947305868d), radius: 0.6568532982307745d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06216976894312287d, y: 0.8000106930509658d), radius: 0.14161710248516435d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8344887844967693d, y: 0.051799305559141584d), radius: 0.1828445685229898d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5036698775887435d, y: 0.4947282890346635d), radius: 0.2777819480765662d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18297386181486208d, y: 0.44328548063061113d), radius: 0.3610639732660085d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9307544946391363d, y: 0.018898505224085094d), radius: 0.5013516485123889d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.531314350850403d, y: 0.41083282939707444d), radius: 0.21410087117072985d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6635529760343032d, y: 0.8438395268208407d), radius: 0.9079504997987314d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5024659995003489d, y: 0.7536741551405584d), radius: 0.6506352354070748d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6690475061889942d, y: 0.024412141161255674d), radius: 0.5824087366010148d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09984737279842182d, y: 0.5603770205255684d), radius: 0.20531024270755938d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5129787392916529d, y: 0.564429425575043d), radius: 0.8057501486253705d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25695421449803646d, y: 0.4447969250227892d), radius: 0.8391312407136013d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18663324678511206d, y: 0.7089472593357838d), radius: 0.2797590054543767d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5811294734998633d, y: 0.9683654212571164d), radius: 0.1175647643277149d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6899327615112983d, y: 0.7826121490162998d), radius: 0.8087558611383731d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6457293450821365d, y: 0.30429806036332563d), radius: 0.21298032029686276d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7485855142620294d, y: 0.2705381409566556d), radius: 0.9482785193800902d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.582397503073223d, y: 0.04859570885843978d), radius: 0.5160247870306347d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7229858730472919d, y: 0.9905968361591857d), radius: 0.07241959498264572d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13789385892430772d, y: 0.240284986387994d), radius: 0.6328834576230054d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9844905721957685d, y: 0.7204006176335122d), radius: 0.453546561800682d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5067070653231425d, y: 0.5463204778478661d), radius: 0.04678575430229992d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.703071870953264d, y: 0.22851747159565394d), radius: 0.7754720575846108d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4939250003517984d, y: 0.38493758561465485d), radius: 0.27535692169728276d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5657042181609815d, y: 0.5801112495505197d), radius: 0.5932455557007278d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7456421771280238d, y: 0.3938069517303624d), radius: 0.47228726256651d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43503201258581436d, y: 0.6963266335994118d), radius: 0.07267751266519784d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9576609527945302d, y: 0.5073921491645358d), radius: 0.6128770966140727d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9656374448285008d, y: 0.6578973274845425d), radius: 0.8504396643058537d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6598960651992875d, y: 0.2998035916066851d), radius: 0.6434897708358452d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2778269376300493d, y: 0.1127206346121955d), radius: 0.7539633968076827d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2374939910178424d, y: 0.2853282527941736d), radius: 0.762287190511869d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8623909484238613d, y: 0.2719879300811643d), radius: 0.6582500878788154d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2mi(
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
INSERT INTO public.npgsqlcirclecirclelistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI)],
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
    npgsqlcirclecirclelistd1e2mi_id
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
                methodParametrName: "npgsqlcirclecirclelistd1e2mi_id", 
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
    npgsqlcirclecirclelistd1e2mi_id
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
    npgsqlcirclecirclelistd1e2mi_id,
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
    npgsqlcirclecirclelistd1e2mi_id
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
    npgsqlcirclecirclelistd1e2mi_id,
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
                methodParametrName: "npgsqlcirclecirclelistd1e2mi_id", 
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
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
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
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 126, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 138, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
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
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 82, query1, 157, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 150, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 119, query1, 137, query2))
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[34], false);
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
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 141, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 137, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[34], false);
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
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 21, query1, 73, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
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
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 51, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelBatch(connection, 26, 150))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[34], false);
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
                ((INpgsqlCircleListcircleListD1)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models = await ((INpgsqlCircleListcircleListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[24], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[25], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[26], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[27], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[28], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[29], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[30], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[31], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[32], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[33], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleListD1)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((INpgsqlCircleListcircleListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[13], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[14], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[15], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[16], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[17], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[18], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[19], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[20], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[21], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[22], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[23], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[24], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[25], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[26], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[27], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[28], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[29], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[30], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[31], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[32], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[33], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
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
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MIWA),
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
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
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MIWA),
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI)],
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
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MI),
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MI>(2);
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
                    NpgsqlCirclecircleListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MI>(2);
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
                    NpgsqlCirclecircleListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
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
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MIWA),
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
npgsqlcirclecirclelistd1e2mi_id,
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
LEFT JOIN public.binary_npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
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
    npgsqlcirclecirclelistd1e2mi_id,
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
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA), typeof(NpgsqlCirclecircleListD1E2MIWA)],
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
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
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
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
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
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
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA), typeof(NpgsqlCirclecircleListD1E2MIWA)],
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
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
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
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
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
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
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI), typeof(NpgsqlCirclecircleListD1E2MI)],
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MI>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MI>();
                await ((INpgsqlCircleListcircleListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MI>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MI>();
                ((INpgsqlCircleListcircleListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI)],
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
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA), typeof(NpgsqlCirclecircleListD1E2MIWA)],
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                await ((INpgsqlCircleListcircleListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                ((INpgsqlCircleListcircleListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

