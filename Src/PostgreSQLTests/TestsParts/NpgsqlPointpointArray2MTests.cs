

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32904670772643807d, y: 0.00361825880276756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4212783322509398d, y: 0.027525291471523494d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021852898917001262d, y: 0.2172688389035865d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7757523312502899d, y: 0.2715756154077744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8707039827172486d, y: 0.652386722184277d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23071930290504294d, y: 0.6211236031199135d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42841866326356226d, y: 0.553760921441818d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33291112054646876d, y: 0.4578357722174995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6155354253709051d, y: 0.09465110098410101d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8464095796564198d, y: 0.9188517694829372d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1270284326965081d, y: 0.7241226514503325d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11182174250069332d, y: 0.4429731618951934d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.846663374508814d, y: 0.3396998554197245d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9607302931451684d, y: 0.6298943008005319d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9104040700161967d, y: 0.8244965853187223d),

new NpgsqlTypes.NpgsqlPoint(x: 0.58262504648562d, y: 0.01419347345534161d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8370221722035316d, y: 0.8221973087756467d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5432820087468967d, y: 0.27528715066117937d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34453906858969063d, y: 0.889147671966688d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2949769528153494d, y: 0.6648732585902214d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4229339818747805d, y: 0.08069116092466366d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9275192056511488d, y: 0.20842241953420937d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6007193816486286d, y: 0.7103076520901831d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31272864315094406d, y: 0.31530499148075686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.006725234203264985d, y: 0.7420799918970871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4977227486234248d, y: 0.06140968724494722d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7517656735135223d, y: 0.01005849083620447d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2864788945124407d, y: 0.627861644932395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6598552118873086d, y: 0.524053934580016d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35795371289291844d, y: 0.9749850346726383d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9280058467711914d, y: 0.7263086087369967d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8483386100485413d, y: 0.05875239441036206d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3037889237329463d, y: 0.6378135536026779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6155400344479817d, y: 0.024525827490231245d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8165079180466606d, y: 0.19546701406829103d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3265266847186348d, y: 0.7841163962271258d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5190814970386624d, y: 0.8915934224975126d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012068783455766785d, y: 0.7355989067532522d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41500888080678955d, y: 0.4703420703851495d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15184937359911643d, y: 0.11766889197037278d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3780228487700916d, y: 0.9640527464765609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19901562982566212d, y: 0.35063673339751733d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43098359375265993d, y: 0.6599397483919273d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5866608907860555d, y: 0.1454571574963044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36016323377752946d, y: 0.05413771494289865d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4404164568361736d, y: 0.6916097813720603d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3791783114851509d, y: 0.3146681201057874d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9453811780305701d, y: 0.3628305205432959d),

new NpgsqlTypes.NpgsqlPoint(x: 0.608799157967025d, y: 0.2207035359628725d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22349292545951216d, y: 0.07944553256590792d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7143649851349877d, y: 0.4153294740347828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.80960693214448d, y: 0.26598959025260216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45396562194482437d, y: 0.5586017929638107d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6846148901211588d, y: 0.5256068035068605d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5427601722256495d, y: 0.12349388477817469d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9322159111407539d, y: 0.5093928650311704d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4292673241768147d, y: 0.2975183179551565d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4904116801653716d, y: 0.8269320709018235d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7658105335531861d, y: 0.2940633043814026d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4012657455149662d, y: 0.7822099402099713d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7280387937596455d, y: 0.5800630125328864d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17429903150777903d, y: 0.7926488673794843d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7440490019014318d, y: 0.895453668869685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3471399970173076d, y: 0.34521576044528124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7890941161394218d, y: 0.4408688384718329d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0661452478683221d, y: 0.42058814943003453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.989112296529712d, y: 0.48960148986352947d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8584860324224978d, y: 0.5565691441147714d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5638784300888696d, y: 0.9015559513133572d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05888732810297648d, y: 0.9969510892375736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19931851007415602d, y: 0.993165052484288d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5888783239041745d, y: 0.7458544489683299d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8819145040662019d, y: 0.021285237222684383d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16290779120891463d, y: 0.6178517468728941d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2840806919906709d, y: 0.881286667435909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5821999115198071d, y: 0.8027897657196195d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9773614371530457d, y: 0.1768793465574362d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.34566441829207917d, y: 0.804466939270849d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9113610836478332d, y: 0.8213281667394647d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27357691679885177d, y: 0.05798485221985383d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46431609444557154d, y: 0.8205259959142981d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07501333617379569d, y: 0.8801331232031261d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4947711324027264d, y: 0.9858285286324612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4141500807060168d, y: 0.8801561717037728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3303262811313453d, y: 0.2473514671508661d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9711242040053891d, y: 0.3449592020338319d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8434077901721005d, y: 0.1842049777105753d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12888792500677682d, y: 0.37464618146628936d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3831873089924064d, y: 0.05873240082979658d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8702290730260483d, y: 0.5231688977126832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7992624023384826d, y: 0.761714644034419d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9713637384313097d, y: 0.2942699488480174d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7169624206245719d, y: 0.1877152277796975d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9416978513317501d, y: 0.746712917868678d),

