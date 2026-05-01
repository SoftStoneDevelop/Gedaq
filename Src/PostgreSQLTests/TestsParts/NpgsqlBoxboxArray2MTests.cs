

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
    internal partial interface INpgsqlBoxListboxArray
    {
    }
    
    internal partial class NpgsqlBoxListboxArray : INpgsqlBoxListboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray2M[] _testData = new NpgsqlBoxboxArray2M[]
        {
            new NpgsqlBoxboxArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8855310916950825d,right: 0.215641419371572d,bottom: 0.6913523639402844d,left: 0.0010736648400520021d),

new NpgsqlTypes.NpgsqlBox(top: 0.7108443812075663d,right: 0.6594794800132647d,bottom: 0.6492722650369063d,left: 0.18635609986305535d),

new NpgsqlTypes.NpgsqlBox(top: 0.7900970039093471d,right: 0.9661660069975754d,bottom: 0.1000376103908518d,left: 0.7324410177160677d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.34370641753182973d,right: 0.5607780047775909d,bottom: 0.15285701025977683d,left: 0.029250776040464443d),

new NpgsqlTypes.NpgsqlBox(top: 0.7911526331903305d,right: 0.33252972561356d,bottom: 0.11424181160197888d,left: 0.24164464437614508d),

new NpgsqlTypes.NpgsqlBox(top: 0.9515012538418458d,right: 0.7442159362361189d,bottom: 0.47382872737406523d,left: 0.502939412126871d),

new NpgsqlTypes.NpgsqlBox(top: 0.8732965662142234d,right: 0.889813893317793d,bottom: 0.4547407653332468d,left: 0.7099150532318996d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.579950921088431d,right: 0.7883310910467456d,bottom: 0.20057830753480566d,left: 0.7191024800840249d),

new NpgsqlTypes.NpgsqlBox(top: 0.7317808738884083d,right: 0.5900979722160212d,bottom: 0.5619469984148217d,left: 0.4881416800541102d),

new NpgsqlTypes.NpgsqlBox(top: 0.43789895373403387d,right: 0.9673505957211861d,bottom: 0.10605824232670114d,left: 0.1942684891662403d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7786249521011085d,right: 0.2615505320479087d,bottom: 0.6330831612677393d,left: 0.06483103874592744d),

new NpgsqlTypes.NpgsqlBox(top: 0.5706189641350937d,right: 0.5244070174980519d,bottom: 0.049801179643564675d,left: 0.23988676852796487d),

new NpgsqlTypes.NpgsqlBox(top: 0.9952178274028605d,right: 0.9996726129427719d,bottom: 0.6395804310400204d,left: 0.49577460345558255d),

new NpgsqlTypes.NpgsqlBox(top: 0.587257749624322d,right: 0.7869976107604828d,bottom: 0.46359901527447334d,left: 0.03526632039158961d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5148384434852252d,right: 0.5153506490879145d,bottom: 0.15817319880355063d,left: 0.496554091254202d),

new NpgsqlTypes.NpgsqlBox(top: 0.5091294278337575d,right: 0.6716657239225069d,bottom: 0.3261517679629863d,left: 0.19081424453527018d),

new NpgsqlTypes.NpgsqlBox(top: 0.6970961896290498d,right: 0.8943792271735282d,bottom: 0.06893520200924896d,left: 0.6816542255546403d),

new NpgsqlTypes.NpgsqlBox(top: 0.9833459061674786d,right: 0.6448629008457509d,bottom: 0.3109565499777658d,left: 0.09525701430377731d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7208089719944928d,right: 0.8973925708647962d,bottom: 0.2678645216185005d,left: 0.2526274757875766d),

new NpgsqlTypes.NpgsqlBox(top: 0.7118393929062361d,right: 0.6122651245117541d,bottom: 0.07642507125957165d,left: 0.576402527915675d),

new NpgsqlTypes.NpgsqlBox(top: 0.4386913933657457d,right: 0.5099548358201342d,bottom: 0.22698575091880624d,left: 0.4982592263536857d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3568568754922d,right: 0.9389528540454802d,bottom: 0.08276759804067357d,left: 0.14203973432838435d),

new NpgsqlTypes.NpgsqlBox(top: 0.8337667651967173d,right: 0.9431265601904414d,bottom: 0.1856648190296255d,left: 0.13379999491978223d),

new NpgsqlTypes.NpgsqlBox(top: 0.7495697381486959d,right: 0.458968166485791d,bottom: 0.26542996745173164d,left: 0.4272867554998159d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9784539092808596d,right: 0.9204522423874775d,bottom: 0.5554475974338002d,left: 0.1490703527338334d),

new NpgsqlTypes.NpgsqlBox(top: 0.9206468470651389d,right: 0.8470661465233486d,bottom: 0.3159542955755691d,left: 0.2046967782581317d),

new NpgsqlTypes.NpgsqlBox(top: 0.8009678039967297d,right: 0.7892612042657906d,bottom: 0.029458983137373274d,left: 0.3784758370017276d),

new NpgsqlTypes.NpgsqlBox(top: 0.5841639076621352d,right: 0.5295535060732273d,bottom: 0.024417285343623862d,left: 0.011400813183054304d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.38474810985636876d,right: 0.7907076719123295d,bottom: 0.31870268535548363d,left: 0.7017278787962257d),

new NpgsqlTypes.NpgsqlBox(top: 0.7956908864644956d,right: 0.9710360943035753d,bottom: 0.43816826161685196d,left: 0.4511090758346564d),

new NpgsqlTypes.NpgsqlBox(top: 0.1749293507776074d,right: 0.5216741602161565d,bottom: 0.15417179591357366d,left: 0.22470663750599718d),

new NpgsqlTypes.NpgsqlBox(top: 0.8389315765782288d,right: 0.76175507114912d,bottom: 0.8339843993940251d,left: 0.11860359369815399d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7128628445921108d,right: 0.973168214487888d,bottom: 0.6424753499924675d,left: 0.8640809736219037d),

