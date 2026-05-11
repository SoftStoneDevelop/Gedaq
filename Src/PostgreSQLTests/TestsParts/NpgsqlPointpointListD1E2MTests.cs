

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
    internal partial interface INpgsqlPointListpointListD1
    {
    }
    
    internal partial class NpgsqlPointListpointListD1 : INpgsqlPointListpointListD1
    {


#region TestData

        private readonly NpgsqlPointpointListD1E2M[] _testData = new NpgsqlPointpointListD1E2M[]
        {
            new NpgsqlPointpointListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2402219686178816d, y: 0.401485687035929d),

new NpgsqlTypes.NpgsqlPoint(x: 0.851232894597491d, y: 0.36561209896134217d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5179365059306296d, y: 0.9883608079672671d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.369642523466855d, y: 0.8429491640807566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8084990541929467d, y: 0.9576365019586222d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8373047687433212d, y: 0.870904226296918d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02078102986432595d, y: 0.004503151755857804d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5768023199479146d, y: 0.9029361725143167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7810787558434206d, y: 0.302130452555328d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6876648939003925d, y: 0.2127904776639289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21787606434851992d, y: 0.6681841240046411d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.011544210194654903d, y: 0.9291746398395174d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35539177530078914d, y: 0.7284486815934968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27704620781290235d, y: 0.01904428384449741d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8730762600584941d, y: 0.40842979876197083d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28005607496247675d, y: 0.03255575125814747d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2786858010552009d, y: 0.7420658356036492d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5787165106578028d, y: 0.3703066902521922d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9449548149454783d, y: 0.2597361066306958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0239770258270271d, y: 0.6003544408137599d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19729353272239525d, y: 0.29681786233188356d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08200067037020509d, y: 0.15027759260923523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5760765918918034d, y: 0.9611606324311524d),

new NpgsqlTypes.NpgsqlPoint(x: 0.731324473935776d, y: 0.49924448788471454d),

new NpgsqlTypes.NpgsqlPoint(x: 0.421474604362873d, y: 0.4357158371696237d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9583884744285284d, y: 0.29800752843170486d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40929230035133746d, y: 0.4289527356510695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6604581246830831d, y: 0.9371500820429642d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7980618782492194d, y: 0.37985266628826075d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45298125758867347d, y: 0.755835421045539d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7138485456319401d, y: 0.9945763200566418d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2906691000964522d, y: 0.8285736047062111d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16916206071865236d, y: 0.84498128555584d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7873737578754424d, y: 0.9147086017278931d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8017048073952334d, y: 0.4638559525877315d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6938576692332689d, y: 0.9487596613050435d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.34379632579371844d, y: 0.8988542154120618d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4444996673960051d, y: 0.6849623279494416d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5382460559625794d, y: 0.5259349691079621d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8990994828979781d, y: 0.2570471931557845d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38060390980716274d, y: 0.3246889157269046d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3234228002807056d, y: 0.9707305033986066d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02489869670623368d, y: 0.1787758909317405d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9324455995353098d, y: 0.16712658188277596d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8465821396682919d, y: 0.10142989703129013d),

new NpgsqlTypes.NpgsqlPoint(x: 0.642491085176554d, y: 0.6758010729341697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.292453308242394d, y: 0.5139675939786983d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25176148601966697d, y: 0.5029859617632185d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10559492998556996d, y: 0.9525715904322821d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8283083059059282d, y: 0.11217877185096237d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21181898488186213d, y: 0.024387183495861775d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1004660212370252d, y: 0.9727139539272173d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11947880949357081d, y: 0.10114272719793604d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5845895995390623d, y: 0.6788151689224894d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7104666437517827d, y: 0.780980079555821d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3850705040162813d, y: 0.18180908376386284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7838286936791939d, y: 0.611426375837478d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28542315266974694d, y: 0.9033088896216154d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6538544158954498d, y: 0.8901010109465658d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8130452043695784d, y: 0.8667028084815586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6789707168308537d, y: 0.2496360223953512d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33815442789008965d, y: 0.6134306059627489d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13621523931695778d, y: 0.800529800786801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7569758530908159d, y: 0.7835308635912945d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12622075531962906d, y: 0.5344963476996412d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9677168842515538d, y: 0.5899783554959525d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5790122554503624d, y: 0.2051444054715693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.010237130468587763d, y: 0.4309056505976363d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42606536545327856d, y: 0.5980059786750632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7178141283081845d, y: 0.7565414700889752d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3066972641621801d, y: 0.48386956608528553d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32103539259377556d, y: 0.4597956534372871d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9220959935111844d, y: 0.8872109321878653d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3603012190375934d, y: 0.4294332952336527d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33143369775407205d, y: 0.28005160803690077d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7642339089118976d, y: 0.6403965448509948d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46408142729572943d, y: 0.359842509835678d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16646559816962103d, y: 0.9564080478801218d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9861233486404227d, y: 0.6714185470771878d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9102619980948053d, y: 0.9022471938358082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.025632875522366372d, y: 0.972276635355903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9457610073526125d, y: 0.22677531638387505d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4174656738691046d, y: 0.39189072646120193d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21460533244317326d, y: 0.700897632184694d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7450603811884065d, y: 0.2519918371790437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08435890586993089d, y: 0.7000066810728195d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9152749598125566d, y: 0.8367813089984468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.025536350651551243d, y: 0.1187169228771785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8076554908736785d, y: 0.1435452088111281d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48318654278157613d, y: 0.35229820429782144d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6797774604807888d, y: 0.8444324918219507d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32696716172876694d, y: 0.28089509021665426d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5358335694873513d, y: 0.4862040357384788d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08431397284796416d, y: 0.45600830698973294d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23145896910394792d, y: 0.6327308519949741d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1232705230842287d, y: 0.9560744186372182d),

new NpgsqlTypes.NpgsqlPoint(x: 0.665819216353698d, y: 0.6351969059877107d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9642844673480804d, y: 0.19218583341077722d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16501915446698256d, y: 0.21964304614339147d),

new NpgsqlTypes.NpgsqlPoint(x: 0.639298025822486d, y: 0.5390450419765866d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18597755225477985d, y: 0.7417108108362048d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.925397399962034d, y: 0.18016478329360064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229504791915231d, y: 0.045544048807624415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06447233087023951d, y: 0.423762545410479d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13524408293284917d, y: 0.5067234609032493d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8495761001831069d, y: 0.020555765439266627d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7729091089638187d, y: 0.6857792142184783d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9545228271583198d, y: 0.7340899033283681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5357938878837822d, y: 0.7480149495065068d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8824995775012807d, y: 0.7606567942320828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6506287744359859d, y: 0.19260974593813984d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0764183078884293d, y: 0.28620197519185253d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8892242805192027d, y: 0.9766343143008788d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07886250706517561d, y: 0.6409754564416134d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27903714007235403d, y: 0.4416143572652028d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0019881432412612865d, y: 0.5207581939501781d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7038211253463955d, y: 0.3823370942668475d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2670556632728638d, y: 0.4352826826950267d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7355364887797167d, y: 0.016856419496726893d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6186712230076484d, y: 0.4255855425272591d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6459310578836013d, y: 0.3714289945281717d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3567702781275659d, y: 0.9594615146966283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8843873085879291d, y: 0.21760999894385347d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6178948328968359d, y: 0.263982105032716d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19645442011528458d, y: 0.8904036959728644d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20893509406721567d, y: 0.03208692522629719d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31063896235553157d, y: 0.704885016810783d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3995091932705236d, y: 0.41983630996867427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1903125091275769d, y: 0.8463733216502632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1111165295744111d, y: 0.08970991172569964d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21515495195101408d, y: 0.7046683815792685d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8990679713456173d, y: 0.9986898149145012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13838893837488742d, y: 0.34940290665915386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9179495713154529d, y: 0.12510521717235001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.003803402015153501d, y: 0.472502864351531d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48348270057761955d, y: 0.7764794009549216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.896548562759854d, y: 0.5883769479868702d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2943668199762549d, y: 0.6426759931557913d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48726303654718583d, y: 0.660955992975086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7115788098260915d, y: 0.3147941055690867d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9277852980312945d, y: 0.9017455880801195d),

new NpgsqlTypes.NpgsqlPoint(x: 0.208598553459864d, y: 0.6886984589955163d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7470737829511072d, y: 0.6571343952551943d),

new NpgsqlTypes.NpgsqlPoint(x: 0.023966462142800182d, y: 0.9642247286378643d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21147009391318916d, y: 0.741918074089058d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3979865124046388d, y: 0.6355544812187521d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9395415788356725d, y: 0.43666586330149015d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9757103800758834d, y: 0.9281093371225821d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20169624878540549d, y: 0.5965326618400032d),

new NpgsqlTypes.NpgsqlPoint(x: 0.031745357879644276d, y: 0.7562118731851792d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18490098062808102d, y: 0.982906084027853d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9936054448681509d, y: 0.8530877300325753d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9642020051455324d, y: 0.1488868400785135d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7589714428926663d, y: 0.7426977364867459d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4180386930282306d, y: 0.22281620507381927d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3530463413148366d, y: 0.9413002546993645d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1923518616777775d, y: 0.8490002345184553d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29802805193075843d, y: 0.7147950348623758d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2353055037422711d, y: 0.025367532183377617d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41955549423411675d, y: 0.6158974238757909d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8494662778572927d, y: 0.8258545639617897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08694726639416461d, y: 0.4028432531926821d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5243878261971442d, y: 0.5507838175508268d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7818104581664089d, y: 0.9121464934701442d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49230323482941885d, y: 0.9967518185398608d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7760350072724906d, y: 0.5124878173287654d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9986576488130217d, y: 0.6802441098786748d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36601930868117105d, y: 0.8961581462318625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7381009452723596d, y: 0.4816318284139367d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4889754490184538d, y: 0.17965601658075503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1825168730404998d, y: 0.726340767395621d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10653970562714599d, y: 0.7597421769511058d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8830663778480149d, y: 0.3350444970778832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6004436851089614d, y: 0.41986428408611d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3951047361214156d, y: 0.8501379783611889d),

new NpgsqlTypes.NpgsqlPoint(x: 0.004841907717275107d, y: 0.274568230195804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.86803805009733d, y: 0.05388685876446042d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.693488705339173d, y: 0.354044658174438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7466740606680847d, y: 0.8698743313469398d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21109547102863435d, y: 0.09221055584715765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.007618916867499492d, y: 0.9430532713946068d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2262247247660929d, y: 0.7817312941033103d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8274134394925288d, y: 0.4676325869532605d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9838503834709551d, y: 0.35454652409062537d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20973781630191257d, y: 0.6987183863145245d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17984914831119525d, y: 0.3971856976063882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9041386457963623d, y: 0.07621911135740367d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10655506874209575d, y: 0.14626172405294247d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2683519015519421d, y: 0.5291852101305367d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0814043643062129d, y: 0.1022707971024347d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1680249286829022d, y: 0.3223002785086865d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8012754761033707d, y: 0.2591695780811236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20257762519138933d, y: 0.8139879577427865d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42564913991257813d, y: 0.39565650790496076d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6737188003936215d, y: 0.06015229215527873d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5197339543643191d, y: 0.16266646393258544d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5618416651460606d, y: 0.14155606754914118d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8928181945397615d, y: 0.09754705263145269d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5359932873551534d, y: 0.4326751129627642d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9545138365380641d, y: 0.5540322160940493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6291565605755906d, y: 0.6487541743192274d),

new NpgsqlTypes.NpgsqlPoint(x: 0.602331015087655d, y: 0.6039303870552143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7909512017700708d, y: 0.745028182017675d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16292103884926556d, y: 0.5187213357878449d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22013678856486985d, y: 0.6672744708004772d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07620780482289846d, y: 0.34611032380263373d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8345951492346692d, y: 0.9921255041170819d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5315373918816071d, y: 0.8419853133079908d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37576741451137363d, y: 0.8870113419318809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10140043261257636d, y: 0.7291135775361258d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9381373961955203d, y: 0.8939389318655727d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06979977166583018d, y: 0.010207096268572524d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3461798924545201d, y: 0.7730107740383069d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38799713439526706d, y: 0.41004108304076425d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14670262568156545d, y: 0.5496616633576547d),

new NpgsqlTypes.NpgsqlPoint(x: 0.044219137603994985d, y: 0.23308499707950148d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8254822409572926d, y: 0.5950189508949698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1626352138044963d, y: 0.033486016608936464d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14877964828185275d, y: 0.390700052766931d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46948947631447857d, y: 0.25988675511927317d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9710031789202648d, y: 0.8567969746344046d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5144895215940692d, y: 0.6486021438844557d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5709221636467458d, y: 0.6723491449487649d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41393099043635806d, y: 0.9917133910935773d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03347947668093998d, y: 0.9414266202087741d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8399932072560016d, y: 0.24098203545585772d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37424285768736687d, y: 0.013637850572794763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7322141608172573d, y: 0.39465956322113904d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3990697062106918d, y: 0.6631644830424883d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7967840108459701d, y: 0.5362086009000773d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10692427432252805d, y: 0.4041214174934904d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5792140358818672d, y: 0.03152406054630752d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4397580298431537d, y: 0.22525017069301878d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45020239002780604d, y: 0.4537769577305747d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4791664419830006d, y: 0.5727108280127299d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6395558815398407d, y: 0.8212698303701068d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9317341893041885d, y: 0.24698667531778462d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7057869753507932d, y: 0.7770128462966401d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6384885005029576d, y: 0.6017408601833049d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8324778272108396d, y: 0.4028515873559462d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9883228308762206d, y: 0.4079539605280169d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6957300067544269d, y: 0.6204624930686483d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9861487812804901d, y: 0.16469268843693208d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29328913603844964d, y: 0.29487030126660696d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7488833899575843d, y: 0.6866313424246095d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5954967426851986d, y: 0.768047420296921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7147374562171537d, y: 0.041500828572079485d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6934010239340408d, y: 0.15501412483728771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.923973421610645d, y: 0.7643499891478948d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6767645150558528d, y: 0.2302332116452087d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5832530574230275d, y: 0.16295485243770047d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07041662597342258d, y: 0.8801667790981851d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39239655337672785d, y: 0.15129607756282126d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2782830375384361d, y: 0.18707217816114663d),

},
    ModelInner = new NpgsqlPointpointListD12MI
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9914799000098091d, y: 0.032729310701045455d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06990772641509124d, y: 0.09061341095723885d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9226236267839479d, y: 0.23966542570124694d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5236689033516081d, y: 0.2544106345530145d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19572449183135276d, y: 0.5792529312845033d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05551419148058989d, y: 0.36116591428749023d),

