

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
new NpgsqlTypes.NpgsqlPoint(x: 0.984362032217994d, y: 0.08656108542954521d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2861117701606314d, y: 0.8642604154989427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5527324761459447d, y: 0.6198890934856802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02891780854480508d, y: 0.29117287610009024d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36593083288617023d, y: 0.8250905425165402d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8850602609161903d, y: 0.67914982941953d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5422235194529439d, y: 0.23056045837936534d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45952721248871675d, y: 0.35323022010964067d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5679816940867506d, y: 0.6748726603375922d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9268825882034378d, y: 0.24554577498703722d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23751786299767796d, y: 0.7657924714808849d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2598291809499811d, y: 0.5169072990354039d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.971386380509101d, y: 0.8270365742295692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.606253086535625d, y: 0.8176537928185537d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6241480048718537d, y: 0.22973763840358696d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9526960746885388d, y: 0.7360210084164812d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6866528593965469d, y: 0.39545637378417764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16774379432024356d, y: 0.019840572583974203d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7296378046901401d, y: 0.9274020148068596d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8745520192614182d, y: 0.6880740009699506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07461787719214963d, y: 0.20664622499025365d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35861358907111884d, y: 0.8893571957010752d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.274970591809656d, y: 0.26711848246183256d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07668469577183334d, y: 0.07544964755718242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5372417484322953d, y: 0.2138316131457143d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.055352864700737525d, y: 0.3137729323578171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05692617047010251d, y: 0.2791482270010299d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10105003918289035d, y: 0.6675398251597103d),

new NpgsqlTypes.NpgsqlPoint(x: 0.322669847312525d, y: 0.9822055072260903d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8817769235870163d, y: 0.8119337137025742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6448130425155701d, y: 0.8231706440870227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04572826866563018d, y: 0.5281343201772019d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12334044478439388d, y: 0.6186637904915735d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7966121098781407d, y: 0.994316005221278d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11825151118508137d, y: 0.23886795418988216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5137167262392284d, y: 0.353826201364287d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10666067845108163d, y: 0.2603130826890605d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5082948387368053d, y: 0.3358934312726578d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2990454424508352d, y: 0.0347793664912639d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6393487379243187d, y: 0.7603352640144774d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2478342352275511d, y: 0.17068399723490046d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16547558160005893d, y: 0.11639811585534143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23339186590823358d, y: 0.528440905470757d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3669812036068305d, y: 0.9287844616518475d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7025078353760743d, y: 0.5781939324273047d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9160338692427388d, y: 0.13843003977090917d),

new NpgsqlTypes.NpgsqlPoint(x: 0.009081461543613889d, y: 0.44777554786352936d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6455307613638932d, y: 0.22226270307062146d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7681331211840041d, y: 0.17288206747084178d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7330637766581797d, y: 0.47544558221610644d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7973452792613729d, y: 0.3091564913486623d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04143819769833845d, y: 0.33801099956642255d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7083698253985254d, y: 0.6430553116776296d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2905460391201601d, y: 0.2802448732141677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48998755760055557d, y: 0.31212730077618533d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16820975130848737d, y: 0.6410677690973899d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6702403415143193d, y: 0.9655139888909208d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02313252058394022d, y: 0.7594862852960481d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3432975696926136d, y: 0.41173627018256964d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.818677878716907d, y: 0.6495464635861238d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7441302418632256d, y: 0.5734943124538675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7270686446302418d, y: 0.3255081739578435d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9295354677574473d, y: 0.724662171445371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8123423158829113d, y: 0.7651591040517253d),

new NpgsqlTypes.NpgsqlPoint(x: 0.795814158391262d, y: 0.5721605645346591d),

