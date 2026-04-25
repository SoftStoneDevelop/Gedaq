

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.004085803567544621d, y: 0.2360628478336091d),

new NpgsqlTypes.NpgsqlPoint(x: 0.595397081196531d, y: 0.5822095207686893d),

new NpgsqlTypes.NpgsqlPoint(x: 0.027951031135908022d, y: 0.2147871181062414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5049541677373162d, y: 0.8021383805111524d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3660693370143422d, y: 0.8925481050908171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38409072702129465d, y: 0.49970640920658704d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5667133626687421d, y: 0.05635968496629529d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6283979259367334d, y: 0.02086447957055848d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9497986020253972d, y: 0.13621829111655837d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06391313215295957d, y: 0.046884453541310545d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17563402550170992d, y: 0.05101538093182645d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3135647462155291d, y: 0.754780340573418d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06446965292253093d, y: 0.4157899568222976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7779639443773024d, y: 0.27533381794573186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4965727296003988d, y: 0.6023830990921878d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23982086740287234d, y: 0.16807039729160023d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6706009221470743d, y: 0.5844802493891629d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2356403717748058d, y: 0.6964915383711957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7170470847896281d, y: 0.655598515018441d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36431819351500305d, y: 0.9857960568715398d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3964959655243476d, y: 0.2471489972651435d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24056075074159855d, y: 0.16342823269342666d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31451509917879295d, y: 0.2418761591556472d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9110275817988425d, y: 0.8707094068540235d),

new NpgsqlTypes.NpgsqlPoint(x: 0.046798613596307104d, y: 0.03417818813059581d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20565288684383853d, y: 0.08160265840993264d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24217796358888422d, y: 0.9069092623222663d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6522917607100848d, y: 0.8023451020175664d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17692799258070413d, y: 0.8922585213399575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02461783898319425d, y: 0.14869055286379118d),

new NpgsqlTypes.NpgsqlPoint(x: 0.340408481253652d, y: 0.5851550076034976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4704484692330697d, y: 0.25134831019493187d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01353898958703692d, y: 0.4313500987373856d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4013625760750753d, y: 0.28257919796385567d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7960296336756765d, y: 0.23832295448123864d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44902593718050043d, y: 0.5442552121236616d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5731002129859984d, y: 0.31232759646630825d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11199099725283268d, y: 0.7679128191894569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6199367972419468d, y: 0.28408259831182725d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.013968454937739794d, y: 0.8426015571912754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11344645586128521d, y: 0.8336172209914108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9121100827024298d, y: 0.6740905566777556d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9141922346403332d, y: 0.7098195595632306d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19970800957756085d, y: 0.5513132347448234d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7478896086201534d, y: 0.3608552680768271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3022230640051984d, y: 0.8473126399890438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20375057025970156d, y: 0.5005554697446797d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.756998536735895d, y: 0.5400770136173796d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11521130059123996d, y: 0.6733834306940307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.043101714601450625d, y: 0.9105929228313456d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45692037692317544d, y: 0.7089101142931477d),

new NpgsqlTypes.NpgsqlPoint(x: 0.006814232318749669d, y: 0.16980972638076652d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4769081893627716d, y: 0.967171873892637d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5401649634456658d, y: 0.17222402806142234d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8463752289573492d, y: 0.5152145076599722d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7934932748404748d, y: 0.2542590356666222d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9116682684234841d, y: 0.2824778080230298d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04116286788185042d, y: 0.7529735859101575d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49636053230199684d, y: 0.8355777760494874d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7620110738765831d, y: 0.6063682321975438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4964330569407803d, y: 0.6762746589843416d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41258683709978394d, y: 0.2823153701020299d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9761992991122095d, y: 0.07477068462453584d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9996751769171567d, y: 0.9111672987416567d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45576287081272104d, y: 0.28288617662061033d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7330948722947048d, y: 0.1729567329798668d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48014693096331296d, y: 0.5096303514297602d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06601264646295801d, y: 0.28595740154493543d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9164072397662214d, y: 0.8389067838248261d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28714960247861676d, y: 0.4273990029462498d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7802441866793199d, y: 0.33655277977859854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8494103194761996d, y: 0.19405360479247402d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16822057760130948d, y: 0.06187153859641248d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2758621058686086d, y: 0.7145932407525993d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4337479561282843d, y: 0.2854400385405277d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41832792197383684d, y: 0.8801693501179866d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5829602021804766d, y: 0.781586514134924d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8603657490801007d, y: 0.8139142517268139d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47310873395776065d, y: 0.6644238348521184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8051167297887339d, y: 0.13854659728328722d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5400034577619942d, y: 0.5817335588310962d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9279660955809291d, y: 0.08590584047429517d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8242815631738647d, y: 0.2882097309046242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38714217036118903d, y: 0.45426885436483155d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1944124707241267d, y: 0.02948900295189627d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3386928803272703d, y: 0.1250068372832317d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9002999453949013d, y: 0.7039526702215271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3372407471432388d, y: 0.8369057043080439d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7305880935237447d, y: 0.2636019909751546d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3576898342075564d, y: 0.4565384944565828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28225950302680036d, y: 0.06163627996402765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28138752056986005d, y: 0.6528113133664155d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14578576780051677d, y: 0.9650247943241952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2814548181473949d, y: 0.6449646057942732d),

