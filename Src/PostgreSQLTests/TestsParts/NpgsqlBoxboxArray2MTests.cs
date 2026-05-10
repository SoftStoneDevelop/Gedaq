

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
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8679691195448672d,right: 0.936459514159407d,bottom: 0.7548024631632413d,left: 0.9129216986050556d),

new NpgsqlTypes.NpgsqlBox(top: 0.6544240357401518d,right: 0.8898128085541466d,bottom: 0.5864755214957407d,left: 0.16054634081871189d),

new NpgsqlTypes.NpgsqlBox(top: 0.2240099613116342d,right: 0.8649937591858476d,bottom: 0.030782603275535725d,left: 0.3684037737312772d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7136644091187249d,right: 0.847303312229191d,bottom: 0.14658755889133135d,left: 0.14825276745171034d),

new NpgsqlTypes.NpgsqlBox(top: 0.45790737912218427d,right: 0.48055688665107044d,bottom: 0.27985145807466305d,left: 0.06963644032688854d),

new NpgsqlTypes.NpgsqlBox(top: 0.8752799780113165d,right: 0.5378555270813834d,bottom: 0.5275726244648338d,left: 0.12514040472560362d),

new NpgsqlTypes.NpgsqlBox(top: 0.6609054365472802d,right: 0.8804258325484795d,bottom: 0.06576228445730015d,left: 0.7672919311353726d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.357028398021774d,right: 0.4318708447042855d,bottom: 0.11394397884513496d,left: 0.013952650782057319d),

new NpgsqlTypes.NpgsqlBox(top: 0.6252427823306836d,right: 0.7890472802912303d,bottom: 0.040834784208324204d,left: 0.10414890631908957d),

new NpgsqlTypes.NpgsqlBox(top: 0.61551970668582d,right: 0.845011237574852d,bottom: 0.4873523924827914d,left: 0.4008037632265238d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9801192108585712d,right: 0.8182665529511473d,bottom: 0.3823339063899154d,left: 0.1864407933613912d),

new NpgsqlTypes.NpgsqlBox(top: 0.426794610042889d,right: 0.597653323229939d,bottom: 0.16761230415566464d,left: 0.41459671003507337d),

new NpgsqlTypes.NpgsqlBox(top: 0.8311933601508856d,right: 0.566365004775033d,bottom: 0.7666997284006333d,left: 0.15155871708185065d),

new NpgsqlTypes.NpgsqlBox(top: 0.43048900472675633d,right: 0.7781099945313699d,bottom: 0.12747292699793888d,left: 0.37273177592524454d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.20958913118632394d,right: 0.4435438528442559d,bottom: 0.09006719953221143d,left: 0.20367368144968312d),

new NpgsqlTypes.NpgsqlBox(top: 0.3165513593937703d,right: 0.9943246271327804d,bottom: 0.2264646184663126d,left: 0.82389409356783d),

new NpgsqlTypes.NpgsqlBox(top: 0.7549066192487321d,right: 0.8632066051497862d,bottom: 0.35217723801752143d,left: 0.41841156150968883d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7263501216528083d,right: 0.8036825333967251d,bottom: 0.04104244084375286d,left: 0.47088839889472056d),

new NpgsqlTypes.NpgsqlBox(top: 0.9443932460993755d,right: 0.3562382958349206d,bottom: 0.7376293222388435d,left: 0.2116530756394035d),

new NpgsqlTypes.NpgsqlBox(top: 0.4228719383341316d,right: 0.7644119906845807d,bottom: 0.039176629128381824d,left: 0.7622637646484044d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1779037388497381d,right: 0.8697211439655367d,bottom: 0.005776409630239621d,left: 0.5420492200837321d),

new NpgsqlTypes.NpgsqlBox(top: 0.9110338378268973d,right: 0.5859071887581448d,bottom: 0.06601195689695583d,left: 0.3854703406765335d),

new NpgsqlTypes.NpgsqlBox(top: 0.20344283850242872d,right: 0.8538787918827241d,bottom: 0.1166879390153317d,left: 0.6551972675120208d),

new NpgsqlTypes.NpgsqlBox(top: 0.7706104665179722d,right: 0.6813598673458873d,bottom: 0.5792241578416737d,left: 0.4679080367351106d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8329574108333546d,right: 0.8286120620612304d,bottom: 0.7341998348584181d,left: 0.5586651601121422d),

new NpgsqlTypes.NpgsqlBox(top: 0.587673528791232d,right: 0.4140831956164712d,bottom: 0.45977344197888015d,left: 0.03391815611390414d),

new NpgsqlTypes.NpgsqlBox(top: 0.07949030449586902d,right: 0.6360715805975743d,bottom: 0.013572308375025766d,left: 0.09489329252976475d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3586395170903035d,right: 0.8871045497318593d,bottom: 0.22249322446358732d,left: 0.8122800207193608d),

new NpgsqlTypes.NpgsqlBox(top: 0.6099526536855986d,right: 0.9697421261689838d,bottom: 0.34899009430426586d,left: 0.9231768987926875d),

new NpgsqlTypes.NpgsqlBox(top: 0.949165826842367d,right: 0.8700585687143015d,bottom: 0.13270133992754007d,left: 0.4213933836612326d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6500530574329298d,right: 0.9767512283684364d,bottom: 0.39791416148001113d,left: 0.4467951882906367d),

new NpgsqlTypes.NpgsqlBox(top: 0.5218602708040135d,right: 0.09020839984466777d,bottom: 0.1313521489694558d,left: 0.012343779357109064d),

new NpgsqlTypes.NpgsqlBox(top: 0.46085018690784296d,right: 0.47361404285762043d,bottom: 0.03973481638654608d,left: 0.21699296053038408d),