new NpgsqlTypes.NpgsqlBox(top: 0.4087574289892588d,right: 0.9062849815412617d,bottom: 0.0762639943251815d,left: 0.38007844234715016d),

new NpgsqlTypes.NpgsqlBox(top: 0.9623695209504267d,right: 0.5785929687292128d,bottom: 0.5080889015608753d,left: 0.4075701613873707d),

new NpgsqlTypes.NpgsqlBox(top: 0.9251015128501021d,right: 0.7338532932335867d,bottom: 0.5272716538496749d,left: 0.12124592812477664d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9899267964883487d,right: 0.913327871475809d,bottom: 0.8601924691636994d,left: 0.7702235019253519d),

new NpgsqlTypes.NpgsqlBox(top: 0.5748615414817295d,right: 0.25960009724247324d,bottom: 0.1512233528856669d,left: 0.06833675883465196d),

new NpgsqlTypes.NpgsqlBox(top: 0.5220210648463262d,right: 0.9820690173842376d,bottom: 0.06968765066334004d,left: 0.4628763381135298d),

new NpgsqlTypes.NpgsqlBox(top: 0.39180374273016727d,right: 0.8781094228380701d,bottom: 0.3821901717417612d,left: 0.7615629759486294d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4794721188643798d,right: 0.892179463022718d,bottom: 0.34943071955457516d,left: 0.7673661021234273d),

new NpgsqlTypes.NpgsqlBox(top: 0.4150494329576544d,right: 0.7210420436757015d,bottom: 0.04523556154086972d,left: 0.4711689509027672d),

new NpgsqlTypes.NpgsqlBox(top: 0.6540515400441214d,right: 0.8107016004292323d,bottom: 0.34854824708552323d,left: 0.3784288130259541d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6674501279139278d,right: 0.5615432430213959d,bottom: 0.46526259683956683d,left: 0.03842646720288745d),

new NpgsqlTypes.NpgsqlBox(top: 0.9314682638065249d,right: 0.9039724331158676d,bottom: 0.6479068512989711d,left: 0.14310781283731988d),

new NpgsqlTypes.NpgsqlBox(top: 0.8818384036892246d,right: 0.8334684541841095d,bottom: 0.2163257627750752d,left: 0.8024225572871179d),

new NpgsqlTypes.NpgsqlBox(top: 0.764585586074385d,right: 0.21435871621300961d,bottom: 0.4371218754604055d,left: 0.16060841733823805d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9650953403568016d,right: 0.6219824077673122d,bottom: 0.9400927872642116d,left: 0.4788381948295609d),

new NpgsqlTypes.NpgsqlBox(top: 0.333420073639377d,right: 0.9099412513960062d,bottom: 0.15499261648148233d,left: 0.7500969907959363d),

new NpgsqlTypes.NpgsqlBox(top: 0.8765108894495627d,right: 0.38118494259505487d,bottom: 0.5000604562885167d,left: 0.2499970456445214d),

new NpgsqlTypes.NpgsqlBox(top: 0.6249909860459341d,right: 0.4433565847328508d,bottom: 0.10324047146181348d,left: 0.39546296315344087d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.24446188154881765d,right: 0.04523894682192997d,bottom: 0.011944839337105106d,left: 0.0014813055847058276d),

new NpgsqlTypes.NpgsqlBox(top: 0.30473974286961825d,right: 0.3396761045822623d,bottom: 0.03385223240687474d,left: 0.17011602152631877d),

new NpgsqlTypes.NpgsqlBox(top: 0.6219201921762569d,right: 0.6638082616935809d,bottom: 0.11317045148578675d,left: 0.17819655522276168d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7148101202496613d,right: 0.9533572123064503d,bottom: 0.4485221498614751d,left: 0.41324461162027404d),

new NpgsqlTypes.NpgsqlBox(top: 0.35455379704508405d,right: 0.7898765368166417d,bottom: 0.27386164813689917d,left: 0.256737037733756d),

new NpgsqlTypes.NpgsqlBox(top: 0.967660880787006d,right: 0.4640401005621041d,bottom: 0.19302563034870113d,left: 0.3478718863622321d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6826413160729325d,right: 0.4875795200202636d,bottom: 0.5614531599852339d,left: 0.3053317458161253d),

new NpgsqlTypes.NpgsqlBox(top: 0.7778958836059449d,right: 0.8776916992300008d,bottom: 0.3416256446720448d,left: 0.28854459726696013d),

new NpgsqlTypes.NpgsqlBox(top: 0.7512656107886342d,right: 0.49973166176723105d,bottom: 0.7504972456642901d,left: 0.2874924857603116d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9899294380914136d,right: 0.9559684728312358d,bottom: 0.7938668541814439d,left: 0.14033512516056235d),

new NpgsqlTypes.NpgsqlBox(top: 0.83129533652381d,right: 0.25771175443170513d,bottom: 0.3082588324304901d,left: 0.06745936984120382d),

new NpgsqlTypes.NpgsqlBox(top: 0.964965697976561d,right: 0.9671264767086674d,bottom: 0.5082974889558618d,left: 0.703006749918793d),

new NpgsqlTypes.NpgsqlBox(top: 0.32236709075380976d,right: 0.5206575845439404d,bottom: 0.09508482888282976d,left: 0.08123590964093741d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7089080198318192d,right: 0.7752310535437698d,bottom: 0.653400192126164d,left: 0.5195442911860176d),

new NpgsqlTypes.NpgsqlBox(top: 0.9280528054754811d,right: 0.8905766030931652d,bottom: 0.19494131823161498d,left: 0.6905651574604241d),

new NpgsqlTypes.NpgsqlBox(top: 0.792880463720606d,right: 0.7250096022746625d,bottom: 0.2299589442464648d,left: 0.12179960107204424d),