new NpgsqlTypes.NpgsqlPoint(x: 0.025726494837444713d, y: 0.7310976787892055d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0727236778453012d, y: 0.6862279901343389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5849719062790718d, y: 0.6880606430774927d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6566480099878863d, y: 0.846076167180288d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4800997447351003d, y: 0.8773177850833488d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18856391932194927d, y: 0.3893930627264248d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3800514007884973d, y: 0.8754969690935692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15780426233460165d, y: 0.0526587687707718d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.056965887919420255d, y: 0.5442555951024673d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6971646971988315d, y: 0.050705905328319756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13362561570869425d, y: 0.9733646446742541d),

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
new NpgsqlTypes.NpgsqlPoint(x: 0.656184555194788d, y: 0.034093340197430266d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13693815327669523d, y: 0.41097429247861605d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23340697840209257d, y: 0.0945823616843039d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46096038065912837d, y: 0.6724756960678864d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5164553939176529d, y: 0.9914613371748309d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09247316090232804d, y: 0.8720133834460837d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18498708451643675d, y: 0.9994018186163907d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16781675066862578d, y: 0.819432628922124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.939426072488817d, y: 0.8415652005680895d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8770977447266061d, y: 0.19489079904118511d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21180541180981394d, y: 0.24482948521010517d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02513937562485158d, y: 0.4219261088933657d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8842281560780146d, y: 0.9070898003335088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7106138463255215d, y: 0.8922931747196663d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5532482145229606d, y: 0.8182617033632462d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03586132003498643d, y: 0.5638239339524701d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8470778116942429d, y: 0.9643425827055934d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09578600399128201d, y: 0.8430086142826237d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23090447380078938d, y: 0.6775756298071542d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5286512059066842d, y: 0.1448864103027715d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7091637063513146d, y: 0.5035454286813482d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1524022773741831d, y: 0.7754555942296318d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7123689220361872d, y: 0.2095406067482054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0574226381936066d, y: 0.5053276372738151d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7255333403468907d, y: 0.8488020967860597d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05474029818659809d, y: 0.0985306820333085d),

new NpgsqlTypes.NpgsqlPoint(x: 0.020557180598833158d, y: 0.7824039337753583d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9804238033945395d, y: 0.9864705929557576d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9792586497433998d, y: 0.5284354368209946d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5597014031920277d, y: 0.0480871416973061d),

new NpgsqlTypes.NpgsqlPoint(x: 0.493992156700792d, y: 0.18046833854491007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34162497921276513d, y: 0.7098007408775995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6812452471603141d, y: 0.9013561710762592d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41767740031106826d, y: 0.159572090414971d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38114898535798425d, y: 0.7898872877750361d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27582543027680684d, y: 0.003338273711899764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4793283590072257d, y: 0.9934812985146938d),

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
new NpgsqlTypes.NpgsqlPoint(x: 0.8780276257351675d, y: 0.5806212516776347d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29150728136849113d, y: 0.970211755731533d),

new NpgsqlTypes.NpgsqlPoint(x: 0.022157853789973925d, y: 0.46460055832332614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8468277446402611d, y: 0.26534124227239797d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.946809987474751d, y: 0.5870322525844728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6578720275549329d, y: 0.4663390725911397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8660648682964711d, y: 0.44768771347635083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6545198582446085d, y: 0.8590478171556477d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5345754022651255d, y: 0.5287484405073066d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5061605906865432d, y: 0.7564382847699891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.625273220218611d, y: 0.4953333627653722d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23767352617976645d, y: 0.23455184660307382d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3688039930423096d, y: 0.32913737123337394d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8594905431904356d, y: 0.18063151935137522d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11913768068197184d, y: 0.3767151350740512d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25379163170281627d, y: 0.13279630628640937d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7998744726473753d, y: 0.8830759329816922d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3257375402723286d, y: 0.8976361180761261d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16201499351178794d, y: 0.06793456694925415d),

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
new NpgsqlTypes.NpgsqlPoint(x: 0.9729478484908343d, y: 0.2163981297535823d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8215935447830369d, y: 0.2876733854048137d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1668393653363388d, y: 0.5184140968642831d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05835358568572824d, y: 0.03173558218961692d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2615531282869922d, y: 0.6327480241050553d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1314540281848421d, y: 0.3207422777884613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4732188033307446d, y: 0.8904047514901019d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.622347932525052d, y: 0.47922159123447894d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458229883927464d, y: 0.44999444831941693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6587506338031169d, y: 0.4598185354532881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5684954093420628d, y: 0.5491186763154864d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10689314142258521d, y: 0.3579083013408273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4478140859993093d, y: 0.9531501780042915d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22898846325402145d, y: 0.25563370128587104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09085719275455617d, y: 0.4584972525067825d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4178242123174284d, y: 0.5015996142825447d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06393712502769644d, y: 0.039612895527775915d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36215286836940974d, y: 0.9384661439925479d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9038881903526504d, y: 0.678167690288596d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9092802291471592d, y: 0.5226335586055388d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9305344109772689d, y: 0.6244598577165383d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24269821392322477d, y: 0.6236665205294015d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6804850562654853d, y: 0.8259824566440114d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0617804250215902d, y: 0.14815295671059392d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6183200976976941d, y: 0.9028782458502352d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38985226780919424d, y: 0.6349445148320043d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2993505929667244d, y: 0.4583072199214804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9354017301314304d, y: 0.4821278242850139d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8525276427394918d, y: 0.046349180525866784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3546726725417002d, y: 0.21383457048366283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5930546950914295d, y: 0.1424075061565413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0013604684550606594d, y: 0.7067374762677545d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09906600732431536d, y: 0.7239321096334302d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15846312964609321d, y: 0.6601996717862748d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5937178301047719d, y: 0.6751384035230202d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7829437189104453d, y: 0.7823069846462374d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5676347635784667d, y: 0.6279748582606652d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7459492215911703d, y: 0.7815604724740095d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05011286181544139d, y: 0.0022506745941657247d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29451975696208055d, y: 0.12757648586820003d),