new NpgsqlTypes.NpgsqlBox(top: 0.6471021703864933d,right: 0.7408076331560525d,bottom: 0.46993656043288645d,left: 0.22813920700860435d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5900974785954677d,right: 0.3663228860347777d,bottom: 0.062415131918404754d,left: 0.29496836620244093d),

new NpgsqlTypes.NpgsqlBox(top: 0.938148107380543d,right: 0.8132583106414689d,bottom: 0.2407964093254379d,left: 0.8082811313486306d),

new NpgsqlTypes.NpgsqlBox(top: 0.5302553323556364d,right: 0.8068885728664285d,bottom: 0.17004210253895824d,left: 0.5911357381734812d),

new NpgsqlTypes.NpgsqlBox(top: 0.5378689528250771d,right: 0.5839234550088489d,bottom: 0.11818214475510491d,left: 0.19170613758287314d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9501675554571629d,right: 0.823610902629741d,bottom: 0.10517880735998109d,left: 0.21838534963878165d),

new NpgsqlTypes.NpgsqlBox(top: 0.5739552060392089d,right: 0.7099374048421486d,bottom: 0.2598601608576946d,left: 0.07146642170887685d),

new NpgsqlTypes.NpgsqlBox(top: 0.6839810688642642d,right: 0.9531854592290847d,bottom: 0.6090784817867995d,left: 0.2534669052688092d),

new NpgsqlTypes.NpgsqlBox(top: 0.5924485936675064d,right: 0.7654748349794588d,bottom: 0.26856535730937436d,left: 0.19463328234490174d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.991424535391022d,right: 0.3555015572456881d,bottom: 0.8679923905089895d,left: 0.04532302195568216d),

new NpgsqlTypes.NpgsqlBox(top: 0.1576367120170784d,right: 0.42822355727579153d,bottom: 0.11516848903113397d,left: 0.10089109128146712d),

new NpgsqlTypes.NpgsqlBox(top: 0.7276030150131187d,right: 0.23769568589938928d,bottom: 0.3293324326764493d,left: 0.07721691380427254d),

new NpgsqlTypes.NpgsqlBox(top: 0.08753788737854362d,right: 0.9484324047998567d,bottom: 0.016035936886934943d,left: 0.2523420006365721d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.44397900732839857d,right: 0.2986894990169071d,bottom: 0.4369252234763952d,left: 0.2853399062696561d),

new NpgsqlTypes.NpgsqlBox(top: 0.7626775433766612d,right: 0.9342593492910612d,bottom: 0.38556656039994053d,left: 0.06540953505840263d),

new NpgsqlTypes.NpgsqlBox(top: 0.727743428374784d,right: 0.405083200903226d,bottom: 0.25329419108672613d,left: 0.329089219326144d),

new NpgsqlTypes.NpgsqlBox(top: 0.9034938385188795d,right: 0.973757078585156d,bottom: 0.24616586560374898d,left: 0.27940070210867873d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.798730614815169d,right: 0.37547739619640974d,bottom: 0.11858601362276644d,left: 0.1630423458274729d),

new NpgsqlTypes.NpgsqlBox(top: 0.4719537255300672d,right: 0.8212680957230377d,bottom: 0.06497090191815513d,left: 0.7770764412623058d),

new NpgsqlTypes.NpgsqlBox(top: 0.5039025304561375d,right: 0.9535639701886849d,bottom: 0.03443005864489046d,left: 0.037936545599793425d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7677608436216588d,right: 0.825659492877408d,bottom: 0.649364507705518d,left: 0.4399101799360424d),

new NpgsqlTypes.NpgsqlBox(top: 0.6285570816054709d,right: 0.6992175133972832d,bottom: 0.41425974003975574d,left: 0.25149243304926716d),

new NpgsqlTypes.NpgsqlBox(top: 0.9532250519440496d,right: 0.600635312593015d,bottom: 0.37422025693182104d,left: 0.015708394904796363d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6061460820320954d,right: 0.8309691261432073d,bottom: 0.30182768289655293d,left: 0.5948117808367721d),

new NpgsqlTypes.NpgsqlBox(top: 0.43840664942088325d,right: 0.3254602854578392d,bottom: 0.2508105556714588d,left: 0.29317882898227055d),

new NpgsqlTypes.NpgsqlBox(top: 0.9595472106912102d,right: 0.9254833154623869d,bottom: 0.5293877061527038d,left: 0.08051542720325722d),

new NpgsqlTypes.NpgsqlBox(top: 0.2971818029081814d,right: 0.8020110833206565d,bottom: 0.28549964525784033d,left: 0.3657042956608164d),

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
new NpgsqlTypes.NpgsqlBox(top: 0.7430183096490911d,right: 0.5810437350461978d,bottom: 0.23228781836416168d,left: 0.33251638144783036d),

new NpgsqlTypes.NpgsqlBox(top: 0.9655172184963264d,right: 0.7627196875702353d,bottom: 0.6326230354510293d,left: 0.4698526793228117d),

new NpgsqlTypes.NpgsqlBox(top: 0.9352612585665074d,right: 0.7105323885229679d,bottom: 0.5432681361688855d,left: 0.2670157709897485d),

new NpgsqlTypes.NpgsqlBox(top: 0.9532619683967796d,right: 0.9815250485180604d,bottom: 0.490864876654455d,left: 0.553736544480865d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6503566855124114d,right: 0.43825857797556866d,bottom: 0.08691164871180757d,left: 0.007265454473191824d),