new NpgsqlTypes.NpgsqlBox(top: 0.9295316020488328d,right: 0.903798891008021d,bottom: 0.9037482605049849d,left: 0.19536780932919495d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3992847984018202d,right: 0.7251765457343445d,bottom: 0.09253513801318447d,left: 0.5685930382224834d),

new NpgsqlTypes.NpgsqlBox(top: 0.3613904968629127d,right: 0.07802280948821783d,bottom: 0.034666417373223846d,left: 0.02736436530508879d),

new NpgsqlTypes.NpgsqlBox(top: 0.8116407783946209d,right: 0.259845954732566d,bottom: 0.6131618646372913d,left: 0.110216224289722d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5701684518026131d,right: 0.8651958943482239d,bottom: 0.08277339750992996d,left: 0.5929723185197465d),

new NpgsqlTypes.NpgsqlBox(top: 0.8060120023353606d,right: 0.5559394533964069d,bottom: 0.3183348377978775d,left: 0.4264720970208773d),

new NpgsqlTypes.NpgsqlBox(top: 0.648951304822837d,right: 0.09853410885069791d,bottom: 0.04591672715519124d,left: 0.07956823302173655d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8172869593764199d,right: 0.8614556418881096d,bottom: 0.7201252629356908d,left: 0.7229977754387964d),

new NpgsqlTypes.NpgsqlBox(top: 0.6779504683999348d,right: 0.7997108575431728d,bottom: 0.2894274460325277d,left: 0.19956363684755518d),

new NpgsqlTypes.NpgsqlBox(top: 0.9125424554142263d,right: 0.20920213666132503d,bottom: 0.3808196522729098d,left: 0.19428563363204066d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8462090863935634d,right: 0.8047843439293882d,bottom: 0.7485741311912305d,left: 0.4385080786390877d),

new NpgsqlTypes.NpgsqlBox(top: 0.7872575860335569d,right: 0.6975694238587399d,bottom: 0.4626200140546771d,left: 0.05050561185752278d),

new NpgsqlTypes.NpgsqlBox(top: 0.3162658896087792d,right: 0.5482656324349272d,bottom: 0.10325580092227316d,left: 0.23328998288393998d),

new NpgsqlTypes.NpgsqlBox(top: 0.884629946608171d,right: 0.49667573084368943d,bottom: 0.5881253109728326d,left: 0.3149452386792321d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8449456764235701d,right: 0.8142178253760366d,bottom: 0.44697661053441984d,left: 0.1976203507673161d),

new NpgsqlTypes.NpgsqlBox(top: 0.954279147271978d,right: 0.3182050943136139d,bottom: 0.9534262839087846d,left: 0.1551979316247134d),

new NpgsqlTypes.NpgsqlBox(top: 0.97231319124844d,right: 0.5635342079642971d,bottom: 0.8072892597674932d,left: 0.5622569947691027d),

new NpgsqlTypes.NpgsqlBox(top: 0.9953565701846221d,right: 0.4816245050566157d,bottom: 0.5851296239527202d,left: 0.0942445566902036d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.38578822319761574d,right: 0.46233245514735866d,bottom: 0.19043484835928193d,left: 0.45520885756570006d),

new NpgsqlTypes.NpgsqlBox(top: 0.9372695391886873d,right: 0.5778490944139826d,bottom: 0.829867332765853d,left: 0.2548657161029547d),

new NpgsqlTypes.NpgsqlBox(top: 0.5065155445234831d,right: 0.8806403279564399d,bottom: 0.36253174085595685d,left: 0.36039509091895194d),

new NpgsqlTypes.NpgsqlBox(top: 0.7737845720024026d,right: 0.8156111315433833d,bottom: 0.4924017279694425d,left: 0.38467461517225554d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9467880826043303d,right: 0.9570936953965946d,bottom: 0.8638298165993239d,left: 0.05677600591580734d),

new NpgsqlTypes.NpgsqlBox(top: 0.3983528258595431d,right: 0.22623584689242782d,bottom: 0.25198827407668134d,left: 0.0808249630029656d),

new NpgsqlTypes.NpgsqlBox(top: 0.3704238713180229d,right: 0.5575281344251183d,bottom: 0.2264182398000617d,left: 0.29094533220979646d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6740558089160132d,right: 0.9955295239126101d,bottom: 0.23755622485328776d,left: 0.8757191007398784d),

new NpgsqlTypes.NpgsqlBox(top: 0.9105188802029824d,right: 0.8425752020545602d,bottom: 0.5486851631333222d,left: 0.6766159228166797d),

new NpgsqlTypes.NpgsqlBox(top: 0.29290294019126273d,right: 0.35718309781622304d,bottom: 0.2542006925268061d,left: 0.20622877744774715d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6679454358903117d,right: 0.07479059581837566d,bottom: 0.3578766781108935d,left: 0.05967581811227318d),

new NpgsqlTypes.NpgsqlBox(top: 0.9305471766290845d,right: 0.6590623485577342d,bottom: 0.6595217042710207d,left: 0.09034682606481459d),

new NpgsqlTypes.NpgsqlBox(top: 0.986652784020975d,right: 0.5502321122031723d,bottom: 0.8458516238171996d,left: 0.2211504414852793d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7445260787044701d,right: 0.5326263657196522d,bottom: 0.2269992993419745d,left: 0.49945286793169663d),

new NpgsqlTypes.NpgsqlBox(top: 0.14816804119676685d,right: 0.7627509295643338d,bottom: 0.07013181723180728d,left: 0.3885742390577399d),

new NpgsqlTypes.NpgsqlBox(top: 0.8935021003683703d,right: 0.3598284776156774d,bottom: 0.6656270281741365d,left: 0.30322501268493207d),

new NpgsqlTypes.NpgsqlBox(top: 0.6954919693571363d,right: 0.7850760685735347d,bottom: 0.3375040899363103d,left: 0.7701293451784649d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5372069703700608d,right: 0.5508328452657953d,bottom: 0.03639809626866641d,left: 0.17930435976026404d),

