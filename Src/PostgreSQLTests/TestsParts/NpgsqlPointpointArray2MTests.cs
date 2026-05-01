

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
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6149364558046109d, y: 0.6554284874907803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08867367030781093d, y: 0.6267418316395623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.527113808097941d, y: 0.4518663292262435d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5036969879955626d, y: 0.2238448181125191d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5420942922868299d, y: 0.1922107096877541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27420421259928396d, y: 0.4274657509987472d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9709187195423697d, y: 0.0011223287607394772d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24959195369972642d, y: 0.9421367137407586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6125507805593089d, y: 0.3546346625078577d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9051317556849072d, y: 0.4887900129863829d),

new NpgsqlTypes.NpgsqlPoint(x: 0.753440142122922d, y: 0.013016504098910864d),

new NpgsqlTypes.NpgsqlPoint(x: 0.058888129853829074d, y: 0.5585293148954928d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8665497763046973d, y: 0.7268713612630566d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5919958376622223d, y: 0.9672495133870891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9805500135153299d, y: 0.78380589931004d),

new NpgsqlTypes.NpgsqlPoint(x: 0.553964766952202d, y: 0.7224988633012678d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6995820127431468d, y: 0.9074975117732753d),

new NpgsqlTypes.NpgsqlPoint(x: 0.805819367376014d, y: 0.6481182086560477d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6252646732558899d, y: 0.847460874716788d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24343890845271854d, y: 0.7513335189087915d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7821534480889322d, y: 0.6193781282698775d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11686887954172331d, y: 0.2103390797284469d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.98153398144186d, y: 0.783450854204241d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6632874326836918d, y: 0.7277897981249937d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07841583308803446d, y: 0.34816425474504953d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21931178052879896d, y: 0.6114355138650649d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05156045030634704d, y: 0.5723495308579329d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22998328247158306d, y: 0.6852749510003042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.646873992921122d, y: 0.47706271302128944d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09819311319820212d, y: 0.7694893096996969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8484033467824181d, y: 0.07987349122465237d),

new NpgsqlTypes.NpgsqlPoint(x: 0.96625062565056d, y: 0.27965274870691637d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7658646946199663d, y: 0.3841605502248686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04627155542480432d, y: 0.003342427033974804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6686338210737869d, y: 0.08288367060096902d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5069434526364947d, y: 0.8463927810602945d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5461118922468965d, y: 0.10251400815328693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018342597008622286d, y: 0.7655568492787815d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8375472627931368d, y: 0.15830253799046923d),

new NpgsqlTypes.NpgsqlPoint(x: 0.025347650390716736d, y: 0.5767057654317703d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6889024212531127d, y: 0.08079942996310274d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24138572601587283d, y: 0.047367682613292716d),

new NpgsqlTypes.NpgsqlPoint(x: 0.79807459030738d, y: 0.7556264357831515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5605385145003279d, y: 0.3591899293592312d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.895777506731167d, y: 0.3471011622279391d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6467992578887415d, y: 0.49416226048576084d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3493260908830681d, y: 0.13182828264124213d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9651886149869003d, y: 0.8698825677559293d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.932413641619914d, y: 0.9543865991180253d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21769612234472502d, y: 0.3459500759326105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43608013675191126d, y: 0.8676959307918689d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5228031872550677d, y: 0.9265038371520523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25710800347251417d, y: 0.3949565968553236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33147439726844974d, y: 0.8108517050670689d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4901066935224967d, y: 0.890095032139625d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5529343276780987d, y: 0.042706911101060396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8904950563316502d, y: 0.3485343366611695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7801743475589281d, y: 0.7205459602877359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4698497399153362d, y: 0.08323028532211574d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2934708549351518d, y: 0.8505429556752004d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15954271328687886d, y: 0.28704468292263785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34015307235046477d, y: 0.6850515799589465d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9279766091146401d, y: 0.7833984898980042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4924723731263153d, y: 0.36372904842395526d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49439197778540567d, y: 0.3566803055257265d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3052182289022153d, y: 0.6129541795274572d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7759017636896579d, y: 0.6775531248484907d),

