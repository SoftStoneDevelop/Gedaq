

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
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4160695085223983d, y: 0.12645107661972854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4550534648020871d, y: 0.843122809459604d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4444578190518276d, y: 0.8120589769570745d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.575902400753881d, y: 0.9140496041773137d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9399564735304695d, y: 0.4576496148014868d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9512251121478453d, y: 0.8891252056263803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47236313668540664d, y: 0.19249772847521385d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3000736899651836d, y: 0.12991953396821254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7966334397849356d, y: 0.36313698590371135d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05056390211390638d, y: 0.01570825132444542d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20000990014655495d, y: 0.6070729543448903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.013414794690596255d, y: 0.45252545786348575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7665451186366712d, y: 0.8758163137673584d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5321621452289341d, y: 0.9163616692260784d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5966591634585938d, y: 0.9778930101406899d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8377029375019227d, y: 0.8215199386139537d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9363813418780956d, y: 0.860344386236467d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39721639257106833d, y: 0.5989484096848232d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4508920712084332d, y: 0.30116935439608894d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7275261587574368d, y: 0.7676377381453041d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8789673301792857d, y: 0.655564093500314d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6287546219548463d, y: 0.9527144754765221d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4885807453989278d, y: 0.07531309184913093d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5922882058494132d, y: 0.407386606308226d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6809339387630824d, y: 0.6933279867443484d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7631055320538891d, y: 0.1576067105236728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10951157999847838d, y: 0.7154341301058046d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7603175127241861d, y: 0.7078169525605927d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5164536739831804d, y: 0.04519376934440911d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7821921700117307d, y: 0.6189875794846671d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22516399084161332d, y: 0.35655466257265445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5536126714343752d, y: 0.2531741399869657d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6645750346206442d, y: 0.30593716344765054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.644191908709162d, y: 0.7103364277754001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7479777443755358d, y: 0.19802693710118047d),

new NpgsqlTypes.NpgsqlPoint(x: 0.786213469536887d, y: 0.21026636876513172d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9975981428263505d, y: 0.8391616948335722d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5826792236786543d, y: 0.6104727969575976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49505582455129726d, y: 0.4788551570519587d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6781214550541043d, y: 0.6054697916332906d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5448535808454807d, y: 0.20738293110828876d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49215672973602986d, y: 0.18757677336597445d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18135736707176098d, y: 0.05350018925496447d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7861119664089062d, y: 0.529728085849611d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40718521302169075d, y: 0.8290413915058781d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9098109150264357d, y: 0.04450119966636901d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8139927768056673d, y: 0.7094170034666352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7677846875385715d, y: 0.3282877607032846d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5321163862978469d, y: 0.9164771054567616d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9774344627421943d, y: 0.6472440869672071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16188864726721985d, y: 0.42798783074897684d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2972845970116542d, y: 0.24314313174516078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5116797182217637d, y: 0.4073483498225121d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6629963369894029d, y: 0.6937469537076416d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04767343640965882d, y: 0.4972034360610833d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7590083748706163d, y: 0.44067111994517416d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20901566391681303d, y: 0.32852548133671833d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24078027086397757d, y: 0.7391420970340205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6634857388964399d, y: 0.7919914533901485d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0038633804677039585d, y: 0.32239269679546967d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1741007200750414d, y: 0.9630117894361796d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19264341707510702d, y: 0.859825154047055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8074890337103897d, y: 0.23260088014946256d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9973292570482393d, y: 0.6954868912187456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03325021804178352d, y: 0.3873338595511132d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8521884071470099d, y: 0.7844822934072081d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4479401768980342d, y: 0.8766992517379475d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24980568429722205d, y: 0.6381199626208278d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06212130143331507d, y: 0.6064856281519874d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45277641968716076d, y: 0.622617385564923d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14681473758478036d, y: 0.2446007008365132d),

new NpgsqlTypes.NpgsqlPoint(x: 0.004720786229066354d, y: 0.16739006350443175d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5684603644545105d, y: 0.307574207181349d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9099924726166952d, y: 0.20033852221598614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9419035634123831d, y: 0.3456767344600683d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7419382651905717d, y: 0.81323668733057d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7953201116347831d, y: 0.14915494577736954d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8723251451967198d, y: 0.3964750648300215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5540467574860001d, y: 0.31234955144124166d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.011864006158707863d, y: 0.24879646549268508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8066236068955209d, y: 0.6022515063168907d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6230004635084279d, y: 0.003991524633874088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1644684330192283d, y: 0.5305085265959495d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7073514461917194d, y: 0.3698851644160863d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5199587673019485d, y: 0.6615765054455123d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9096754883644531d, y: 0.23659619788064123d),