new NpgsqlTypes.NpgsqlBox(top: 0.8492843528600794d,right: 0.7105552245794472d,bottom: 0.7165907462263855d,left: 0.3495390115686715d),

new NpgsqlTypes.NpgsqlBox(top: 0.23627741589688056d,right: 0.6729344491851381d,bottom: 0.05015094993631419d,left: 0.17894527815842676d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.05863917911113581d,right: 0.9386210409638779d,bottom: 0.055587525414727224d,left: 0.11110056209873553d),

new NpgsqlTypes.NpgsqlBox(top: 0.42943259931665867d,right: 0.7176821214009615d,bottom: 0.29830523445770285d,left: 0.04728510068257408d),

new NpgsqlTypes.NpgsqlBox(top: 0.534660470670509d,right: 0.9570413771658842d,bottom: 0.4591690185645393d,left: 0.33553970562277236d),

new NpgsqlTypes.NpgsqlBox(top: 0.39784256878048885d,right: 0.22421437647397724d,bottom: 0.10230898171062053d,left: 0.05039567169689407d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6545154651574376d,right: 0.8585597473436654d,bottom: 0.1309211689951938d,left: 0.6718561104930886d),

new NpgsqlTypes.NpgsqlBox(top: 0.6959582596873921d,right: 0.7785498988163767d,bottom: 0.2787636597776375d,left: 0.06246447425449875d),

new NpgsqlTypes.NpgsqlBox(top: 0.6391544564762622d,right: 0.5683893136949054d,bottom: 0.550328892056371d,left: 0.29946530458750287d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8013879291819751d,right: 0.6829866717215055d,bottom: 0.7150703387465059d,left: 0.6564747803618853d),

new NpgsqlTypes.NpgsqlBox(top: 0.9206249765449164d,right: 0.37430817801303484d,bottom: 0.6693940635026208d,left: 0.2165732342614749d),

new NpgsqlTypes.NpgsqlBox(top: 0.6291571486930126d,right: 0.7690982600484868d,bottom: 0.15596125617760037d,left: 0.21075053411186384d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2850306258825872d,right: 0.7103826304520068d,bottom: 0.2065763852961655d,left: 0.31162133770598677d),

new NpgsqlTypes.NpgsqlBox(top: 0.43516799466498d,right: 0.6127201508082697d,bottom: 0.3698172535489951d,left: 0.4253018267251638d),

new NpgsqlTypes.NpgsqlBox(top: 0.45638081936221686d,right: 0.9904114122131138d,bottom: 0.04118509611155241d,left: 0.5454101691083449d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6781739810340727d,right: 0.8612516284354274d,bottom: 0.2764293885218502d,left: 0.024374253714864236d),

new NpgsqlTypes.NpgsqlBox(top: 0.9938379701465593d,right: 0.5413250758415162d,bottom: 0.07342631242337183d,left: 0.36718239495968497d),

new NpgsqlTypes.NpgsqlBox(top: 0.8638408360529678d,right: 0.5821588478832772d,bottom: 0.8486384525044213d,left: 0.4181007426950055d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9477857615210171d,right: 0.8645665042181574d,bottom: 0.021081514754651143d,left: 0.32552288284184805d),

new NpgsqlTypes.NpgsqlBox(top: 0.6313457407607952d,right: 0.7220702787916119d,bottom: 0.12581443683805082d,left: 0.5280258864453842d),

new NpgsqlTypes.NpgsqlBox(top: 0.5269705480211799d,right: 0.38114152559485937d,bottom: 0.21320590889194402d,left: 0.2796639540895308d),

new NpgsqlTypes.NpgsqlBox(top: 0.8244985341480948d,right: 0.5355501022803923d,bottom: 0.05010578847456881d,left: 0.05162483734418921d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.31548378949244205d,right: 0.5749073763386497d,bottom: 0.183378797821785d,left: 0.5084781969717057d),

new NpgsqlTypes.NpgsqlBox(top: 0.6031305515342489d,right: 0.3967060295821163d,bottom: 0.38164784571489985d,left: 0.2100767361906306d),

new NpgsqlTypes.NpgsqlBox(top: 0.9528526281881375d,right: 0.8052373390540181d,bottom: 0.7976228227378339d,left: 0.10738216818171298d),

new NpgsqlTypes.NpgsqlBox(top: 0.6211587553048077d,right: 0.8875890322992082d,bottom: 0.5836932818418927d,left: 0.7094148225010034d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9560676289112865d,right: 0.3102089008990597d,bottom: 0.9442514197614635d,left: 0.1239035111284359d),

new NpgsqlTypes.NpgsqlBox(top: 0.6217723222940963d,right: 0.029344298340298614d,bottom: 0.5963166585530167d,left: 0.00950828364393741d),

new NpgsqlTypes.NpgsqlBox(top: 0.9671304201772879d,right: 0.9852180953499351d,bottom: 0.45823812523917684d,left: 0.12143623127124237d),

new NpgsqlTypes.NpgsqlBox(top: 0.7064171569674075d,right: 0.4647071323698998d,bottom: 0.04390696653458226d,left: 0.13803491518259559d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2135183966872567d,right: 0.5532198702239995d,bottom: 0.18632525998748461d,left: 0.38784943912405356d),

new NpgsqlTypes.NpgsqlBox(top: 0.28094462038373413d,right: 0.8498550891345192d,bottom: 0.20672071191785724d,left: 0.843747860510594d),

new NpgsqlTypes.NpgsqlBox(top: 0.5087281234804919d,right: 0.35969544161819544d,bottom: 0.2988414144239324d,left: 0.2567382635528742d),

new NpgsqlTypes.NpgsqlBox(top: 0.5817028563767477d,right: 0.4777522836927409d,bottom: 0.12548534259388466d,left: 0.17224905085662678d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5686652692574227d,right: 0.44675819579883436d,bottom: 0.5126387944641446d,left: 0.27242456999459974d),

new NpgsqlTypes.NpgsqlBox(top: 0.5929622484703965d,right: 0.8457715805882895d,bottom: 0.2679156436993285d,left: 0.15249344056409508d),