new NpgsqlTypes.NpgsqlPoint(x: 0.024467998528484136d, y: 0.1904791593800047d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4105186400763048d, y: 0.7303680955882473d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5560719745006272d, y: 0.20941666135809656d),

new NpgsqlTypes.NpgsqlPoint(x: 0.320037928005368d, y: 0.5554215965153241d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09965112217395933d, y: 0.7288592752717591d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5518881570479734d, y: 0.7075394594491401d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06730657106195903d, y: 0.5659367238006233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9591640917795131d, y: 0.4968006796251154d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6366098471638421d, y: 0.36414690803735794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2791268907200032d, y: 0.4270270999207859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5527607400215888d, y: 0.643846265042452d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5777810045974106d, y: 0.12013671197448428d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7204356909062222d, y: 0.043776340988487816d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30107145209090913d, y: 0.8715220150734313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4456129989217039d, y: 0.93733332987632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07957857314064964d, y: 0.8041967152726914d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9239073173138113d, y: 0.6291539335236324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6638565043682375d, y: 0.6644206785606914d),

new NpgsqlTypes.NpgsqlPoint(x: 0.613214652666164d, y: 0.9546903908923081d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9134682577741957d, y: 0.8508323358649369d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5193852776365878d, y: 0.032392723882148644d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5208944840663537d, y: 0.8108991586714606d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4308023667317007d, y: 0.3447510890800394d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5273829089425677d, y: 0.4913636232809715d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2766705602678795d, y: 0.9219601293521035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6907237347871039d, y: 0.7678595313046578d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9131264428618073d, y: 0.49759034588485074d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8344767246235388d, y: 0.2161075649587485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1288504328133807d, y: 0.21162036138079732d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8430047223680946d, y: 0.0035607694766041087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4164311041949693d, y: 0.1335244797387286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7646148578223915d, y: 0.469115246148338d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7681545499851752d, y: 0.12973179654460676d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45297205606796187d, y: 0.6956620657400441d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4582099182004813d, y: 0.5118563691128222d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4335582555634142d, y: 0.35034837825682974d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42841303675767695d, y: 0.009183443257062218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6282310291546682d, y: 0.46538587986241875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8264354382955451d, y: 0.8165923580537292d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31453987383109805d, y: 0.08191835558454652d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7213174378017522d, y: 0.35981668612205375d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5982435565010659d, y: 0.20423659330667276d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4315064617022165d, y: 0.9447639381066216d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6647867924900589d, y: 0.24408462019803245d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7190879061599124d, y: 0.11093427087532659d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5609594580520936d, y: 0.6273846736883094d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8189226787735797d, y: 0.11139694147655466d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5458046461435343d, y: 0.5667383390777961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8201359909065499d, y: 0.398935145543589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.328174345486832d, y: 0.7730191357382732d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6037363748663195d, y: 0.707288057748406d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42325539914912724d, y: 0.18292743393891098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41983657890200776d, y: 0.6935407855039687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7007381988367768d, y: 0.04345064056514447d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8286451461699441d, y: 0.4971658404324224d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21869318557605222d, y: 0.6098228492064947d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2567240551526174d, y: 0.347128766323864d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31113852572331346d, y: 0.7626796059915746d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6203647895571028d, y: 0.8861445971822478d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5509690367729966d, y: 0.9882109698852568d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7958855184760888d, y: 0.44214186723167603d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17378182649478413d, y: 0.9312219112745519d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6412258923732213d, y: 0.6309572816470563d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4767333314168468d, y: 0.7590455591183587d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5767383169328101d, y: 0.7545949622872216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2941790358193528d, y: 0.2537091937317374d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5381006105034958d, y: 0.6049828816374355d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1401701490838846d, y: 0.28422838077595436d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8830071992984331d, y: 0.694946084463404d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3420600463888903d, y: 0.5260582499683482d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6280784007280179d, y: 0.6322172013892453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40640479535407104d, y: 0.5528460026063524d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11943977349574508d, y: 0.06011699558599137d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8145621223848459d, y: 0.47858976096386485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23862807977798184d, y: 0.12640755082671995d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8392613661405002d, y: 0.7729360172253009d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8514890830138805d, y: 0.23825698572280718d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5794155909638127d, y: 0.6025225566078445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2719518524686304d, y: 0.20541770580541652d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18684928564361003d, y: 0.26618649972503905d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3788086433366953d, y: 0.09323766974827907d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48552055485838574d, y: 0.9155927533678742d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7696140903821652d, y: 0.022666730385242695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22990713420738607d, y: 0.5285728604647928d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0014278433659344891d, y: 0.2720118180554968d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9377735122651885d, y: 0.384978804991464d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5677405264325242d, y: 0.7856151139836512d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9279996001221251d, y: 0.05789463090655467d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8718200135119999d, y: 0.5698479244572342d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8095023677764227d, y: 0.8196503719360259d),