new NpgsqlTypes.NpgsqlPoint(x: 0.027754484098882037d, y: 0.23738155609863698d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6727785061374931d, y: 0.426045437593632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38656371272664236d, y: 0.34828792864562275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6791877057393637d, y: 0.438254611167338d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5847336501243606d, y: 0.8284746724877349d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7637901699294292d, y: 0.3971185038571141d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8605986922791098d, y: 0.1096109069899186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09323934498587949d, y: 0.771850224308246d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6763306236765273d, y: 0.5527541663907269d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9095269210652349d, y: 0.12389453137678641d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6157490912729395d, y: 0.5973080795348881d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38585739152291376d, y: 0.45622015426513074d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15924408505992482d, y: 0.2924151339904191d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7825359403349239d, y: 0.02093722825904254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9793513371782072d, y: 0.157236292813146d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8084136609346302d, y: 0.10672409301392494d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20849373938449933d, y: 0.9371722802977428d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7587809315261436d, y: 0.7197108046342084d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1990217729194298d, y: 0.9154653827353088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40163885353444884d, y: 0.23961217888010777d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29479137512992837d, y: 0.0193367188405974d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38107502914797364d, y: 0.6366717871761723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7801521813174321d, y: 0.330390209289983d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44784897620412745d, y: 0.1867950465132776d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8178972706990891d, y: 0.9097795442247858d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44832507349407813d, y: 0.668791140047763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8733007846788646d, y: 0.9106443580658098d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6943923428186255d, y: 0.4029420687965627d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0774969291552845d, y: 0.49460510688566073d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8509380388793903d, y: 0.8123419779712128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3973991917285793d, y: 0.7338677466495265d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7009999034871514d, y: 0.7912230004083076d),

new NpgsqlTypes.NpgsqlPoint(x: 0.574087172221573d, y: 0.03752840900889021d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6756698010514939d, y: 0.31917294596794354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42242324236237583d, y: 0.20573161263748252d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5203838664344335d, y: 0.550160324135416d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8336812398495936d, y: 0.8107999480163247d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5409453697260322d, y: 0.43811883448174704d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32603797382068234d, y: 0.026097436935676677d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2909816005549464d, y: 0.2324390231969633d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4658273566230995d, y: 0.20957441145316236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4391624298996274d, y: 0.7384639895785905d),

new NpgsqlTypes.NpgsqlPoint(x: 0.349347508609568d, y: 0.92167039704737d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7845390930497873d, y: 0.5575362703459235d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9501073146582265d, y: 0.17240188902607323d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40131054190714455d, y: 0.38152019671035453d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08756234358119086d, y: 0.9616932630817178d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37604647450074835d, y: 0.04915221192414876d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35710720043229194d, y: 0.6490823106291396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8977441443437794d, y: 0.9290987677136628d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6963156134705175d, y: 0.6469090634606266d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9609666811014359d, y: 0.900766469561333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18363625485538582d, y: 0.6626307813572189d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9114504547310437d, y: 0.649283264356153d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44203060032233354d, y: 0.5139292332061985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5489058630970676d, y: 0.6128441215760259d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19396509681163332d, y: 0.43379367225375653d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9776523469225626d, y: 0.054550410243535685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5822025924031052d, y: 0.42294634959996313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10058438137716696d, y: 0.708867798603472d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11411139313545393d, y: 0.3389062838872564d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5849765360278392d, y: 0.031172961006445732d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6950977262062021d, y: 0.8444581159869042d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5278871837293474d, y: 0.2647390349025659d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40426309969017615d, y: 0.11668076372843805d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18077115316379644d, y: 0.3128580880941546d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.038312912914272745d, y: 0.11161444215616478d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3080109920478914d, y: 0.762459177408061d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8653449464256584d, y: 0.9855481868031779d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.512813528192732d, y: 0.035227772392164236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9099228658753908d, y: 0.44347138864743807d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23023265718358898d, y: 0.8554128550436069d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6880528775189354d, y: 0.17812690296423173d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7989933536522614d, y: 0.29056208641453074d),