new NpgsqlTypes.NpgsqlPoint(x: 0.031461297586383385d, y: 0.025821593807156984d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13294224517813025d, y: 0.3522589948700885d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40945140662319257d, y: 0.7992239872169273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.656697480053401d, y: 0.13551327507358923d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44076265304893736d, y: 0.2123048151511412d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8886467921362897d, y: 0.2219711287537257d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37237676346372794d, y: 0.07037650003880258d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37859496479000554d, y: 0.4736116232197001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8979514430164308d, y: 0.6838166524961776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14417116992723922d, y: 0.5009368310996182d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49765151150028064d, y: 0.9550200049404952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8751607002179423d, y: 0.4828073346078392d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6267084795504652d, y: 0.5516461408054467d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37468069741125554d, y: 0.8999458160156903d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6481175494321074d, y: 0.18110425900175775d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8898849158216607d, y: 0.112056413062387d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3649478251030137d, y: 0.37744869938449066d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1459358922126106d, y: 0.0660054382505102d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9163258414934963d, y: 0.06015667339325681d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5306239572478549d, y: 0.6135627330856238d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5223615940408352d, y: 0.39360416810517984d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2484386211810503d, y: 0.9628230748673209d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8321384208298244d, y: 0.5921328074635989d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6849086041079522d, y: 0.7067890002591541d),

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
new NpgsqlTypes.NpgsqlPoint(x: 0.5611783553827514d, y: 0.22641994523995068d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8083700602983751d, y: 0.6895637954436529d),

new NpgsqlTypes.NpgsqlPoint(x: 0.030655769704395985d, y: 0.638349942597d),

new NpgsqlTypes.NpgsqlPoint(x: 0.702032817864309d, y: 0.650223486172723d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13813317134349612d, y: 0.6397334885568424d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2193045336262721d, y: 0.6621473653771807d),

new NpgsqlTypes.NpgsqlPoint(x: 0.724965304859774d, y: 0.008768955337653428d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17727235545101028d, y: 0.01826930903628665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03539553093449366d, y: 0.45355561003996214d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2062207769958364d, y: 0.607667015408521d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1358490457658027d, y: 0.961091002679563d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38210560945806293d, y: 0.9587990393369544d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6261892508908139d, y: 0.3785731069941244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9790255742977042d, y: 0.9528776739375434d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6313195200325803d, y: 0.8521599001737632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8836647831102166d, y: 0.2563578483817365d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04196523220640602d, y: 0.7417752242583183d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9251296028817233d, y: 0.5917258139725735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7608206252262472d, y: 0.7178693260366308d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7332326359828859d, y: 0.647338643974569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2708270923596413d, y: 0.7961251976620255d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8002804179240708d, y: 0.38160090964913185d),

new NpgsqlTypes.NpgsqlPoint(x: 0.674930394869258d, y: 0.6514781985283088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4573933172253206d, y: 0.008229624428784499d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5517476659465265d, y: 0.15210896871508994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1587342913757458d, y: 0.298834724805491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6959165357492072d, y: 0.18648158082347333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6369494143643736d, y: 0.3365319151276587d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9843744612646202d, y: 0.5814378314334426d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8548164516691563d, y: 0.6653098515663045d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08867791090236044d, y: 0.4358561421808115d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.26451236932168254d, y: 0.1639615857771607d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7229186881363449d, y: 0.9045234073231944d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31784515937373126d, y: 0.7025592984685959d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08608785963142507d, y: 0.8292224889053421d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5423026312434985d, y: 0.27155878127315225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9651497981120302d, y: 0.70561386486004d),

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
new NpgsqlTypes.NpgsqlPoint(x: 0.4029296318160327d, y: 0.5632746987526281d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48911325437032127d, y: 0.8121460267574292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9719526718240808d, y: 0.8846177720499092d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45869963135483527d, y: 0.9357730613676325d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8867331262218786d, y: 0.1797961170894623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8991952964740647d, y: 0.7414132717639988d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5980383530509624d, y: 0.13907990773983547d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5551718919368815d, y: 0.41797305513171223d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26288178670232776d, y: 0.7520604456727842d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18826211600382736d, y: 0.11575795464501493d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9264135787206871d, y: 0.13346042462798924d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4902802213110312d, y: 0.30111810544576667d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3732226212494617d, y: 0.2441539529343032d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8491387014427649d, y: 0.9160176766191089d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7777106563465195d, y: 0.5285889068987039d),