new NpgsqlTypes.NpgsqlBox(top: 0.4840771845534023d,right: 0.5030571049300528d,bottom: 0.02840739193372288d,left: 0.10363806917502472d),

new NpgsqlTypes.NpgsqlBox(top: 0.743584635395317d,right: 0.538199114291347d,bottom: 0.6193358825482423d,left: 0.48571375829372687d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9598057572918344d,right: 0.885342560912297d,bottom: 0.3918298339958737d,left: 0.7836730706533294d),

new NpgsqlTypes.NpgsqlBox(top: 0.4361323317045306d,right: 0.7372199208294987d,bottom: 0.22224307929693066d,left: 0.4952519254682315d),

new NpgsqlTypes.NpgsqlBox(top: 0.6745418845956526d,right: 0.7251651910350085d,bottom: 0.21266122969042933d,left: 0.36589253111367015d),

new NpgsqlTypes.NpgsqlBox(top: 0.9884077010888841d,right: 0.58753394059374d,bottom: 0.384271500526433d,left: 0.09183880074734474d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7350543294102276d,right: 0.7698214893104879d,bottom: 0.4491755678834546d,left: 0.45081744919472255d),

new NpgsqlTypes.NpgsqlBox(top: 0.5886355249847605d,right: 0.9856984671203302d,bottom: 0.49007735676354336d,left: 0.3359136345358902d),

new NpgsqlTypes.NpgsqlBox(top: 0.30670280052688337d,right: 0.8138877333605093d,bottom: 0.1244924529906567d,left: 0.6038287993667714d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9239967258927547d,right: 0.9534287150042964d,bottom: 0.258205882526061d,left: 0.25513362331047107d),

new NpgsqlTypes.NpgsqlBox(top: 0.9005608212442426d,right: 0.9131573176871072d,bottom: 0.8465047852624598d,left: 0.09957067855485013d),

new NpgsqlTypes.NpgsqlBox(top: 0.7919125250671996d,right: 0.5088214637172161d,bottom: 0.38705642403796137d,left: 0.24421640947737633d),

new NpgsqlTypes.NpgsqlBox(top: 0.4999880547816342d,right: 0.9657069303107926d,bottom: 0.37106268843648504d,left: 0.4701331609752206d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7319256206084431d,right: 0.8327991192887287d,bottom: 0.3799041992857566d,left: 0.641456003655812d),

new NpgsqlTypes.NpgsqlBox(top: 0.45907811383746167d,right: 0.9683330356005595d,bottom: 0.1549060399069232d,left: 0.03693217405995053d),

new NpgsqlTypes.NpgsqlBox(top: 0.44773114463314834d,right: 0.409128269336998d,bottom: 0.31886570052326013d,left: 0.04700269869481932d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7607376905207937d,right: 0.5901976179341368d,bottom: 0.12201348488500097d,left: 0.3365414100460037d),

new NpgsqlTypes.NpgsqlBox(top: 0.6787769278065788d,right: 0.36720908979261146d,bottom: 0.5459296788072601d,left: 0.21099039701097377d),

new NpgsqlTypes.NpgsqlBox(top: 0.49707874184839274d,right: 0.47688907334455677d,bottom: 0.21928633314402124d,left: 0.06826567364403746d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1592769041512403d,right: 0.4596516554521105d,bottom: 0.1536955031157241d,left: 0.1753577242560015d),

new NpgsqlTypes.NpgsqlBox(top: 0.88420407223701d,right: 0.4172925530212467d,bottom: 0.4578398145417245d,left: 0.2691881903185177d),

new NpgsqlTypes.NpgsqlBox(top: 0.5060933142608395d,right: 0.5841901807216283d,bottom: 0.2055586762766537d,left: 0.4471255170311018d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.980434125235313d,right: 0.9092479622050957d,bottom: 0.19011078494887368d,left: 0.36947960047296335d),

new NpgsqlTypes.NpgsqlBox(top: 0.6430648496982887d,right: 0.8288250945579638d,bottom: 0.10649594443021804d,left: 0.3494827870677334d),

new NpgsqlTypes.NpgsqlBox(top: 0.48379598649322497d,right: 0.2298630309390396d,bottom: 0.4832469687410702d,left: 0.15034254270094916d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.962176976135807d,right: 0.6871873294470866d,bottom: 0.7138252768999082d,left: 0.1830521918136172d),

new NpgsqlTypes.NpgsqlBox(top: 0.7278582525062993d,right: 0.8388578247023131d,bottom: 0.24875400346095533d,left: 0.5012139164275824d),

new NpgsqlTypes.NpgsqlBox(top: 0.5593951061783553d,right: 0.755280045314405d,bottom: 0.29779519533393417d,left: 0.6152595097966823d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7354599738923967d,right: 0.34369418993495426d,bottom: 0.031744230458508604d,left: 0.3321731117559782d),

new NpgsqlTypes.NpgsqlBox(top: 0.9170243496460242d,right: 0.16176231949553865d,bottom: 0.36931348746300985d,left: 0.13098305491937245d),

new NpgsqlTypes.NpgsqlBox(top: 0.3233851836884999d,right: 0.693384548228739d,bottom: 0.26915577194562d,left: 0.4125714702289276d),

new NpgsqlTypes.NpgsqlBox(top: 0.41896411480031526d,right: 0.9691307959200249d,bottom: 0.3045741460540219d,left: 0.37840889501431285d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6823240693515813d,right: 0.290765685824969d,bottom: 0.250759111695362d,left: 0.2469556502428083d),

new NpgsqlTypes.NpgsqlBox(top: 0.9488978988102201d,right: 0.49876869536161506d,bottom: 0.9463400070099269d,left: 0.23704012653232143d),