new NpgsqlTypes.NpgsqlBox(top: 0.15369812390426518d,right: 0.9980578132750659d,bottom: 0.0786766165708166d,left: 0.029923682638816285d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8516180106629528d,right: 0.0977368828691706d,bottom: 0.21733801390259988d,left: 0.05192010748733067d),

new NpgsqlTypes.NpgsqlBox(top: 0.455620264798695d,right: 0.5719018751098516d,bottom: 0.42600579234785096d,left: 0.5675610649973389d),

new NpgsqlTypes.NpgsqlBox(top: 0.4048792355077827d,right: 0.6006067959761102d,bottom: 0.14834238608262895d,left: 0.47102183735194036d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3235061509088797d,right: 0.797834668853758d,bottom: 0.20094452842046617d,left: 0.12088719807198633d),

new NpgsqlTypes.NpgsqlBox(top: 0.9073357448752617d,right: 0.7831244985553295d,bottom: 0.6872481003160196d,left: 0.6616973156523966d),

new NpgsqlTypes.NpgsqlBox(top: 0.8249739617497921d,right: 0.6556868125798563d,bottom: 0.46043980159710685d,left: 0.2005189698582981d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9532104070976664d,right: 0.9506706235604876d,bottom: 0.14210596587717828d,left: 0.803008334003015d),

new NpgsqlTypes.NpgsqlBox(top: 0.688147366850654d,right: 0.377504947128228d,bottom: 0.4368255756714109d,left: 0.15295689762779818d),

new NpgsqlTypes.NpgsqlBox(top: 0.9435040967223742d,right: 0.45822368288281945d,bottom: 0.1664486588792783d,left: 0.22131391827188285d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.47407356216431984d,right: 0.6563993878131842d,bottom: 0.1840035921850316d,left: 0.18004904697638224d),

new NpgsqlTypes.NpgsqlBox(top: 0.560205907563275d,right: 0.9141157826270737d,bottom: 0.12227553553671944d,left: 0.2976122806235958d),

new NpgsqlTypes.NpgsqlBox(top: 0.5839587919290645d,right: 0.3783551814181352d,bottom: 0.23315938678965453d,left: 0.21996174102287613d),

new NpgsqlTypes.NpgsqlBox(top: 0.8901247012718936d,right: 0.8335379094869945d,bottom: 0.27926014109872865d,left: 0.10572880748010982d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8110123289494948d,right: 0.38709447816930376d,bottom: 0.06429939154813968d,left: 0.28598055939056366d),

new NpgsqlTypes.NpgsqlBox(top: 0.9468223274550938d,right: 0.9884579153408808d,bottom: 0.3703035113147799d,left: 0.17566179047208474d),

new NpgsqlTypes.NpgsqlBox(top: 0.6152064296344321d,right: 0.8139207926620086d,bottom: 0.28394390853172724d,left: 0.5010597268738369d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.755279358272981d,right: 0.49066714790134414d,bottom: 0.4801552361971563d,left: 0.09209382217016204d),

new NpgsqlTypes.NpgsqlBox(top: 0.3312739548865503d,right: 0.4697210102388113d,bottom: 0.02190756156564877d,left: 0.2987082458873136d),

new NpgsqlTypes.NpgsqlBox(top: 0.6527461913615114d,right: 0.09463464861752291d,bottom: 0.34961521225633796d,left: 0.008679175799769845d),

new NpgsqlTypes.NpgsqlBox(top: 0.8736289505875809d,right: 0.9149121798576757d,bottom: 0.33697560668345483d,left: 0.5178992389572595d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3034632795696929d,right: 0.4086907775056804d,bottom: 0.2516010515293533d,left: 0.2411865361444563d),

new NpgsqlTypes.NpgsqlBox(top: 0.7806460529204998d,right: 0.7833187326010361d,bottom: 0.3457275256682325d,left: 0.1460598302585291d),

new NpgsqlTypes.NpgsqlBox(top: 0.49060540399742103d,right: 0.5029427107345243d,bottom: 0.436452937072489d,left: 0.04475415511212022d),

new NpgsqlTypes.NpgsqlBox(top: 0.6062654597404953d,right: 0.9473593129595522d,bottom: 0.5336962359228924d,left: 0.281596022553979d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7492113300142126d,right: 0.9072163979183324d,bottom: 0.12101645716540321d,left: 0.20039557968114863d),

new NpgsqlTypes.NpgsqlBox(top: 0.692401591031485d,right: 0.9040362753522823d,bottom: 0.6206131312893499d,left: 0.5552146961845289d),

new NpgsqlTypes.NpgsqlBox(top: 0.7441406931464751d,right: 0.6248373710389494d,bottom: 0.17202871166335254d,left: 0.21723214210592723d),

new NpgsqlTypes.NpgsqlBox(top: 0.9974580981125568d,right: 0.685927137665301d,bottom: 0.20056570023062803d,left: 0.11734735431553212d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7812158831427429d,right: 0.633598468290854d,bottom: 0.223125029421804d,left: 0.32639892415104854d),

new NpgsqlTypes.NpgsqlBox(top: 0.7984351928549438d,right: 0.8720869231350216d,bottom: 0.6212626649132297d,left: 0.5967444025514025d),

new NpgsqlTypes.NpgsqlBox(top: 0.6429552546671343d,right: 0.8657603887572477d,bottom: 0.5790893641910795d,left: 0.1087623678952283d),

new NpgsqlTypes.NpgsqlBox(top: 0.9932976530994524d,right: 0.9648132402935479d,bottom: 0.1533276181945198d,left: 0.767274457567625d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4376587617841665d,right: 0.7314761152409098d,bottom: 0.3132356242852713d,left: 0.4375041367032353d),

new NpgsqlTypes.NpgsqlBox(top: 0.5125373924666747d,right: 0.3332665684070162d,bottom: 0.35323919621763433d,left: 0.17040525727001632d),