new NpgsqlTypes.NpgsqlPoint(x: 0.552301995412863d, y: 0.6184548825070111d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45679586237387715d, y: 0.6547296681113733d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16331196889472122d, y: 0.029277822511824425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9379680850633908d, y: 0.6212791503192654d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9692743374350832d, y: 0.2264664530328192d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23782868940393753d, y: 0.1933954459355094d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0007282194091418059d, y: 0.8486803012164804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18679022957490388d, y: 0.6596386101234285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6885449842689302d, y: 0.9156331239625296d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9960017589921459d, y: 0.7425768730130836d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10118847185162427d, y: 0.9620452378978874d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33710044078878d, y: 0.9846765667151136d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6455529213552359d, y: 0.44794046528044607d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8796843297103268d, y: 0.4228199235416539d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9431603917138948d, y: 0.6443812489680205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6988504295473645d, y: 0.7731014652960849d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8280370945690213d, y: 0.3232518735352019d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9622401397598236d, y: 0.7971811074348258d),

new NpgsqlTypes.NpgsqlPoint(x: 0.031474527902480176d, y: 0.7993829443294872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5705836107500888d, y: 0.6570730093927075d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8480851839721465d, y: 0.6397086300858222d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9940096524108135d, y: 0.9646166152505117d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07675345893691121d, y: 0.3399951456095083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6626319669838877d, y: 0.4417838273972432d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30258548557731313d, y: 0.970530620941314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8637575859510505d, y: 0.09684188614040579d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7956391487695647d, y: 0.28415907507693194d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.906613757698601d, y: 0.14162603737321522d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17149348248084006d, y: 0.6933057045002836d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09560937683993687d, y: 0.059044911922960686d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10765116544756659d, y: 0.7973913429685299d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9154466593605727d, y: 0.3008763544793165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7219800350686058d, y: 0.36979203698118635d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5673636618283037d, y: 0.7527623543040604d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9564977413452642d, y: 0.8929412234509935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18194943463224966d, y: 0.9449667047185594d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05828163068109249d, y: 0.8279845362024588d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8140936498573416d, y: 0.31924449294953927d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10213256601339638d, y: 0.879559953572982d),

new NpgsqlTypes.NpgsqlPoint(x: 0.624155718098594d, y: 0.47033438492194124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3313477147966548d, y: 0.17052006551611887d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35523525812416346d, y: 0.11484621934869121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2966230265524893d, y: 0.482100921129193d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21713943352311538d, y: 0.8358605387668422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9047773825950107d, y: 0.7405445988143395d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4066588096450595d, y: 0.14417850499712404d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5388991926910417d, y: 0.066881276607614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5511890965182399d, y: 0.7788243035391108d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9344446515458634d, y: 0.05897733012541451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20002078448946392d, y: 0.8827381874738041d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6340867109347914d, y: 0.7483596091390767d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7476333713308819d, y: 0.6877878439416188d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9501804017875597d, y: 0.6658559047409283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43805280759311993d, y: 0.4123965065552333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14795573859702116d, y: 0.5973854594798111d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3312152174343723d, y: 0.08371375410128257d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48166881929394567d, y: 0.8363990944157301d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7675357989413217d, y: 0.40952978579815913d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04778469541540198d, y: 0.6051030574694266d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2049364443211591d, y: 0.20718709823918502d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2904694575723905d, y: 0.3644135339418235d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7183820485987533d, y: 0.8980041062103267d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38519430795843024d, y: 0.950531415044957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3249504083716894d, y: 0.6088598891044298d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4996146449380058d, y: 0.9634403238915159d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5864822576672627d, y: 0.9707326659813794d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4471089156577578d, y: 0.4399732137927782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9743231020319502d, y: 0.7612001785152552d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16788724030599222d, y: 0.21405351383859872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8552322974358691d, y: 0.8950100209788754d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0444558725334524d, y: 0.3355553067683482d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5732316122550486d, y: 0.44562974721956206d),