new NpgsqlTypes.NpgsqlPoint(x: 0.598176824755458d, y: 0.021587986075007226d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04850542675537017d, y: 0.04883691816299185d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9598659765501963d, y: 0.1582501942628387d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04487434357014086d, y: 0.7377691940900474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9247719874048391d, y: 0.41672120931626866d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39146967585554504d, y: 0.15021643882203783d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9036607697765662d, y: 0.132539235345157d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9131286888151391d, y: 0.5207367095612581d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5316981195314144d, y: 0.7201818515572197d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4862997721137122d, y: 0.5091228046928142d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5871855579415791d, y: 0.567283518108099d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6166122092225488d, y: 0.6568616856171724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.82012354377499d, y: 0.5884795985774609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3738352975585948d, y: 0.32105928424807795d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4982633477832775d, y: 0.1411524241262767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38663118838234034d, y: 0.5339696711792081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33951017068825406d, y: 0.9636449134830053d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3342474886407468d, y: 0.44088002527035053d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8592500139770732d, y: 0.3411780048410563d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6093200156999753d, y: 0.6923317567612959d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154524328384461d, y: 0.022274619322691924d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4933671936629598d, y: 0.04368864591418109d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19458856231117228d, y: 0.5051389516896594d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8617229399759332d, y: 0.2012562107261323d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5681601733738048d, y: 0.16065129548160628d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9884702772881617d, y: 0.40386117201437643d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8582391268305284d, y: 0.6108175571269974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3719477766845466d, y: 0.7949704798382304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4511214653851868d, y: 0.9139525532615956d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02309856527851961d, y: 0.5133695451491241d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21264828835846283d, y: 0.008105708620469554d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9921684898402668d, y: 0.052804269654743496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07327629144731906d, y: 0.24474024376627723d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.806259016207493d, y: 0.061448514070713056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06829645076988777d, y: 0.12606781855415583d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00844100173746909d, y: 0.6884853793444545d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7465944427479398d, y: 0.9539933833333025d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46006111120574855d, y: 0.9487310865884772d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09883876893888344d, y: 0.7633507176134148d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5264898208058189d, y: 0.28952796635785893d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6255377565317085d, y: 0.2655974927458207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9629264548203913d, y: 0.2371295960341906d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6708050452828161d, y: 0.26287477727708664d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3223659699547877d, y: 0.4001364066058892d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7638372468012326d, y: 0.09932875602372915d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6502821491506487d, y: 0.07275424920024731d),

new NpgsqlTypes.NpgsqlPoint(x: 0.409902092819305d, y: 0.1485181882952501d),

new NpgsqlTypes.NpgsqlPoint(x: 0.326353285076322d, y: 0.8241402225815383d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9691953450316267d, y: 0.5484826528128474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4401948489368913d, y: 0.008894685961763016d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5026186382043825d, y: 0.6755186939064259d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6680131482174309d, y: 0.6300296265224754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.958780056211945d, y: 0.27718317095683687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5330810649504775d, y: 0.7317313331785169d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9921418254219474d, y: 0.1525918528718191d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3974587176352996d, y: 0.8152461953342193d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8994175024740211d, y: 0.518032493361166d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4927078004787897d, y: 0.0378807828584069d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4124664805093513d, y: 0.9920146732036079d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7335423120892891d, y: 0.3962175805186433d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7072310747058325d, y: 0.6032122734029903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7095644992789903d, y: 0.9523065632054106d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6913418751743301d, y: 0.05230052193634738d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10767845039266499d, y: 0.1920459567183791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38488231553737073d, y: 0.9202870743251934d),

},
    NullableValue = null,
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 111;
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 53, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 90, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 27, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 102, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 111, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 117, query1, 111, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 84, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 42, query1, 99, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 16, 113))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 84, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
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
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 17);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[3], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[4], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[25],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[29], false);
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