new NpgsqlTypes.NpgsqlBox(top: 0.953795054511085d,right: 0.9217273745628015d,bottom: 0.6337869621968107d,left: 0.7620772823222204d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7076401468594049d,right: 0.1930526492179654d,bottom: 0.7032007708571683d,left: 0.11366202350897603d),

new NpgsqlTypes.NpgsqlBox(top: 0.8888248347311855d,right: 0.9297961703950083d,bottom: 0.35734687796171194d,left: 0.6757748000783632d),

new NpgsqlTypes.NpgsqlBox(top: 0.957711464963823d,right: 0.7586717964910925d,bottom: 0.29967901878405134d,left: 0.38628036199564575d),

new NpgsqlTypes.NpgsqlBox(top: 0.9626774791189416d,right: 0.8322560756063575d,bottom: 0.9304064968174215d,left: 0.3720540675389239d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5442887491391671d,right: 0.6104697420602018d,bottom: 0.3690976052614853d,left: 0.1712512510199754d),

new NpgsqlTypes.NpgsqlBox(top: 0.9865548239311892d,right: 0.9453478351854259d,bottom: 0.4405954927298352d,left: 0.35248871025576833d),

new NpgsqlTypes.NpgsqlBox(top: 0.8545232886708237d,right: 0.5835365381343154d,bottom: 0.8044786462988971d,left: 0.40794452001076664d),

new NpgsqlTypes.NpgsqlBox(top: 0.740355312625785d,right: 0.7308761536048115d,bottom: 0.415019139029412d,left: 0.7108233166473943d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4554615982268755d,right: 0.9431805143828946d,bottom: 0.09277288457386612d,left: 0.05299398728717386d),

new NpgsqlTypes.NpgsqlBox(top: 0.827519868268728d,right: 0.6078401257513563d,bottom: 0.45187062684036994d,left: 0.5842604876474349d),

new NpgsqlTypes.NpgsqlBox(top: 0.9590524667979161d,right: 0.34309864173827176d,bottom: 0.24029413176941394d,left: 0.33696635985380075d),

new NpgsqlTypes.NpgsqlBox(top: 0.7902260826001862d,right: 0.19430740424771153d,bottom: 0.15493702327073666d,left: 0.08748867967499385d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.28551778273680306d,right: 0.9253464372890745d,bottom: 0.21975829661722934d,left: 0.12051559807888346d),

new NpgsqlTypes.NpgsqlBox(top: 0.49054229149404505d,right: 0.4299021035994225d,bottom: 0.47879638374507494d,left: 0.034573738183976466d),

new NpgsqlTypes.NpgsqlBox(top: 0.45573251271241566d,right: 0.6389062795998726d,bottom: 0.3697520315124979d,left: 0.22236061614309732d),

new NpgsqlTypes.NpgsqlBox(top: 0.6476953232304519d,right: 0.9662577710349399d,bottom: 0.2565229446201237d,left: 0.771995495689039d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9899190393287245d,right: 0.9132228180498361d,bottom: 0.2416868399039308d,left: 0.5630366420442542d),

new NpgsqlTypes.NpgsqlBox(top: 0.8665870060315727d,right: 0.24568755995297908d,bottom: 0.828545247884821d,left: 0.08892652854200478d),

new NpgsqlTypes.NpgsqlBox(top: 0.9389717037609354d,right: 0.9685975696372067d,bottom: 0.15044004896707108d,left: 0.498994781930992d),

new NpgsqlTypes.NpgsqlBox(top: 0.8207184712546918d,right: 0.8835062734624465d,bottom: 0.2272050267689799d,left: 0.2843661197411316d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7873140053623543d,right: 0.8436225096593916d,bottom: 0.3332893241547745d,left: 0.6043585568505687d),

new NpgsqlTypes.NpgsqlBox(top: 0.6659666740696838d,right: 0.8958318088514434d,bottom: 0.2594568214408782d,left: 0.5532163603025105d),

new NpgsqlTypes.NpgsqlBox(top: 0.5205868448467141d,right: 0.8838422857608453d,bottom: 0.3073214790351476d,left: 0.520359465380653d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9197030827854141d,right: 0.8421707706873597d,bottom: 0.040147206227925d,left: 0.13473527009682518d),

new NpgsqlTypes.NpgsqlBox(top: 0.8389997266250031d,right: 0.6044892234677434d,bottom: 0.5171876442220265d,left: 0.5725702380163507d),

new NpgsqlTypes.NpgsqlBox(top: 0.7012752157403661d,right: 0.9720797329098554d,bottom: 0.40971604374951787d,left: 0.04540313042833022d),

new NpgsqlTypes.NpgsqlBox(top: 0.9566599422207145d,right: 0.4117264803170312d,bottom: 0.0652601244348121d,left: 0.22324397798068463d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6065277204653337d,right: 0.6581581969925989d,bottom: 0.485246468356618d,left: 0.2256695574708697d),

new NpgsqlTypes.NpgsqlBox(top: 0.34089568006687654d,right: 0.4536012354004282d,bottom: 0.19844813736349087d,left: 0.3179899792720441d),

new NpgsqlTypes.NpgsqlBox(top: 0.7927358199247581d,right: 0.9904975924858161d,bottom: 0.22022230177541935d,left: 0.525595604112581d),

new NpgsqlTypes.NpgsqlBox(top: 0.7455903159456824d,right: 0.985020772131121d,bottom: 0.6046597303372886d,left: 0.3731068332099343d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2230958667530475d,right: 0.1631590159266011d,bottom: 0.16297127777486886d,left: 0.10772772773772654d),