new NpgsqlTypes.NpgsqlPoint(x: 0.057592183238606376d, y: 0.11439703074962781d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3373996272667925d, y: 0.862995295729006d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1170155334104872d, y: 0.358847424613026d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7709582638100928d, y: 0.15080851493976988d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7392747994130797d, y: 0.3000263535007751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38044304686564767d, y: 0.015977551455236605d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44694573315944197d, y: 0.7031766931409739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6941623863620703d, y: 0.14375149792788844d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8338438290902735d, y: 0.8353838826591856d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0520721549981209d, y: 0.22294724740425542d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6561431536803528d, y: 0.036557234550303686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8079426430223802d, y: 0.5516705204041245d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9465628204856582d, y: 0.09668501275753438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6561074418069247d, y: 0.1827411901197954d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8491920615996471d, y: 0.5591327967451261d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6520801496654199d, y: 0.14483766712146895d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5835117981232725d, y: 0.8917438116966258d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17983134938823764d, y: 0.8920215102830616d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25570586707534604d, y: 0.14896439959227648d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6867948328048237d, y: 0.007353818142999291d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12881453855653735d, y: 0.6623604024417201d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09091258242941325d, y: 0.10872844869574072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.893826322808287d, y: 0.9797588398395042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6644956200533576d, y: 0.44515243062346366d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21306361785501127d, y: 0.3245395814109273d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6243134594416332d, y: 0.48247900289983436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22024676998289838d, y: 0.7063789421869204d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1247179742441692d, y: 0.9188153032260591d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7773939544657182d, y: 0.01728858231144681d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12531714384324177d, y: 0.9630760486383159d),

new NpgsqlTypes.NpgsqlPoint(x: 0.998541552210949d, y: 0.8719569350550755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5326978505158886d, y: 0.14588339691068875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8467701189926483d, y: 0.7761813034702044d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28616811241327644d, y: 0.15109775917622803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6317762014685953d, y: 0.5842753013157093d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9531375036536973d, y: 0.6310349885232772d),

new NpgsqlTypes.NpgsqlPoint(x: 0.612302814449174d, y: 0.7254680723913186d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.680019351275053d, y: 0.4530442916571331d),

new NpgsqlTypes.NpgsqlPoint(x: 0.673453947930144d, y: 0.326621788425964d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7404575580475562d, y: 0.3362919729413012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4092275437365782d, y: 0.840896192056777d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0025973087032608033d, y: 0.5216932468420776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8921858964948942d, y: 0.8432448858813633d),