new NpgsqlTypes.NpgsqlPoint(x: 0.001063132599580796d, y: 0.18687391038183143d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.626705902790504d, y: 0.24871089962434145d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6166057972010489d, y: 0.13366609731546508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0039828718839488575d, y: 0.022359195176858804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8233637425315614d, y: 0.8827094375888445d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.731970992125079d, y: 0.9446926949565948d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9376038297227023d, y: 0.4874713420278627d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2774114986355438d, y: 0.5626639534630845d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8104315977902237d, y: 0.7891082779702225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9547915467187803d, y: 0.14941337339198169d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6053907202851511d, y: 0.8367964303096486d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5202544607153639d, y: 0.6950533428518999d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46952691728879026d, y: 0.7346978440328213d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18259425614175695d, y: 0.6731183031867479d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8922182701931063d, y: 0.6344845750437124d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47690638812756536d, y: 0.1849299153256827d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07153526861465886d, y: 0.7758854928194301d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6908555140323877d, y: 0.6893908550759121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7338810595724772d, y: 0.35575011864910866d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6040603336176192d, y: 0.020487067805954884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.059915456734758954d, y: 0.9337795451664228d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7775427668295003d, y: 0.7218758352412805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7344987159032058d, y: 0.231080871262194d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09016633303309596d, y: 0.6674049336923701d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8327151002175333d, y: 0.06821196873034252d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41986440590080176d, y: 0.711434375732525d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6061582996427167d, y: 0.49399083207990235d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08640802544150805d, y: 0.5309264521840538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4658962703390699d, y: 0.8922438945716129d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5768243449849705d, y: 0.23403729991873135d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02681711903052919d, y: 0.3511065637055978d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9259297928814292d, y: 0.6213535488022441d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2876388426022153d, y: 0.185155890204586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6991854232781257d, y: 0.8401476005940403d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11417740017536071d, y: 0.11603901076614853d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5305985866196754d, y: 0.4083040249104978d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8732365272021498d, y: 0.02153152103856737d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9444536847646334d, y: 0.40866746524275166d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7799188413776397d, y: 0.5188689013816034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11513774069870464d, y: 0.32019710377740596d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4343887474000774d, y: 0.053415358079078046d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8709608332964193d, y: 0.2950852193414818d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9580126468583015d, y: 0.7998931422412124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2809160532842597d, y: 0.8364459152772821d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2599633840771859d, y: 0.05644729109185809d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.957157078539996d, y: 0.20335689355040765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45525813329500053d, y: 0.40484051978198077d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2827938255819339d, y: 0.4292533777541543d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8591304055407458d, y: 0.5131709850918105d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.961181660225927d, y: 0.14261578027888466d),

new NpgsqlTypes.NpgsqlPoint(x: 0.894708133719855d, y: 0.5419089281229412d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5494181752467056d, y: 0.4228628709721639d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09951583066598546d, y: 0.3235423371728502d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48745985828961913d, y: 0.8136787802933354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7254366023355124d, y: 0.6409781630289441d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0706667482186385d, y: 0.049266140619484755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8735968418352742d, y: 0.19306326072535285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6011937646659163d, y: 0.3529481639855844d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6045822389809505d, y: 0.5370384871608941d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6081294095453504d, y: 0.7246093445670241d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44826092615324864d, y: 0.0028626762415351337d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8989407548058693d, y: 0.5252673361092288d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.497699771759194d, y: 0.17596503377937234d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9261321865175431d, y: 0.7723430624139781d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6498141219702621d, y: 0.9732004105394678d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9691990232067639d, y: 0.2572697235202006d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7827282576938299d, y: 0.9487307305385801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6906256801737218d, y: 0.896334783557299d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5668260307960286d, y: 0.04057539681207578d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9189058481002699d, y: 0.6984840811534002d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10959959268498654d, y: 0.503037553660805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31567212512127074d, y: 0.5952134789340472d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37591538018859005d, y: 0.06262487603814604d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21206640185802306d, y: 0.5175329809550413d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7500303932411847d, y: 0.15948420443050249d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7417154171500874d, y: 0.4833248132528385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07847293075989037d, y: 0.956415966207145d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6178911765211124d, y: 0.4604541319826285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45237084550777806d, y: 0.9199290786702589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2546633954190187d, y: 0.6660420538234935d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29805160290858224d, y: 0.5589597937396177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40515432277230856d, y: 0.8624937774483984d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4872330489833083d, y: 0.5578400328320059d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7569865583613219d, y: 0.33185856745649833d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1655016238258371d, y: 0.6768895333080729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4499150337659016d, y: 0.014878712009560147d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5371435856698141d, y: 0.9607908495123679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38637313692162756d, y: 0.5005711412074759d),