new NpgsqlTypes.NpgsqlBox(top: 0.9780145470043305d,right: 0.9853688440531998d,bottom: 0.6537970076316023d,left: 0.8122349582315892d),

new NpgsqlTypes.NpgsqlBox(top: 0.1348696547387338d,right: 0.7508725161497397d,bottom: 0.06628791999743544d,left: 0.5880467874462569d),

new NpgsqlTypes.NpgsqlBox(top: 0.5192907810722112d,right: 0.1863351480885176d,bottom: 0.12131966130355387d,left: 0.14016414375429986d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6244761836200673d,right: 0.44238875773385933d,bottom: 0.002892513830046739d,left: 0.07639017150075578d),

new NpgsqlTypes.NpgsqlBox(top: 0.9568592252732517d,right: 0.40985875038638653d,bottom: 0.7800835281139471d,left: 0.13052126972784273d),

new NpgsqlTypes.NpgsqlBox(top: 0.8752331453824514d,right: 0.5812484821363861d,bottom: 0.8038371171954659d,left: 0.34210643762766046d),

new NpgsqlTypes.NpgsqlBox(top: 0.5928454767916974d,right: 0.8893086231281457d,bottom: 0.060783088538345686d,left: 0.14682244475726158d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.18255341400067548d,right: 0.5874428106659932d,bottom: 0.12762559399064122d,left: 0.10147681541912434d),

new NpgsqlTypes.NpgsqlBox(top: 0.44868854942979375d,right: 0.13458573755104342d,bottom: 0.34503668992684344d,left: 0.10055700235291376d),

new NpgsqlTypes.NpgsqlBox(top: 0.3140306433599843d,right: 0.7409960887492211d,bottom: 0.047096261851329646d,left: 0.5307318469653663d),

new NpgsqlTypes.NpgsqlBox(top: 0.5427442492275051d,right: 0.6946115631683275d,bottom: 0.23146208556314052d,left: 0.5674705792036915d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5941063870990941d,right: 0.9376381546448498d,bottom: 0.1369232711839472d,left: 0.4317989512312703d),

new NpgsqlTypes.NpgsqlBox(top: 0.8694253295166703d,right: 0.9473094364992874d,bottom: 0.5417834059721995d,left: 0.5230611282768567d),

new NpgsqlTypes.NpgsqlBox(top: 0.837013764201818d,right: 0.6361127321174993d,bottom: 0.27617285056894436d,left: 0.20649984914656505d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8103609860432894d,right: 0.7957591254164448d,bottom: 0.17968214344843825d,left: 0.5899247355759227d),

new NpgsqlTypes.NpgsqlBox(top: 0.6129892175984428d,right: 0.9153231754916537d,bottom: 0.10411139415177029d,left: 0.09594998105846786d),

new NpgsqlTypes.NpgsqlBox(top: 0.869458835463224d,right: 0.8675255491611121d,bottom: 0.18072753274726183d,left: 0.37631604014244757d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8442632567160584d,right: 0.887049181855452d,bottom: 0.1916200122238202d,left: 0.24110728745434673d),

new NpgsqlTypes.NpgsqlBox(top: 0.16965881749603662d,right: 0.9846725865340358d,bottom: 0.04041909812620892d,left: 0.5629124915049336d),

new NpgsqlTypes.NpgsqlBox(top: 0.6942218943795034d,right: 0.8564079973619162d,bottom: 0.5195899534156936d,left: 0.25031048687200774d),

new NpgsqlTypes.NpgsqlBox(top: 0.6272734196607819d,right: 0.8337478504491019d,bottom: 0.43784650923285384d,left: 0.13410929038836483d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7474607444747928d,right: 0.8731682945086657d,bottom: 0.3417368399177626d,left: 0.18003981554644488d),

new NpgsqlTypes.NpgsqlBox(top: 0.7144784350968302d,right: 0.8370767514522036d,bottom: 0.3509476371327206d,left: 0.08742404787949332d),

new NpgsqlTypes.NpgsqlBox(top: 0.5946252032839053d,right: 0.5958968345227968d,bottom: 0.33831440751706443d,left: 0.49376627996472144d),

new NpgsqlTypes.NpgsqlBox(top: 0.4832003039073428d,right: 0.8036832995119072d,bottom: 0.31888908643077774d,left: 0.25318357893830623d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7842686245881295d,right: 0.6240127076672869d,bottom: 0.1531622707193443d,left: 0.06422087965847445d),

new NpgsqlTypes.NpgsqlBox(top: 0.7984199938684953d,right: 0.2454560714146633d,bottom: 0.7729449857582167d,left: 0.0346011919311221d),

new NpgsqlTypes.NpgsqlBox(top: 0.48659797534757654d,right: 0.9616964456247d,bottom: 0.07443900103890222d,left: 0.7959658058454584d),

new NpgsqlTypes.NpgsqlBox(top: 0.24790158933414252d,right: 0.9425744098043635d,bottom: 0.0034495940678179737d,left: 0.5000486671701949d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8389501620571945d,right: 0.7651656494051288d,bottom: 0.07112074261437873d,left: 0.06863900637393394d),

new NpgsqlTypes.NpgsqlBox(top: 0.13507950143629666d,right: 0.7474834983465344d,bottom: 0.12033679087034266d,left: 0.6999396581402211d),

new NpgsqlTypes.NpgsqlBox(top: 0.3419757441484602d,right: 0.35001262255758503d,bottom: 0.1641312010834617d,left: 0.2693573005019321d),

new NpgsqlTypes.NpgsqlBox(top: 0.9196378504725072d,right: 0.5951262954160955d,bottom: 0.9077659472569898d,left: 0.09864186215627913d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6402488387527082d,right: 0.8851815536577738d,bottom: 0.543301354737245d,left: 0.0795465854194709d),

