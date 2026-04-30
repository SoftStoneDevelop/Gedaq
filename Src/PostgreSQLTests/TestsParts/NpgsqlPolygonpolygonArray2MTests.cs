

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
    internal partial interface INpgsqlPolygonListpolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonListpolygonArray : INpgsqlPolygonListpolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray2M[] _testData = new NpgsqlPolygonpolygonArray2M[]
        {
            new NpgsqlPolygonpolygonArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9282323805087811d, y: 0.4193219554286305d), new NpgsqlTypes.NpgsqlPoint(x: 0.46420991706912385d, y: 0.08867266570122634d), new NpgsqlTypes.NpgsqlPoint(x: 0.9225239925670332d, y: 0.890616745477916d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.848864027667215d, y: 0.7817307148974573d), new NpgsqlTypes.NpgsqlPoint(x: 0.20918928340789822d, y: 0.2908779444826899d), new NpgsqlTypes.NpgsqlPoint(x: 0.22711628637717407d, y: 0.17604978543623218d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8102571704227315d, y: 0.3151287084665536d), new NpgsqlTypes.NpgsqlPoint(x: 0.6205488402927896d, y: 0.7615424641236656d), new NpgsqlTypes.NpgsqlPoint(x: 0.013361906745637087d, y: 0.46156322856956455d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.970447635455856d, y: 0.6842986407306721d), new NpgsqlTypes.NpgsqlPoint(x: 0.8923232635269988d, y: 0.9702180979944591d), new NpgsqlTypes.NpgsqlPoint(x: 0.4992494095438812d, y: 0.9126768007966225d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8061498845364696d, y: 0.21124113608891826d), new NpgsqlTypes.NpgsqlPoint(x: 0.5336648691595799d, y: 0.03860910687167296d), new NpgsqlTypes.NpgsqlPoint(x: 0.3413922528755844d, y: 0.012584961259188843d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3621466922563785d, y: 0.9633182317228443d), new NpgsqlTypes.NpgsqlPoint(x: 0.4882328321303072d, y: 0.6348142332419063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7299070044518584d, y: 0.7132488691862384d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8582975068456047d, y: 0.6509914673724687d), new NpgsqlTypes.NpgsqlPoint(x: 0.5298962460054983d, y: 0.8767517724771544d), new NpgsqlTypes.NpgsqlPoint(x: 0.8916559847672031d, y: 0.850965711137421d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33539777606576215d, y: 0.3645622027010631d), new NpgsqlTypes.NpgsqlPoint(x: 0.17831679723948068d, y: 0.2760712532937357d), new NpgsqlTypes.NpgsqlPoint(x: 0.94279311427067d, y: 0.6747890469131422d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1618017720395728d, y: 0.9137371571723765d), new NpgsqlTypes.NpgsqlPoint(x: 0.49613482924042995d, y: 0.5713356197737077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8441831213623118d, y: 0.6191227481276433d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9959101118620391d, y: 0.9171594542449224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8043427165028582d, y: 0.7113088726725777d), new NpgsqlTypes.NpgsqlPoint(x: 0.2652957661697287d, y: 0.29792569650118883d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7622685967616863d, y: 0.15111589844010287d), new NpgsqlTypes.NpgsqlPoint(x: 0.07536847694584226d, y: 0.005132718949475312d), new NpgsqlTypes.NpgsqlPoint(x: 0.84344448124561d, y: 0.7971352601095824d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2583628496328333d, y: 0.3869868194316166d), new NpgsqlTypes.NpgsqlPoint(x: 0.11425981771082006d, y: 0.28157369883429906d), new NpgsqlTypes.NpgsqlPoint(x: 0.8569067175536655d, y: 0.1943246121595873d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.489620990423693d, y: 0.19060522792003987d), new NpgsqlTypes.NpgsqlPoint(x: 0.11317418449254002d, y: 0.32861800525058216d), new NpgsqlTypes.NpgsqlPoint(x: 0.38352951914054934d, y: 0.8201279559241612d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7000248346238047d, y: 0.2994607537824374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5074853479788066d, y: 0.6524134768381287d), new NpgsqlTypes.NpgsqlPoint(x: 0.8303029101270077d, y: 0.5391727319406396d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5444974427675978d, y: 0.18809633899125489d), new NpgsqlTypes.NpgsqlPoint(x: 0.8766049107628594d, y: 0.3240092294456379d), new NpgsqlTypes.NpgsqlPoint(x: 0.13049780914007503d, y: 0.3628747870040063d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6162310039836345d, y: 0.698365696532356d), new NpgsqlTypes.NpgsqlPoint(x: 0.8732779648004055d, y: 0.23697194716910097d), new NpgsqlTypes.NpgsqlPoint(x: 0.22440614151150917d, y: 0.8288696627559089d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8729147077028075d, y: 0.22869302508148948d), new NpgsqlTypes.NpgsqlPoint(x: 0.09484312486868662d, y: 0.5284309504037883d), new NpgsqlTypes.NpgsqlPoint(x: 0.9725049114919861d, y: 0.02278953851511656d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2454582489008188d, y: 0.3840917255994474d), new NpgsqlTypes.NpgsqlPoint(x: 0.03758196099271849d, y: 0.45578299272083167d), new NpgsqlTypes.NpgsqlPoint(x: 0.07276545420519231d, y: 0.16980092161746396d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9056163548708493d, y: 0.42399328767140254d), new NpgsqlTypes.NpgsqlPoint(x: 0.3804895754363983d, y: 0.1616573710947642d), new NpgsqlTypes.NpgsqlPoint(x: 0.4282187342504157d, y: 0.5464028872995909d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9422116181820182d, y: 0.20431165447857424d), new NpgsqlTypes.NpgsqlPoint(x: 0.7837175882537591d, y: 0.804954332028371d), new NpgsqlTypes.NpgsqlPoint(x: 0.43966804009079175d, y: 0.07289525631217142d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4006328986332981d, y: 0.4133054391511146d), new NpgsqlTypes.NpgsqlPoint(x: 0.6706647562980556d, y: 0.5206069466647856d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961118153319281d, y: 0.30526929327615415d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9219275575821141d, y: 0.5414710762509853d), new NpgsqlTypes.NpgsqlPoint(x: 0.9012505985499272d, y: 0.9479534443486384d), new NpgsqlTypes.NpgsqlPoint(x: 0.6893761120720532d, y: 0.12761767839525828d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10173233797751802d, y: 0.6083962281575334d), new NpgsqlTypes.NpgsqlPoint(x: 0.20315655796691579d, y: 0.9435145313312081d), new NpgsqlTypes.NpgsqlPoint(x: 0.7243852293396933d, y: 0.4218952661314992d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37403662753980993d, y: 0.9641429932911001d), new NpgsqlTypes.NpgsqlPoint(x: 0.4240806211319975d, y: 0.8509076298855178d), new NpgsqlTypes.NpgsqlPoint(x: 0.9060619271453999d, y: 0.8864125912926468d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16518516288378604d, y: 0.7883503491647839d), new NpgsqlTypes.NpgsqlPoint(x: 0.51133416539869d, y: 0.3085151163449694d), new NpgsqlTypes.NpgsqlPoint(x: 0.4616968167662816d, y: 0.2915947263057618d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6504611722494841d, y: 0.810201582518004d), new NpgsqlTypes.NpgsqlPoint(x: 0.46140573875976765d, y: 0.1095186273775196d), new NpgsqlTypes.NpgsqlPoint(x: 0.7608003768634588d, y: 0.46271068911884117d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.981704468657455d, y: 0.8206405454676176d), new NpgsqlTypes.NpgsqlPoint(x: 0.5482341330847401d, y: 0.8904937894420393d), new NpgsqlTypes.NpgsqlPoint(x: 0.572539867430135d, y: 0.13934105043260914d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04059361351951274d, y: 0.1288420200835817d), new NpgsqlTypes.NpgsqlPoint(x: 0.3080915009412233d, y: 0.27654752842530295d), new NpgsqlTypes.NpgsqlPoint(x: 0.8866059855823804d, y: 0.6068600913149484d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5173902387711717d, y: 0.2780741270159719d), new NpgsqlTypes.NpgsqlPoint(x: 0.952540878198927d, y: 0.24419691517678088d), new NpgsqlTypes.NpgsqlPoint(x: 0.8009437843797172d, y: 0.7462879526564349d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8500192260140632d, y: 0.4170338072990071d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454249325104792d, y: 0.8976229593614825d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083216710633327d, y: 0.6362271056651605d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.965628023502074d, y: 0.44470933682283453d), new NpgsqlTypes.NpgsqlPoint(x: 0.2441950734819821d, y: 0.2593192828909885d), new NpgsqlTypes.NpgsqlPoint(x: 0.4924428960566727d, y: 0.4505365662192583d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9935119567451336d, y: 0.22375562994873033d), new NpgsqlTypes.NpgsqlPoint(x: 0.819007554992913d, y: 0.9534812854630154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9499994824209146d, y: 0.8693452963949123d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7229813963987908d, y: 0.7835984033316601d), new NpgsqlTypes.NpgsqlPoint(x: 0.17361110088947684d, y: 0.8832455448492503d), new NpgsqlTypes.NpgsqlPoint(x: 0.6612214569643348d, y: 0.14974488281865295d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9450443509884159d, y: 0.16715087863616207d), new NpgsqlTypes.NpgsqlPoint(x: 0.16967171356011257d, y: 0.5041475522661559d), new NpgsqlTypes.NpgsqlPoint(x: 0.5078445813242107d, y: 0.08882234268745237d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2625963141375819d, y: 0.22376787487516758d), new NpgsqlTypes.NpgsqlPoint(x: 0.9537913642403918d, y: 0.6868458445249985d), new NpgsqlTypes.NpgsqlPoint(x: 0.799889894844017d, y: 0.6992187275302353d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004191622138388973d, y: 0.10507851736344287d), new NpgsqlTypes.NpgsqlPoint(x: 0.2677895728938391d, y: 0.22461154217254242d), new NpgsqlTypes.NpgsqlPoint(x: 0.4947180502609039d, y: 0.3630972494012289d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9242569638379639d, y: 0.2814698492500848d), new NpgsqlTypes.NpgsqlPoint(x: 0.862303746475663d, y: 0.7344625359547852d), new NpgsqlTypes.NpgsqlPoint(x: 0.8824827893792827d, y: 0.02218902667330125d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9105096215209316d, y: 0.27346739997178415d), new NpgsqlTypes.NpgsqlPoint(x: 0.2902968788562743d, y: 0.8545384122882299d), new NpgsqlTypes.NpgsqlPoint(x: 0.4606250071013289d, y: 0.19741236286452957d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29601062966028047d, y: 0.7996053497619768d), new NpgsqlTypes.NpgsqlPoint(x: 0.8738272768561236d, y: 0.7624739710349513d), new NpgsqlTypes.NpgsqlPoint(x: 0.8478014679806332d, y: 0.6569054325763799d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6883337994821446d, y: 0.27337719079285205d), new NpgsqlTypes.NpgsqlPoint(x: 0.3662193884800863d, y: 0.9837131240560355d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286225808981247d, y: 0.4050575509091009d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8277971549716407d, y: 0.35458659366724743d), new NpgsqlTypes.NpgsqlPoint(x: 0.4296344042660529d, y: 0.3662592029756824d), new NpgsqlTypes.NpgsqlPoint(x: 0.9790255981605631d, y: 0.6384451431984225d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.011360718283636384d, y: 0.3211597733260536d), new NpgsqlTypes.NpgsqlPoint(x: 0.5343884819861191d, y: 0.7769899999123783d), new NpgsqlTypes.NpgsqlPoint(x: 0.2014378640633132d, y: 0.27689002588572287d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8284999030584914d, y: 0.44649206665002106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5346120340176054d, y: 0.7856414272549326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7092608957091137d, y: 0.4110607693627393d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17545116055974197d, y: 0.508703685664069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8285400950202719d, y: 0.4934796518780501d), new NpgsqlTypes.NpgsqlPoint(x: 0.06804682542378981d, y: 0.19596562495056735d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13847990897336904d, y: 0.6867527686606575d), new NpgsqlTypes.NpgsqlPoint(x: 0.67569029505361d, y: 0.3735115944840849d), new NpgsqlTypes.NpgsqlPoint(x: 0.5101655958408136d, y: 0.31090654809373675d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30528289679680753d, y: 0.6479330025392688d), new NpgsqlTypes.NpgsqlPoint(x: 0.10039151841560956d, y: 0.08169879954372428d), new NpgsqlTypes.NpgsqlPoint(x: 0.22356613247407786d, y: 0.35538786547335033d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6313042344713423d, y: 0.5055492949748601d), new NpgsqlTypes.NpgsqlPoint(x: 0.9939462520036759d, y: 0.05700952300726503d), new NpgsqlTypes.NpgsqlPoint(x: 0.6570123834925337d, y: 0.25193832726035925d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.634743605442852d, y: 0.6740028277708456d), new NpgsqlTypes.NpgsqlPoint(x: 0.21796798816143115d, y: 0.49104597930739113d), new NpgsqlTypes.NpgsqlPoint(x: 0.6728132338068773d, y: 0.35448329224959985d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0945684189249606d, y: 0.11047553098695284d), new NpgsqlTypes.NpgsqlPoint(x: 0.469352080738627d, y: 0.8033975278485768d), new NpgsqlTypes.NpgsqlPoint(x: 0.052808974133326414d, y: 0.6244945979153239d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2489302428866388d, y: 0.26524286747053527d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375271936778303d, y: 0.8300724409627893d), new NpgsqlTypes.NpgsqlPoint(x: 0.20229164170265168d, y: 0.11720285168466693d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.560058243553892d, y: 0.6679273124320255d), new NpgsqlTypes.NpgsqlPoint(x: 0.27165276145507444d, y: 0.6545991155735961d), new NpgsqlTypes.NpgsqlPoint(x: 0.9303837506217535d, y: 0.1338672534201929d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9089475441100422d, y: 0.7966081831543779d), new NpgsqlTypes.NpgsqlPoint(x: 0.036603665716641864d, y: 0.1902029836937923d), new NpgsqlTypes.NpgsqlPoint(x: 0.3371316083458821d, y: 0.39752247247044525d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7494819000278505d, y: 0.49902278035248726d), new NpgsqlTypes.NpgsqlPoint(x: 0.7518080979731815d, y: 0.9273748094234281d), new NpgsqlTypes.NpgsqlPoint(x: 0.8154230410581464d, y: 0.359359441164284d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6893981201957724d, y: 0.04314790011087599d), new NpgsqlTypes.NpgsqlPoint(x: 0.9969634299498475d, y: 0.06585326766890076d), new NpgsqlTypes.NpgsqlPoint(x: 0.09399643489890797d, y: 0.5742385256241052d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2873286272872525d, y: 0.975302269589208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6439579623623809d, y: 0.08635794144219333d), new NpgsqlTypes.NpgsqlPoint(x: 0.08840101651108534d, y: 0.345236957444251d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29883418761990765d, y: 0.6561819802336687d), new NpgsqlTypes.NpgsqlPoint(x: 0.2829640988165115d, y: 0.911997482339383d), new NpgsqlTypes.NpgsqlPoint(x: 0.2518967889597039d, y: 0.835124212593396d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3306136943770357d, y: 0.4252828548233998d), new NpgsqlTypes.NpgsqlPoint(x: 0.2988065050045744d, y: 0.3945512336129655d), new NpgsqlTypes.NpgsqlPoint(x: 0.9260938781668947d, y: 0.7223922666183773d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.021924398263389766d, y: 0.8274692677995232d), new NpgsqlTypes.NpgsqlPoint(x: 0.7083450785494522d, y: 0.21078817823626872d), new NpgsqlTypes.NpgsqlPoint(x: 0.0120715838614317d, y: 0.8072254003447974d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2836745000146125d, y: 0.241993349163528d), new NpgsqlTypes.NpgsqlPoint(x: 0.3092273763655492d, y: 0.8036563003963141d), new NpgsqlTypes.NpgsqlPoint(x: 0.8768911601313902d, y: 0.15961055322543583d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9519348801443127d, y: 0.2760787226708642d), new NpgsqlTypes.NpgsqlPoint(x: 0.230685137588293d, y: 0.701684730160885d), new NpgsqlTypes.NpgsqlPoint(x: 0.3598518343212139d, y: 0.39789124147710275d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17471580344672022d, y: 0.29664994339606165d), new NpgsqlTypes.NpgsqlPoint(x: 0.6475042156966919d, y: 0.07430780896304412d), new NpgsqlTypes.NpgsqlPoint(x: 0.5332996562468127d, y: 0.3530424175245567d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20028251487445958d, y: 0.2960174862791527d), new NpgsqlTypes.NpgsqlPoint(x: 0.9801750425525568d, y: 0.7996730235222859d), new NpgsqlTypes.NpgsqlPoint(x: 0.7035141183609573d, y: 0.9860568555429579d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20469809323053345d, y: 0.1181543431849944d), new NpgsqlTypes.NpgsqlPoint(x: 0.12342785200624606d, y: 0.586277210503072d), new NpgsqlTypes.NpgsqlPoint(x: 0.23990482069655816d, y: 0.3851049509980258d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18486689452985983d, y: 0.54093661538125d), new NpgsqlTypes.NpgsqlPoint(x: 0.7030905157653234d, y: 0.09585727892685869d), new NpgsqlTypes.NpgsqlPoint(x: 0.861344897399994d, y: 0.3970847964176335d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24285032477345858d, y: 0.9978097697197826d), new NpgsqlTypes.NpgsqlPoint(x: 0.07835033429380489d, y: 0.7470165970069298d), new NpgsqlTypes.NpgsqlPoint(x: 0.9459821880012939d, y: 0.9142074713407534d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19534077692950613d, y: 0.10234125511878522d), new NpgsqlTypes.NpgsqlPoint(x: 0.3066204485897541d, y: 0.4046531404357089d), new NpgsqlTypes.NpgsqlPoint(x: 0.31590746870655806d, y: 0.9897201635431886d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9244567934810591d, y: 0.955892523457409d), new NpgsqlTypes.NpgsqlPoint(x: 0.10754662682849647d, y: 0.44948243066928617d), new NpgsqlTypes.NpgsqlPoint(x: 0.08934644489344112d, y: 0.17715363489803215d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41083848436951975d, y: 0.7857956018592164d), new NpgsqlTypes.NpgsqlPoint(x: 0.03451546976320663d, y: 0.16511837933052154d), new NpgsqlTypes.NpgsqlPoint(x: 0.07662801955414877d, y: 0.7108931663489122d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5536285031986474d, y: 0.9608078250942684d), new NpgsqlTypes.NpgsqlPoint(x: 0.6890790683680921d, y: 0.036097279643844904d), new NpgsqlTypes.NpgsqlPoint(x: 0.33331797417077746d, y: 0.05035074109446236d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6585955582689674d, y: 0.5143319078028711d), new NpgsqlTypes.NpgsqlPoint(x: 0.3372582368806244d, y: 0.23748490394282484d), new NpgsqlTypes.NpgsqlPoint(x: 0.08994223970091053d, y: 0.697147443363586d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9045235395864919d, y: 0.28623876541354876d), new NpgsqlTypes.NpgsqlPoint(x: 0.34562613767698613d, y: 0.6575749755476323d), new NpgsqlTypes.NpgsqlPoint(x: 0.13395781810520624d, y: 0.5433165865502383d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2647051081923041d, y: 0.5763149972834827d), new NpgsqlTypes.NpgsqlPoint(x: 0.13499416693309652d, y: 0.15673806691576242d), new NpgsqlTypes.NpgsqlPoint(x: 0.8114219996074796d, y: 0.10802812255279926d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.043124620138027536d, y: 0.5179699129308961d), new NpgsqlTypes.NpgsqlPoint(x: 0.34046595743937014d, y: 0.8093690805408158d), new NpgsqlTypes.NpgsqlPoint(x: 0.14298374720865925d, y: 0.16504668165284575d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7994700302702553d, y: 0.6062688015306863d), new NpgsqlTypes.NpgsqlPoint(x: 0.895900037601697d, y: 0.13445523030011397d), new NpgsqlTypes.NpgsqlPoint(x: 0.4886569626471404d, y: 0.6500470751989685d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.132936218094447d, y: 0.5256166818668438d), new NpgsqlTypes.NpgsqlPoint(x: 0.05354272995918652d, y: 0.29121269545915085d), new NpgsqlTypes.NpgsqlPoint(x: 0.3609570232510543d, y: 0.18479080478998167d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8681070328590573d, y: 0.14159273335467581d), new NpgsqlTypes.NpgsqlPoint(x: 0.8581369059373654d, y: 0.5797200225226949d), new NpgsqlTypes.NpgsqlPoint(x: 0.3284981975921334d, y: 0.6902519986038718d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7638345639685599d, y: 0.7474736937519667d), new NpgsqlTypes.NpgsqlPoint(x: 0.37878532614898d, y: 0.3064293374104541d), new NpgsqlTypes.NpgsqlPoint(x: 0.5747764858949834d, y: 0.9433544145948404d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10502488984450631d, y: 0.229594243916041d), new NpgsqlTypes.NpgsqlPoint(x: 0.20900096893346254d, y: 0.8006226872418226d), new NpgsqlTypes.NpgsqlPoint(x: 0.9641232883523253d, y: 0.41963959674016127d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2938146250199477d, y: 0.22945935751087154d), new NpgsqlTypes.NpgsqlPoint(x: 0.1512300747599853d, y: 0.9114304084111295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7685006995283414d, y: 0.15645443590153085d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7425608470013941d, y: 0.2977207827049556d), new NpgsqlTypes.NpgsqlPoint(x: 0.6760165697449229d, y: 0.42692090293155527d), new NpgsqlTypes.NpgsqlPoint(x: 0.6082327999340864d, y: 0.2637733493961215d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42540728223506663d, y: 0.19311799543716202d), new NpgsqlTypes.NpgsqlPoint(x: 0.34168502460377603d, y: 0.15821587825521177d), new NpgsqlTypes.NpgsqlPoint(x: 0.9776706492424662d, y: 0.14077494459420115d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3766642506707857d, y: 0.12589470242066836d), new NpgsqlTypes.NpgsqlPoint(x: 0.8007256996882944d, y: 0.212592623652762d), new NpgsqlTypes.NpgsqlPoint(x: 0.015690501113361455d, y: 0.31862453925849865d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38198468290822973d, y: 0.03716200174548934d), new NpgsqlTypes.NpgsqlPoint(x: 0.1243332459536316d, y: 0.760798184124487d), new NpgsqlTypes.NpgsqlPoint(x: 0.18990792394907474d, y: 0.36236214226834584d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5894674233469847d, y: 0.7910434968407128d), new NpgsqlTypes.NpgsqlPoint(x: 0.33727767054746793d, y: 0.6009086549740087d), new NpgsqlTypes.NpgsqlPoint(x: 0.3425731339165843d, y: 0.7166253017282148d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9733790327463232d, y: 0.15135751574465528d), new NpgsqlTypes.NpgsqlPoint(x: 0.14507477755913833d, y: 0.2690081426832791d), new NpgsqlTypes.NpgsqlPoint(x: 0.023430456840489056d, y: 0.6001740601041154d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4157839305495006d, y: 0.9665949240324226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6450161380718533d, y: 0.7903790135736127d), new NpgsqlTypes.NpgsqlPoint(x: 0.547418277594506d, y: 0.5030569397206264d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4582793283996971d, y: 0.7969367796998091d), new NpgsqlTypes.NpgsqlPoint(x: 0.4015395167884136d, y: 0.40401428021054053d), new NpgsqlTypes.NpgsqlPoint(x: 0.4577185094773364d, y: 0.309430189022456d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13967538009291836d, y: 0.7835200764680799d), new NpgsqlTypes.NpgsqlPoint(x: 0.2469963789385684d, y: 0.8297080003851526d), new NpgsqlTypes.NpgsqlPoint(x: 0.7719949271702655d, y: 0.13206694905405747d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8747128005664638d, y: 0.27260367527294005d), new NpgsqlTypes.NpgsqlPoint(x: 0.32705668332857396d, y: 0.49828884186285916d), new NpgsqlTypes.NpgsqlPoint(x: 0.8070949753560134d, y: 0.4456356563722832d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6945372668703522d, y: 0.8186114329785195d), new NpgsqlTypes.NpgsqlPoint(x: 0.5953649173529301d, y: 0.3282063000634524d), new NpgsqlTypes.NpgsqlPoint(x: 0.11796664816031432d, y: 0.28230107739081756d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48823569780855725d, y: 0.06109129205395547d), new NpgsqlTypes.NpgsqlPoint(x: 0.18961881330309982d, y: 0.19481943569115623d), new NpgsqlTypes.NpgsqlPoint(x: 0.7713535033650772d, y: 0.08537514858439421d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8260582530077417d, y: 0.2775836801263696d), new NpgsqlTypes.NpgsqlPoint(x: 0.07029808822505768d, y: 0.31095865005517376d), new NpgsqlTypes.NpgsqlPoint(x: 0.6003514388917376d, y: 0.7821977899487264d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9093674474898283d, y: 0.23861944787238887d), new NpgsqlTypes.NpgsqlPoint(x: 0.22206538944170195d, y: 0.09854836973418224d), new NpgsqlTypes.NpgsqlPoint(x: 0.16725234116507737d, y: 0.6092752574507441d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48219326571250254d, y: 0.7761129266758758d), new NpgsqlTypes.NpgsqlPoint(x: 0.41834407731739276d, y: 0.16720080446347352d), new NpgsqlTypes.NpgsqlPoint(x: 0.9677298524542669d, y: 0.489857249868319d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8863470268048487d, y: 0.19286879496226772d), new NpgsqlTypes.NpgsqlPoint(x: 0.2711757133585403d, y: 0.8540707337940716d), new NpgsqlTypes.NpgsqlPoint(x: 0.9277796465101338d, y: 0.13695857902835007d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6389990028384028d, y: 0.3587133952607643d), new NpgsqlTypes.NpgsqlPoint(x: 0.7144965107016905d, y: 0.4109735831984225d), new NpgsqlTypes.NpgsqlPoint(x: 0.4795409582233595d, y: 0.3428533846498498d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2719569082971155d, y: 0.8280505748788723d), new NpgsqlTypes.NpgsqlPoint(x: 0.2955256611910325d, y: 0.29563870793812974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6159755567017254d, y: 0.9790921724085287d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9932480606395111d, y: 0.8292761314741454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4425089521405351d, y: 0.8725014889674781d), new NpgsqlTypes.NpgsqlPoint(x: 0.766459990061029d, y: 0.49468376551834403d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9079332111339542d, y: 0.8695384197833337d), new NpgsqlTypes.NpgsqlPoint(x: 0.5595616441560445d, y: 0.11738265597589936d), new NpgsqlTypes.NpgsqlPoint(x: 0.7973742599829695d, y: 0.24807791354230624d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.014103956405798312d, y: 0.17384019625544378d), new NpgsqlTypes.NpgsqlPoint(x: 0.1313469117164886d, y: 0.19895936210232268d), new NpgsqlTypes.NpgsqlPoint(x: 0.7787069644001058d, y: 0.23933130417811666d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8090600218894607d, y: 0.6706243405915895d), new NpgsqlTypes.NpgsqlPoint(x: 0.7445574288386797d, y: 0.976007211653042d), new NpgsqlTypes.NpgsqlPoint(x: 0.39051420742252085d, y: 0.09615892070654375d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.599783279059291d, y: 0.3906860331604809d), new NpgsqlTypes.NpgsqlPoint(x: 0.44477212078772355d, y: 0.6575890867185888d), new NpgsqlTypes.NpgsqlPoint(x: 0.3351622674015491d, y: 0.4999389754858262d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5653817505747928d, y: 0.007276121105397437d), new NpgsqlTypes.NpgsqlPoint(x: 0.10327285036658929d, y: 0.2048689022732706d), new NpgsqlTypes.NpgsqlPoint(x: 0.10800381897784705d, y: 0.6893522302688677d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7396054614219598d, y: 0.031398064975929785d), new NpgsqlTypes.NpgsqlPoint(x: 0.44290816345456563d, y: 0.02972627196174049d), new NpgsqlTypes.NpgsqlPoint(x: 0.5174874778720312d, y: 0.7325153753877268d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.528542887773204d, y: 0.452365863690412d), new NpgsqlTypes.NpgsqlPoint(x: 0.9053585316180898d, y: 0.055530747212607645d), new NpgsqlTypes.NpgsqlPoint(x: 0.004860773726217293d, y: 0.6807237263518051d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9440312516852029d, y: 0.27576065798129d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407649423935666d, y: 0.8271708478315619d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372108070845262d, y: 0.8407261467832653d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8762528807077459d, y: 0.9536300374913083d), new NpgsqlTypes.NpgsqlPoint(x: 0.9359162402880865d, y: 0.5059171482015176d), new NpgsqlTypes.NpgsqlPoint(x: 0.5898787212942646d, y: 0.8361989629011014d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6762266509099236d, y: 0.16000017618389606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5501110200179427d, y: 0.5317478959049012d), new NpgsqlTypes.NpgsqlPoint(x: 0.6709779414705114d, y: 0.2593592000645424d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22762148562952d, y: 0.44319383971538184d), new NpgsqlTypes.NpgsqlPoint(x: 0.767104325966715d, y: 0.3310711861279175d), new NpgsqlTypes.NpgsqlPoint(x: 0.7212593892587592d, y: 0.01838750871687278d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9993133237585071d, y: 0.4072424638420742d), new NpgsqlTypes.NpgsqlPoint(x: 0.37289842488853897d, y: 0.45653475642997565d), new NpgsqlTypes.NpgsqlPoint(x: 0.9949957707102087d, y: 0.8730709089964157d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9777271506113087d, y: 0.8495349403835528d), new NpgsqlTypes.NpgsqlPoint(x: 0.8899779824200368d, y: 0.7327889441366705d), new NpgsqlTypes.NpgsqlPoint(x: 0.48577967422495016d, y: 0.8639720438557135d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11945482219049675d, y: 0.6248220309208387d), new NpgsqlTypes.NpgsqlPoint(x: 0.5356669709972437d, y: 0.6313422772296571d), new NpgsqlTypes.NpgsqlPoint(x: 0.316620811925733d, y: 0.8644905452333116d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.937048876865816d, y: 0.29427817400489054d), new NpgsqlTypes.NpgsqlPoint(x: 0.8321360930145362d, y: 0.628190446855969d), new NpgsqlTypes.NpgsqlPoint(x: 0.8343693124291797d, y: 0.10396258089436894d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8897101637873918d, y: 0.6973690752735935d), new NpgsqlTypes.NpgsqlPoint(x: 0.12147743292175495d, y: 0.600598850518953d), new NpgsqlTypes.NpgsqlPoint(x: 0.5906631605956673d, y: 0.5695151924575251d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45349891351669314d, y: 0.4083585975052454d), new NpgsqlTypes.NpgsqlPoint(x: 0.46671966861551994d, y: 0.5571992910508876d), new NpgsqlTypes.NpgsqlPoint(x: 0.5502697688956283d, y: 0.9984391980374834d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13313873011658117d, y: 0.7465251217931169d), new NpgsqlTypes.NpgsqlPoint(x: 0.46482705900560595d, y: 0.8400358032871703d), new NpgsqlTypes.NpgsqlPoint(x: 0.2895975168409689d, y: 0.8881473754430228d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8404265769670705d, y: 0.6164418708771615d), new NpgsqlTypes.NpgsqlPoint(x: 0.7298199167902204d, y: 0.7895136445727157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5145831858519075d, y: 0.5763341628614916d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38216434213529005d, y: 0.9267141631738933d), new NpgsqlTypes.NpgsqlPoint(x: 0.3848755082635602d, y: 0.5091899170683387d), new NpgsqlTypes.NpgsqlPoint(x: 0.467324610081544d, y: 0.44260061819795404d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2728876697860063d, y: 0.5960030559640319d), new NpgsqlTypes.NpgsqlPoint(x: 0.02351384961771419d, y: 0.5504990305931332d), new NpgsqlTypes.NpgsqlPoint(x: 0.8054854349029715d, y: 0.8749545088688047d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5900121425093304d, y: 0.8324853078303444d), new NpgsqlTypes.NpgsqlPoint(x: 0.832463314322392d, y: 0.987839705966977d), new NpgsqlTypes.NpgsqlPoint(x: 0.7878336324596587d, y: 0.2728471830836704d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7739990085380941d, y: 0.9636401099098355d), new NpgsqlTypes.NpgsqlPoint(x: 0.36264383216343454d, y: 0.9875396895033817d), new NpgsqlTypes.NpgsqlPoint(x: 0.18797173295219938d, y: 0.7677488758494253d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3911718035642545d, y: 0.16098494802659635d), new NpgsqlTypes.NpgsqlPoint(x: 0.11509958727282332d, y: 0.6134135255741323d), new NpgsqlTypes.NpgsqlPoint(x: 0.44691555163839625d, y: 0.3494338429015106d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8185532466078667d, y: 0.13321500190449476d), new NpgsqlTypes.NpgsqlPoint(x: 0.716300045344392d, y: 0.9615845687955461d), new NpgsqlTypes.NpgsqlPoint(x: 0.7277896885393167d, y: 0.5234249861246673d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13104320156141636d, y: 0.6465285824037074d), new NpgsqlTypes.NpgsqlPoint(x: 0.7073728791675402d, y: 0.034468684926845294d), new NpgsqlTypes.NpgsqlPoint(x: 0.2836166005904984d, y: 0.12256930314581083d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42868800346995795d, y: 0.825680014925921d), new NpgsqlTypes.NpgsqlPoint(x: 0.2542404048893405d, y: 0.9925271012212455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5096997591567055d, y: 0.23078553614828923d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6798166222397407d, y: 0.9152039201494665d), new NpgsqlTypes.NpgsqlPoint(x: 0.7188248467292585d, y: 0.9363398112987846d), new NpgsqlTypes.NpgsqlPoint(x: 0.07120300924884859d, y: 0.7252463363931824d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34119186439209115d, y: 0.8485631256002829d), new NpgsqlTypes.NpgsqlPoint(x: 0.6279840958701853d, y: 0.3376413038435314d), new NpgsqlTypes.NpgsqlPoint(x: 0.032172133150801474d, y: 0.9024118375441036d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22575996528092235d, y: 0.041732908542011504d), new NpgsqlTypes.NpgsqlPoint(x: 0.06213316153156456d, y: 0.1452205852201387d), new NpgsqlTypes.NpgsqlPoint(x: 0.6119748638499829d, y: 0.6282829269865313d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4036720363608164d, y: 0.0516544589213771d), new NpgsqlTypes.NpgsqlPoint(x: 0.4653413551453248d, y: 0.39096008172085694d), new NpgsqlTypes.NpgsqlPoint(x: 0.1916927162416452d, y: 0.6249103437462189d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5225627857649365d, y: 0.7972956634646359d), new NpgsqlTypes.NpgsqlPoint(x: 0.7726366327269598d, y: 0.791158202069018d), new NpgsqlTypes.NpgsqlPoint(x: 0.19485266290690761d, y: 0.5149246432763296d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6238502685091744d, y: 0.7009454837614421d), new NpgsqlTypes.NpgsqlPoint(x: 0.4085721255339797d, y: 0.4527800430690049d), new NpgsqlTypes.NpgsqlPoint(x: 0.1751927006680014d, y: 0.15967635212231268d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15792280211486698d, y: 0.22229842801505983d), new NpgsqlTypes.NpgsqlPoint(x: 0.14897733206135033d, y: 0.14622698399113987d), new NpgsqlTypes.NpgsqlPoint(x: 0.602320272278394d, y: 0.330129511159467d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20588786479643773d, y: 0.925389852565952d), new NpgsqlTypes.NpgsqlPoint(x: 0.8940694963867212d, y: 0.8460339156810412d), new NpgsqlTypes.NpgsqlPoint(x: 0.29228854821678896d, y: 0.06540027266113335d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22939684456942044d, y: 0.8586189174539315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8411963537661552d, y: 0.7415611122146185d), new NpgsqlTypes.NpgsqlPoint(x: 0.8123087667651051d, y: 0.6141209560541925d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.010575645583514537d, y: 0.5085404504914409d), new NpgsqlTypes.NpgsqlPoint(x: 0.7079067650340138d, y: 0.9990621287776583d), new NpgsqlTypes.NpgsqlPoint(x: 0.3818086497886075d, y: 0.17559079707197978d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41069132036764777d, y: 0.652672566551958d), new NpgsqlTypes.NpgsqlPoint(x: 0.935612465030846d, y: 0.1323633471355572d), new NpgsqlTypes.NpgsqlPoint(x: 0.07656207430747786d, y: 0.920827720268143d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7552893808306901d, y: 0.8542799750060053d), new NpgsqlTypes.NpgsqlPoint(x: 0.3450072306314178d, y: 0.2117526112291892d), new NpgsqlTypes.NpgsqlPoint(x: 0.9444353252855316d, y: 0.9508138432194765d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24111331701758854d, y: 0.09969056138091126d), new NpgsqlTypes.NpgsqlPoint(x: 0.7686405538250155d, y: 0.4087416560220152d), new NpgsqlTypes.NpgsqlPoint(x: 0.8203693757818799d, y: 0.3159692319785168d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8642137083337511d, y: 0.16083883093896123d), new NpgsqlTypes.NpgsqlPoint(x: 0.5474603939220732d, y: 0.9592737464198645d), new NpgsqlTypes.NpgsqlPoint(x: 0.30874675300108867d, y: 0.8857223016871001d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09715431505580185d, y: 0.649039594320746d), new NpgsqlTypes.NpgsqlPoint(x: 0.7699078131449787d, y: 0.5279327078847168d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296277900325266d, y: 0.3419527597320945d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9897849289767547d, y: 0.9593383375232044d), new NpgsqlTypes.NpgsqlPoint(x: 0.7792620322042189d, y: 0.3491301021336869d), new NpgsqlTypes.NpgsqlPoint(x: 0.4547105022660085d, y: 0.232975732943695d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11299757655512821d, y: 0.7532458800777807d), new NpgsqlTypes.NpgsqlPoint(x: 0.4615233907073868d, y: 0.5016126348965544d), new NpgsqlTypes.NpgsqlPoint(x: 0.1531834964735781d, y: 0.4581191991566368d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19620021382531483d, y: 0.1671620567741866d), new NpgsqlTypes.NpgsqlPoint(x: 0.33371234929631755d, y: 0.058239828397076865d), new NpgsqlTypes.NpgsqlPoint(x: 0.6106861536069832d, y: 0.5857178263520787d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8205328018689857d, y: 0.34729493384158683d), new NpgsqlTypes.NpgsqlPoint(x: 0.8203065936202236d, y: 0.8199877128695002d), new NpgsqlTypes.NpgsqlPoint(x: 0.1453454452056433d, y: 0.6587008756654266d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45416136204079594d, y: 0.7757090452510773d), new NpgsqlTypes.NpgsqlPoint(x: 0.5204265081639289d, y: 0.8036204970632796d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136846867297588d, y: 0.00930199408499699d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5800765878106209d, y: 0.46058103332392986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5984904476793181d, y: 0.9956870581788329d), new NpgsqlTypes.NpgsqlPoint(x: 0.6045487681337156d, y: 0.6171846264107548d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.837757620343164d, y: 0.8203438589160628d), new NpgsqlTypes.NpgsqlPoint(x: 0.7051564119396936d, y: 0.34386281014226616d), new NpgsqlTypes.NpgsqlPoint(x: 0.49786233473330943d, y: 0.8513687290240088d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7562719168324602d, y: 0.419577857965185d), new NpgsqlTypes.NpgsqlPoint(x: 0.42247013105254494d, y: 0.5181836562650813d), new NpgsqlTypes.NpgsqlPoint(x: 0.745535768093482d, y: 0.5334078239078235d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.009893170204727686d, y: 0.49458040619578514d), new NpgsqlTypes.NpgsqlPoint(x: 0.9112857954422334d, y: 0.9690945764206327d), new NpgsqlTypes.NpgsqlPoint(x: 0.43611422286271095d, y: 0.4839844650585797d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.547879954548535d, y: 0.9490911605797632d), new NpgsqlTypes.NpgsqlPoint(x: 0.3265136001022845d, y: 0.20951250006828803d), new NpgsqlTypes.NpgsqlPoint(x: 0.2905901625977798d, y: 0.37827018000764456d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5932475246760073d, y: 0.3718428419154587d), new NpgsqlTypes.NpgsqlPoint(x: 0.6321091116080612d, y: 0.06520790534299215d), new NpgsqlTypes.NpgsqlPoint(x: 0.337666355461662d, y: 0.951764309129949d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.027005458695361084d, y: 0.8471059055504081d), new NpgsqlTypes.NpgsqlPoint(x: 0.9436441039485537d, y: 0.8080229471561431d), new NpgsqlTypes.NpgsqlPoint(x: 0.674192604742935d, y: 0.45248397519427874d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8329338405435514d, y: 0.5603465026584257d), new NpgsqlTypes.NpgsqlPoint(x: 0.6341906906838295d, y: 0.7900879005617784d), new NpgsqlTypes.NpgsqlPoint(x: 0.41173038326410083d, y: 0.34876909182951044d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29086382085263696d, y: 0.0016800020641271063d), new NpgsqlTypes.NpgsqlPoint(x: 0.615085447855468d, y: 0.09769069322208601d), new NpgsqlTypes.NpgsqlPoint(x: 0.5701319069854011d, y: 0.29426725730763315d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.058962083199022075d, y: 0.9527429982855697d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601314726368841d, y: 0.8361404023264605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8381175929896557d, y: 0.6126958759307498d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13497116906485307d, y: 0.4407569745863088d), new NpgsqlTypes.NpgsqlPoint(x: 0.8785974231514256d, y: 0.2684095899594614d), new NpgsqlTypes.NpgsqlPoint(x: 0.2734800156645021d, y: 0.5232872371307555d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3240302470365092d, y: 0.08359826735413722d), new NpgsqlTypes.NpgsqlPoint(x: 0.6483067258373364d, y: 0.10865771696744386d), new NpgsqlTypes.NpgsqlPoint(x: 0.422134771104401d, y: 0.33259603490867784d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5651594661404374d, y: 0.7123041731566015d), new NpgsqlTypes.NpgsqlPoint(x: 0.9011912635781008d, y: 0.6564249031735081d), new NpgsqlTypes.NpgsqlPoint(x: 0.9965966821554376d, y: 0.5161108349205654d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48237393065625767d, y: 0.01022871051887042d), new NpgsqlTypes.NpgsqlPoint(x: 0.11689139122161152d, y: 0.3627322848565415d), new NpgsqlTypes.NpgsqlPoint(x: 0.33195759712148754d, y: 0.1949791566978738d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40932308384882155d, y: 0.44907889331726913d), new NpgsqlTypes.NpgsqlPoint(x: 0.2539261236756871d, y: 0.8065001097589007d), new NpgsqlTypes.NpgsqlPoint(x: 0.4407247711605794d, y: 0.22710556926391023d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7983473926115922d, y: 0.11108871277856702d), new NpgsqlTypes.NpgsqlPoint(x: 0.2665748037213488d, y: 0.25751719810350404d), new NpgsqlTypes.NpgsqlPoint(x: 0.3445389716361509d, y: 0.407984511635337d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3535171311348767d, y: 0.2869600153906977d), new NpgsqlTypes.NpgsqlPoint(x: 0.811901886355093d, y: 0.4471253067044727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6441603650652429d, y: 0.8215816578733984d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4525607446303639d, y: 0.24115548488026306d), new NpgsqlTypes.NpgsqlPoint(x: 0.12071640920849813d, y: 0.7133983362619402d), new NpgsqlTypes.NpgsqlPoint(x: 0.9415662871381094d, y: 0.04158538869385464d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.701137411166169d, y: 0.30852504609461984d), new NpgsqlTypes.NpgsqlPoint(x: 0.19082533619407072d, y: 0.9335760001957174d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776576339327786d, y: 0.08426991000528128d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28084730436008243d, y: 0.7832428291160617d), new NpgsqlTypes.NpgsqlPoint(x: 0.88104892036173d, y: 0.02640482337923966d), new NpgsqlTypes.NpgsqlPoint(x: 0.8278831492339521d, y: 0.38696663338394255d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4371105740017257d, y: 0.5376551202300286d), new NpgsqlTypes.NpgsqlPoint(x: 0.7577241542884755d, y: 0.07044979321597944d), new NpgsqlTypes.NpgsqlPoint(x: 0.004696578838412124d, y: 0.39470492339601837d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6816896206773587d, y: 0.5094647363530828d), new NpgsqlTypes.NpgsqlPoint(x: 0.29746778771012583d, y: 0.5607100493040972d), new NpgsqlTypes.NpgsqlPoint(x: 0.6887367340090813d, y: 0.3042746133201131d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8480703012948079d, y: 0.8232722815612254d), new NpgsqlTypes.NpgsqlPoint(x: 0.8763370412991811d, y: 0.8809613940962476d), new NpgsqlTypes.NpgsqlPoint(x: 0.7581728812061732d, y: 0.4312054924986116d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2196034823812184d, y: 0.7890707744654265d), new NpgsqlTypes.NpgsqlPoint(x: 0.8880222470377869d, y: 0.12662968480815195d), new NpgsqlTypes.NpgsqlPoint(x: 0.9878251382783972d, y: 0.4780293586115386d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5086226064029619d, y: 0.883693775738407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8601470979118473d, y: 0.8797684941012073d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470166951251285d, y: 0.02877905899226718d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7086735360225559d, y: 0.12801925816418847d), new NpgsqlTypes.NpgsqlPoint(x: 0.4421864351261585d, y: 0.6241795043946899d), new NpgsqlTypes.NpgsqlPoint(x: 0.7471424868779486d, y: 0.732339188254839d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10786984501911312d, y: 0.029450143495511005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9918242456117444d, y: 0.5877499806310683d), new NpgsqlTypes.NpgsqlPoint(x: 0.6674720308080286d, y: 0.8945739886922432d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3125914860107979d, y: 0.739196414791653d), new NpgsqlTypes.NpgsqlPoint(x: 0.05011960037166541d, y: 0.9698971151966636d), new NpgsqlTypes.NpgsqlPoint(x: 0.9882785307792797d, y: 0.46228297361702075d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.540151795944683d, y: 0.7656682163424551d), new NpgsqlTypes.NpgsqlPoint(x: 0.004382911309415705d, y: 0.3779814841514657d), new NpgsqlTypes.NpgsqlPoint(x: 0.2886963523771273d, y: 0.8512157073910317d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7439619628660087d, y: 0.6348534795781505d), new NpgsqlTypes.NpgsqlPoint(x: 0.021418843792566644d, y: 0.8249285018272098d), new NpgsqlTypes.NpgsqlPoint(x: 0.788241681165561d, y: 0.7581863279394123d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7909470237943257d, y: 0.9278871533410971d), new NpgsqlTypes.NpgsqlPoint(x: 0.796129019565466d, y: 0.7591510733246548d), new NpgsqlTypes.NpgsqlPoint(x: 0.3648558291064562d, y: 0.04741907275879553d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3779422574098422d, y: 0.8521743849880445d), new NpgsqlTypes.NpgsqlPoint(x: 0.1933369609402551d, y: 0.4144572852198395d), new NpgsqlTypes.NpgsqlPoint(x: 0.1320479382648717d, y: 0.5623751407466084d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7861548431380968d, y: 0.9477650544288164d), new NpgsqlTypes.NpgsqlPoint(x: 0.10016385341741785d, y: 0.5112337661249627d), new NpgsqlTypes.NpgsqlPoint(x: 0.1642682517025238d, y: 0.2592863781270931d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6111093566661009d, y: 0.6850308040804037d), new NpgsqlTypes.NpgsqlPoint(x: 0.8620328404429957d, y: 0.38811718570063025d), new NpgsqlTypes.NpgsqlPoint(x: 0.5639116808768522d, y: 0.048053732233584556d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.007184020974642102d, y: 0.8510761154363209d), new NpgsqlTypes.NpgsqlPoint(x: 0.4968597711694649d, y: 0.9506242310818147d), new NpgsqlTypes.NpgsqlPoint(x: 0.4665249819056052d, y: 0.8095968404503958d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9743057172586463d, y: 0.2925142805168731d), new NpgsqlTypes.NpgsqlPoint(x: 0.21544283617784699d, y: 0.3944601456665101d), new NpgsqlTypes.NpgsqlPoint(x: 0.6196399322213971d, y: 0.45923157803315495d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22826942909239545d, y: 0.9127695778127979d), new NpgsqlTypes.NpgsqlPoint(x: 0.24731898282717157d, y: 0.15934748246260866d), new NpgsqlTypes.NpgsqlPoint(x: 0.14824539604287523d, y: 0.7152964548981124d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004153778012633835d, y: 0.7857415087316153d), new NpgsqlTypes.NpgsqlPoint(x: 0.32769848205418306d, y: 0.36788790630180723d), new NpgsqlTypes.NpgsqlPoint(x: 0.26373534794060194d, y: 0.8124964516492642d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5568940682845718d, y: 0.3701011589788453d), new NpgsqlTypes.NpgsqlPoint(x: 0.8777347601610069d, y: 0.9470264814103183d), new NpgsqlTypes.NpgsqlPoint(x: 0.19640235859161892d, y: 0.2587467540914038d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3553767714074405d, y: 0.7383801539323362d), new NpgsqlTypes.NpgsqlPoint(x: 0.7241978987579172d, y: 0.298134653378646d), new NpgsqlTypes.NpgsqlPoint(x: 0.7331699732578628d, y: 0.6939442351199875d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5226481433456676d, y: 0.7492273582021745d), new NpgsqlTypes.NpgsqlPoint(x: 0.574726064488146d, y: 0.908264345758566d), new NpgsqlTypes.NpgsqlPoint(x: 0.05271991062059622d, y: 0.46756719654582535d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5726589596369277d, y: 0.27825684493186065d), new NpgsqlTypes.NpgsqlPoint(x: 0.11936008729167547d, y: 0.15243035811035688d), new NpgsqlTypes.NpgsqlPoint(x: 0.2926383791322531d, y: 0.05746611515508371d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5436026529407757d, y: 0.2779999933020213d), new NpgsqlTypes.NpgsqlPoint(x: 0.9323095839010062d, y: 0.1628523608501382d), new NpgsqlTypes.NpgsqlPoint(x: 0.930391028284897d, y: 0.8404506849967592d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.521075167023359d, y: 0.4311924954058771d), new NpgsqlTypes.NpgsqlPoint(x: 0.6090204361624602d, y: 0.6870943364602217d), new NpgsqlTypes.NpgsqlPoint(x: 0.34677372599506895d, y: 0.9836122801854608d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40680563752122123d, y: 0.9921133147933728d), new NpgsqlTypes.NpgsqlPoint(x: 0.9423099515420617d, y: 0.8033492198132689d), new NpgsqlTypes.NpgsqlPoint(x: 0.3638818821142996d, y: 0.24969321821182322d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28486855271552913d, y: 0.8520494674949788d), new NpgsqlTypes.NpgsqlPoint(x: 0.3918176702346936d, y: 0.1987882067041018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8437879953366145d, y: 0.9063662046506843d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20220433070618093d, y: 0.34058518259054826d), new NpgsqlTypes.NpgsqlPoint(x: 0.35508202847763304d, y: 0.022033232215123544d), new NpgsqlTypes.NpgsqlPoint(x: 0.8304267758865309d, y: 0.5908867110996918d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.694914930686668d, y: 0.8770344756665276d), new NpgsqlTypes.NpgsqlPoint(x: 0.13023712871291038d, y: 0.39716561903832115d), new NpgsqlTypes.NpgsqlPoint(x: 0.17111219598058391d, y: 0.0057968244217623255d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.060793666144941305d, y: 0.24799944541384566d), new NpgsqlTypes.NpgsqlPoint(x: 0.30760251614329504d, y: 0.529330552762606d), new NpgsqlTypes.NpgsqlPoint(x: 0.39456018783881697d, y: 0.3943196175882524d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.00994915543582664d, y: 0.0803884149155365d), new NpgsqlTypes.NpgsqlPoint(x: 0.799922288563451d, y: 0.5924616838153951d), new NpgsqlTypes.NpgsqlPoint(x: 0.18518358762403375d, y: 0.9791382635161352d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07042939991470831d, y: 0.023905700877194347d), new NpgsqlTypes.NpgsqlPoint(x: 0.028474933048859286d, y: 0.6421029579516168d), new NpgsqlTypes.NpgsqlPoint(x: 0.7475386100934914d, y: 0.7765055024668368d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9612814846428492d, y: 0.208812840517687d), new NpgsqlTypes.NpgsqlPoint(x: 0.9377361729611879d, y: 0.4223041863547231d), new NpgsqlTypes.NpgsqlPoint(x: 0.6165881252250337d, y: 0.31249158810750166d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3030659265875696d, y: 0.7810981304349726d), new NpgsqlTypes.NpgsqlPoint(x: 0.019861527910032706d, y: 0.3321518230992866d), new NpgsqlTypes.NpgsqlPoint(x: 0.6336346698843955d, y: 0.8948220407614857d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9985006588175067d, y: 0.4850878052194355d), new NpgsqlTypes.NpgsqlPoint(x: 0.6997854621211289d, y: 0.36040881158048643d), new NpgsqlTypes.NpgsqlPoint(x: 0.8253881082482185d, y: 0.9435292883947123d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4806426846304861d, y: 0.6841076112155148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800356493737941d, y: 0.8068727321334275d), new NpgsqlTypes.NpgsqlPoint(x: 0.9644774365144763d, y: 0.26330824837522904d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6779185650407163d, y: 0.09885875879294004d), new NpgsqlTypes.NpgsqlPoint(x: 0.08754449299032452d, y: 0.7207016847387848d), new NpgsqlTypes.NpgsqlPoint(x: 0.3512484863244618d, y: 0.5694795789302487d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38627860458331753d, y: 0.693599193548505d), new NpgsqlTypes.NpgsqlPoint(x: 0.9706381863672249d, y: 0.8062397430067068d), new NpgsqlTypes.NpgsqlPoint(x: 0.9949602671272988d, y: 0.1262378214797365d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04310182348679659d, y: 0.18493555930658934d), new NpgsqlTypes.NpgsqlPoint(x: 0.13699545570540006d, y: 0.361785702770559d), new NpgsqlTypes.NpgsqlPoint(x: 0.5809814402530162d, y: 0.7591042210099427d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5762508212389558d, y: 0.9219590995590421d), new NpgsqlTypes.NpgsqlPoint(x: 0.16152655503154711d, y: 0.8550008989828803d), new NpgsqlTypes.NpgsqlPoint(x: 0.693793790767539d, y: 0.27928732048464766d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9624197449560693d, y: 0.15576191738985212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6008912064751755d, y: 0.9438482217846498d), new NpgsqlTypes.NpgsqlPoint(x: 0.4900289519363614d, y: 0.48625492485844757d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4665507879271227d, y: 0.6714472147982044d), new NpgsqlTypes.NpgsqlPoint(x: 0.5270347061472556d, y: 0.2304609796521122d), new NpgsqlTypes.NpgsqlPoint(x: 0.6137147070755329d, y: 0.04279566149911962d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6789219756500378d, y: 0.12483232578360726d), new NpgsqlTypes.NpgsqlPoint(x: 0.04458544528269337d, y: 0.5047225570227286d), new NpgsqlTypes.NpgsqlPoint(x: 0.09363795564253818d, y: 0.6979731241148868d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.013092438060664624d, y: 0.5581375413363681d), new NpgsqlTypes.NpgsqlPoint(x: 0.5038920221859049d, y: 0.6476877078872277d), new NpgsqlTypes.NpgsqlPoint(x: 0.05467584580193774d, y: 0.8737208832671168d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2970667809253503d, y: 0.8963277742555161d), new NpgsqlTypes.NpgsqlPoint(x: 0.8712455901909151d, y: 0.13127749518385046d), new NpgsqlTypes.NpgsqlPoint(x: 0.14588825519529625d, y: 0.41093555109609026d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7109927899742926d, y: 0.9010779824313603d), new NpgsqlTypes.NpgsqlPoint(x: 0.8846415467019865d, y: 0.6337101963623375d), new NpgsqlTypes.NpgsqlPoint(x: 0.8134736166044975d, y: 0.839534380507574d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33490571927296353d, y: 0.16140605361949312d), new NpgsqlTypes.NpgsqlPoint(x: 0.8720180182389617d, y: 0.482269930732351d), new NpgsqlTypes.NpgsqlPoint(x: 0.545778968461968d, y: 0.21819409743029772d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6212669943663206d, y: 0.45151287128552986d), new NpgsqlTypes.NpgsqlPoint(x: 0.267413080891058d, y: 0.14061286982641508d), new NpgsqlTypes.NpgsqlPoint(x: 0.9556266909512336d, y: 0.48665554277428513d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8951840198039444d, y: 0.977617703110807d), new NpgsqlTypes.NpgsqlPoint(x: 0.6611150033903057d, y: 0.7619251988207378d), new NpgsqlTypes.NpgsqlPoint(x: 0.46524895421209933d, y: 0.17545643226652463d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5921968098874234d, y: 0.8072683083759808d), new NpgsqlTypes.NpgsqlPoint(x: 0.6599153190798129d, y: 0.2840057149437314d), new NpgsqlTypes.NpgsqlPoint(x: 0.5349109630191158d, y: 0.5123025645595188d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5615055496037314d, y: 0.2797463781458165d), new NpgsqlTypes.NpgsqlPoint(x: 0.19057435926903232d, y: 0.0868113979898828d), new NpgsqlTypes.NpgsqlPoint(x: 0.007571583024795547d, y: 0.9387407512693369d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13813453226163674d, y: 0.12146890436981717d), new NpgsqlTypes.NpgsqlPoint(x: 0.652308582332315d, y: 0.030863080082184857d), new NpgsqlTypes.NpgsqlPoint(x: 0.03645163881996971d, y: 0.3940882082644537d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22533721411083685d, y: 0.8268599968800406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5849617709238576d, y: 0.8634489517529483d), new NpgsqlTypes.NpgsqlPoint(x: 0.6667213328388747d, y: 0.986848813136825d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39940168333644954d, y: 0.49152582180557614d), new NpgsqlTypes.NpgsqlPoint(x: 0.09365016016923278d, y: 0.908960328972424d), new NpgsqlTypes.NpgsqlPoint(x: 0.27039414745297286d, y: 0.40996789443952397d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.013426949461256665d, y: 0.9715573165822312d), new NpgsqlTypes.NpgsqlPoint(x: 0.613201052754065d, y: 0.3269422739758937d), new NpgsqlTypes.NpgsqlPoint(x: 0.968133597998877d, y: 0.9481481039585425d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48462051866268674d, y: 0.349353626725848d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551333600488542d, y: 0.4417705129277598d), new NpgsqlTypes.NpgsqlPoint(x: 0.7721508745771734d, y: 0.7786071842855569d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4630905765310376d, y: 0.8413579730984941d), new NpgsqlTypes.NpgsqlPoint(x: 0.5758927324592797d, y: 0.6651518218981097d), new NpgsqlTypes.NpgsqlPoint(x: 0.43633546164518144d, y: 0.7285769915311223d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40991414868691045d, y: 0.24113463730579765d), new NpgsqlTypes.NpgsqlPoint(x: 0.1450126556074649d, y: 0.8945518942104033d), new NpgsqlTypes.NpgsqlPoint(x: 0.7757230942561844d, y: 0.003309169755726593d)),

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
INSERT INTO public.npgsqlpolygonpolygonarray2mi(
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
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

                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray2mi_id", 
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
                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray2mi_id", 
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
                List<NpgsqlPolygonpolygonArray2M> models = null;

                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray2M> models = null;

                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[24],_testData[29], false);
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
                parametr2.Value = 65;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[29], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 57, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 48, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[27],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 67, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 76, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 67, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 48, query1, 3, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 65, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 100, query1, 99, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelBatchAsync(connection, 3, 70))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[29], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelBatch(connection, 84, 20))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[29], false);
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
FROM public.binary_npgsqlpolygonpolygonarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonListpolygonArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonListpolygonArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonListpolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonListpolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray2m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray2M>(15);

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
                ((INpgsqlPolygonListpolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonListpolygonArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