new NpgsqlTypes.NpgsqlBox(top: 0.9699894400026299d,right: 0.8266027725997844d,bottom: 0.08039491891336614d,left: 0.263833778633764d),

new NpgsqlTypes.NpgsqlBox(top: 0.9532613653962012d,right: 0.3289449275926498d,bottom: 0.6498590116311902d,left: 0.19784912843752334d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.37381865436029493d,right: 0.7177446688011718d,bottom: 0.2202680410129607d,left: 0.463545372407148d),

new NpgsqlTypes.NpgsqlBox(top: 0.8199635461956981d,right: 0.49522033616532923d,bottom: 0.26766386357766936d,left: 0.3361791769416326d),

new NpgsqlTypes.NpgsqlBox(top: 0.414706793189611d,right: 0.7199579232316848d,bottom: 0.0229340566271804d,left: 0.28968383383044993d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6002132940544415d,right: 0.9527310842426118d,bottom: 0.39966478423401597d,left: 0.04963605364033308d),

new NpgsqlTypes.NpgsqlBox(top: 0.38318697916127953d,right: 0.6446268481324936d,bottom: 0.0046786489869218295d,left: 0.45325032391906594d),

new NpgsqlTypes.NpgsqlBox(top: 0.9374569507645146d,right: 0.9397361971858543d,bottom: 0.058147544786836924d,left: 0.9119025712675604d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8566089437047625d,right: 0.44675154267998696d,bottom: 0.6841286939729444d,left: 0.04671655162714661d),

new NpgsqlTypes.NpgsqlBox(top: 0.6625343171322312d,right: 0.5895225003626984d,bottom: 0.32726660684319864d,left: 0.5547579631499431d),

new NpgsqlTypes.NpgsqlBox(top: 0.7880595764698116d,right: 0.9835089203516316d,bottom: 0.1401944752619021d,left: 0.9507616520669561d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.25703530230488614d,right: 0.9069974259827309d,bottom: 0.1637734618960731d,left: 0.1459977095198689d),

new NpgsqlTypes.NpgsqlBox(top: 0.9380335712422921d,right: 0.31782861860810463d,bottom: 0.6311204654727778d,left: 0.20996597186057075d),

new NpgsqlTypes.NpgsqlBox(top: 0.9500335462406094d,right: 0.4854930882349424d,bottom: 0.3670669395922983d,left: 0.4128104227200833d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9673334902936217d,right: 0.8440244914846039d,bottom: 0.07153711935662366d,left: 0.14004453031203246d),

new NpgsqlTypes.NpgsqlBox(top: 0.7765572527459229d,right: 0.9970894748310488d,bottom: 0.40997792983194603d,left: 0.918263473214568d),

new NpgsqlTypes.NpgsqlBox(top: 0.592139558621732d,right: 0.34003971997141d,bottom: 0.36212895572639525d,left: 0.019337600298275026d),

new NpgsqlTypes.NpgsqlBox(top: 0.9524524956281949d,right: 0.6767435335818653d,bottom: 0.657625378892533d,left: 0.3925507352698716d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5881335072560937d,right: 0.9598733165933367d,bottom: 0.17063351568087193d,left: 0.05464114504388151d),

new NpgsqlTypes.NpgsqlBox(top: 0.5530041050961193d,right: 0.32829108104979676d,bottom: 0.04392413869013434d,left: 0.2218682943043946d),

new NpgsqlTypes.NpgsqlBox(top: 0.9330506253318973d,right: 0.5209629870411479d,bottom: 0.31422677061088644d,left: 0.466716819746425d),

new NpgsqlTypes.NpgsqlBox(top: 0.6293529402769196d,right: 0.8984832490712087d,bottom: 0.3763490730725265d,left: 0.7231365161610006d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5099781709794186d,right: 0.979002805974965d,bottom: 0.39052278652573524d,left: 0.9133507128361664d),

new NpgsqlTypes.NpgsqlBox(top: 0.9553133683175848d,right: 0.7949826799914801d,bottom: 0.9013798506333485d,left: 0.6127782494702055d),

new NpgsqlTypes.NpgsqlBox(top: 0.6265132676058717d,right: 0.40782668068600636d,bottom: 0.45247663124318305d,left: 0.2526174566673033d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7195419094306873d,right: 0.9553458042846678d,bottom: 0.22517281596824312d,left: 0.29397156201057795d),

new NpgsqlTypes.NpgsqlBox(top: 0.35235610697471265d,right: 0.9701499372218964d,bottom: 0.25312791140375934d,left: 0.13819301335727108d),

new NpgsqlTypes.NpgsqlBox(top: 0.8296757187576239d,right: 0.5998597349824631d,bottom: 0.5929620056892759d,left: 0.24193943135694984d),

new NpgsqlTypes.NpgsqlBox(top: 0.7265254842499177d,right: 0.7975602467345244d,bottom: 0.16500121375463406d,left: 0.7370840214294501d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9763215978811194d,right: 0.8371117074609026d,bottom: 0.18496977160532235d,left: 0.6421668818297128d),

new NpgsqlTypes.NpgsqlBox(top: 0.9730442091178358d,right: 0.9515722197371322d,bottom: 0.8109361202953739d,left: 0.2537750157663883d),

new NpgsqlTypes.NpgsqlBox(top: 0.7389778686875099d,right: 0.8744161432127695d,bottom: 0.30432203098696176d,left: 0.4085932562500926d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.730238685804406d,right: 0.21571088206433542d,bottom: 0.15421995959738488d,left: 0.20844014824551094d),

new NpgsqlTypes.NpgsqlBox(top: 0.5674477367576859d,right: 0.49509741004047125d,bottom: 0.19409203173941125d,left: 0.023678804316420887d),

new NpgsqlTypes.NpgsqlBox(top: 0.93075001330608d,right: 0.28498443769988646d,bottom: 0.7553162418068194d,left: 0.25989705988036116d),