new NpgsqlTypes.NpgsqlPoint(x: 0.479609950614446d, y: 0.7622816772854384d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8141998929153503d, y: 0.9759473511975123d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8026360984347447d, y: 0.7822632191530781d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9557934932034811d, y: 0.3270761906921862d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44578253592504846d, y: 0.4773424694614036d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.048938880322572986d, y: 0.345351538407212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3133561891846328d, y: 0.06271996887793096d),

new NpgsqlTypes.NpgsqlPoint(x: 0.971223312875952d, y: 0.8672777246164746d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6898990390096132d, y: 0.9041139105091095d),

new NpgsqlTypes.NpgsqlPoint(x: 0.560570418486816d, y: 0.7972220873115533d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8795518326176837d, y: 0.02972087925964173d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22036992059003435d, y: 0.14030836573448602d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44622675396552736d, y: 0.2599009210271056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8919420315945948d, y: 0.1330009251880604d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31719659547288626d, y: 0.5342944812378476d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08303095078913625d, y: 0.9810901894259773d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18705593429528777d, y: 0.7312780853511772d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2894727399995929d, y: 0.5577733711108592d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8938314713489314d, y: 0.7641067780788794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8657153261782876d, y: 0.039366851729566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5028439920866962d, y: 0.9384508514836911d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8592695025228585d, y: 0.5748749107259297d),

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
new NpgsqlTypes.NpgsqlPoint(x: 0.37897071637548285d, y: 0.9978050354685098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4225181132699085d, y: 0.8430408714300056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03136289505477008d, y: 0.41031193678931366d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8608749396942423d, y: 0.5524490298023087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41316937714602997d, y: 0.5289260279305393d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7479957203418454d, y: 0.04571672346959299d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6492762408850832d, y: 0.281386722049184d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42923135141229596d, y: 0.11581137726397372d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8979876010873534d, y: 0.2715923471017613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9583162335497809d, y: 0.8762258859593234d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9373624158511027d, y: 0.7819289268111922d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7749582799750013d, y: 0.10203922067370197d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4491495216664322d, y: 0.2400786346685706d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19701531621355628d, y: 0.8040456150221769d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.024730076594990935d, y: 0.3710000530392741d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6151459451071343d, y: 0.7361974049920976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7249870687016182d, y: 0.24210308871624964d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48815242316352747d, y: 0.8546325094044934d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08009970032800373d, y: 0.8324384368825632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6152075893095829d, y: 0.4649325842482378d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4737573486241211d, y: 0.6325579038272896d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8065315585200168d, y: 0.5835198241282712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7986652531646808d, y: 0.0031847862127070137d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7612636146011761d, y: 0.14546015581434946d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.011538047394601292d, y: 0.9670770003537437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7783325241646682d, y: 0.3268107578602498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3939611502945387d, y: 0.34518437440765215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7367852833455942d, y: 0.7724533497465557d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5373188409371488d, y: 0.7304807324323189d),

new NpgsqlTypes.NpgsqlPoint(x: 0.981648072549698d, y: 0.7333778265428652d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5020660128519273d, y: 0.6662148051807489d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8603875500702629d, y: 0.4591182252946502d),

},
    ModelInner = null,
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[34], false);
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
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
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
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
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 63;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

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
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 90, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 2, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
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
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[31],_testData[34], false);
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
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 44, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[34], false);
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
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 63, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
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
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 23, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[34], false);
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
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 102, query1, 114, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 9, query1, 145, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[34], false);
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
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 49, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 75, 140))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 29, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[34], false);
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
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[7], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[8], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[9], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[10], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[14], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[15], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[16], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[17], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[18], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[19], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[15],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[16],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[17],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[18],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[19],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[20],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[21],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[22],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[23],_testData[29], false);
                NpgsqlPointpointArray2M.AssertModel(models[24],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[25],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[26],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[27],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 82);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[29], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[34], false);
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