new NpgsqlTypes.NpgsqlBox(top: 0.39758642178575765d,right: 0.3249147449448293d,bottom: 0.17061672516178028d,left: 0.010793620971278894d),

new NpgsqlTypes.NpgsqlBox(top: 0.6944389660627467d,right: 0.434231647808644d,bottom: 0.66278665740986d,left: 0.04007647161016359d),

new NpgsqlTypes.NpgsqlBox(top: 0.8741681892149444d,right: 0.6308036884046083d,bottom: 0.023067214675045467d,left: 0.1774741880613021d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5001864555439278d,right: 0.7725738582170169d,bottom: 0.33513448101964016d,left: 0.31705605112745716d),

new NpgsqlTypes.NpgsqlBox(top: 0.4135625773994157d,right: 0.2594425121114924d,bottom: 0.4098001891877321d,left: 0.12607413035109705d),

new NpgsqlTypes.NpgsqlBox(top: 0.9223349739113962d,right: 0.767808399455288d,bottom: 0.31280587736994225d,left: 0.09851793695248245d),

new NpgsqlTypes.NpgsqlBox(top: 0.7846241490375939d,right: 0.8392347832357008d,bottom: 0.06276133511154114d,left: 0.30820005591131916d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6578707356601741d,right: 0.42251730766358975d,bottom: 0.1621339947769309d,left: 0.2686863189816221d),

new NpgsqlTypes.NpgsqlBox(top: 0.8966435784013994d,right: 0.32127386005726355d,bottom: 0.8638436518102798d,left: 0.2469835793479307d),

new NpgsqlTypes.NpgsqlBox(top: 0.6477612915019458d,right: 0.5909419247415241d,bottom: 0.3166904946195186d,left: 0.2569168215020773d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7126387978772302d,right: 0.7910531831355765d,bottom: 0.5408239926833995d,left: 0.01667696176980671d),

new NpgsqlTypes.NpgsqlBox(top: 0.4239552915234208d,right: 0.5414909349768547d,bottom: 0.4167432778246941d,left: 0.000273497351182983d),

new NpgsqlTypes.NpgsqlBox(top: 0.9004487207982924d,right: 0.8509631427935272d,bottom: 0.34379748834139356d,left: 0.4723239567073655d),

new NpgsqlTypes.NpgsqlBox(top: 0.8622644293725352d,right: 0.7859897229187089d,bottom: 0.5776657480961197d,left: 0.14612646702541465d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8224004345247015d,right: 0.4465412233459589d,bottom: 0.4192462961139587d,left: 0.09605007914990471d),

new NpgsqlTypes.NpgsqlBox(top: 0.33880081841140364d,right: 0.6152587599969298d,bottom: 0.14351761851468114d,left: 0.2489822290888989d),

new NpgsqlTypes.NpgsqlBox(top: 0.9501839370952219d,right: 0.7543339198201399d,bottom: 0.4873753419131305d,left: 0.6968785352808358d),

new NpgsqlTypes.NpgsqlBox(top: 0.6932359185801344d,right: 0.9543826754282905d,bottom: 0.5305701996897862d,left: 0.619715225320034d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4512053526734212d,right: 0.564592364885371d,bottom: 0.17063300201463483d,left: 0.5327273055641745d),

new NpgsqlTypes.NpgsqlBox(top: 0.9402708819209549d,right: 0.7602786114575855d,bottom: 0.8164038012423862d,left: 0.1652855230203547d),

new NpgsqlTypes.NpgsqlBox(top: 0.787107535230578d,right: 0.4616311818715765d,bottom: 0.6548686117132825d,left: 0.23563234731902327d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3531794641984498d,right: 0.7722959352036008d,bottom: 0.3055826114017839d,left: 0.456024639784527d),

new NpgsqlTypes.NpgsqlBox(top: 0.6586879195790915d,right: 0.943121099775338d,bottom: 0.22251752027332172d,left: 0.9373399240843883d),

new NpgsqlTypes.NpgsqlBox(top: 0.8345093768418436d,right: 0.9322052442043645d,bottom: 0.24093030359005574d,left: 0.49021959962691664d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5807735137001256d,right: 0.4459679587388443d,bottom: 0.5183850782181659d,left: 0.365986945457203d),

new NpgsqlTypes.NpgsqlBox(top: 0.8825579922837407d,right: 0.8948397063849437d,bottom: 0.09956889049752227d,left: 0.3522842104841333d),

new NpgsqlTypes.NpgsqlBox(top: 0.25914787076008405d,right: 0.2277736990710113d,bottom: 0.17382539968908517d,left: 0.052594318295397735d),

new NpgsqlTypes.NpgsqlBox(top: 0.27093578242041993d,right: 0.8190835063852447d,bottom: 0.022797426331938264d,left: 0.6402123434924284d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6873927207940296d,right: 0.9072435630582267d,bottom: 0.3449919569372436d,left: 0.5712976530594354d),

new NpgsqlTypes.NpgsqlBox(top: 0.9493629881700488d,right: 0.5441360032145401d,bottom: 0.9134232173132151d,left: 0.17285079053462993d),

new NpgsqlTypes.NpgsqlBox(top: 0.3855050443049788d,right: 0.6017375160521409d,bottom: 0.18264808775273333d,left: 0.5035095622595571d),

new NpgsqlTypes.NpgsqlBox(top: 0.8600898403931886d,right: 0.3136304787937517d,bottom: 0.06694046001984166d,left: 0.14707498350835124d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2724655231670623d,right: 0.5429922760871486d,bottom: 0.004987940784503375d,left: 0.30616193428706406d),