new NpgsqlTypes.NpgsqlPoint(x: 0.883771967085293d, y: 0.5662332532618378d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5714335594212218d, y: 0.6229636875059062d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45324800578983737d, y: 0.4796259652526407d),

new NpgsqlTypes.NpgsqlPoint(x: 0.906766569176949d, y: 0.5078635812223656d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23478710603412511d, y: 0.3575348577761803d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.543547487313347d, y: 0.29724118780511954d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8633314958689446d, y: 0.8074316575901835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45179953679540263d, y: 0.8493106427373949d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8846160455412675d, y: 0.9588378244915068d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07335737836787948d, y: 0.2743171311706848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.312862456289269d, y: 0.4127813645258199d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7332258076775396d, y: 0.854295512779441d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4047185932671906d, y: 0.38953183788703305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04396049854247397d, y: 0.8687389330469772d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6808748448131788d, y: 0.3247565556764138d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9185383416839428d, y: 0.8162974050249499d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13686556317704235d, y: 0.6198642025580724d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9274692798458634d, y: 0.5372478750537093d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24230902798186826d, y: 0.39926722402515225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10272836443956168d, y: 0.6344042177712391d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17525452682817177d, y: 0.6670358393752392d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5060020225673749d, y: 0.3099230631056973d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23031007755032606d, y: 0.8176829568633226d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3655322573873033d, y: 0.9486822171226329d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21084352961407526d, y: 0.5540180840930036d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15158492424093717d, y: 0.6476502965603784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6885383753674174d, y: 0.9139816491198612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3374703183011273d, y: 0.22287154251330143d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18389635284624295d, y: 0.9480604457328174d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5551639760595786d, y: 0.10290568071829242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2969496513246985d, y: 0.4739190167393835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25664782063697145d, y: 0.4838959568781498d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2816912594481875d, y: 0.07767551347575463d),

new NpgsqlTypes.NpgsqlPoint(x: 0.500993577750494d, y: 0.8229202498197392d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39452008594328447d, y: 0.5960793308095987d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9216147838630566d, y: 0.6128384035764611d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2844979061950613d, y: 0.5123709524351137d),

new NpgsqlTypes.NpgsqlPoint(x: 0.394673821542583d, y: 0.5445300528838142d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9550041230906857d, y: 0.8874118441548448d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4784850612656222d, y: 0.08218069097443625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9726394667014139d, y: 0.6109105114425285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19432602478218786d, y: 0.9296932329579148d),

new NpgsqlTypes.NpgsqlPoint(x: 0.821143514379805d, y: 0.8514912017731704d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1600638544592946d, y: 0.611795329702494d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2222040226397607d, y: 0.5563613535457215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5690234035261375d, y: 0.2692981334703306d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36457240294354254d, y: 0.9018927535044318d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3976899716287847d, y: 0.7606879868208902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9174045681370847d, y: 0.4232970462985579d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8927231735295494d, y: 0.3351731938800977d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5149397367683761d, y: 0.7492492809455791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19180024954397956d, y: 0.14599860271764697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2828190441780437d, y: 0.2562164448494507d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47785796124920077d, y: 0.46769204464787495d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2492167027863037d, y: 0.5532594295603236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7444769769727377d, y: 0.7442269132656024d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6954075658556047d, y: 0.7759249785042412d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.851004902070591d, y: 0.2622824453171151d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7760923489581397d, y: 0.8170712464504055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5474820494745538d, y: 0.381734602557684d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16875628582570168d, y: 0.3588629094665007d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5509595106854841d, y: 0.2475181636976439d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32952715271203237d, y: 0.6629926035093225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5341443446610613d, y: 0.7440726527288593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5160052193218172d, y: 0.2162526659162719d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19440321529569426d, y: 0.23694646976606992d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8749752277090945d, y: 0.6550297227651519d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5287188288663661d, y: 0.2673237790568693d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7338486199828075d, y: 0.4639013128911039d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46837678163647356d, y: 0.8564735564951479d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7741047294889152d, y: 0.8595522633781196d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.255258030044502d, y: 0.527162029560864d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4147276026357338d, y: 0.7173908699480599d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3922119695585783d, y: 0.14819481383294475d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7179278194659566d, y: 0.08181045732907166d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15642432766733483d, y: 0.6473569303543154d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8902748672691796d, y: 0.2611121963141556d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21425783103209628d, y: 0.9021687157442604d),

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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[29], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                        Assert.That(models, Has.Count.EqualTo(13));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[9], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 99, query1, 162, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 67, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelBatchAsync(connection, 9, 123))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSelectModelBatch(connection, 74, 99))
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
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[29], false);
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
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 147);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 139);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
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

