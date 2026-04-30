

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
    internal partial interface INpgsqlBoxArrayboxArray
    {
    }
    
    internal partial class NpgsqlBoxArrayboxArray : INpgsqlBoxArrayboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray1M[] _testData = new NpgsqlBoxboxArray1M[]
        {
            new NpgsqlBoxboxArray1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9238276153031822d,right: 0.6034054861583292d,bottom: 0.3936106454238515d,left: 0.28570206967087175d),
new NpgsqlTypes.NpgsqlBox(top: 0.9617746786542872d,right: 0.723692977486184d,bottom: 0.7290310354712218d,left: 0.19979194669779354d),
new NpgsqlTypes.NpgsqlBox(top: 0.6796940128847784d,right: 0.6601970226657009d,bottom: 0.1857422540908924d,left: 0.39486122443774696d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3296641960712894d,right: 0.7352873582580584d,bottom: 0.1815607277450716d,left: 0.5336189299249589d),
new NpgsqlTypes.NpgsqlBox(top: 0.8986860284869184d,right: 0.4316046457607108d,bottom: 0.26147314398116395d,left: 0.12074226934815224d),
new NpgsqlTypes.NpgsqlBox(top: 0.6173927452156468d,right: 0.15369701404339364d,bottom: 0.29504080917702336d,left: 0.12444419462968404d),
new NpgsqlTypes.NpgsqlBox(top: 0.4867251664091069d,right: 0.8022188898171869d,bottom: 0.40067534156550644d,left: 0.0069160507433746465d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4554793606945434d,right: 0.09735247627472499d,bottom: 0.4050451878742245d,left: 0.052211014679594436d),
new NpgsqlTypes.NpgsqlBox(top: 0.4186633416889539d,right: 0.7883513089869656d,bottom: 0.007746164617333684d,left: 0.1565681569193853d),
new NpgsqlTypes.NpgsqlBox(top: 0.7912745314901775d,right: 0.7382608014084738d,bottom: 0.6497742502514767d,left: 0.6831429095300015d),
new NpgsqlTypes.NpgsqlBox(top: 0.414676230171089d,right: 0.8861539345985819d,bottom: 0.0659000032742898d,left: 0.2087106983574546d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9613389354481756d,right: 0.9429325351405521d,bottom: 0.9231604800050152d,left: 0.2009088025406327d),
new NpgsqlTypes.NpgsqlBox(top: 0.10913220890054631d,right: 0.4699845451887853d,bottom: 0.052049186137003156d,left: 0.32894374213028477d),
new NpgsqlTypes.NpgsqlBox(top: 0.7805913253021913d,right: 0.4488781993417015d,bottom: 0.5498759182952321d,left: 0.27649751149133905d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.688499788578779d,right: 0.7073510261667305d,bottom: 0.14145435460516764d,left: 0.36517539040828506d),
new NpgsqlTypes.NpgsqlBox(top: 0.8636542485065665d,right: 0.6143021706794328d,bottom: 0.1947869609507522d,left: 0.2698286428662354d),
new NpgsqlTypes.NpgsqlBox(top: 0.4816513194648162d,right: 0.7901513943646726d,bottom: 0.003548266472325312d,left: 0.52971631095838d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9886665541565334d,right: 0.3871687893009932d,bottom: 0.26787612737088284d,left: 0.20670221138160083d),
new NpgsqlTypes.NpgsqlBox(top: 0.5609117166354773d,right: 0.44878164335504633d,bottom: 0.030991622150440712d,left: 0.2476076912047671d),
new NpgsqlTypes.NpgsqlBox(top: 0.5622757823205327d,right: 0.742217346542396d,bottom: 0.40666646822594965d,left: 0.012731085879491233d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8676165001238916d,right: 0.6945759585258081d,bottom: 0.5267406395492578d,left: 0.6586049705499802d),
new NpgsqlTypes.NpgsqlBox(top: 0.7449283908324221d,right: 0.8872930776819424d,bottom: 0.21453278326946845d,left: 0.7252299210205352d),
new NpgsqlTypes.NpgsqlBox(top: 0.49890036424926587d,right: 0.6260575862345384d,bottom: 0.42550417635379223d,left: 0.1814948266224503d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7419298890033038d,right: 0.9109287503987312d,bottom: 0.42527976143324075d,left: 0.8208671152602843d),
new NpgsqlTypes.NpgsqlBox(top: 0.6511545312197548d,right: 0.6686679040781598d,bottom: 0.10138891926532301d,left: 0.5678440941629255d),
new NpgsqlTypes.NpgsqlBox(top: 0.8148142817618006d,right: 0.47146484653941567d,bottom: 0.5243013067293564d,left: 0.2301846941645943d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9389048233727053d,right: 0.735336551096701d,bottom: 0.5351582624373836d,left: 0.7300266801959565d),
new NpgsqlTypes.NpgsqlBox(top: 0.5589855841547209d,right: 0.2715782183646741d,bottom: 0.4802274592092517d,left: 0.1608526083004489d),
new NpgsqlTypes.NpgsqlBox(top: 0.7991314789568283d,right: 0.7714969104983465d,bottom: 0.31538508698673606d,left: 0.19431804165244537d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7829141535667127d,right: 0.934916383911196d,bottom: 0.4534002787082614d,left: 0.10505767150882739d),
new NpgsqlTypes.NpgsqlBox(top: 0.5687636892643503d,right: 0.6888418480779912d,bottom: 0.23008579302090115d,left: 0.48696718017389573d),
new NpgsqlTypes.NpgsqlBox(top: 0.5323597113961986d,right: 0.8075643145624044d,bottom: 0.018511137140289402d,left: 0.7027924888426481d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8018751473241713d,right: 0.41474095723444926d,bottom: 0.5364990083579858d,left: 0.09448136427949028d),
new NpgsqlTypes.NpgsqlBox(top: 0.7102990958187062d,right: 0.996696694169752d,bottom: 0.35560629404736277d,left: 0.8413857714940544d),
new NpgsqlTypes.NpgsqlBox(top: 0.5321481924562054d,right: 0.7885683945688414d,bottom: 0.025556578800272844d,left: 0.24237183536509388d),
new NpgsqlTypes.NpgsqlBox(top: 0.9017063959651773d,right: 0.7574807781326534d,bottom: 0.046500372497903175d,left: 0.28681324555158716d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7029194967846436d,right: 0.37754036214699194d,bottom: 0.2559472421208011d,left: 0.09640262542524292d),
new NpgsqlTypes.NpgsqlBox(top: 0.7195136531842977d,right: 0.7732236780000991d,bottom: 0.42135682440244004d,left: 0.42161415853724904d),
new NpgsqlTypes.NpgsqlBox(top: 0.6921328840631265d,right: 0.7056162790491125d,bottom: 0.2611728585581303d,left: 0.6192638778328226d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7263054119695955d,right: 0.9590480331966835d,bottom: 0.49030427573652713d,left: 0.8227109465105785d),
new NpgsqlTypes.NpgsqlBox(top: 0.11817630846579108d,right: 0.7196576898557742d,bottom: 0.018441362763058522d,left: 0.6413843976811342d),
new NpgsqlTypes.NpgsqlBox(top: 0.5107477117584773d,right: 0.5652817264985622d,bottom: 0.0955855712720608d,left: 0.5562984006475487d),
new NpgsqlTypes.NpgsqlBox(top: 0.7167933717884301d,right: 0.7843737750946272d,bottom: 0.1585575394938893d,left: 0.17865062439847246d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5728645748244284d,right: 0.9837527107001084d,bottom: 0.19627345847098898d,left: 0.46786704473963525d),
new NpgsqlTypes.NpgsqlBox(top: 0.7996655102693281d,right: 0.2383396593638868d,bottom: 0.7365983065272876d,left: 0.1605790094664088d),
new NpgsqlTypes.NpgsqlBox(top: 0.9290388887286366d,right: 0.7963530165477849d,bottom: 0.8958340521826791d,left: 0.577495835315312d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7278396288786264d,right: 0.26772836427152136d,bottom: 0.2758997987296712d,left: 0.10196287958530015d),
new NpgsqlTypes.NpgsqlBox(top: 0.8876766418343083d,right: 0.6692013565109083d,bottom: 0.7368363993974639d,left: 0.1636192512988056d),
new NpgsqlTypes.NpgsqlBox(top: 0.7697179807489625d,right: 0.6962167388171702d,bottom: 0.449280034044074d,left: 0.14279381133191282d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7000100309648751d,right: 0.8970553714975054d,bottom: 0.1754937075653783d,left: 0.0902891935517921d),
new NpgsqlTypes.NpgsqlBox(top: 0.7521137807762628d,right: 0.9443306402166401d,bottom: 0.5871037901962597d,left: 0.07198753442311467d),
new NpgsqlTypes.NpgsqlBox(top: 0.5924574652295553d,right: 0.19320126383659297d,bottom: 0.11302358826151726d,left: 0.15268611563507262d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4891964770253542d,right: 0.8968018214204475d,bottom: 0.053903599140514125d,left: 0.18034669547356275d),
new NpgsqlTypes.NpgsqlBox(top: 0.9386765484326278d,right: 0.6985748653419127d,bottom: 0.15483063226763083d,left: 0.41936111844387447d),
new NpgsqlTypes.NpgsqlBox(top: 0.45823362190236927d,right: 0.450703599636222d,bottom: 0.24029016194850494d,left: 0.408267406230734d),
new NpgsqlTypes.NpgsqlBox(top: 0.5628598302392549d,right: 0.42609702670519534d,bottom: 0.5082686940134493d,left: 0.09451511366711207d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2434202070035928d,right: 0.45234555447019975d,bottom: 0.2271969005448976d,left: 0.033209117589071635d),
new NpgsqlTypes.NpgsqlBox(top: 0.9191843057653066d,right: 0.3062338637765447d,bottom: 0.058793916202683705d,left: 0.2815907722973223d),
new NpgsqlTypes.NpgsqlBox(top: 0.5190472858057942d,right: 0.9336957446003203d,bottom: 0.1577927797271641d,left: 0.8169516335183838d),
new NpgsqlTypes.NpgsqlBox(top: 0.26007988751175426d,right: 0.7989200338974055d,bottom: 0.19605297300888047d,left: 0.49778844340502915d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9390977648002408d,right: 0.9867967887584923d,bottom: 0.7845990198540996d,left: 0.21369101491468234d),
new NpgsqlTypes.NpgsqlBox(top: 0.4480801788920301d,right: 0.996425125013819d,bottom: 0.01833005068100413d,left: 0.10980593574077047d),
new NpgsqlTypes.NpgsqlBox(top: 0.11930344320319652d,right: 0.9592626470785899d,bottom: 0.059971587347239064d,left: 0.6301110752021502d),
new NpgsqlTypes.NpgsqlBox(top: 0.5284632156866194d,right: 0.7212872365599579d,bottom: 0.27411422985983613d,left: 0.4040382235536977d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7072286052590119d,right: 0.7949082453414457d,bottom: 0.47029190294690815d,left: 0.44337603164504236d),
new NpgsqlTypes.NpgsqlBox(top: 0.1241665499974477d,right: 0.48006864378164515d,bottom: 0.07736946687614366d,left: 0.275414880269668d),
new NpgsqlTypes.NpgsqlBox(top: 0.6302106029601713d,right: 0.486856476215658d,bottom: 0.5308850716851441d,left: 0.3470256353241139d),
new NpgsqlTypes.NpgsqlBox(top: 0.9617116478241897d,right: 0.7601537979654934d,bottom: 0.9495144424002755d,left: 0.7249512226928914d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.14954574156321387d,right: 0.28452401140603967d,bottom: 0.0594999676655622d,left: 0.11226437768220188d),
new NpgsqlTypes.NpgsqlBox(top: 0.671509179464069d,right: 0.29012102444503873d,bottom: 0.2820759383137954d,left: 0.028494023248585187d),
new NpgsqlTypes.NpgsqlBox(top: 0.9464262546734551d,right: 0.655876274294451d,bottom: 0.6419148083360171d,left: 0.4334018748165087d),
new NpgsqlTypes.NpgsqlBox(top: 0.7684721163792843d,right: 0.8684620950358298d,bottom: 0.6436432267464606d,left: 0.6063359749610824d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8855705821902448d,right: 0.9836675960791655d,bottom: 0.8471146206650165d,left: 0.10227958098590095d),
new NpgsqlTypes.NpgsqlBox(top: 0.86268083811209d,right: 0.8581236500319211d,bottom: 0.34094228931172377d,left: 0.8080476796801512d),
new NpgsqlTypes.NpgsqlBox(top: 0.26697974318205286d,right: 0.35885905688448894d,bottom: 0.008077801091918357d,left: 0.19796034480047042d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7676200416163261d,right: 0.4191131646033618d,bottom: 0.3691043795537582d,left: 0.1052489927303637d),
new NpgsqlTypes.NpgsqlBox(top: 0.6377636998820381d,right: 0.9108449888321912d,bottom: 0.29435726988676625d,left: 0.7203719695116235d),
new NpgsqlTypes.NpgsqlBox(top: 0.9328428619691703d,right: 0.7725889485662386d,bottom: 0.4096022727942864d,left: 0.43907307003953855d),
new NpgsqlTypes.NpgsqlBox(top: 0.7414203201993537d,right: 0.7257784243066433d,bottom: 0.0015312776054066113d,left: 0.03147179719207649d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7780532117623666d,right: 0.9024574761314492d,bottom: 0.25797191828415944d,left: 0.8068583523072556d),
new NpgsqlTypes.NpgsqlBox(top: 0.847653584062207d,right: 0.8068447969380809d,bottom: 0.45542238754909214d,left: 0.26558967069072437d),
new NpgsqlTypes.NpgsqlBox(top: 0.7325776156788706d,right: 0.5548580826948449d,bottom: 0.3864909457741291d,left: 0.1870612631174824d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6186554926088742d,right: 0.9818784417559208d,bottom: 0.29605560446212553d,left: 0.23978579618815465d),
new NpgsqlTypes.NpgsqlBox(top: 0.9593451849901918d,right: 0.8628648705936617d,bottom: 0.26840171897878107d,left: 0.5970205160140558d),
new NpgsqlTypes.NpgsqlBox(top: 0.6167261719198902d,right: 0.21729015422233033d,bottom: 0.16263442151930574d,left: 0.07756623773884519d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.333835135384957d,right: 0.5641775699854081d,bottom: 0.12120388235577306d,left: 0.20405004124009718d),
new NpgsqlTypes.NpgsqlBox(top: 0.8792285395432423d,right: 0.4691858490412981d,bottom: 0.3114062432815228d,left: 0.4170725781480862d),
new NpgsqlTypes.NpgsqlBox(top: 0.6667703200855406d,right: 0.299564737797524d,bottom: 0.2713937164228659d,left: 0.16049875366036204d),
new NpgsqlTypes.NpgsqlBox(top: 0.837707035341853d,right: 0.7982680396352501d,bottom: 0.7037626945019425d,left: 0.5558718670478455d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4311704085909991d,right: 0.2847151748936455d,bottom: 0.004430750865243027d,left: 0.22725608254633523d),
new NpgsqlTypes.NpgsqlBox(top: 0.47980376707898553d,right: 0.7488956788424477d,bottom: 0.22166232937906694d,left: 0.014941456780210971d),
new NpgsqlTypes.NpgsqlBox(top: 0.9540448227636972d,right: 0.4925867800943965d,bottom: 0.15757115942519884d,left: 0.3450515718704381d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7905458274925222d,right: 0.10548924846286989d,bottom: 0.06454550439103834d,left: 0.013228410610508168d),
new NpgsqlTypes.NpgsqlBox(top: 0.17430537842756466d,right: 0.8787046931238596d,bottom: 0.06326681162187331d,left: 0.2903799526764411d),
new NpgsqlTypes.NpgsqlBox(top: 0.84211282779457d,right: 0.6500065709908263d,bottom: 0.074127390805933d,left: 0.4051949782301273d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.44677609314394295d,right: 0.5860947616086379d,bottom: 0.26694305967322296d,left: 0.22091679377695894d),
new NpgsqlTypes.NpgsqlBox(top: 0.6558544340080337d,right: 0.7463822662184939d,bottom: 0.6152013021297091d,left: 0.10527029215937167d),
new NpgsqlTypes.NpgsqlBox(top: 0.26743974400126147d,right: 0.9700044755820273d,bottom: 0.13233291860796048d,left: 0.884559387256153d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9842349516029351d,right: 0.5338980767647659d,bottom: 0.8377272223504597d,left: 0.12763737981387036d),
new NpgsqlTypes.NpgsqlBox(top: 0.9660643986507481d,right: 0.2760836919639523d,bottom: 0.8031426619094407d,left: 0.14633188650372042d),
new NpgsqlTypes.NpgsqlBox(top: 0.9734471116666783d,right: 0.8172840857780852d,bottom: 0.4903715251941919d,left: 0.07137719280061072d),
new NpgsqlTypes.NpgsqlBox(top: 0.9003037132555614d,right: 0.856349459632533d,bottom: 0.5895780786684965d,left: 0.6149549466256431d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4839738271578553d,right: 0.6175005717856379d,bottom: 0.47007167737571853d,left: 0.15909521568205132d),
new NpgsqlTypes.NpgsqlBox(top: 0.6116190018076368d,right: 0.34919759575349196d,bottom: 0.3582337247345527d,left: 0.30405858066843483d),
new NpgsqlTypes.NpgsqlBox(top: 0.8058956494875263d,right: 0.5153305601501578d,bottom: 0.08273210553085442d,left: 0.24126393163429838d),
new NpgsqlTypes.NpgsqlBox(top: 0.5228759399884342d,right: 0.9832733988938269d,bottom: 0.10850378496067614d,left: 0.8694858744934949d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.41586580197366463d,right: 0.5178605338402955d,bottom: 0.32615187234533494d,left: 0.11642801620343346d),
new NpgsqlTypes.NpgsqlBox(top: 0.9039294778208097d,right: 0.6576616679675279d,bottom: 0.593268240129844d,left: 0.3152161275884754d),
new NpgsqlTypes.NpgsqlBox(top: 0.7097385327041454d,right: 0.2623685935621096d,bottom: 0.02836835474249899d,left: 0.10401641416846308d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8587295462060873d,right: 0.9391614239606353d,bottom: 0.3300058356238781d,left: 0.5945901060191915d),
new NpgsqlTypes.NpgsqlBox(top: 0.09539826595330714d,right: 0.802646565026229d,bottom: 0.031077617547983993d,left: 0.5659415876664284d),
new NpgsqlTypes.NpgsqlBox(top: 0.8831109188205466d,right: 0.514711831444202d,bottom: 0.6392876761486753d,left: 0.17285699605444982d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4610140627631958d,right: 0.8553628583743345d,bottom: 0.36517417893423965d,left: 0.2657010671348936d),
new NpgsqlTypes.NpgsqlBox(top: 0.29343411924008944d,right: 0.9716282934039673d,bottom: 0.18010616453829964d,left: 0.22318050783904964d),
new NpgsqlTypes.NpgsqlBox(top: 0.21018218398875688d,right: 0.4837371643695684d,bottom: 0.1080502569833488d,left: 0.3591462095594935d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6370849950837595d,right: 0.6354394531228483d,bottom: 0.20743600531111372d,left: 0.18716575940540947d),
new NpgsqlTypes.NpgsqlBox(top: 0.8017028265795152d,right: 0.7002150681870091d,bottom: 0.743134220876418d,left: 0.19183785431110156d),
new NpgsqlTypes.NpgsqlBox(top: 0.6496642970660608d,right: 0.6016711344414174d,bottom: 0.37888062910793974d,left: 0.05351051790476469d),
new NpgsqlTypes.NpgsqlBox(top: 0.9677241706575057d,right: 0.6395638156299928d,bottom: 0.6088948223719973d,left: 0.42004482570942314d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8094441350499867d,right: 0.6824439232625341d,bottom: 0.47423497081510513d,left: 0.41441527148351254d),
new NpgsqlTypes.NpgsqlBox(top: 0.7107036700816917d,right: 0.3304159241811012d,bottom: 0.6301047797979816d,left: 0.18567038910902423d),
new NpgsqlTypes.NpgsqlBox(top: 0.48319818521709146d,right: 0.5962968990797671d,bottom: 0.3037734423924462d,left: 0.2566800837370944d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2906658400294083d,right: 0.6425425428110575d,bottom: 0.270493350399473d,left: 0.5211966354494152d),
new NpgsqlTypes.NpgsqlBox(top: 0.4542411223222893d,right: 0.5465526410641023d,bottom: 0.41883560051377877d,left: 0.09113791057570675d),
new NpgsqlTypes.NpgsqlBox(top: 0.7967088687624609d,right: 0.8843006470041128d,bottom: 0.19910985457507724d,left: 0.32268777290083517d),
new NpgsqlTypes.NpgsqlBox(top: 0.4392350433842108d,right: 0.7089855147485061d,bottom: 0.33178326212195164d,left: 0.26004222978043456d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3733561460021734d,right: 0.9665806380337998d,bottom: 0.23939213463320252d,left: 0.7694528437273292d),
new NpgsqlTypes.NpgsqlBox(top: 0.19782033150739986d,right: 0.9687340376697843d,bottom: 0.07169842360839163d,left: 0.5887263665276145d),
new NpgsqlTypes.NpgsqlBox(top: 0.7530472783723853d,right: 0.9432438971118658d,bottom: 0.0037530042498878924d,left: 0.14990720394513002d),
new NpgsqlTypes.NpgsqlBox(top: 0.7435096583070858d,right: 0.8068240242351341d,bottom: 0.41961144376158954d,left: 0.1395678990495034d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6493196691565961d,right: 0.6981363316288411d,bottom: 0.5491478957670716d,left: 0.051528633985064354d),
new NpgsqlTypes.NpgsqlBox(top: 0.9502625932557819d,right: 0.7767171166787489d,bottom: 0.6145146816657984d,left: 0.6948609831463536d),
new NpgsqlTypes.NpgsqlBox(top: 0.9793152593266475d,right: 0.9657116624547033d,bottom: 0.20525674811894035d,left: 0.4795239060586094d),
new NpgsqlTypes.NpgsqlBox(top: 0.9728562400495397d,right: 0.733376319336894d,bottom: 0.02753907899806385d,left: 0.5151309230558944d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9032760410681714d,right: 0.7778621853905036d,bottom: 0.7209200860053742d,left: 0.6140343171573835d),
new NpgsqlTypes.NpgsqlBox(top: 0.5971405178436904d,right: 0.9801789443273354d,bottom: 0.43551776862809766d,left: 0.5843509735098255d),
new NpgsqlTypes.NpgsqlBox(top: 0.8559732806434037d,right: 0.39292076633900097d,bottom: 0.5161589935222286d,left: 0.28247766932710494d),
new NpgsqlTypes.NpgsqlBox(top: 0.43879794905229197d,right: 0.9614061456045889d,bottom: 0.12539722618219118d,left: 0.3152666890508513d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8346645677315242d,right: 0.7382476392287126d,bottom: 0.3640890503055717d,left: 0.16177602666094437d),
new NpgsqlTypes.NpgsqlBox(top: 0.7999349864177007d,right: 0.6632126286412479d,bottom: 0.1458192832292574d,left: 0.3659133877546388d),
new NpgsqlTypes.NpgsqlBox(top: 0.9595992378326939d,right: 0.8683170965324498d,bottom: 0.9527081545528879d,left: 0.15331907292613345d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9548290971499267d,right: 0.972378545228954d,bottom: 0.1679706022855939d,left: 0.3506905669488577d),
new NpgsqlTypes.NpgsqlBox(top: 0.8819662015559273d,right: 0.8108259050897969d,bottom: 0.4315221048120438d,left: 0.6801507593808228d),
new NpgsqlTypes.NpgsqlBox(top: 0.8189065729384233d,right: 0.8995190598283324d,bottom: 0.7982551461398223d,left: 0.8068084069265171d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8143035265764441d,right: 0.5926870434914092d,bottom: 0.13662028137115234d,left: 0.29109204316251003d),
new NpgsqlTypes.NpgsqlBox(top: 0.8454104582279919d,right: 0.5439820744002091d,bottom: 0.3283902138229674d,left: 0.027713316008706856d),
new NpgsqlTypes.NpgsqlBox(top: 0.18325235971740217d,right: 0.6124428217488486d,bottom: 0.16918704092389936d,left: 0.16025221225752706d),
new NpgsqlTypes.NpgsqlBox(top: 0.8912822061046763d,right: 0.4475667939202186d,bottom: 0.4057297749855876d,left: 0.01997154831480974d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6343329848195217d,right: 0.2570929574063059d,bottom: 0.45607352845903715d,left: 0.17196831980373384d),
new NpgsqlTypes.NpgsqlBox(top: 0.5477815319436705d,right: 0.7220858986207284d,bottom: 0.3407558239106533d,left: 0.3504251405541252d),
new NpgsqlTypes.NpgsqlBox(top: 0.8720559320521527d,right: 0.9414598089751378d,bottom: 0.855639465256012d,left: 0.25841084585143426d),
new NpgsqlTypes.NpgsqlBox(top: 0.8457493388310267d,right: 0.5266725594175699d,bottom: 0.4632589773353595d,left: 0.26427714053715623d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9970938530552839d,right: 0.6640171461419808d,bottom: 0.3944742844974376d,left: 0.6109834699214728d),
new NpgsqlTypes.NpgsqlBox(top: 0.4513883941697624d,right: 0.8024327216634167d,bottom: 0.37186539135692254d,left: 0.7757406045816877d),
new NpgsqlTypes.NpgsqlBox(top: 0.7945606586152516d,right: 0.6340997485712104d,bottom: 0.6227244995173552d,left: 0.6177426808950991d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5750120021055939d,right: 0.9179777896623581d,bottom: 0.3685859751218097d,left: 0.642811673700565d),
new NpgsqlTypes.NpgsqlBox(top: 0.6453506890506286d,right: 0.42766367876613887d,bottom: 0.18783003287920075d,left: 0.01611286127625977d),
new NpgsqlTypes.NpgsqlBox(top: 0.9377335375642669d,right: 0.3361193366726819d,bottom: 0.08344046319996068d,left: 0.24485420037801897d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9628455150276514d,right: 0.6229905029592312d,bottom: 0.2623793747098623d,left: 0.5535616424323858d),
new NpgsqlTypes.NpgsqlBox(top: 0.39955520991176696d,right: 0.8892638586237402d,bottom: 0.0742814118648013d,left: 0.5905664596050387d),
new NpgsqlTypes.NpgsqlBox(top: 0.6383033975480527d,right: 0.7364932391518443d,bottom: 0.23505443518078584d,left: 0.5308248410174599d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9820098414557311d,right: 0.9237050633160301d,bottom: 0.431825435200353d,left: 0.887134072725265d),
new NpgsqlTypes.NpgsqlBox(top: 0.706975748701013d,right: 0.3017195867341683d,bottom: 0.23144537519105557d,left: 0.19518277143395635d),
new NpgsqlTypes.NpgsqlBox(top: 0.5601769583794558d,right: 0.7203473399009737d,bottom: 0.4076758484217884d,left: 0.4794175069995399d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8084063202146845d,right: 0.41898166323483943d,bottom: 0.283914107423588d,left: 0.020406797964531487d),
new NpgsqlTypes.NpgsqlBox(top: 0.9043115158959057d,right: 0.897126715681066d,bottom: 0.8682273305832968d,left: 0.2553549593734731d),
new NpgsqlTypes.NpgsqlBox(top: 0.3869934238046038d,right: 0.6531123531693452d,bottom: 0.13091110516581816d,left: 0.29261339715395907d),
new NpgsqlTypes.NpgsqlBox(top: 0.9996864303580542d,right: 0.47149786570540564d,bottom: 0.5634962638747394d,left: 0.28671370594508716d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5224377476832722d,right: 0.5343049119028096d,bottom: 0.4320094508192537d,left: 0.1503192595630316d),
new NpgsqlTypes.NpgsqlBox(top: 0.6008267427704064d,right: 0.993150765014666d,bottom: 0.039159346986959d,left: 0.23872224823025912d),
new NpgsqlTypes.NpgsqlBox(top: 0.39550350317096294d,right: 0.8590757586450595d,bottom: 0.2440990141264614d,left: 0.4493818184403624d),
new NpgsqlTypes.NpgsqlBox(top: 0.6448822984092016d,right: 0.7690032540173933d,bottom: 0.12727452368470926d,left: 0.01239131937878224d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5351903869321736d,right: 0.9576757709016905d,bottom: 0.06740154986397351d,left: 0.5495706578180298d),
new NpgsqlTypes.NpgsqlBox(top: 0.608612873039835d,right: 0.9256412010312558d,bottom: 0.06932216972919547d,left: 0.582016724445992d),
new NpgsqlTypes.NpgsqlBox(top: 0.8746609586225798d,right: 0.4927345452858706d,bottom: 0.46867849762795d,left: 0.3539685674302048d),
new NpgsqlTypes.NpgsqlBox(top: 0.8164833856833907d,right: 0.961215185657922d,bottom: 0.8119075412180747d,left: 0.8485042192746317d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.07977675555925912d,right: 0.4841801640742873d,bottom: 0.0027821836530822486d,left: 0.1418123632328665d),
new NpgsqlTypes.NpgsqlBox(top: 0.6972062040718096d,right: 0.33708847031426636d,bottom: 0.5222878058960966d,left: 0.13558307204968978d),
new NpgsqlTypes.NpgsqlBox(top: 0.5606097273359302d,right: 0.6572877065760917d,bottom: 0.0924926886684092d,left: 0.4431637275367878d),
new NpgsqlTypes.NpgsqlBox(top: 0.44819301724073446d,right: 0.7315526864635057d,bottom: 0.4022979370917902d,left: 0.05815684765269735d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6746084498322288d,right: 0.25219035080622243d,bottom: 0.05996383911859948d,left: 0.05424458700591617d),
new NpgsqlTypes.NpgsqlBox(top: 0.9704058767902946d,right: 0.7801552943559404d,bottom: 0.7510223487235836d,left: 0.2779939274244295d),
new NpgsqlTypes.NpgsqlBox(top: 0.5291790457761599d,right: 0.9211982198833745d,bottom: 0.4589100711431605d,left: 0.688039452478631d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6664979901823216d,right: 0.11349027717595417d,bottom: 0.5276447779995816d,left: 0.09409641786612666d),
new NpgsqlTypes.NpgsqlBox(top: 0.46578776527603716d,right: 0.9771075688031927d,bottom: 0.4310370841965192d,left: 0.8258886378822732d),
new NpgsqlTypes.NpgsqlBox(top: 0.7752501222608625d,right: 0.7235432766480907d,bottom: 0.07575890333323543d,left: 0.24579183247599246d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5493170774981448d,right: 0.979706323956888d,bottom: 0.5146438652649297d,left: 0.8264863122780427d),
new NpgsqlTypes.NpgsqlBox(top: 0.8644557867874529d,right: 0.774057291259429d,bottom: 0.765138381237152d,left: 0.03375155099140825d),
new NpgsqlTypes.NpgsqlBox(top: 0.5960881519265432d,right: 0.5979785374279172d,bottom: 0.27618958652070247d,left: 0.02779362914455885d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.35135907596967797d,right: 0.52666311723761d,bottom: 0.13106549646372279d,left: 0.13663175539278416d),
new NpgsqlTypes.NpgsqlBox(top: 0.029188420617753175d,right: 0.6518552701738032d,bottom: 0.005348079072707734d,left: 0.4724957984204192d),
new NpgsqlTypes.NpgsqlBox(top: 0.7630446190110145d,right: 0.8328135034004949d,bottom: 0.06599613768093093d,left: 0.3217491180406852d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6233377521303324d,right: 0.8672409131853188d,bottom: 0.599102085095259d,left: 0.09408168059575084d),
new NpgsqlTypes.NpgsqlBox(top: 0.6585955659558715d,right: 0.30611383529606995d,bottom: 0.20324756511946174d,left: 0.013022621504358622d),
new NpgsqlTypes.NpgsqlBox(top: 0.6269080747635386d,right: 0.7893944153716626d,bottom: 0.3362529168775704d,left: 0.058801356081938594d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.261853321505798d,right: 0.6094727435538548d,bottom: 0.1686073522688908d,left: 0.3197100058484086d),
new NpgsqlTypes.NpgsqlBox(top: 0.7997714670309203d,right: 0.6391488518235485d,bottom: 0.36121541516687483d,left: 0.44475768548457806d),
new NpgsqlTypes.NpgsqlBox(top: 0.9081114638952574d,right: 0.2539176065962493d,bottom: 0.6760904957256536d,left: 0.049467459979394945d),
new NpgsqlTypes.NpgsqlBox(top: 0.7035941946803123d,right: 0.6773285940681582d,bottom: 0.4238655478787744d,left: 0.6075609380243556d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.29179166329189077d,right: 0.8943575820857171d,bottom: 0.2495940160509761d,left: 0.7970626555019675d),
new NpgsqlTypes.NpgsqlBox(top: 0.6591038653471178d,right: 0.7976036644358961d,bottom: 0.3421588794233893d,left: 0.77457263156355d),
new NpgsqlTypes.NpgsqlBox(top: 0.3848683156325895d,right: 0.4272189949362777d,bottom: 0.21404488900593366d,left: 0.2443268044828827d),
new NpgsqlTypes.NpgsqlBox(top: 0.2833425312431529d,right: 0.38260035263733994d,bottom: 0.17867196898878535d,left: 0.10644307527570551d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5554731874656089d,right: 0.44907371881840885d,bottom: 0.3507096045786715d,left: 0.33565693534875063d),
new NpgsqlTypes.NpgsqlBox(top: 0.6118909853601371d,right: 0.8957656637393069d,bottom: 0.13979609534789506d,left: 0.32984905622403915d),
new NpgsqlTypes.NpgsqlBox(top: 0.9167423012987075d,right: 0.9582100953397816d,bottom: 0.6785984997467241d,left: 0.3787650181918717d),
new NpgsqlTypes.NpgsqlBox(top: 0.953893139519285d,right: 0.9761558621722015d,bottom: 0.49172832647385356d,left: 0.6528504645514382d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6125378184551183d,right: 0.6584961095663703d,bottom: 0.447441628320989d,left: 0.473204866144198d),
new NpgsqlTypes.NpgsqlBox(top: 0.41549980122990415d,right: 0.7482800990731808d,bottom: 0.3185849198123748d,left: 0.5968558006337261d),
new NpgsqlTypes.NpgsqlBox(top: 0.9383697725194351d,right: 0.8337930577717414d,bottom: 0.7757890817638623d,left: 0.0504162116755944d),
new NpgsqlTypes.NpgsqlBox(top: 0.9632192357542301d,right: 0.37086825653811706d,bottom: 0.8044090467219415d,left: 0.24732926964681967d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.872788369369306d,right: 0.4455101388552958d,bottom: 0.44083064152047324d,left: 0.35134139583400636d),
new NpgsqlTypes.NpgsqlBox(top: 0.9962688990837971d,right: 0.5189717077089461d,bottom: 0.3839376400633977d,left: 0.09517069391721389d),
new NpgsqlTypes.NpgsqlBox(top: 0.6906727165383031d,right: 0.9253274042353091d,bottom: 0.04042070360789729d,left: 0.35078459729147293d),
new NpgsqlTypes.NpgsqlBox(top: 0.9226559215409235d,right: 0.5102274841252962d,bottom: 0.01118559842016642d,left: 0.3859349903628644d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5778195039142879d,right: 0.31614041773798673d,bottom: 0.5655309491006657d,left: 0.1637378334133257d),
new NpgsqlTypes.NpgsqlBox(top: 0.47154929519993116d,right: 0.9206806137076168d,bottom: 0.2718865764645201d,left: 0.017606643243535336d),
new NpgsqlTypes.NpgsqlBox(top: 0.942452104099136d,right: 0.5298522709644043d,bottom: 0.8217315706994859d,left: 0.017358599135948505d),
new NpgsqlTypes.NpgsqlBox(top: 0.2936131513645541d,right: 0.6892976661300079d,bottom: 0.08049048200765019d,left: 0.4415954630090192d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9173546517763597d,right: 0.7715407195563765d,bottom: 0.8941411137471257d,left: 0.3527684938458663d),
new NpgsqlTypes.NpgsqlBox(top: 0.8589051415137693d,right: 0.7122980458984839d,bottom: 0.6538917252847322d,left: 0.2624605608002124d),
new NpgsqlTypes.NpgsqlBox(top: 0.5370155510599774d,right: 0.9278076045002158d,bottom: 0.12542753819555452d,left: 0.14689968759016003d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6485081594208403d,right: 0.2976179321935888d,bottom: 0.27754740382241616d,left: 0.25368082159001637d),
new NpgsqlTypes.NpgsqlBox(top: 0.7460385847917311d,right: 0.9633994216743068d,bottom: 0.30654346452175785d,left: 0.7788192382425081d),
new NpgsqlTypes.NpgsqlBox(top: 0.8069657316218308d,right: 0.6247393544265116d,bottom: 0.27750790006546877d,left: 0.31722843643346366d),
new NpgsqlTypes.NpgsqlBox(top: 0.8543400043651658d,right: 0.2254679708755677d,bottom: 0.7083875055382532d,left: 0.14158788765367414d),
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
INSERT INTO public.npgsqlboxboxarray1mi(
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
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

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5728645748244284d,right: 0.9837527107001084d,bottom: 0.19627345847098898d,left: 0.46786704473963525d),
new NpgsqlTypes.NpgsqlBox(top: 0.7996655102693281d,right: 0.2383396593638868d,bottom: 0.7365983065272876d,left: 0.1605790094664088d),
new NpgsqlTypes.NpgsqlBox(top: 0.9290388887286366d,right: 0.7963530165477849d,bottom: 0.8958340521826791d,left: 0.577495835315312d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4891964770253542d,right: 0.8968018214204475d,bottom: 0.053903599140514125d,left: 0.18034669547356275d),
new NpgsqlTypes.NpgsqlBox(top: 0.9386765484326278d,right: 0.6985748653419127d,bottom: 0.15483063226763083d,left: 0.41936111844387447d),
new NpgsqlTypes.NpgsqlBox(top: 0.45823362190236927d,right: 0.450703599636222d,bottom: 0.24029016194850494d,left: 0.408267406230734d),
new NpgsqlTypes.NpgsqlBox(top: 0.5628598302392549d,right: 0.42609702670519534d,bottom: 0.5082686940134493d,left: 0.09451511366711207d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9390977648002408d,right: 0.9867967887584923d,bottom: 0.7845990198540996d,left: 0.21369101491468234d),
new NpgsqlTypes.NpgsqlBox(top: 0.4480801788920301d,right: 0.996425125013819d,bottom: 0.01833005068100413d,left: 0.10980593574077047d),
new NpgsqlTypes.NpgsqlBox(top: 0.11930344320319652d,right: 0.9592626470785899d,bottom: 0.059971587347239064d,left: 0.6301110752021502d),
new NpgsqlTypes.NpgsqlBox(top: 0.5284632156866194d,right: 0.7212872365599579d,bottom: 0.27411422985983613d,left: 0.4040382235536977d),
}));
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8855705821902448d,right: 0.9836675960791655d,bottom: 0.8471146206650165d,left: 0.10227958098590095d),
new NpgsqlTypes.NpgsqlBox(top: 0.86268083811209d,right: 0.8581236500319211d,bottom: 0.34094228931172377d,left: 0.8080476796801512d),
new NpgsqlTypes.NpgsqlBox(top: 0.26697974318205286d,right: 0.35885905688448894d,bottom: 0.008077801091918357d,left: 0.19796034480047042d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4311704085909991d,right: 0.2847151748936455d,bottom: 0.004430750865243027d,left: 0.22725608254633523d),
new NpgsqlTypes.NpgsqlBox(top: 0.47980376707898553d,right: 0.7488956788424477d,bottom: 0.22166232937906694d,left: 0.014941456780210971d),
new NpgsqlTypes.NpgsqlBox(top: 0.9540448227636972d,right: 0.4925867800943965d,bottom: 0.15757115942519884d,left: 0.3450515718704381d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 107;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 33, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 100, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 87, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 129, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 10, query1, 62, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 129, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 129, query1, 100, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 67, query1, 35, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 100, 10))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 19, 113))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 92);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[29], false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MI),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray1M),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1m m
LEFT JOIN public.binary_npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1M>(15);

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
                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