new NpgsqlTypes.NpgsqlPoint(x: 0.027630394449547513d, y: 0.17905615269353448d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25037790424190554d, y: 0.9791558053958563d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6654139122150139d, y: 0.48320984121245714d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6345844683581041d, y: 0.17412295661429789d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7428369515192224d, y: 0.3320642179027321d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8903288509574677d, y: 0.8645243192135985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4960321518923403d, y: 0.040559450177227174d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd12mi(
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
INSERT INTO public.npgsqlpointpointlistd12mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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

                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd12mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)), 
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
                methodParametrName: "npgsqlpointpointlistd12mi_id", 
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
                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd12mi_id
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
    npgsqlpointpointlistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd12mi_id
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
    npgsqlpointpointlistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                methodParametrName: "npgsqlpointpointlistd12mi_id", 
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
                List<NpgsqlPointpointListD1E2M> models = null;

                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointListD1E2M> models = null;

                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd12mi mi ON mi.id = m.npgsqlpointpointlistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd12mi mi ON mi.id = m.npgsqlpointpointlistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 103;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd12mi mi ON mi.id = m.npgsqlpointpointlistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 51, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 113, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 159, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 113, query1, 159, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 162, query1, 162, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 150, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 129, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 120, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd12mi mi ON mi.id = m.npgsqlpointpointlistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 136, 120))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[34], false);
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
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatch(connection, 13, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models = await ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models =  ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[2], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[3], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[4], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[5], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[6], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[7], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[8], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[9], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[10], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[11], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[12], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[13], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[14], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[15], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[16], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[17], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[18], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[19], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[20], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[21], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[22], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[23], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[31],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[32],_testData[34], false);
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
FROM public.binary_npgsqlpointpointlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD12MIWA),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD12MI),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD12MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD12MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointlistd12mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointListD1E2M),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
FROM public.binary_npgsqlpointpointlistd1e2m m
LEFT JOIN public.binary_npgsqlpointpointlistd12mi mi ON mi.id = m.npgsqlpointpointlistd12mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointlistd12mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models =  ((INpgsqlPointListpointListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD12MIWA), typeof(NpgsqlPointpointListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointListD12MIWA>();
                var models2 = new List<NpgsqlPointpointListD12MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD12MIWA>();
                var models2 = new List<NpgsqlPointpointListD12MIWA>();
                ((INpgsqlPointListpointListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointlistd12mi
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
                    NpgsqlPointpointListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointlistd12mi
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
                    NpgsqlPointpointListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD12MIWA), typeof(NpgsqlPointpointListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models1 = new List<NpgsqlPointpointListD12MIWA>();
                var models2 = new List<NpgsqlPointpointListD12MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD12MIWA>();
                var models2 = new List<NpgsqlPointpointListD12MIWA>();
                ((INpgsqlPointListpointListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointlistd12mi
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
                    NpgsqlPointpointListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointlistd12mi
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
                    NpgsqlPointpointListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD12MI), typeof(NpgsqlPointpointListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointListD12MI>();
                var models2 = new List<NpgsqlPointpointListD12MI>();
                await ((INpgsqlPointListpointListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD12MI>();
                var models2 = new List<NpgsqlPointpointListD12MI>();
                ((INpgsqlPointListpointListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointListpointListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD12MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD12MIWA), typeof(NpgsqlPointpointListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models1 = new List<NpgsqlPointpointListD12MIWA>();
                var models2 = new List<NpgsqlPointpointListD12MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD12MIWA>();
                var models2 = new List<NpgsqlPointpointListD12MIWA>();
                ((INpgsqlPointListpointListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models = await ((INpgsqlPointListpointListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

