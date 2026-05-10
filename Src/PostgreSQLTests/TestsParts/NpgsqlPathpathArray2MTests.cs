

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2698023897749252d, y: 0.2804893419534038d), new NpgsqlTypes.NpgsqlPoint(x: 0.806500893058391d, y: 0.7144511020843315d), new NpgsqlTypes.NpgsqlPoint(x: 0.0011547569778458389d, y: 0.40217816537679474d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07701066079185048d, y: 0.4505902212914794d), new NpgsqlTypes.NpgsqlPoint(x: 0.5862020527593519d, y: 0.37785720673554657d), new NpgsqlTypes.NpgsqlPoint(x: 0.2348009061824904d, y: 0.4306377241973959d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.032901136841033685d, y: 0.5148259700106379d), new NpgsqlTypes.NpgsqlPoint(x: 0.7020638624178868d, y: 0.6931328750878875d), new NpgsqlTypes.NpgsqlPoint(x: 0.11329944881495135d, y: 0.4973994215788069d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28420352348591227d, y: 0.3070715740575479d), new NpgsqlTypes.NpgsqlPoint(x: 0.005183001961155509d, y: 0.7328241594648588d), new NpgsqlTypes.NpgsqlPoint(x: 0.9879133626736367d, y: 0.7181341458673358d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6947700902525329d, y: 0.4631494503680368d), new NpgsqlTypes.NpgsqlPoint(x: 0.6386413699549363d, y: 0.23161124428648483d), new NpgsqlTypes.NpgsqlPoint(x: 0.09727173368842135d, y: 0.09457560836118939d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27470537698592146d, y: 0.4551043994128844d), new NpgsqlTypes.NpgsqlPoint(x: 0.8519617667388981d, y: 0.49986657204772156d), new NpgsqlTypes.NpgsqlPoint(x: 0.6360904071910789d, y: 0.7572137899159296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7137173891744505d, y: 0.11009122898532253d), new NpgsqlTypes.NpgsqlPoint(x: 0.11849349388450436d, y: 0.2221421619980256d), new NpgsqlTypes.NpgsqlPoint(x: 0.2020982011063065d, y: 0.4247508483818785d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2678775437092613d, y: 0.3862333224628537d), new NpgsqlTypes.NpgsqlPoint(x: 0.6393680976901908d, y: 0.9198821746514751d), new NpgsqlTypes.NpgsqlPoint(x: 0.5419459796000562d, y: 0.5682599298234061d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14874142418598735d, y: 0.08068182995514206d), new NpgsqlTypes.NpgsqlPoint(x: 0.4706841918188456d, y: 0.453569034556072d), new NpgsqlTypes.NpgsqlPoint(x: 0.3539003442671438d, y: 0.14072319453277526d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3656677202965519d, y: 0.6876954981244485d), new NpgsqlTypes.NpgsqlPoint(x: 0.20666394343405492d, y: 0.7813792369236648d), new NpgsqlTypes.NpgsqlPoint(x: 0.2312942628329704d, y: 0.02743074995671546d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26379129034705184d, y: 0.9777626382942208d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971294241262869d, y: 0.7917719937118297d), new NpgsqlTypes.NpgsqlPoint(x: 0.2316602682780149d, y: 0.7793238941674805d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2529535555369632d, y: 0.9598236018977213d), new NpgsqlTypes.NpgsqlPoint(x: 0.6610926498539312d, y: 0.10528919070352305d), new NpgsqlTypes.NpgsqlPoint(x: 0.4020091837410663d, y: 0.5315377848956773d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9392397959473315d, y: 0.6905128433673351d), new NpgsqlTypes.NpgsqlPoint(x: 0.039066479327434456d, y: 0.35054379910977984d), new NpgsqlTypes.NpgsqlPoint(x: 0.9108991804391836d, y: 0.6188244537371039d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.312203220717046d, y: 0.20421700773925666d), new NpgsqlTypes.NpgsqlPoint(x: 0.28416349712891664d, y: 0.8319127344982665d), new NpgsqlTypes.NpgsqlPoint(x: 0.8069606335654882d, y: 0.7656593317013305d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14749658343553107d, y: 0.9578737782373826d), new NpgsqlTypes.NpgsqlPoint(x: 0.5168452035019065d, y: 0.4532601607698502d), new NpgsqlTypes.NpgsqlPoint(x: 0.3727600293427942d, y: 0.373147274262847d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6047112943196304d, y: 0.3741182069854537d), new NpgsqlTypes.NpgsqlPoint(x: 0.2876684465811634d, y: 0.649480089385509d), new NpgsqlTypes.NpgsqlPoint(x: 0.4641628664550339d, y: 0.3711229416090974d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12243236395351642d, y: 0.7399355424506904d), new NpgsqlTypes.NpgsqlPoint(x: 0.9250903050972573d, y: 0.42115351465367745d), new NpgsqlTypes.NpgsqlPoint(x: 0.33208216898917586d, y: 0.011450990371770442d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8925817196971741d, y: 0.3637321269878401d), new NpgsqlTypes.NpgsqlPoint(x: 0.7289829616665494d, y: 0.6406558934323631d), new NpgsqlTypes.NpgsqlPoint(x: 0.8587501704783319d, y: 0.9944222038985412d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7473938466109932d, y: 0.9040704715659748d), new NpgsqlTypes.NpgsqlPoint(x: 0.2784173645984054d, y: 0.17679540649850045d), new NpgsqlTypes.NpgsqlPoint(x: 0.6802303319090438d, y: 0.23906532027170446d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48555904928666616d, y: 0.5917383039794215d), new NpgsqlTypes.NpgsqlPoint(x: 0.8180629748167954d, y: 0.14275891878790892d), new NpgsqlTypes.NpgsqlPoint(x: 0.4602051403833506d, y: 0.007186883752455908d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6865966269113914d, y: 0.13888692675196623d), new NpgsqlTypes.NpgsqlPoint(x: 0.12136401904278604d, y: 0.3123278304035775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7764091666835515d, y: 0.7224249052707926d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9758445068793576d, y: 0.794417749820871d), new NpgsqlTypes.NpgsqlPoint(x: 0.15541332790779427d, y: 0.13513893047688808d), new NpgsqlTypes.NpgsqlPoint(x: 0.16927891168494125d, y: 0.7144213686388864d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13835216203997003d, y: 0.458598291915731d), new NpgsqlTypes.NpgsqlPoint(x: 0.9822307073568507d, y: 0.7225068977070807d), new NpgsqlTypes.NpgsqlPoint(x: 0.4202690245022308d, y: 0.7753570577927027d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.513231250928599d, y: 0.03361495835193129d), new NpgsqlTypes.NpgsqlPoint(x: 0.883838830759188d, y: 0.5479056101515006d), new NpgsqlTypes.NpgsqlPoint(x: 0.6190629302023162d, y: 0.9448549886416922d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.853678834328501d, y: 0.7096410808460621d), new NpgsqlTypes.NpgsqlPoint(x: 0.9892155981855095d, y: 0.8303064826647015d), new NpgsqlTypes.NpgsqlPoint(x: 0.24474541001219396d, y: 0.7690999097017156d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8638296504211713d, y: 0.2972053213294622d), new NpgsqlTypes.NpgsqlPoint(x: 0.5724213152748763d, y: 0.8882573705238149d), new NpgsqlTypes.NpgsqlPoint(x: 0.27549391934110756d, y: 0.08608196074742447d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3366953406856642d, y: 0.48275835990482796d), new NpgsqlTypes.NpgsqlPoint(x: 0.7947461806863461d, y: 0.44128772389101456d), new NpgsqlTypes.NpgsqlPoint(x: 0.9375531390933074d, y: 0.10866088939568086d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49415776879687057d, y: 0.3424264932173906d), new NpgsqlTypes.NpgsqlPoint(x: 0.19022621948252993d, y: 0.6623641246551579d), new NpgsqlTypes.NpgsqlPoint(x: 0.8458087140836992d, y: 0.1968600010730296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4470607856312796d, y: 0.3632833927103105d), new NpgsqlTypes.NpgsqlPoint(x: 0.1323282682713477d, y: 0.038971835914817454d), new NpgsqlTypes.NpgsqlPoint(x: 0.344327759457266d, y: 0.2503600639940069d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5219967137969576d, y: 0.1302362315023815d), new NpgsqlTypes.NpgsqlPoint(x: 0.13879343909065878d, y: 0.8920563413509324d), new NpgsqlTypes.NpgsqlPoint(x: 0.44409378303885394d, y: 0.11508850682527183d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.347965777909795d, y: 0.8420842101601786d), new NpgsqlTypes.NpgsqlPoint(x: 0.36857657155899326d, y: 0.3289773046347254d), new NpgsqlTypes.NpgsqlPoint(x: 0.2158270859449919d, y: 0.4969764086231113d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1773204848590657d, y: 0.28303237454693386d), new NpgsqlTypes.NpgsqlPoint(x: 0.7768870825291212d, y: 0.41320165616488824d), new NpgsqlTypes.NpgsqlPoint(x: 0.14816933462474513d, y: 0.6245679281356156d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7512714074180052d, y: 0.5085592361720079d), new NpgsqlTypes.NpgsqlPoint(x: 0.3976353386074777d, y: 0.7456602194116727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6499738920261837d, y: 0.5494217922191864d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9129767254356439d, y: 0.35884302259434797d), new NpgsqlTypes.NpgsqlPoint(x: 0.7537407998506604d, y: 0.027682191780906917d), new NpgsqlTypes.NpgsqlPoint(x: 0.0777920034133609d, y: 0.8707579315328582d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08135459417499724d, y: 0.8980808529322709d), new NpgsqlTypes.NpgsqlPoint(x: 0.08316287080432394d, y: 0.6524136545544995d), new NpgsqlTypes.NpgsqlPoint(x: 0.4722473934207002d, y: 0.8271577866072152d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19890597006362498d, y: 0.09592159403367273d), new NpgsqlTypes.NpgsqlPoint(x: 0.08868495108449503d, y: 0.7094635190049998d), new NpgsqlTypes.NpgsqlPoint(x: 0.6245784525821719d, y: 0.6547832568815286d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6764056889371197d, y: 0.3911040247682488d), new NpgsqlTypes.NpgsqlPoint(x: 0.2475074526300356d, y: 0.525158215163737d), new NpgsqlTypes.NpgsqlPoint(x: 0.15346005305593047d, y: 0.0903561409611342d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4172077494341575d, y: 0.09468168358202356d), new NpgsqlTypes.NpgsqlPoint(x: 0.5462441534150819d, y: 0.3519947012063246d), new NpgsqlTypes.NpgsqlPoint(x: 0.8069021384648438d, y: 0.2785330913834603d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4354497380981739d, y: 0.082339086052586d), new NpgsqlTypes.NpgsqlPoint(x: 0.8896272100433502d, y: 0.6027117885150475d), new NpgsqlTypes.NpgsqlPoint(x: 0.07273471000931409d, y: 0.7531403953045529d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6580376909227608d, y: 0.14985132652912414d), new NpgsqlTypes.NpgsqlPoint(x: 0.7575304993192437d, y: 0.5860063825035048d), new NpgsqlTypes.NpgsqlPoint(x: 0.6629497936540424d, y: 0.8636477727286527d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9176470648376507d, y: 0.5409906836160862d), new NpgsqlTypes.NpgsqlPoint(x: 0.37362825677743006d, y: 0.1786785698491924d), new NpgsqlTypes.NpgsqlPoint(x: 0.13312794677802875d, y: 0.49720887731704866d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28232658083836926d, y: 0.6990794279438067d), new NpgsqlTypes.NpgsqlPoint(x: 0.6820044073976845d, y: 0.5678277944666876d), new NpgsqlTypes.NpgsqlPoint(x: 0.6303283368531973d, y: 0.2915738144404558d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5157041871667889d, y: 0.3665916538994244d), new NpgsqlTypes.NpgsqlPoint(x: 0.4675284260502959d, y: 0.21020194613817322d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993848165049964d, y: 0.6642653582219727d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8503596101613207d, y: 0.28420072563952403d), new NpgsqlTypes.NpgsqlPoint(x: 0.27749058082502265d, y: 0.7827469025428508d), new NpgsqlTypes.NpgsqlPoint(x: 0.22670209891407567d, y: 0.4979321486457009d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7022665301404527d, y: 0.16108961324534266d), new NpgsqlTypes.NpgsqlPoint(x: 0.6931293301241028d, y: 0.5291671042142989d), new NpgsqlTypes.NpgsqlPoint(x: 0.4680220722130638d, y: 0.6598176118869757d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5704969776172515d, y: 0.27703538988516085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8653346709228665d, y: 0.7045796460449159d), new NpgsqlTypes.NpgsqlPoint(x: 0.2754169206119206d, y: 0.08465115978994797d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4697115946160073d, y: 0.2107297312585069d), new NpgsqlTypes.NpgsqlPoint(x: 0.08055763788024217d, y: 0.49610225614345527d), new NpgsqlTypes.NpgsqlPoint(x: 0.40240704251589765d, y: 0.9853838799356105d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.295364804022728d, y: 0.3069568244108294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6573889662248312d, y: 0.44418878599385847d), new NpgsqlTypes.NpgsqlPoint(x: 0.7213475759568575d, y: 0.7468248617034795d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3137029818294874d, y: 0.15271140784025505d), new NpgsqlTypes.NpgsqlPoint(x: 0.12761072369586113d, y: 0.9847557426306107d), new NpgsqlTypes.NpgsqlPoint(x: 0.3494760828581608d, y: 0.5405336991005032d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28580712273532627d, y: 0.5176732942752311d), new NpgsqlTypes.NpgsqlPoint(x: 0.4019195664113673d, y: 0.26485972390328105d), new NpgsqlTypes.NpgsqlPoint(x: 0.21821608300715178d, y: 0.9787382641599081d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01674199556808531d, y: 0.9372384224340105d), new NpgsqlTypes.NpgsqlPoint(x: 0.36921612743639365d, y: 0.23727173520578704d), new NpgsqlTypes.NpgsqlPoint(x: 0.3788465455777388d, y: 0.21566669653001025d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5585335003058254d, y: 0.9252551338797702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6062524958644273d, y: 0.028732849835185204d), new NpgsqlTypes.NpgsqlPoint(x: 0.22718784394433367d, y: 0.5205109560391041d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2066861881043126d, y: 0.2620193387628248d), new NpgsqlTypes.NpgsqlPoint(x: 0.6468257706751673d, y: 0.635871973256659d), new NpgsqlTypes.NpgsqlPoint(x: 0.9155953389183501d, y: 0.8356415576417611d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5300491522303886d, y: 0.75966557646951d), new NpgsqlTypes.NpgsqlPoint(x: 0.48528025466929947d, y: 0.017520683174568008d), new NpgsqlTypes.NpgsqlPoint(x: 0.4411694991232744d, y: 0.7720787594935479d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5719104953676947d, y: 0.2576712736717556d), new NpgsqlTypes.NpgsqlPoint(x: 0.1400344796882882d, y: 0.7291750933468998d), new NpgsqlTypes.NpgsqlPoint(x: 0.4042344205346058d, y: 0.9100761294103725d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7556415488527968d, y: 0.9548803907898799d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515770306538423d, y: 0.5667681149463931d), new NpgsqlTypes.NpgsqlPoint(x: 0.45639752840643766d, y: 0.914026013692654d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9524159448641665d, y: 0.43460394394280055d), new NpgsqlTypes.NpgsqlPoint(x: 0.8042246806632211d, y: 0.37964195986830485d), new NpgsqlTypes.NpgsqlPoint(x: 0.3229616757734475d, y: 0.9166694954274556d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3869309212101696d, y: 0.7159275261008102d), new NpgsqlTypes.NpgsqlPoint(x: 0.5794081606965007d, y: 0.7718041335773742d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672416453961193d, y: 0.21813276858279163d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.518721427094874d, y: 0.8874169868355686d), new NpgsqlTypes.NpgsqlPoint(x: 0.7934464818778889d, y: 0.3414476544071995d), new NpgsqlTypes.NpgsqlPoint(x: 0.46778556647352565d, y: 0.45199627964172184d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39165482775831495d, y: 0.12422027148885428d), new NpgsqlTypes.NpgsqlPoint(x: 0.6004564390972376d, y: 0.9160172689827224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8777658695070618d, y: 0.8979687190863187d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1008738600251814d, y: 0.26442696548999156d), new NpgsqlTypes.NpgsqlPoint(x: 0.13256102460852337d, y: 0.33263900920417977d), new NpgsqlTypes.NpgsqlPoint(x: 0.21478148354511284d, y: 0.6424490573206433d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.715721855849003d, y: 0.5450773490705403d), new NpgsqlTypes.NpgsqlPoint(x: 0.6118479720396343d, y: 0.572498401714699d), new NpgsqlTypes.NpgsqlPoint(x: 0.7162873014819996d, y: 0.8813370358652138d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7354750055010576d, y: 0.1654225124706471d), new NpgsqlTypes.NpgsqlPoint(x: 0.39118541251089733d, y: 0.35846334217432707d), new NpgsqlTypes.NpgsqlPoint(x: 0.29671012061403135d, y: 0.6022168593862987d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9705394212625097d, y: 0.5931435767928335d), new NpgsqlTypes.NpgsqlPoint(x: 0.45616029829854843d, y: 0.19656707985413457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6658577935758088d, y: 0.8483641001493218d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.911976543077163d, y: 0.16861602997768d), new NpgsqlTypes.NpgsqlPoint(x: 0.7557087892073964d, y: 0.9800311886581673d), new NpgsqlTypes.NpgsqlPoint(x: 0.3747171454236916d, y: 0.31736722338948253d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6001203570023538d, y: 0.1287898337776323d), new NpgsqlTypes.NpgsqlPoint(x: 0.0950591299573037d, y: 0.19182224447041818d), new NpgsqlTypes.NpgsqlPoint(x: 0.28028046133475926d, y: 0.9059494603735474d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.030775718140123698d, y: 0.7539339693604805d), new NpgsqlTypes.NpgsqlPoint(x: 0.09395887219775789d, y: 0.6987663951300644d), new NpgsqlTypes.NpgsqlPoint(x: 0.9979746138442319d, y: 0.6500210884601367d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5450582121258183d, y: 0.16969063123476857d), new NpgsqlTypes.NpgsqlPoint(x: 0.133964618898608d, y: 0.633339939741662d), new NpgsqlTypes.NpgsqlPoint(x: 0.5904570958929577d, y: 0.4445646142168308d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5060541680558801d, y: 0.44174840269317384d), new NpgsqlTypes.NpgsqlPoint(x: 0.7147506305600969d, y: 0.8876076776965145d), new NpgsqlTypes.NpgsqlPoint(x: 0.13188646338804377d, y: 0.6550186848432181d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24239243041588654d, y: 0.16670457378804626d), new NpgsqlTypes.NpgsqlPoint(x: 0.4729284302769585d, y: 0.49009080800373295d), new NpgsqlTypes.NpgsqlPoint(x: 0.010941158531167172d, y: 0.0009540029344771161d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8880497630052183d, y: 0.04591632185387218d), new NpgsqlTypes.NpgsqlPoint(x: 0.40158396399408125d, y: 0.913586968327948d), new NpgsqlTypes.NpgsqlPoint(x: 0.4876889766232593d, y: 0.05510568907477387d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9212884034647488d, y: 0.3716157206422781d), new NpgsqlTypes.NpgsqlPoint(x: 0.05522733047148842d, y: 0.28138417621316814d), new NpgsqlTypes.NpgsqlPoint(x: 0.057623784413054935d, y: 0.9417204326120147d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27243108312021713d, y: 0.6694673918477017d), new NpgsqlTypes.NpgsqlPoint(x: 0.504407491387523d, y: 0.22139257756880315d), new NpgsqlTypes.NpgsqlPoint(x: 0.07498335651128829d, y: 0.09449538202095953d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9610663949393063d, y: 0.5379992229457445d), new NpgsqlTypes.NpgsqlPoint(x: 0.4906235312335683d, y: 0.8973670650468083d), new NpgsqlTypes.NpgsqlPoint(x: 0.7069916854714614d, y: 0.709540092084599d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49077549297039325d, y: 0.3747274616416276d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612022354688614d, y: 0.7651066482788268d), new NpgsqlTypes.NpgsqlPoint(x: 0.5418538609924461d, y: 0.2755856498893916d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4916338727860441d, y: 0.5636778609817258d), new NpgsqlTypes.NpgsqlPoint(x: 0.004208024319504511d, y: 0.18566555078085967d), new NpgsqlTypes.NpgsqlPoint(x: 0.03348179402653051d, y: 0.31096529976014153d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7998585942527158d, y: 0.89592052150907d), new NpgsqlTypes.NpgsqlPoint(x: 0.5275709143151285d, y: 0.26934123201187377d), new NpgsqlTypes.NpgsqlPoint(x: 0.9768449035177644d, y: 0.9463005807939061d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9473521745603821d, y: 0.3558810202336281d), new NpgsqlTypes.NpgsqlPoint(x: 0.5116284727948842d, y: 0.2090997854686063d), new NpgsqlTypes.NpgsqlPoint(x: 0.15672082987621905d, y: 0.5943186539680142d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9341038552007077d, y: 0.2143793055389045d), new NpgsqlTypes.NpgsqlPoint(x: 0.7656636148418515d, y: 0.060582686288517706d), new NpgsqlTypes.NpgsqlPoint(x: 0.24531101149165335d, y: 0.5106228512022354d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5510348929686264d, y: 0.32766076802592325d), new NpgsqlTypes.NpgsqlPoint(x: 0.07265371497633222d, y: 0.9738865143197032d), new NpgsqlTypes.NpgsqlPoint(x: 0.48135219319244305d, y: 0.28480449160182386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03885787415092745d, y: 0.7187329034280794d), new NpgsqlTypes.NpgsqlPoint(x: 0.2343096200280823d, y: 0.7414017628390946d), new NpgsqlTypes.NpgsqlPoint(x: 0.023440299781346208d, y: 0.7196150086596501d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42366834965261946d, y: 0.5963398837002009d), new NpgsqlTypes.NpgsqlPoint(x: 0.48081698014091434d, y: 0.5282446518605772d), new NpgsqlTypes.NpgsqlPoint(x: 0.6652002011853847d, y: 0.06487175523140198d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5049261105320365d, y: 0.06508403881629832d), new NpgsqlTypes.NpgsqlPoint(x: 0.38884048834142637d, y: 0.8660806898805695d), new NpgsqlTypes.NpgsqlPoint(x: 0.11270830963940826d, y: 0.509915230030432d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4497833707650172d, y: 0.7823107430300345d), new NpgsqlTypes.NpgsqlPoint(x: 0.33363141893136794d, y: 0.3693599895681501d), new NpgsqlTypes.NpgsqlPoint(x: 0.3640949014472685d, y: 0.5477808639722969d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42094122841919845d, y: 0.9613413874360689d), new NpgsqlTypes.NpgsqlPoint(x: 0.10359365383588359d, y: 0.5020653115909207d), new NpgsqlTypes.NpgsqlPoint(x: 0.46887792049783406d, y: 0.7857632202232459d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18165252745462757d, y: 0.026610581407293332d), new NpgsqlTypes.NpgsqlPoint(x: 0.2820487794922596d, y: 0.4519083398905035d), new NpgsqlTypes.NpgsqlPoint(x: 0.5169897527058173d, y: 0.054872383700075966d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8266864956085525d, y: 0.09164275022352741d), new NpgsqlTypes.NpgsqlPoint(x: 0.5666019646135945d, y: 0.015213748212853373d), new NpgsqlTypes.NpgsqlPoint(x: 0.2633906390042362d, y: 0.06834415453655773d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.516530660151338d, y: 0.07170712997671258d), new NpgsqlTypes.NpgsqlPoint(x: 0.1339632711435237d, y: 0.5234192973459035d), new NpgsqlTypes.NpgsqlPoint(x: 0.4281136682276382d, y: 0.6273827533814846d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7966367438940605d, y: 0.1184759625620112d), new NpgsqlTypes.NpgsqlPoint(x: 0.508450451897975d, y: 0.4185540393103224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8573412095239535d, y: 0.24494017058319129d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24779638075865473d, y: 0.5819702484180562d), new NpgsqlTypes.NpgsqlPoint(x: 0.1251184241181873d, y: 0.9651637139011705d), new NpgsqlTypes.NpgsqlPoint(x: 0.991958005482421d, y: 0.49829514895360627d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9888593781657458d, y: 0.5313964502765142d), new NpgsqlTypes.NpgsqlPoint(x: 0.6774625519498062d, y: 0.0019550091132856107d), new NpgsqlTypes.NpgsqlPoint(x: 0.5044899042338842d, y: 0.5193549305677779d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5611276561581665d, y: 0.7679691331115235d), new NpgsqlTypes.NpgsqlPoint(x: 0.8087474458430446d, y: 0.9415094830246858d), new NpgsqlTypes.NpgsqlPoint(x: 0.6806974748723786d, y: 0.21317643039711642d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34370132316454893d, y: 0.7728800796494404d), new NpgsqlTypes.NpgsqlPoint(x: 0.4029259483471076d, y: 0.10909712207927924d), new NpgsqlTypes.NpgsqlPoint(x: 0.23292306014027087d, y: 0.07974267346583164d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2629790195220899d, y: 0.6057044901501217d), new NpgsqlTypes.NpgsqlPoint(x: 0.7217024383980525d, y: 0.14908483417539542d), new NpgsqlTypes.NpgsqlPoint(x: 0.08920252544466811d, y: 0.11697969842862832d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9238534663722974d, y: 0.40868475132891025d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158951937156427d, y: 0.5871886959432486d), new NpgsqlTypes.NpgsqlPoint(x: 0.43629815102166514d, y: 0.8517362078206191d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5185238559177635d, y: 0.3047057651459203d), new NpgsqlTypes.NpgsqlPoint(x: 0.07055993363093793d, y: 0.941102327892593d), new NpgsqlTypes.NpgsqlPoint(x: 0.9585973212172312d, y: 0.8696428217561221d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16181232130398748d, y: 0.701012566654571d), new NpgsqlTypes.NpgsqlPoint(x: 0.7537580328849933d, y: 0.9604734485433556d), new NpgsqlTypes.NpgsqlPoint(x: 0.3835650103521421d, y: 0.7714246324783145d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5531483572649046d, y: 0.2016806156670412d), new NpgsqlTypes.NpgsqlPoint(x: 0.640796897057253d, y: 0.05669904353014987d), new NpgsqlTypes.NpgsqlPoint(x: 0.350763091940112d, y: 0.8517801992380432d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6939485241780088d, y: 0.7845847149644093d), new NpgsqlTypes.NpgsqlPoint(x: 0.8200199679310627d, y: 0.3609392575314697d), new NpgsqlTypes.NpgsqlPoint(x: 0.1890969305031912d, y: 0.8992188616828313d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9145252462787248d, y: 0.15918369251776365d), new NpgsqlTypes.NpgsqlPoint(x: 0.6166021629044385d, y: 0.8703631197396207d), new NpgsqlTypes.NpgsqlPoint(x: 0.14638754080789318d, y: 0.45355213085275414d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0897401449542915d, y: 0.455197640221346d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070347760869946d, y: 0.7044568700554186d), new NpgsqlTypes.NpgsqlPoint(x: 0.7438686561533528d, y: 0.3940556460602328d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6288791017054539d, y: 0.9165653392673695d), new NpgsqlTypes.NpgsqlPoint(x: 0.2546627256452504d, y: 0.5356929700913423d), new NpgsqlTypes.NpgsqlPoint(x: 0.5570999486239995d, y: 0.9593017493229695d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18499215165048244d, y: 0.5533768080211597d), new NpgsqlTypes.NpgsqlPoint(x: 0.15654138815847063d, y: 0.40196231663141135d), new NpgsqlTypes.NpgsqlPoint(x: 0.9198349854708946d, y: 0.12650802735529287d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6012918308943616d, y: 0.6005066187530913d), new NpgsqlTypes.NpgsqlPoint(x: 0.5428542134177717d, y: 0.2034573364882507d), new NpgsqlTypes.NpgsqlPoint(x: 0.42769313031286904d, y: 0.5547615530777746d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48554644204124264d, y: 0.7503089648330018d), new NpgsqlTypes.NpgsqlPoint(x: 0.474840839197465d, y: 0.795717060893256d), new NpgsqlTypes.NpgsqlPoint(x: 0.7155480192383379d, y: 0.20565147149706053d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9952632948719031d, y: 0.8942854523887307d), new NpgsqlTypes.NpgsqlPoint(x: 0.44047698232699073d, y: 0.7603340354823274d), new NpgsqlTypes.NpgsqlPoint(x: 0.2885549620054413d, y: 0.8714259234033952d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9432511359004211d, y: 0.6367929157343132d), new NpgsqlTypes.NpgsqlPoint(x: 0.8768478264914457d, y: 0.2252976094351401d), new NpgsqlTypes.NpgsqlPoint(x: 0.05450423559443296d, y: 0.6048258024549663d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29146443813603995d, y: 0.4395056818542684d), new NpgsqlTypes.NpgsqlPoint(x: 0.49682619302931086d, y: 0.5132507763217145d), new NpgsqlTypes.NpgsqlPoint(x: 0.6509901204673946d, y: 0.4358449673478886d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004223847921280166d, y: 0.7694346680933152d), new NpgsqlTypes.NpgsqlPoint(x: 0.9599334275731352d, y: 0.16945581694116507d), new NpgsqlTypes.NpgsqlPoint(x: 0.17509397592073506d, y: 0.5028080069646594d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47698416719259884d, y: 0.9524471779453957d), new NpgsqlTypes.NpgsqlPoint(x: 0.18136691770962188d, y: 0.4435303281289672d), new NpgsqlTypes.NpgsqlPoint(x: 0.9974822180482261d, y: 0.3467263542250709d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32401756451411445d, y: 0.00984426247774095d), new NpgsqlTypes.NpgsqlPoint(x: 0.9689338858744331d, y: 0.10682288372435222d), new NpgsqlTypes.NpgsqlPoint(x: 0.743749391328039d, y: 0.464593710108293d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08695889720253536d, y: 0.36399448887828467d), new NpgsqlTypes.NpgsqlPoint(x: 0.34373937983071345d, y: 0.41510474522309415d), new NpgsqlTypes.NpgsqlPoint(x: 0.9918718161898953d, y: 0.8572292623490759d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5490382342750797d, y: 0.51788493165925d), new NpgsqlTypes.NpgsqlPoint(x: 0.30010333428106295d, y: 0.2959536013520212d), new NpgsqlTypes.NpgsqlPoint(x: 0.9815729310436959d, y: 0.8411435214531447d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25546803073633784d, y: 0.8216621848280062d), new NpgsqlTypes.NpgsqlPoint(x: 0.6345390046827258d, y: 0.8602925608056756d), new NpgsqlTypes.NpgsqlPoint(x: 0.1350127193679469d, y: 0.24403564152941482d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04630193099195168d, y: 0.906336792397789d), new NpgsqlTypes.NpgsqlPoint(x: 0.2690540211687613d, y: 0.8165293731442865d), new NpgsqlTypes.NpgsqlPoint(x: 0.8902503353424752d, y: 0.8557306669343339d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5218983549831484d, y: 0.7289284796737658d), new NpgsqlTypes.NpgsqlPoint(x: 0.7824738332523088d, y: 0.19344530201215848d), new NpgsqlTypes.NpgsqlPoint(x: 0.8811252571862487d, y: 0.5472560982345803d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14031727398259397d, y: 0.18084787225134147d), new NpgsqlTypes.NpgsqlPoint(x: 0.21579201462014708d, y: 0.7159832257269325d), new NpgsqlTypes.NpgsqlPoint(x: 0.2901867222479294d, y: 0.7302700952201212d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32959828891110066d, y: 0.10562472703254067d), new NpgsqlTypes.NpgsqlPoint(x: 0.5294475224990365d, y: 0.8171541881412402d), new NpgsqlTypes.NpgsqlPoint(x: 0.5345277351447838d, y: 0.08228119601122685d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5000903149998306d, y: 0.5891043762549698d), new NpgsqlTypes.NpgsqlPoint(x: 0.19225159675138348d, y: 0.34318721413475994d), new NpgsqlTypes.NpgsqlPoint(x: 0.40242280324632385d, y: 0.9744042195683958d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1846069507535213d, y: 0.43592381134329117d), new NpgsqlTypes.NpgsqlPoint(x: 0.9640049279539816d, y: 0.3750142244538395d), new NpgsqlTypes.NpgsqlPoint(x: 0.25197889000284646d, y: 0.7990851990291127d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49409070525308496d, y: 0.338667674114848d), new NpgsqlTypes.NpgsqlPoint(x: 0.8944869682324437d, y: 0.07851853926126862d), new NpgsqlTypes.NpgsqlPoint(x: 0.45586290911897376d, y: 0.30196551817623374d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29139146382555636d, y: 0.2585571712979101d), new NpgsqlTypes.NpgsqlPoint(x: 0.1378280322324834d, y: 0.6258287228619676d), new NpgsqlTypes.NpgsqlPoint(x: 0.9048733052631522d, y: 0.7968971110414832d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6513781149599567d, y: 0.012011473918193905d), new NpgsqlTypes.NpgsqlPoint(x: 0.9439000215479803d, y: 0.5245861563556087d), new NpgsqlTypes.NpgsqlPoint(x: 0.16280880216537985d, y: 0.43429593264379185d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7911896396204617d, y: 0.7121880144250545d), new NpgsqlTypes.NpgsqlPoint(x: 0.07999884594530715d, y: 0.3810308910033088d), new NpgsqlTypes.NpgsqlPoint(x: 0.06493551005843645d, y: 0.09590606974481708d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1127544812140534d, y: 0.25628214939176464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626062916838178d, y: 0.47133584187503386d), new NpgsqlTypes.NpgsqlPoint(x: 0.8638943193228558d, y: 0.8935451174908907d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.193617302175221d, y: 0.6272836953784746d), new NpgsqlTypes.NpgsqlPoint(x: 0.47889075505596623d, y: 0.15658119317614494d), new NpgsqlTypes.NpgsqlPoint(x: 0.890528006307525d, y: 0.3477967426665449d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4474498055253473d, y: 0.9377765430234416d), new NpgsqlTypes.NpgsqlPoint(x: 0.01649313539926689d, y: 0.615562020854542d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749181106288812d, y: 0.38358898481559367d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8251283651579057d, y: 0.7553311850164656d), new NpgsqlTypes.NpgsqlPoint(x: 0.39327731666770294d, y: 0.1914298881828027d), new NpgsqlTypes.NpgsqlPoint(x: 0.4347642321754899d, y: 0.8051373030007106d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9072694077922405d, y: 0.13682459016223314d), new NpgsqlTypes.NpgsqlPoint(x: 0.1957972716003924d, y: 0.4270412751362579d), new NpgsqlTypes.NpgsqlPoint(x: 0.5315309793248828d, y: 0.18301633813244955d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8981902365512368d, y: 0.12208816336735262d), new NpgsqlTypes.NpgsqlPoint(x: 0.3139927180277261d, y: 0.3783805684540442d), new NpgsqlTypes.NpgsqlPoint(x: 0.01216233808139866d, y: 0.7465358369595378d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6974418640064106d, y: 0.6439048968191595d), new NpgsqlTypes.NpgsqlPoint(x: 0.9802404927001523d, y: 0.6293348459489174d), new NpgsqlTypes.NpgsqlPoint(x: 0.2831556917533147d, y: 0.16414383123973708d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2777665291429118d, y: 0.2630387634756606d), new NpgsqlTypes.NpgsqlPoint(x: 0.478138497297118d, y: 0.7470514621218921d), new NpgsqlTypes.NpgsqlPoint(x: 0.5268071461426582d, y: 0.9667262492837643d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7323387919478372d, y: 0.2246856911956031d), new NpgsqlTypes.NpgsqlPoint(x: 0.7518850666706538d, y: 0.34270588164653204d), new NpgsqlTypes.NpgsqlPoint(x: 0.7787787206633039d, y: 0.3861194370928185d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5557747940843649d, y: 0.4403159957940286d), new NpgsqlTypes.NpgsqlPoint(x: 0.062092130493004216d, y: 0.08923250273556238d), new NpgsqlTypes.NpgsqlPoint(x: 0.213252915352399d, y: 0.722588196003838d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007187060590168715d, y: 0.03129706121793974d), new NpgsqlTypes.NpgsqlPoint(x: 0.9413529046506134d, y: 0.30041332524028463d), new NpgsqlTypes.NpgsqlPoint(x: 0.05622532370227762d, y: 0.6227995815445164d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20653380984653313d, y: 0.08178540664912015d), new NpgsqlTypes.NpgsqlPoint(x: 0.6902551647874698d, y: 0.23210213958905757d), new NpgsqlTypes.NpgsqlPoint(x: 0.7214694538945173d, y: 0.3275303975990733d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1060066629680243d, y: 0.14410897041082538d), new NpgsqlTypes.NpgsqlPoint(x: 0.6606292874573502d, y: 0.7812689671100449d), new NpgsqlTypes.NpgsqlPoint(x: 0.22932668151427993d, y: 0.47295139131672514d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37236803354142733d, y: 0.2301608973539231d), new NpgsqlTypes.NpgsqlPoint(x: 0.08358132829893139d, y: 0.17171743443174514d), new NpgsqlTypes.NpgsqlPoint(x: 0.04310606777524273d, y: 0.5164526224021564d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23309591451855316d, y: 0.23285963744408722d), new NpgsqlTypes.NpgsqlPoint(x: 0.9072917253296862d, y: 0.0051707320482955454d), new NpgsqlTypes.NpgsqlPoint(x: 0.15466083152780996d, y: 0.7855129590002307d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22931391085606778d, y: 0.7410704598481496d), new NpgsqlTypes.NpgsqlPoint(x: 0.6037650678217384d, y: 0.7577006171411895d), new NpgsqlTypes.NpgsqlPoint(x: 0.8337554816653935d, y: 0.32261022161707753d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7100616623679714d, y: 0.5335113106894267d), new NpgsqlTypes.NpgsqlPoint(x: 0.10689885698256618d, y: 0.11018231849930038d), new NpgsqlTypes.NpgsqlPoint(x: 0.8215044612123146d, y: 0.8462361880609869d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7491765926381252d, y: 0.7061886706645422d), new NpgsqlTypes.NpgsqlPoint(x: 0.36658994192878613d, y: 0.4681636390623677d), new NpgsqlTypes.NpgsqlPoint(x: 0.2875440569357497d, y: 0.44784099318268156d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5752349070290993d, y: 0.6856320224202959d), new NpgsqlTypes.NpgsqlPoint(x: 0.9440337475071263d, y: 0.7801687351514331d), new NpgsqlTypes.NpgsqlPoint(x: 0.2980894039562716d, y: 0.7927461712580902d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.987540959604095d, y: 0.395268922810194d), new NpgsqlTypes.NpgsqlPoint(x: 0.04475979467334312d, y: 0.6967951148037889d), new NpgsqlTypes.NpgsqlPoint(x: 0.7806013426027264d, y: 0.7815514714892144d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34875017489955407d, y: 0.3490641468620299d), new NpgsqlTypes.NpgsqlPoint(x: 0.9847097231215198d, y: 0.6784406855953525d), new NpgsqlTypes.NpgsqlPoint(x: 0.20426284519698557d, y: 0.668853536660854d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43487720324278056d, y: 0.25376738077995165d), new NpgsqlTypes.NpgsqlPoint(x: 0.7467399152245234d, y: 0.7722077984876213d), new NpgsqlTypes.NpgsqlPoint(x: 0.752752178519119d, y: 0.6210114779122983d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.522779862692405d, y: 0.7387914450319872d), new NpgsqlTypes.NpgsqlPoint(x: 0.9690029544032429d, y: 0.2715874478638083d), new NpgsqlTypes.NpgsqlPoint(x: 0.42647123846674684d, y: 0.8447355957431661d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25357933688125045d, y: 0.18383591261988252d), new NpgsqlTypes.NpgsqlPoint(x: 0.06619199255981845d, y: 0.2998276113305465d), new NpgsqlTypes.NpgsqlPoint(x: 0.4586380002024819d, y: 0.5807493640526652d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.86445891494475d, y: 0.712093177441931d), new NpgsqlTypes.NpgsqlPoint(x: 0.5509152661413275d, y: 0.6768175790591006d), new NpgsqlTypes.NpgsqlPoint(x: 0.5208531537476627d, y: 0.972985392433094d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15329080260239691d, y: 0.8037263665421239d), new NpgsqlTypes.NpgsqlPoint(x: 0.696156730598666d, y: 0.8211358896699058d), new NpgsqlTypes.NpgsqlPoint(x: 0.26643679448802005d, y: 0.6277582843095826d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45950926075472764d, y: 0.3356979812956774d), new NpgsqlTypes.NpgsqlPoint(x: 0.1981731606796998d, y: 0.547426476263033d), new NpgsqlTypes.NpgsqlPoint(x: 0.33353360537546006d, y: 0.03738563246457649d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6968919923958921d, y: 0.3233317909631841d), new NpgsqlTypes.NpgsqlPoint(x: 0.17956099595772057d, y: 0.4410098476199389d), new NpgsqlTypes.NpgsqlPoint(x: 0.4001488299775219d, y: 0.2401344731308842d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7620177928793415d, y: 0.6903050543980362d), new NpgsqlTypes.NpgsqlPoint(x: 0.6520180078747798d, y: 0.38097532365110864d), new NpgsqlTypes.NpgsqlPoint(x: 0.2728808201697759d, y: 0.9746414822739464d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26593211779103854d, y: 0.4716327998437436d), new NpgsqlTypes.NpgsqlPoint(x: 0.6930897643579682d, y: 0.8948644687235192d), new NpgsqlTypes.NpgsqlPoint(x: 0.07386811786262637d, y: 0.1506895499348423d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8061307632109211d, y: 0.35565214757861885d), new NpgsqlTypes.NpgsqlPoint(x: 0.2546571216490673d, y: 0.5473412498281243d), new NpgsqlTypes.NpgsqlPoint(x: 0.5028798415182625d, y: 0.61897848567731d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1501042006811646d, y: 0.3569516836083021d), new NpgsqlTypes.NpgsqlPoint(x: 0.7525569997248186d, y: 0.26182079021845306d), new NpgsqlTypes.NpgsqlPoint(x: 0.5573678611609808d, y: 0.02288423735755485d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40403856165066554d, y: 0.033873162645501d), new NpgsqlTypes.NpgsqlPoint(x: 0.29846863650382427d, y: 0.35671560769246513d), new NpgsqlTypes.NpgsqlPoint(x: 0.977763681359217d, y: 0.8593334030239296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6878344526106184d, y: 0.062086788138217885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9093216280746449d, y: 0.09753750632876523d), new NpgsqlTypes.NpgsqlPoint(x: 0.2730982423620528d, y: 0.6808743994269106d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6110851118411731d, y: 0.741640790095515d), new NpgsqlTypes.NpgsqlPoint(x: 0.6756478226648585d, y: 0.4111163508057034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8437341026252057d, y: 0.2890024112658276d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7457361163532317d, y: 0.26369496900151235d), new NpgsqlTypes.NpgsqlPoint(x: 0.7405558079195732d, y: 0.7519035704143027d), new NpgsqlTypes.NpgsqlPoint(x: 0.662212998269031d, y: 0.5035630279743727d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8958513849445098d, y: 0.30302746842472517d), new NpgsqlTypes.NpgsqlPoint(x: 0.49972310668241193d, y: 0.09786069669442965d), new NpgsqlTypes.NpgsqlPoint(x: 0.13318454036156202d, y: 0.08087292269241919d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2740780248131197d, y: 0.8283590662562218d), new NpgsqlTypes.NpgsqlPoint(x: 0.23009821516967455d, y: 0.5399033244575281d), new NpgsqlTypes.NpgsqlPoint(x: 0.10139707081743277d, y: 0.691064401132825d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5382368828287569d, y: 0.45972844729956264d), new NpgsqlTypes.NpgsqlPoint(x: 0.1183365745364432d, y: 0.2305803004858018d), new NpgsqlTypes.NpgsqlPoint(x: 0.423003283757478d, y: 0.01826995509567919d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9923962934326617d, y: 0.4113241655630544d), new NpgsqlTypes.NpgsqlPoint(x: 0.07783551009248324d, y: 0.17247516361194304d), new NpgsqlTypes.NpgsqlPoint(x: 0.25887988305052956d, y: 0.25996570182445045d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0967924880481954d, y: 0.6668370539153998d), new NpgsqlTypes.NpgsqlPoint(x: 0.7382553145781383d, y: 0.2131685634665763d), new NpgsqlTypes.NpgsqlPoint(x: 0.30387452193791553d, y: 0.5744555183660744d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9630899686959546d, y: 0.27001586690850243d), new NpgsqlTypes.NpgsqlPoint(x: 0.5921328678899397d, y: 0.3905490860047278d), new NpgsqlTypes.NpgsqlPoint(x: 0.14059969863370603d, y: 0.12706928274820528d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49792091501049063d, y: 0.43480847698765823d), new NpgsqlTypes.NpgsqlPoint(x: 0.6150166677095255d, y: 0.4569205855704046d), new NpgsqlTypes.NpgsqlPoint(x: 0.3659586632053091d, y: 0.521262998299815d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5707523888469993d, y: 0.09012558230619938d), new NpgsqlTypes.NpgsqlPoint(x: 0.9629636013455306d, y: 0.09284858503018079d), new NpgsqlTypes.NpgsqlPoint(x: 0.19052425893733815d, y: 0.224298650744289d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11533954126400048d, y: 0.06414890571567033d), new NpgsqlTypes.NpgsqlPoint(x: 0.47337209910803923d, y: 0.0056936376604421746d), new NpgsqlTypes.NpgsqlPoint(x: 0.4604321289003186d, y: 0.5679424336183022d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25136199182943064d, y: 0.8028463841206644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7329931881386036d, y: 0.3700329889330132d), new NpgsqlTypes.NpgsqlPoint(x: 0.7080851021623201d, y: 0.8088015247393974d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.455471426795687d, y: 0.742538392100019d), new NpgsqlTypes.NpgsqlPoint(x: 0.1348264270761107d, y: 0.06423289967082002d), new NpgsqlTypes.NpgsqlPoint(x: 0.2131829512318345d, y: 0.7710779538872105d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8048610405603953d, y: 0.7953255131757776d), new NpgsqlTypes.NpgsqlPoint(x: 0.5100477509167487d, y: 0.7152321607683509d), new NpgsqlTypes.NpgsqlPoint(x: 0.03431365198023406d, y: 0.32333845869280786d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8275137555659074d, y: 0.09664782705157715d), new NpgsqlTypes.NpgsqlPoint(x: 0.059586030175175275d, y: 0.8286664110897963d), new NpgsqlTypes.NpgsqlPoint(x: 0.6575222929700876d, y: 0.9632897668192582d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17182294435807943d, y: 0.04709362197470823d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296205024058782d, y: 0.6247546665914326d), new NpgsqlTypes.NpgsqlPoint(x: 0.054524410785886435d, y: 0.027123400197400338d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2199645939061674d, y: 0.956747375038979d), new NpgsqlTypes.NpgsqlPoint(x: 0.7757535369065376d, y: 0.05367527758112589d), new NpgsqlTypes.NpgsqlPoint(x: 0.9492012507365429d, y: 0.39972017630894696d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.071010428059741d, y: 0.30690236482985345d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549385814995811d, y: 0.5160757806772999d), new NpgsqlTypes.NpgsqlPoint(x: 0.13478812432547915d, y: 0.6823679301501957d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49114928169725414d, y: 0.8629332448721826d), new NpgsqlTypes.NpgsqlPoint(x: 0.04606896670947702d, y: 0.7195430474472053d), new NpgsqlTypes.NpgsqlPoint(x: 0.7005712865729742d, y: 0.9705451550022419d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8909815161945773d, y: 0.9748537009919204d), new NpgsqlTypes.NpgsqlPoint(x: 0.6741207847308158d, y: 0.6042967184040335d), new NpgsqlTypes.NpgsqlPoint(x: 0.9550569061315711d, y: 0.9310551740101703d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5756604451812734d, y: 0.019128866330500593d), new NpgsqlTypes.NpgsqlPoint(x: 0.8495649820478519d, y: 0.637993220658226d), new NpgsqlTypes.NpgsqlPoint(x: 0.29857168729949435d, y: 0.6525469172392212d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9702893309399194d, y: 0.5531764054516967d), new NpgsqlTypes.NpgsqlPoint(x: 0.17877596339971957d, y: 0.7659422087846975d), new NpgsqlTypes.NpgsqlPoint(x: 0.11541519279688617d, y: 0.34888800899195804d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4751056193908144d, y: 0.5945593941512531d), new NpgsqlTypes.NpgsqlPoint(x: 0.017419994354966994d, y: 0.6500246728456422d), new NpgsqlTypes.NpgsqlPoint(x: 0.7459383452877285d, y: 0.046529769195769566d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13067003040265912d, y: 0.3985624217889968d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068466280936628d, y: 0.03630596988023793d), new NpgsqlTypes.NpgsqlPoint(x: 0.5273050039730708d, y: 0.6396363486844857d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5584826509055053d, y: 0.5073910046371527d), new NpgsqlTypes.NpgsqlPoint(x: 0.21073840919282105d, y: 0.9129856439887482d), new NpgsqlTypes.NpgsqlPoint(x: 0.3025899326552173d, y: 0.23125535527252628d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8644489030538473d, y: 0.2779457868906997d), new NpgsqlTypes.NpgsqlPoint(x: 0.6131342784876438d, y: 0.3590501921017021d), new NpgsqlTypes.NpgsqlPoint(x: 0.8355755219969832d, y: 0.31667980703469556d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7687120109962136d, y: 0.8517817867319848d), new NpgsqlTypes.NpgsqlPoint(x: 0.545465423301365d, y: 0.1772439226717829d), new NpgsqlTypes.NpgsqlPoint(x: 0.7611661494358183d, y: 0.30300548069641087d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7877850600732024d, y: 0.3075762021295334d), new NpgsqlTypes.NpgsqlPoint(x: 0.044990836168142034d, y: 0.5012660192269227d), new NpgsqlTypes.NpgsqlPoint(x: 0.5116485470225182d, y: 0.012880349129949509d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6095447598725484d, y: 0.24567800723288458d), new NpgsqlTypes.NpgsqlPoint(x: 0.5176577063765629d, y: 0.8505498837704902d), new NpgsqlTypes.NpgsqlPoint(x: 0.4117028813354613d, y: 0.986975460649962d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11475478171980236d, y: 0.8618858617304613d), new NpgsqlTypes.NpgsqlPoint(x: 0.6042300092445644d, y: 0.36708465885243213d), new NpgsqlTypes.NpgsqlPoint(x: 0.988618974086329d, y: 0.8903071272788488d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5237028233745631d, y: 0.6837571348723591d), new NpgsqlTypes.NpgsqlPoint(x: 0.7826442729111387d, y: 0.2748011933541882d), new NpgsqlTypes.NpgsqlPoint(x: 0.22186464508728243d, y: 0.9934564889527491d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7458108336301558d, y: 0.309265789695065d), new NpgsqlTypes.NpgsqlPoint(x: 0.617842364109554d, y: 0.3074538798902198d), new NpgsqlTypes.NpgsqlPoint(x: 0.702181383486991d, y: 0.34256610458833225d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9909141346266177d, y: 0.9356490519555158d), new NpgsqlTypes.NpgsqlPoint(x: 0.10287316053104179d, y: 0.8647812715865214d), new NpgsqlTypes.NpgsqlPoint(x: 0.858573352088918d, y: 0.7926313414944907d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8138661546745557d, y: 0.09500839320273513d), new NpgsqlTypes.NpgsqlPoint(x: 0.133635501344738d, y: 0.3658282169625672d), new NpgsqlTypes.NpgsqlPoint(x: 0.3771642980928548d, y: 0.41060466056841016d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5115720748290269d, y: 0.3809003119273793d), new NpgsqlTypes.NpgsqlPoint(x: 0.5919176084378063d, y: 0.41781523599940296d), new NpgsqlTypes.NpgsqlPoint(x: 0.9370205703330385d, y: 0.0431765506663625d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028748627886502898d, y: 0.871851223522814d), new NpgsqlTypes.NpgsqlPoint(x: 0.7941736472184491d, y: 0.8832639058053834d), new NpgsqlTypes.NpgsqlPoint(x: 0.7597331971536794d, y: 0.32079449305363317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9072446075913313d, y: 0.07149575143987752d), new NpgsqlTypes.NpgsqlPoint(x: 0.09118621434995344d, y: 0.016769636684630274d), new NpgsqlTypes.NpgsqlPoint(x: 0.597131904135055d, y: 0.2548604817490412d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5469402212617505d, y: 0.8963831149880545d), new NpgsqlTypes.NpgsqlPoint(x: 0.0427369490994336d, y: 0.5285834645720906d), new NpgsqlTypes.NpgsqlPoint(x: 0.6726314263089103d, y: 0.06011101352246484d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.816593889387602d, y: 0.9048143044772831d), new NpgsqlTypes.NpgsqlPoint(x: 0.0597682859888069d, y: 0.7315833771964751d), new NpgsqlTypes.NpgsqlPoint(x: 0.3044382116689569d, y: 0.8658545915391966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46506722389177957d, y: 0.684871359392335d), new NpgsqlTypes.NpgsqlPoint(x: 0.1529219768899861d, y: 0.5184884090899918d), new NpgsqlTypes.NpgsqlPoint(x: 0.5307657689226785d, y: 0.2506506138990646d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9796749475863358d, y: 0.7962867356787766d), new NpgsqlTypes.NpgsqlPoint(x: 0.15223805845485894d, y: 0.5808981464628535d), new NpgsqlTypes.NpgsqlPoint(x: 0.5336093147762652d, y: 0.9818704176464249d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9049523758948396d, y: 0.5557281350216136d), new NpgsqlTypes.NpgsqlPoint(x: 0.3266946899238916d, y: 0.9384782557764965d), new NpgsqlTypes.NpgsqlPoint(x: 0.338018163584927d, y: 0.9447845922888187d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23517550491401273d, y: 0.10872841416279011d), new NpgsqlTypes.NpgsqlPoint(x: 0.06837802158472284d, y: 0.1754551682859654d), new NpgsqlTypes.NpgsqlPoint(x: 0.9975196714538318d, y: 0.4618980225200777d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4830505437318632d, y: 0.9617911813715312d), new NpgsqlTypes.NpgsqlPoint(x: 0.38012448348964223d, y: 0.49977090025278836d), new NpgsqlTypes.NpgsqlPoint(x: 0.6383695310487423d, y: 0.3448093013426218d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.610798253214082d, y: 0.1385600574837258d), new NpgsqlTypes.NpgsqlPoint(x: 0.6677885081033248d, y: 0.4039956441943352d), new NpgsqlTypes.NpgsqlPoint(x: 0.22604141183474047d, y: 0.18436524451268843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24559701402698686d, y: 0.7446716817049651d), new NpgsqlTypes.NpgsqlPoint(x: 0.5438019754598168d, y: 0.24180595996248055d), new NpgsqlTypes.NpgsqlPoint(x: 0.4129203014947185d, y: 0.47573615414959025d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012477083370980191d, y: 0.7124232933897405d), new NpgsqlTypes.NpgsqlPoint(x: 0.32225586302259246d, y: 0.08071542465465376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9634495395085102d, y: 0.5667618972356137d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6508148995877888d, y: 0.9688477266325481d), new NpgsqlTypes.NpgsqlPoint(x: 0.5523098810196082d, y: 0.25243025927453355d), new NpgsqlTypes.NpgsqlPoint(x: 0.44665083913103887d, y: 0.3884456616174954d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47049251079684207d, y: 0.6297701816404598d), new NpgsqlTypes.NpgsqlPoint(x: 0.14930574581043232d, y: 0.6869554842935574d), new NpgsqlTypes.NpgsqlPoint(x: 0.45510883694968707d, y: 0.9169645319950088d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9739811035309316d, y: 0.27528176280131866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5243589413978424d, y: 0.35787643385984813d), new NpgsqlTypes.NpgsqlPoint(x: 0.5701934707189015d, y: 0.02334836762031367d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9870043504179111d, y: 0.5032259133289361d), new NpgsqlTypes.NpgsqlPoint(x: 0.27543090331267284d, y: 0.19697434712058004d), new NpgsqlTypes.NpgsqlPoint(x: 0.5607326766926027d, y: 0.905460747829076d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7553744508944935d, y: 0.20906554617859296d), new NpgsqlTypes.NpgsqlPoint(x: 0.9497075779733118d, y: 0.37948820178268683d), new NpgsqlTypes.NpgsqlPoint(x: 0.5584854290150633d, y: 0.687420806730482d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5026100268503905d, y: 0.6888479174609159d), new NpgsqlTypes.NpgsqlPoint(x: 0.8974348403437263d, y: 0.6254327914540778d), new NpgsqlTypes.NpgsqlPoint(x: 0.4868144960069346d, y: 0.7970027770638759d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.529118779074878d, y: 0.19982935302430538d), new NpgsqlTypes.NpgsqlPoint(x: 0.5568922443874947d, y: 0.04373303085550784d), new NpgsqlTypes.NpgsqlPoint(x: 0.06858812567836947d, y: 0.9288060210780661d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4611853666772926d, y: 0.481422804565491d), new NpgsqlTypes.NpgsqlPoint(x: 0.2983528438191364d, y: 0.9949671743264323d), new NpgsqlTypes.NpgsqlPoint(x: 0.02571462742961761d, y: 0.09183367618139093d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0787744916030203d, y: 0.3161794540003423d), new NpgsqlTypes.NpgsqlPoint(x: 0.18885624904592224d, y: 0.5374340722044036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9656045614498082d, y: 0.6375037866024099d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07405588059904034d, y: 0.4134837373669936d), new NpgsqlTypes.NpgsqlPoint(x: 0.2711803215385118d, y: 0.7441225684926326d), new NpgsqlTypes.NpgsqlPoint(x: 0.0488565005451127d, y: 0.2660838349876019d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04564562621545365d, y: 0.49157759692194414d), new NpgsqlTypes.NpgsqlPoint(x: 0.2393522976126491d, y: 0.05374803029241271d), new NpgsqlTypes.NpgsqlPoint(x: 0.8730353727535795d, y: 0.030593225127447443d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47328171301314625d, y: 0.5474942696889067d), new NpgsqlTypes.NpgsqlPoint(x: 0.9012932065755042d, y: 0.8937449713684352d), new NpgsqlTypes.NpgsqlPoint(x: 0.37734672667756997d, y: 0.17921423719161944d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3615526198108683d, y: 0.13014270568218478d), new NpgsqlTypes.NpgsqlPoint(x: 0.39674409503028685d, y: 0.49515390461876274d), new NpgsqlTypes.NpgsqlPoint(x: 0.10369087837065705d, y: 0.30823498339844846d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1878493241808965d, y: 0.6173410614374581d), new NpgsqlTypes.NpgsqlPoint(x: 0.9878940080762683d, y: 0.07038088329356229d), new NpgsqlTypes.NpgsqlPoint(x: 0.5286274938190023d, y: 0.545041361606296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5875539244812379d, y: 0.17490965481055054d), new NpgsqlTypes.NpgsqlPoint(x: 0.09594103798939801d, y: 0.8779921427954227d), new NpgsqlTypes.NpgsqlPoint(x: 0.013694915971383614d, y: 0.3103250669757124d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3655624659227794d, y: 0.5108582619867814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8489622957103136d, y: 0.22131708026695673d), new NpgsqlTypes.NpgsqlPoint(x: 0.1861490197638056d, y: 0.8397682719021218d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5214224169234646d, y: 0.11941938339651947d), new NpgsqlTypes.NpgsqlPoint(x: 0.9959605084787222d, y: 0.9763441774773209d), new NpgsqlTypes.NpgsqlPoint(x: 0.8830076062275152d, y: 0.8666736817852857d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26148791198659915d, y: 0.6182391424595557d), new NpgsqlTypes.NpgsqlPoint(x: 0.03921434631181231d, y: 0.2548704321009958d), new NpgsqlTypes.NpgsqlPoint(x: 0.2651057889625451d, y: 0.8605634496552851d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4764566908766231d, y: 0.2501001801723802d), new NpgsqlTypes.NpgsqlPoint(x: 0.0029639612287605255d, y: 0.6079277768662679d), new NpgsqlTypes.NpgsqlPoint(x: 0.5181341443166089d, y: 0.5347769609779162d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6269727836686756d, y: 0.5640351868999655d), new NpgsqlTypes.NpgsqlPoint(x: 0.1618915126398579d, y: 0.21202231652362225d), new NpgsqlTypes.NpgsqlPoint(x: 0.4032842269658533d, y: 0.3096379923963223d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3996762344055731d, y: 0.20642269396186452d), new NpgsqlTypes.NpgsqlPoint(x: 0.8983535255329546d, y: 0.7774269640668646d), new NpgsqlTypes.NpgsqlPoint(x: 0.16136948586503996d, y: 0.058321042384338884d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49100259038076743d, y: 0.43572896200810907d), new NpgsqlTypes.NpgsqlPoint(x: 0.3191089715942663d, y: 0.0516369304764045d), new NpgsqlTypes.NpgsqlPoint(x: 0.1979631878930529d, y: 0.38114223435541505d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5862962748536273d, y: 0.0026404429491118098d), new NpgsqlTypes.NpgsqlPoint(x: 0.6797662381995028d, y: 0.8563971571112724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5827208410294108d, y: 0.8339264848766889d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7004088920176853d, y: 0.05010167542283395d), new NpgsqlTypes.NpgsqlPoint(x: 0.23251944604249708d, y: 0.9401706203627713d), new NpgsqlTypes.NpgsqlPoint(x: 0.33073238359154167d, y: 0.973552151358154d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9750910080885706d, y: 0.11470994250457256d), new NpgsqlTypes.NpgsqlPoint(x: 0.14052323686984491d, y: 0.15944010626725535d), new NpgsqlTypes.NpgsqlPoint(x: 0.3510810483348977d, y: 0.8648685852248903d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5433096749224381d, y: 0.8527050647674177d), new NpgsqlTypes.NpgsqlPoint(x: 0.719141355540542d, y: 0.4726651729142264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9071744677031742d, y: 0.12994739389314847d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7900704547550398d, y: 0.9601745943702804d), new NpgsqlTypes.NpgsqlPoint(x: 0.8134786583977686d, y: 0.8374418432148143d), new NpgsqlTypes.NpgsqlPoint(x: 0.4015898668982626d, y: 0.6166396437975655d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.788891105431863d, y: 0.17824497139097395d), new NpgsqlTypes.NpgsqlPoint(x: 0.2634641844370197d, y: 0.6467396922868738d), new NpgsqlTypes.NpgsqlPoint(x: 0.3226895121146798d, y: 0.6668030588788151d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43602748230518484d, y: 0.15654502086395328d), new NpgsqlTypes.NpgsqlPoint(x: 0.5630470956514027d, y: 0.3390613735874043d), new NpgsqlTypes.NpgsqlPoint(x: 0.02520107458365084d, y: 0.35973885274826445d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43483650280200037d, y: 0.7984516478336398d), new NpgsqlTypes.NpgsqlPoint(x: 0.13064243899615535d, y: 0.8086872038186509d), new NpgsqlTypes.NpgsqlPoint(x: 0.682982203355983d, y: 0.6407970628813002d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13489536248037093d, y: 0.6458808856177055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6962723755797662d, y: 0.024619849298924246d), new NpgsqlTypes.NpgsqlPoint(x: 0.7476206889643314d, y: 0.2959747124063524d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6347912006624803d, y: 0.7970548610474946d), new NpgsqlTypes.NpgsqlPoint(x: 0.38933518670426037d, y: 0.9449522864383991d), new NpgsqlTypes.NpgsqlPoint(x: 0.07620788119500255d, y: 0.00533965504611289d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5053358065466319d, y: 0.6221114801676461d), new NpgsqlTypes.NpgsqlPoint(x: 0.09723675557545286d, y: 0.2210456836455933d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315254305780411d, y: 0.3135023133656304d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1048279526720145d, y: 0.8332835526111125d), new NpgsqlTypes.NpgsqlPoint(x: 0.4026666154697697d, y: 0.3996668911115435d), new NpgsqlTypes.NpgsqlPoint(x: 0.5902117380067886d, y: 0.7511583519027045d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7549258964751423d, y: 0.39140955682853484d), new NpgsqlTypes.NpgsqlPoint(x: 0.24100234277795474d, y: 0.7124666435857512d), new NpgsqlTypes.NpgsqlPoint(x: 0.9210585366556194d, y: 0.40298902999683206d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4769392508550533d, y: 0.2963811988590239d), new NpgsqlTypes.NpgsqlPoint(x: 0.08466382484705126d, y: 0.2143234534728118d), new NpgsqlTypes.NpgsqlPoint(x: 0.26686136805733474d, y: 0.07424081866903576d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9783918687150156d, y: 0.6346364297810532d), new NpgsqlTypes.NpgsqlPoint(x: 0.06856656477161138d, y: 0.5114332390549355d), new NpgsqlTypes.NpgsqlPoint(x: 0.1406173532090368d, y: 0.5617773159634686d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2099176713810541d, y: 0.3673039749911474d), new NpgsqlTypes.NpgsqlPoint(x: 0.7840588078415869d, y: 0.7129021309358305d), new NpgsqlTypes.NpgsqlPoint(x: 0.7370080910132861d, y: 0.5842270170512479d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.514212637329762d, y: 0.8003802979977622d), new NpgsqlTypes.NpgsqlPoint(x: 0.08982837017056822d, y: 0.9189693716683018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7782462448244908d, y: 0.40243396674754006d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.883723061440662d, y: 0.6915757601055078d), new NpgsqlTypes.NpgsqlPoint(x: 0.4222177423316552d, y: 0.9054178411305638d), new NpgsqlTypes.NpgsqlPoint(x: 0.11334490409196663d, y: 0.7683270682283152d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5748664972853338d, y: 0.10535369731800648d), new NpgsqlTypes.NpgsqlPoint(x: 0.9175433362678647d, y: 0.2807721547344604d), new NpgsqlTypes.NpgsqlPoint(x: 0.48883095212706573d, y: 0.22163934629367066d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9773072616903017d, y: 0.2613804683820812d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766857679845022d, y: 0.419762768695888d), new NpgsqlTypes.NpgsqlPoint(x: 0.5539097076981054d, y: 0.2688710360014347d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25423772688771495d, y: 0.9291516868860663d), new NpgsqlTypes.NpgsqlPoint(x: 0.16554760163352367d, y: 0.798129619071152d), new NpgsqlTypes.NpgsqlPoint(x: 0.8720920982037459d, y: 0.3839987322065065d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9738667861093747d, y: 0.6707354916800555d), new NpgsqlTypes.NpgsqlPoint(x: 0.40425697142911177d, y: 0.13418635104317533d), new NpgsqlTypes.NpgsqlPoint(x: 0.15340780893119055d, y: 0.48920518083180475d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.914400855970718d, y: 0.8910652876311576d), new NpgsqlTypes.NpgsqlPoint(x: 0.40905710064641265d, y: 0.31336187866643794d), new NpgsqlTypes.NpgsqlPoint(x: 0.29416555224325636d, y: 0.8649136126687132d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7882482106057157d, y: 0.9790499195897692d), new NpgsqlTypes.NpgsqlPoint(x: 0.033388521769561086d, y: 0.32457065878616287d), new NpgsqlTypes.NpgsqlPoint(x: 0.8320464032418451d, y: 0.9423866695922734d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.859520875596038d, y: 0.37346890250426623d), new NpgsqlTypes.NpgsqlPoint(x: 0.642829307671637d, y: 0.9900504172314527d), new NpgsqlTypes.NpgsqlPoint(x: 0.03005555909946378d, y: 0.039400139807124424d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8265303576133777d, y: 0.3017684311723756d), new NpgsqlTypes.NpgsqlPoint(x: 0.08083508242883453d, y: 0.2812931567118504d), new NpgsqlTypes.NpgsqlPoint(x: 0.2679018050553834d, y: 0.9843234503339648d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2578926482613534d, y: 0.4285291436219095d), new NpgsqlTypes.NpgsqlPoint(x: 0.9281471191163612d, y: 0.5768626925077489d), new NpgsqlTypes.NpgsqlPoint(x: 0.5202668459041325d, y: 0.4714781023208684d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2111691662010946d, y: 0.6885487146205344d), new NpgsqlTypes.NpgsqlPoint(x: 0.6506084565585216d, y: 0.59207346769521d), new NpgsqlTypes.NpgsqlPoint(x: 0.4546602125947108d, y: 0.5902391579794779d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11361274402109567d, y: 0.6879837832970317d), new NpgsqlTypes.NpgsqlPoint(x: 0.43208664429984733d, y: 0.3698342738930719d), new NpgsqlTypes.NpgsqlPoint(x: 0.49515214673804975d, y: 0.22913483294281523d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5457309315969703d, y: 0.7035304489908389d), new NpgsqlTypes.NpgsqlPoint(x: 0.7150562180933648d, y: 0.48589550788683844d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301134572607133d, y: 0.9209780084726427d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4112797636775616d, y: 0.5589981980632154d), new NpgsqlTypes.NpgsqlPoint(x: 0.8885282583976403d, y: 0.9319520437682483d), new NpgsqlTypes.NpgsqlPoint(x: 0.38982530536412974d, y: 0.4378743336106087d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34117225599229006d, y: 0.7013168283101245d), new NpgsqlTypes.NpgsqlPoint(x: 0.4971995087153278d, y: 0.6895333535175855d), new NpgsqlTypes.NpgsqlPoint(x: 0.5682091958912061d, y: 0.08576179662950856d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09373568802123877d, y: 0.7722873730144696d), new NpgsqlTypes.NpgsqlPoint(x: 0.7679970860508284d, y: 0.7984429641797638d), new NpgsqlTypes.NpgsqlPoint(x: 0.8022294066319408d, y: 0.43769892561955404d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37501305490098624d, y: 0.9034347302918928d), new NpgsqlTypes.NpgsqlPoint(x: 0.10071707550266096d, y: 0.3647026985880205d), new NpgsqlTypes.NpgsqlPoint(x: 0.7849808996101119d, y: 0.9503321989681304d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6517921169786802d, y: 0.5271379880067514d), new NpgsqlTypes.NpgsqlPoint(x: 0.6159329391455475d, y: 0.5636258461268238d), new NpgsqlTypes.NpgsqlPoint(x: 0.3763374973885776d, y: 0.5129943294896152d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3288234863619214d, y: 0.09654630943520526d), new NpgsqlTypes.NpgsqlPoint(x: 0.18351888411683726d, y: 0.31132600900628427d), new NpgsqlTypes.NpgsqlPoint(x: 0.689454925075431d, y: 0.30232156656693054d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.254956882474339d, y: 0.4331923881076766d), new NpgsqlTypes.NpgsqlPoint(x: 0.13814146217389278d, y: 0.15934416928489015d), new NpgsqlTypes.NpgsqlPoint(x: 0.23659414897047182d, y: 0.7614467864587158d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7725455070736765d, y: 0.4992082897938306d), new NpgsqlTypes.NpgsqlPoint(x: 0.3354821910070602d, y: 0.34065997634698986d), new NpgsqlTypes.NpgsqlPoint(x: 0.30321428093334835d, y: 0.8466860185054743d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9399642074899021d, y: 0.28562744721659694d), new NpgsqlTypes.NpgsqlPoint(x: 0.2549507849043554d, y: 0.6281533311541045d), new NpgsqlTypes.NpgsqlPoint(x: 0.2316346226816185d, y: 0.150644489329139d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2818936100052427d, y: 0.7685489878247925d), new NpgsqlTypes.NpgsqlPoint(x: 0.08595677214544184d, y: 0.51146376598237d), new NpgsqlTypes.NpgsqlPoint(x: 0.23717974215973914d, y: 0.5782978659251325d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7516148889609131d, y: 0.7890774752299484d), new NpgsqlTypes.NpgsqlPoint(x: 0.42215658399441225d, y: 0.3441300101167064d), new NpgsqlTypes.NpgsqlPoint(x: 0.8630183135871989d, y: 0.8600878389816415d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6106216076156179d, y: 0.4803406885767746d), new NpgsqlTypes.NpgsqlPoint(x: 0.1497789987242274d, y: 0.8443776392387085d), new NpgsqlTypes.NpgsqlPoint(x: 0.7721534809402528d, y: 0.9755157648222533d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3547982524683241d, y: 0.9003801906291182d), new NpgsqlTypes.NpgsqlPoint(x: 0.8284826139464175d, y: 0.12176003149201764d), new NpgsqlTypes.NpgsqlPoint(x: 0.1255862728682816d, y: 0.33365999535565205d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42223390741808775d, y: 0.5215102772505088d), new NpgsqlTypes.NpgsqlPoint(x: 0.803614955210649d, y: 0.13345011355048675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8552157699159157d, y: 0.6782285124300088d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8643457299676967d, y: 0.037187856980617995d), new NpgsqlTypes.NpgsqlPoint(x: 0.0607499624935135d, y: 0.31028563314096447d), new NpgsqlTypes.NpgsqlPoint(x: 0.4823315723706585d, y: 0.7969481040778792d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28886678197804416d, y: 0.5427789742973359d), new NpgsqlTypes.NpgsqlPoint(x: 0.6969676294911421d, y: 0.27059491776871303d), new NpgsqlTypes.NpgsqlPoint(x: 0.14988487961617014d, y: 0.24096267547694816d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8199840926336145d, y: 0.38897252434160856d), new NpgsqlTypes.NpgsqlPoint(x: 0.15441591944015431d, y: 0.495047108753113d), new NpgsqlTypes.NpgsqlPoint(x: 0.03478734083026658d, y: 0.29862858835863604d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1575083293830286d, y: 0.8206490364708248d), new NpgsqlTypes.NpgsqlPoint(x: 0.4014029009997119d, y: 0.6642148615627502d), new NpgsqlTypes.NpgsqlPoint(x: 0.610351026941443d, y: 0.5849422611525543d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2579424949150615d, y: 0.5403722352546811d), new NpgsqlTypes.NpgsqlPoint(x: 0.4333304055530527d, y: 0.4331537517981201d), new NpgsqlTypes.NpgsqlPoint(x: 0.7828125582115649d, y: 0.2793949045356605d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9810379387419593d, y: 0.5436359613130036d), new NpgsqlTypes.NpgsqlPoint(x: 0.6363929571401846d, y: 0.39289325769968597d), new NpgsqlTypes.NpgsqlPoint(x: 0.9024638509646798d, y: 0.05042987034934254d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09980536593540523d, y: 0.48475706272525565d), new NpgsqlTypes.NpgsqlPoint(x: 0.5075438507410069d, y: 0.845692499531488d), new NpgsqlTypes.NpgsqlPoint(x: 0.7922866714906273d, y: 0.2708800973681619d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9715339603817086d, y: 0.11919725541375537d), new NpgsqlTypes.NpgsqlPoint(x: 0.00401896134637969d, y: 0.032005611505699694d), new NpgsqlTypes.NpgsqlPoint(x: 0.279656104128718d, y: 0.5027309241001717d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 130, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 69, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 115, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 37, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 32, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 71, query1, 60, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 52, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 39, query1, 136, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 130, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 89, 37))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[29],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[30],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[31],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[32],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 130);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI), typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                await ((INpgsqlPathListpathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                ((INpgsqlPathListpathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathListpathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