new NpgsqlTypes.NpgsqlBox(top: 0.8812127392370048d,right: 0.5033678315266997d,bottom: 0.581449873819124d,left: 0.3980756067717478d),

new NpgsqlTypes.NpgsqlBox(top: 0.8915453677941011d,right: 0.6274148696673405d,bottom: 0.7396604613129054d,left: 0.2916814766880459d),

new NpgsqlTypes.NpgsqlBox(top: 0.1004538428428714d,right: 0.37138972288315175d,bottom: 0.0184366952511551d,left: 0.12603632786696894d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4664100701389421d,right: 0.7463845433838879d,bottom: 0.25470607105901766d,left: 0.041739760653030866d),

new NpgsqlTypes.NpgsqlBox(top: 0.9033067744797763d,right: 0.12713591739922392d,bottom: 0.5331927847671754d,left: 0.05731241284447519d),

new NpgsqlTypes.NpgsqlBox(top: 0.7912993007491065d,right: 0.967374996774916d,bottom: 0.17983096767124673d,left: 0.019981997137276997d),

new NpgsqlTypes.NpgsqlBox(top: 0.8211138150523022d,right: 0.9891932982388606d,bottom: 0.03051534685053947d,left: 0.6116013580889103d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7072144252277471d,right: 0.8086043057252184d,bottom: 0.19493714802612738d,left: 0.15826916473113095d),

new NpgsqlTypes.NpgsqlBox(top: 0.9791837927934998d,right: 0.53753262969579d,bottom: 0.4129409122764117d,left: 0.4636792141607018d),

new NpgsqlTypes.NpgsqlBox(top: 0.7611225819435028d,right: 0.9575983809882425d,bottom: 0.5374430098248049d,left: 0.8888665796961093d),

new NpgsqlTypes.NpgsqlBox(top: 0.9217068168719076d,right: 0.5632528900318108d,bottom: 0.7311307100257549d,left: 0.3378747810852881d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5126797036718762d,right: 0.8086609241667908d,bottom: 0.2824151636568203d,left: 0.5211113067694494d),

new NpgsqlTypes.NpgsqlBox(top: 0.4228573904654568d,right: 0.7291095959806861d,bottom: 0.22641820508271038d,left: 0.38493129267701887d),

new NpgsqlTypes.NpgsqlBox(top: 0.33548046586100544d,right: 0.9637387465790892d,bottom: 0.0757124644646694d,left: 0.48977170062397024d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4581230375951103d,right: 0.3212721798474699d,bottom: 0.3129045924143734d,left: 0.2243108811403709d),

new NpgsqlTypes.NpgsqlBox(top: 0.4589477610368672d,right: 0.06952698559063952d,bottom: 0.08011101069627125d,left: 0.04469493129679136d),

new NpgsqlTypes.NpgsqlBox(top: 0.5663836440903679d,right: 0.25137470302062837d,bottom: 0.04514732548844058d,left: 0.10266849341810413d),

new NpgsqlTypes.NpgsqlBox(top: 0.8402063548874699d,right: 0.9799542994349727d,bottom: 0.3296681663399501d,left: 0.1463956916399144d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3602454897981824d,right: 0.290163090656124d,bottom: 0.13500615380820924d,left: 0.029351966855802547d),

new NpgsqlTypes.NpgsqlBox(top: 0.16151100556258835d,right: 0.6554693238903819d,bottom: 0.1314749184288727d,left: 0.1138169276859402d),

new NpgsqlTypes.NpgsqlBox(top: 0.8185188198538877d,right: 0.61014494638786d,bottom: 0.24440060792398388d,left: 0.5168560349249982d),

new NpgsqlTypes.NpgsqlBox(top: 0.6677346599168813d,right: 0.8607093600067541d,bottom: 0.6392916153201674d,left: 0.2900497502777232d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.464114413845765d,right: 0.9339668213499047d,bottom: 0.38183476684040196d,left: 0.29119911955354494d),

new NpgsqlTypes.NpgsqlBox(top: 0.5964244069015159d,right: 0.42231228657898756d,bottom: 0.4840571484693632d,left: 0.005964802373721656d),

new NpgsqlTypes.NpgsqlBox(top: 0.40459839526502206d,right: 0.8845898477665234d,bottom: 0.3391690404032194d,left: 0.17983639515497996d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4640704574255735d,right: 0.7755150353551415d,bottom: 0.36035885405652823d,left: 0.5252778088082186d),

new NpgsqlTypes.NpgsqlBox(top: 0.7426760998584728d,right: 0.8677926428306237d,bottom: 0.3099809515592262d,left: 0.5323586251955847d),

new NpgsqlTypes.NpgsqlBox(top: 0.8830812509444751d,right: 0.4425490292576333d,bottom: 0.5452131485943311d,left: 0.13388344693996024d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5626105719520492d,right: 0.8416524900038678d,bottom: 0.11313832090598774d,left: 0.7354225410517959d),

new NpgsqlTypes.NpgsqlBox(top: 0.9553870318002162d,right: 0.9130566273714295d,bottom: 0.11021372727129197d,left: 0.8272837773583165d),

new NpgsqlTypes.NpgsqlBox(top: 0.3677562450204881d,right: 0.9905649199178279d,bottom: 0.1515116275088002d,left: 0.16786210348684916d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8165052363759498d,right: 0.8934883687307843d,bottom: 0.12390338896647601d,left: 0.29772632850602376d),

new NpgsqlTypes.NpgsqlBox(top: 0.7505211081620523d,right: 0.6865213950446871d,bottom: 0.6030832672921959d,left: 0.22845912798740997d),