new NpgsqlTypes.NpgsqlPoint(x: 0.693428792399926d, y: 0.2341969290070156d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.659564101164856d, y: 0.6432667681525428d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2226611610220679d, y: 0.8406886286589933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7547092944355009d, y: 0.26339755414968635d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2694267204918912d, y: 0.44657472569453505d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9406401556611867d, y: 0.42590314776465954d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07918251392353726d, y: 0.6112775223105112d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03724864991317334d, y: 0.3542936067983904d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24116644342259386d, y: 0.250783429552664d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23375411612764085d, y: 0.8925237659713079d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7506199846130461d, y: 0.9224844755030136d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4850969520183275d, y: 0.3645541810217269d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8600877722246941d, y: 0.661527812239544d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8637726756109143d, y: 0.23738432783757013d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0006566431207202239d, y: 0.15956814982220513d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5829324923646878d, y: 0.9986338589242127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5013371563540248d, y: 0.30768666041652304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9710271767313958d, y: 0.20871433705777798d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5125367058243109d, y: 0.41750495558554057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8810020695111778d, y: 0.7576253858836078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9905472196878654d, y: 0.2296411910494417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1805535488624056d, y: 0.941826971163109d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6734587688716765d, y: 1.7403843180052725E-05d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24207908548055446d, y: 0.4842823112516861d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5098447586791597d, y: 0.8221399748932953d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8139391953563162d, y: 0.5503780012437197d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7488150377502321d, y: 0.38967089545998834d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21329708328876762d, y: 0.41504901194013377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8660215376730592d, y: 0.07365904455387107d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8042031811284686d, y: 0.29659130260866695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7257452534122378d, y: 0.6627043107635648d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3923480048555913d, y: 0.2633576972809598d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.277455383995585d, y: 0.775128324838547d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5515053798455999d, y: 0.5262360371469109d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7513833837312279d, y: 0.8596570996129929d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7397761011780029d, y: 0.6523560107642022d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9125064938691119d, y: 0.36291990351086256d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5439649088428176d, y: 0.9269756555935547d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7855217840679077d, y: 0.9935489807029971d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8865084778021437d, y: 0.1271087878242546d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4634559604540267d, y: 0.28222200141452003d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7371618921229786d, y: 0.0852733280675283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8231425521670176d, y: 0.9689728811401913d),

new NpgsqlTypes.NpgsqlPoint(x: 0.003596525891572666d, y: 0.33704688070380784d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35844927743214616d, y: 0.3173112339990032d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8216001463870152d, y: 0.6282597929391166d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3291439173816926d, y: 0.13973610919296453d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.825275991817763d, y: 0.6103675004278671d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2801367437986927d, y: 0.08702721801851132d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8158708931808695d, y: 0.7505817114739336d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3094540671494169d, y: 0.06196749556471248d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7208868119289743d, y: 0.4478521881794406d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34160050399325426d, y: 0.9549613869905853d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8925972907894797d, y: 0.9901942081590998d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04978233231442397d, y: 0.24784759185183547d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6851205406180649d, y: 0.05676746063712457d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2906764728059108d, y: 0.49489735903399323d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7751853678864711d, y: 0.7110793491058535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.623926927836949d, y: 0.01725060086402508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9448101832804183d, y: 0.6407188404515063d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.039136475482488886d, y: 0.3983660157659703d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0777612845065545d, y: 0.8720556564332297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11753922481252344d, y: 0.972129489979734d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04456429850288812d, y: 0.6201285076618677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44071746011419055d, y: 0.027204572044353337d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6728003318964233d, y: 0.5842000098344923d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5817384631977965d, y: 0.23088254117803253d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3435860028439156d, y: 0.053429602144066335d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07179166082392363d, y: 0.4541916792785933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25480877839222593d, y: 0.14398100128740754d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7704262530192505d, y: 0.6059578770339558d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9665218979243146d, y: 0.24836823168451294d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7271769246469206d, y: 0.90481651277031d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08838169616326996d, y: 0.27939979357735534d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19369628385698667d, y: 0.9391281244896631d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2772891987610052d, y: 0.9636824932077185d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7603700424687434d, y: 0.13774802970400746d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3421108373909836d, y: 0.9034803544452784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8325704422286551d, y: 0.9265642360382654d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8410088946571834d, y: 0.2013325036728164d),

new NpgsqlTypes.NpgsqlPoint(x: 0.010577220923955521d, y: 0.590016869993245d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8604801541439636d, y: 0.04973378815265406d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11744160143249138d, y: 0.00021253672555843206d),

new NpgsqlTypes.NpgsqlPoint(x: 0.901858511716622d, y: 0.7875487323004777d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13426006930051104d, y: 0.01236755297831904d),

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

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
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
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 147;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
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
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
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
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 79;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
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
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 147, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 9, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
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
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 20, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 65, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
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
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 111, query1, 115, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[34], false);
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
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 102, query1, 70, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 138, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[34], false);
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
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 40, query1, 100, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
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
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 70, 76))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 50, 53))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[34], false);
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
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 53);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

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
                NpgsqlPointpointArray2M.AssertModel(models[20],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[21],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[22],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[23],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WASelectImportModelInnerConfig()
        {
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI), typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                await ((INpgsqlPointListpointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                ((INpgsqlPointListpointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