new NpgsqlTypes.NpgsqlBox(top: 0.4085607372791873d,right: 0.9588042864208614d,bottom: 0.37793521068964364d,left: 0.34874708077468664d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4276798936263594d,right: 0.7046236633758614d,bottom: 0.3757183935500211d,left: 0.07730484551423322d),

new NpgsqlTypes.NpgsqlBox(top: 0.8846036488276504d,right: 0.41308717018225993d,bottom: 0.7270220795226471d,left: 0.37088613833766004d),

new NpgsqlTypes.NpgsqlBox(top: 0.24875895799392078d,right: 0.5494767672134627d,bottom: 0.23894411074194533d,left: 0.42565200476203546d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8302880904259503d,right: 0.3693129858677011d,bottom: 0.623242723634887d,left: 0.19798071827920738d),

new NpgsqlTypes.NpgsqlBox(top: 0.38529664727434587d,right: 0.6106391311572793d,bottom: 0.05000142492755111d,left: 0.022179624187519953d),

new NpgsqlTypes.NpgsqlBox(top: 0.9957902954466639d,right: 0.7549700461321895d,bottom: 0.1833806128196459d,left: 0.7152966228150944d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.375258370934648d,right: 0.8573446455642709d,bottom: 0.3316650511678725d,left: 0.793976374401216d),

new NpgsqlTypes.NpgsqlBox(top: 0.9963981138907922d,right: 0.737125483421243d,bottom: 0.5258701960019234d,left: 0.0833533597733368d),

new NpgsqlTypes.NpgsqlBox(top: 0.607164351869817d,right: 0.8826591203088642d,bottom: 0.023402393870396443d,left: 0.8236283217091078d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.08924135385226661d,right: 0.4998499969134963d,bottom: 0.05382361784003098d,left: 0.07658241032458246d),

new NpgsqlTypes.NpgsqlBox(top: 0.6239516800034643d,right: 0.7988278666006546d,bottom: 0.16288461587868353d,left: 0.263151893705843d),

new NpgsqlTypes.NpgsqlBox(top: 0.24569603705493914d,right: 0.9541342755516604d,bottom: 0.11578397347973157d,left: 0.2874203727959941d),

new NpgsqlTypes.NpgsqlBox(top: 0.8901181100485002d,right: 0.6279559683112691d,bottom: 0.12156734017020732d,left: 0.05124241463709278d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7137486942673348d,right: 0.46086998112155364d,bottom: 0.41009379669872736d,left: 0.09639711309571264d),

new NpgsqlTypes.NpgsqlBox(top: 0.9302551042112752d,right: 0.7691185525932667d,bottom: 0.6621901844869125d,left: 0.359208864025477d),

new NpgsqlTypes.NpgsqlBox(top: 0.8845215275857856d,right: 0.9237047343412844d,bottom: 0.6699757725708346d,left: 0.38544651162597177d),

new NpgsqlTypes.NpgsqlBox(top: 0.18695438979398948d,right: 0.8727846563273938d,bottom: 0.17254993001420815d,left: 0.6484351202379529d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.25534374035025087d,right: 0.7865235810863171d,bottom: 0.017571391144063697d,left: 0.6362324949189684d),

new NpgsqlTypes.NpgsqlBox(top: 0.5991877895007038d,right: 0.9066123592444786d,bottom: 0.3818373184219789d,left: 0.6194834977247874d),

new NpgsqlTypes.NpgsqlBox(top: 0.8440116168001159d,right: 0.6362286936076613d,bottom: 0.7557899367358195d,left: 0.17962019990481493d),

new NpgsqlTypes.NpgsqlBox(top: 0.7450471641617106d,right: 0.11530311351846745d,bottom: 0.02930572977968715d,left: 0.0651975312182671d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.44553210420952405d,right: 0.950927611893061d,bottom: 0.4351361096682944d,left: 0.10176553562455615d),

new NpgsqlTypes.NpgsqlBox(top: 0.4105188235449042d,right: 0.4709746442039783d,bottom: 0.38139301652111457d,left: 0.02277154486321553d),

new NpgsqlTypes.NpgsqlBox(top: 0.8429335690154812d,right: 0.96886917472273d,bottom: 0.0685325293334762d,left: 0.11892520866712919d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7552880482576191d,right: 0.09506526098925439d,bottom: 0.7029610016661086d,left: 0.06931179667704257d),

new NpgsqlTypes.NpgsqlBox(top: 0.9957795492927176d,right: 0.9627867590216626d,bottom: 0.9871820096273806d,left: 0.4365371803370651d),

new NpgsqlTypes.NpgsqlBox(top: 0.8529985348280007d,right: 0.9632608173238898d,bottom: 0.3036624023196959d,left: 0.562313177521448d),

new NpgsqlTypes.NpgsqlBox(top: 0.7838656839961107d,right: 0.9976009006631046d,bottom: 0.16991600384331595d,left: 0.41858200552036773d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5180554338073701d,right: 0.06277205933015029d,bottom: 0.5106818602742241d,left: 0.05091974266298682d),

new NpgsqlTypes.NpgsqlBox(top: 0.5069165401883036d,right: 0.77080659677245d,bottom: 0.024274330009092293d,left: 0.4183278755563242d),

new NpgsqlTypes.NpgsqlBox(top: 0.20085212621139414d,right: 0.5955246297870228d,bottom: 0.04317479023494908d,left: 0.48956482454839345d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.36410579330816784d,right: 0.5189468122861856d,bottom: 0.11836994550295654d,left: 0.35113037586835316d),

new NpgsqlTypes.NpgsqlBox(top: 0.9220653109543145d,right: 0.9143833332592305d,bottom: 0.74483923261606d,left: 0.5526522222170208d),

new NpgsqlTypes.NpgsqlBox(top: 0.9045334147203193d,right: 0.9938902518499256d,bottom: 0.3416766011269359d,left: 0.6999591214002688d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5998869950409467d,right: 0.7968882983162866d,bottom: 0.017260541556758047d,left: 0.3807999720432851d),