new NpgsqlTypes.NpgsqlBox(top: 0.8813801365743638d,right: 0.9394796591158103d,bottom: 0.02554709276744105d,left: 0.4581851859537758d),

new NpgsqlTypes.NpgsqlBox(top: 0.8132208742810818d,right: 0.5286879165534428d,bottom: 0.6365927971791345d,left: 0.3823949581166839d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.35573169856099784d,right: 0.7084395880736624d,bottom: 0.18614167176669516d,left: 0.1235427942028764d),

new NpgsqlTypes.NpgsqlBox(top: 0.5127273480874013d,right: 0.6902644210414601d,bottom: 0.2245658186419981d,left: 0.48861806002034425d),

new NpgsqlTypes.NpgsqlBox(top: 0.9297184501776036d,right: 0.8054925901744182d,bottom: 0.6998417902589805d,left: 0.1167077759661459d),

new NpgsqlTypes.NpgsqlBox(top: 0.47440486083213673d,right: 0.9366538721063835d,bottom: 0.11203188660081342d,left: 0.7552171340074664d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5012487353521917d,right: 0.9540087110369424d,bottom: 0.02166843201333135d,left: 0.7070163467528877d),

new NpgsqlTypes.NpgsqlBox(top: 0.1677875253784259d,right: 0.4596280236545759d,bottom: 0.15405817769275398d,left: 0.0991261453252581d),

new NpgsqlTypes.NpgsqlBox(top: 0.487002676317412d,right: 0.7430801287141583d,bottom: 0.2326106525487065d,left: 0.6330329034013171d),

new NpgsqlTypes.NpgsqlBox(top: 0.7379665294025126d,right: 0.8603976365457278d,bottom: 0.07545291374053908d,left: 0.6837454216878106d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3417572648880791d,right: 0.7512498367969752d,bottom: 0.11171074464226727d,left: 0.5380870471578998d),

new NpgsqlTypes.NpgsqlBox(top: 0.30915018714876397d,right: 0.7382762524588442d,bottom: 0.13685278461061046d,left: 0.3657328197053089d),

new NpgsqlTypes.NpgsqlBox(top: 0.7845553110287402d,right: 0.99396459387469d,bottom: 0.48136917534038204d,left: 0.13676739866255294d),

new NpgsqlTypes.NpgsqlBox(top: 0.6703736129052933d,right: 0.759990451687699d,bottom: 0.6692769146812564d,left: 0.3728412313346411d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.37532737684486983d,right: 0.6982207870044996d,bottom: 0.25939681598435094d,left: 0.6881363939087703d),

new NpgsqlTypes.NpgsqlBox(top: 0.8067181999408316d,right: 0.9384719742537954d,bottom: 0.5631246789110352d,left: 0.3362099033302176d),

new NpgsqlTypes.NpgsqlBox(top: 0.9861404147706789d,right: 0.6395640723470738d,bottom: 0.637963813050826d,left: 0.6248124559657117d),

new NpgsqlTypes.NpgsqlBox(top: 0.8407904374195961d,right: 0.36841365058708586d,bottom: 0.11340124331613466d,left: 0.1911250127266615d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.30239278276009995d,right: 0.691055502632614d,bottom: 0.2477092152194813d,left: 0.08834354808158462d),

new NpgsqlTypes.NpgsqlBox(top: 0.6508647910368585d,right: 0.41161537799346215d,bottom: 0.23549407627657026d,left: 0.3213566673629631d),

new NpgsqlTypes.NpgsqlBox(top: 0.7091846508345105d,right: 0.9862041553053089d,bottom: 0.3832614118605634d,left: 0.9615282299006073d),

new NpgsqlTypes.NpgsqlBox(top: 0.09090325165869184d,right: 0.9836491972211618d,bottom: 0.026705435794666776d,left: 0.6789550997863815d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 186,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7694315047722885d,right: 0.9538126375521757d,bottom: 0.09726482870525321d,left: 0.27025700219133175d),

new NpgsqlTypes.NpgsqlBox(top: 0.9539066350188471d,right: 0.788090006088357d,bottom: 0.5430333086283817d,left: 0.5654569658000077d),

new NpgsqlTypes.NpgsqlBox(top: 0.38812296475363306d,right: 0.9497134848158946d,bottom: 0.2443551860334846d,left: 0.45263766229861124d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7382680336210387d,right: 0.151259901474468d,bottom: 0.2183637926517048d,left: 0.07533189201482349d),

new NpgsqlTypes.NpgsqlBox(top: 0.5642727250614901d,right: 0.469485907908722d,bottom: 0.4353004735486925d,left: 0.18593348482538874d),

new NpgsqlTypes.NpgsqlBox(top: 0.769182999757613d,right: 0.7707897819546471d,bottom: 0.3674056461979093d,left: 0.00785338646614775d),

},
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 59;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[34], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 142, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 126, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 116, query1, 163, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[34], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 42, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 64, query1, 61, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[34], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 67, query1, 156, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 30, query1, 42, query2))
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[34], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 63, query1, 124, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 136, 163))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 167, 174))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[34], false);
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
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[29], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[30], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[31], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[32], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[33], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 2);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[14], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[15], false);
                NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[16], false);
                NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[17], false);
                NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[18], false);
                NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[19], false);
                NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[29], false);
                NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[30], false);
                NpgsqlBoxboxArray2M.AssertModel(models[30],_testData[31], false);
                NpgsqlBoxboxArray2M.AssertModel(models[31],_testData[32], false);
                NpgsqlBoxboxArray2M.AssertModel(models[32],_testData[33], false);
                NpgsqlBoxboxArray2M.AssertModel(models[33],_testData[34], false);
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