new NpgsqlTypes.NpgsqlPoint(x: 0.116232828101414d, y: 0.42367325963386127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5911591245470925d, y: 0.11105113582577486d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12997091533355876d, y: 0.03823867093098521d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3136179203377619d, y: 0.8735080560057263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33886607906297717d, y: 0.071825611341097d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7161831219890694d, y: 0.7305125246738531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9984859233837072d, y: 0.5417239285853956d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3753524121838232d, y: 0.31914167763601375d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32586027911008586d, y: 0.056813880384834925d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6883002289192671d, y: 0.9338692775322056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5267644389664462d, y: 1.254400223060781E-05d),

new NpgsqlTypes.NpgsqlPoint(x: 0.674810121388683d, y: 0.5812553893812376d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8952240144742839d, y: 0.8410622952938385d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7498365181232648d, y: 0.9884225812842239d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48417921962993593d, y: 0.32353036832327087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9531752432891882d, y: 0.9464407131744605d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5354737877476117d, y: 0.15893527354099646d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.505155335217407d, y: 0.7507884329009187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09164729145070216d, y: 0.3419960947567042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08577358106151811d, y: 0.5618606953265426d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15351233275830578d, y: 0.2859066239937289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5030729963806578d, y: 0.2827084722223343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2927203028485098d, y: 0.44748114256390403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9885550713833761d, y: 0.273966001798699d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1731042205479929d, y: 0.29311141441051813d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4579094051538949d, y: 0.07568481080707756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2274457509431076d, y: 0.47210818922906017d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21867743221406166d, y: 0.7305418322361065d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6763544045832086d, y: 0.059373011302788825d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09636531965071282d, y: 0.9965234219530393d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4603555591161623d, y: 0.3049891453495722d),

new NpgsqlTypes.NpgsqlPoint(x: 0.939704183049422d, y: 0.24867677230822616d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.814871633439802d, y: 0.6189097144272595d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3936468959182585d, y: 0.9590465313822532d),

new NpgsqlTypes.NpgsqlPoint(x: 0.01712644054710677d, y: 0.8552016140841121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5959418116069373d, y: 0.8411823599153606d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17673189150960966d, y: 0.12962741274471934d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8838738787712063d, y: 0.4251436267775054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35382663238827605d, y: 0.9003524778577832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0855564071303766d, y: 0.6610464394024106d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8339028855418112d, y: 0.9755824434907483d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3830782188213119d, y: 0.6399484737515285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7990363043402902d, y: 0.4326698676422066d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6954549277927878d, y: 0.5786510575425374d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18863688608118212d, y: 0.32875103740326517d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6160203879888881d, y: 0.567032090960346d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30686061779679996d, y: 0.7673375069445341d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4019506172189956d, y: 0.8702484912918262d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3614840651544735d, y: 0.2889247590037485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7362722032712293d, y: 0.2335581297947148d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28267778004180144d, y: 0.6725798651315881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8893300236409982d, y: 0.35675661578717643d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7231028739106792d, y: 0.09600017039982267d),

new NpgsqlTypes.NpgsqlPoint(x: 0.497717974651282d, y: 0.023255662938276855d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24678507259979243d, y: 0.09947103951989245d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07373874519913948d, y: 0.9260327710736106d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2470557654526041d, y: 0.9334816708917415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5084599478519904d, y: 0.9905950176874081d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04392627436113794d, y: 0.881933742812363d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7422803806937027d, y: 0.44519362314742383d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35720738018761333d, y: 0.2733868030744885d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8359144436441165d, y: 0.8391496941663398d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8711122183089971d, y: 0.22222465862113128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7952675136310832d, y: 0.33188773286540063d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5835936389973829d, y: 0.14086588034346115d),

},
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlPointListpointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlPointListpointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
FROM public.npgsqlpointpointarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[29], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
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
FROM public.npgsqlpointpointarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[29], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[29], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 70, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqlpointpointarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 149, query1, 149, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[29], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 116, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM public.npgsqlpointpointarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 26, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 29, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[29], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 70, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 8, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 116, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 26, 44))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[29], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 89, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[29], false);
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
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[2], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[3], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[4], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[25],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[26],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 113);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[29], false);
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

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MI),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
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
                ((INpgsqlPointListpointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
                await ((INpgsqlPointListpointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
            queryMapType: typeof(NpgsqlPointpointArray2MI),
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
            queryMapType: typeof(NpgsqlPointpointArray2M),
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