new NpgsqlTypes.NpgsqlBox(top: 0.7551149776197472d,right: 0.6700658060495767d,bottom: 0.40332412366762127d,left: 0.3363479103394521d),

new NpgsqlTypes.NpgsqlBox(top: 0.7502152572934441d,right: 0.5676303246624006d,bottom: 0.4635978608412872d,left: 0.36525536215362087d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5084996539733341d,right: 0.703089339428175d,bottom: 0.4044119105683649d,left: 0.6814708719645701d),

new NpgsqlTypes.NpgsqlBox(top: 0.440773088850579d,right: 0.8238106486545639d,bottom: 0.029236778168222455d,left: 0.3559700650444171d),

new NpgsqlTypes.NpgsqlBox(top: 0.4364209043105285d,right: 0.5760820997207278d,bottom: 0.014204340725904374d,left: 0.08600185286889972d),

new NpgsqlTypes.NpgsqlBox(top: 0.8319347109037849d,right: 0.2737143617503667d,bottom: 0.21492222122536708d,left: 0.061217927914265835d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8885065497447013d,right: 0.8020882115691544d,bottom: 0.6571564792238958d,left: 0.07745136892526494d),

new NpgsqlTypes.NpgsqlBox(top: 0.8379084776214379d,right: 0.3021112035345016d,bottom: 0.16062563055425938d,left: 0.07118203867285333d),

new NpgsqlTypes.NpgsqlBox(top: 0.6512304612241708d,right: 0.7659959198394062d,bottom: 0.31625583057543305d,left: 0.25787910119772595d),

new NpgsqlTypes.NpgsqlBox(top: 0.7671341968203255d,right: 0.8900452238590814d,bottom: 0.11338778131075311d,left: 0.022695428686178354d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.18314798904102447d,right: 0.14633755967777884d,bottom: 0.14714651922978195d,left: 0.01519741424503207d),

new NpgsqlTypes.NpgsqlBox(top: 0.7613252361317511d,right: 0.8303026023574114d,bottom: 0.5083361914333945d,left: 0.18203221849543516d),

new NpgsqlTypes.NpgsqlBox(top: 0.9873618398788986d,right: 0.40645809122509535d,bottom: 0.13779609086911548d,left: 0.3321633451423974d),

new NpgsqlTypes.NpgsqlBox(top: 0.859311823135685d,right: 0.6351004474699397d,bottom: 0.16148964146831313d,left: 0.5239504930648583d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8444570735323187d,right: 0.7295305362975621d,bottom: 0.13391326138254578d,left: 0.4726269678142301d),

new NpgsqlTypes.NpgsqlBox(top: 0.4437767574617444d,right: 0.9937816411064588d,bottom: 0.40521562159749713d,left: 0.8020346680696838d),

new NpgsqlTypes.NpgsqlBox(top: 0.6268951594718262d,right: 0.6498979178330471d,bottom: 0.05948775942599194d,left: 0.3919466950394279d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8044607512066071d,right: 0.722260705671868d,bottom: 0.3731626833791297d,left: 0.484693612020229d),

new NpgsqlTypes.NpgsqlBox(top: 0.3382569334554294d,right: 0.34001621890299316d,bottom: 0.319104772345589d,left: 0.15764745193292973d),

new NpgsqlTypes.NpgsqlBox(top: 0.7089990156257212d,right: 0.9256950849492281d,bottom: 0.2771293140120561d,left: 0.3116125998430217d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9539504604052881d,right: 0.8773529720642987d,bottom: 0.17369063255747652d,left: 0.3170584363921354d),

new NpgsqlTypes.NpgsqlBox(top: 0.8868030948947891d,right: 0.643354933136483d,bottom: 0.3760464411099318d,left: 0.6365466684866974d),

new NpgsqlTypes.NpgsqlBox(top: 0.8069031952769756d,right: 0.8781062840683234d,bottom: 0.4069941374666074d,left: 0.7008034243801562d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.594117103573069d,right: 0.9775143448119696d,bottom: 0.5320256965106583d,left: 0.800206468355675d),

new NpgsqlTypes.NpgsqlBox(top: 0.7136724109503103d,right: 0.4532192403369888d,bottom: 0.1461369362303424d,left: 0.41879089934869185d),

new NpgsqlTypes.NpgsqlBox(top: 0.5456314102518879d,right: 0.9593110221125348d,bottom: 0.21642155851370026d,left: 0.9288411083173348d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.168331609101671d,right: 0.39102276539226755d,bottom: 0.11715357911805424d,left: 0.21781066343509348d),

new NpgsqlTypes.NpgsqlBox(top: 0.9236709566068961d,right: 0.5300961432110387d,bottom: 0.019200091505109262d,left: 0.47183905256834613d),

new NpgsqlTypes.NpgsqlBox(top: 0.8017638331370615d,right: 0.48147794840155167d,bottom: 0.17501717674449424d,left: 0.1992182870229695d),

new NpgsqlTypes.NpgsqlBox(top: 0.6620493872001514d,right: 0.6255659562908755d,bottom: 0.1836767027337085d,left: 0.13940401453447449d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                List<NpgsqlBoxboxArray2M> models = null;

                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray2M> models = null;

                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 26;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 72;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 16, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 114, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 16, query1, 149, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 53, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 129, query1, 72, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 83, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 86, query1, 90, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 61, query1, 83, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 75, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 24, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[5], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[29], false);NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[30], false);NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[31], false);NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[32], false);NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[33], false);NpgsqlBoxboxArray2M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 90);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[30], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[31], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[32], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[33], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[34], false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2m m
LEFT JOIN public.binary_npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models =  ((INpgsqlBoxListboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI), typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxArray2MI>();
                var models2 = new List<NpgsqlBoxboxArray2MI>();
                await ((INpgsqlBoxListboxArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MI>();
                var models2 = new List<NpgsqlBoxboxArray2MI>();
                ((INpgsqlBoxListboxArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxListboxArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

