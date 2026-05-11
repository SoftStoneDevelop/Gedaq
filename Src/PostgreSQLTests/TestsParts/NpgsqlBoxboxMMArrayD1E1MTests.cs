

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
    internal partial interface INpgsqlBoxMArrayboxMMArrayD1
    {
    }
    
    internal partial class NpgsqlBoxMArrayboxMMArrayD1 : INpgsqlBoxMArrayboxMMArrayD1
    {


#region TestData

        private readonly NpgsqlBoxboxMMArrayD1E1M[] _testData = new NpgsqlBoxboxMMArrayD1E1M[]
        {
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8834730419301727d,right: 0.9737751514754901d,bottom: 0.5303949721323323d,left: 0.9248513941100658d),
new NpgsqlTypes.NpgsqlBox(top: 0.9406134587409509d,right: 0.7464259079001365d,bottom: 0.4678346336370772d,left: 0.7449387300281464d),
new NpgsqlTypes.NpgsqlBox(top: 0.49305606146267544d,right: 0.5328818629710593d,bottom: 0.027161643836284055d,left: 0.11277668782311023d),
new NpgsqlTypes.NpgsqlBox(top: 0.643408720481805d,right: 0.9421768329779657d,bottom: 0.2302217315936277d,left: 0.4741431497496287d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.761647263786197d,right: 0.6607166433859392d,bottom: 0.6478705395830271d,left: 0.47208323789170037d),
new NpgsqlTypes.NpgsqlBox(top: 0.9989983266019445d,right: 0.5751260496958577d,bottom: 0.3607322078991331d,left: 0.020516880876494947d),
new NpgsqlTypes.NpgsqlBox(top: 0.8525130590409109d,right: 0.7046366393605668d,bottom: 0.4530249878808078d,left: 0.5896740088180251d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7292292830498655d,right: 0.650088043040945d,bottom: 0.21776465603498718d,left: 0.567326158793988d),
new NpgsqlTypes.NpgsqlBox(top: 0.962966787177215d,right: 0.7748096089205947d,bottom: 0.14763074199926285d,left: 0.5351562594338853d),
new NpgsqlTypes.NpgsqlBox(top: 0.8285845432272083d,right: 0.8905919234142553d,bottom: 0.29623180506685753d,left: 0.8581092384096318d),
new NpgsqlTypes.NpgsqlBox(top: 0.941666340129277d,right: 0.9207839219513714d,bottom: 0.5151260701603402d,left: 0.8878514807683976d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9603707771911419d,right: 0.517704834322332d,bottom: 0.9108030404093322d,left: 0.04798983682096314d),
new NpgsqlTypes.NpgsqlBox(top: 0.5192290806146024d,right: 0.37460405671869257d,bottom: 0.13765128689713113d,left: 0.16761976575049797d),
new NpgsqlTypes.NpgsqlBox(top: 0.5283464580968719d,right: 0.2430670144403737d,bottom: 0.2458728851706199d,left: 0.1891283919623049d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9078493163283297d,right: 0.7562750861616522d,bottom: 0.18691283834952677d,left: 0.6451869501996044d),
new NpgsqlTypes.NpgsqlBox(top: 0.8894041428880956d,right: 0.9373888082258217d,bottom: 0.13182610313330878d,left: 0.33410426981658436d),
new NpgsqlTypes.NpgsqlBox(top: 0.9771895299854413d,right: 0.561977383974955d,bottom: 0.6269920365640874d,left: 0.23373548763880936d),
new NpgsqlTypes.NpgsqlBox(top: 0.7013945536441558d,right: 0.5488099067415977d,bottom: 0.4481381376524781d,left: 0.40739072026779943d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7517183452757716d,right: 0.8329231622045684d,bottom: 0.20157305059484876d,left: 0.220389673720766d),
new NpgsqlTypes.NpgsqlBox(top: 0.9093360721667949d,right: 0.7753447605253699d,bottom: 0.8783022440129651d,left: 0.6401142666617493d),
new NpgsqlTypes.NpgsqlBox(top: 0.7081228866582797d,right: 0.9767489004531332d,bottom: 0.6667324320004127d,left: 0.6047383168081517d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9020313709595821d,right: 0.794329672990114d,bottom: 0.8603982086600184d,left: 0.3185921270758637d),
new NpgsqlTypes.NpgsqlBox(top: 0.48401955318277723d,right: 0.9027696991001949d,bottom: 0.3463285468027525d,left: 0.8693630985917687d),
new NpgsqlTypes.NpgsqlBox(top: 0.26240699633291675d,right: 0.1977285339924556d,bottom: 0.21032863603856777d,left: 0.0048546080882433396d),
new NpgsqlTypes.NpgsqlBox(top: 0.5334594749722472d,right: 0.29918785995319763d,bottom: 0.48837169124766744d,left: 0.14185170684369464d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5506876475087783d,right: 0.8169132172773574d,bottom: 0.41731661168310297d,left: 0.6264888739184793d),
new NpgsqlTypes.NpgsqlBox(top: 0.45236514909701697d,right: 0.7578808743151259d,bottom: 0.1276143069188156d,left: 0.5194280895831448d),
new NpgsqlTypes.NpgsqlBox(top: 0.33108717271110455d,right: 0.9573271560068846d,bottom: 0.2846160108598368d,left: 0.028377339579111815d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.22521256110890953d,right: 0.4997467694018978d,bottom: 0.16910368018667332d,left: 0.19201553328996757d),
new NpgsqlTypes.NpgsqlBox(top: 0.8979642109850818d,right: 0.9224114951335821d,bottom: 0.841434867640793d,left: 0.013114236929074097d),
new NpgsqlTypes.NpgsqlBox(top: 0.8608507572335008d,right: 0.8127572425414539d,bottom: 0.8280316111927261d,left: 0.045342295821980905d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.20749599947763808d,right: 0.9357179053504515d,bottom: 0.07954260670761215d,left: 0.38048683997958177d),
new NpgsqlTypes.NpgsqlBox(top: 0.9171795848297886d,right: 0.7304776460161336d,bottom: 0.8540430276752569d,left: 0.2451984973079373d),
new NpgsqlTypes.NpgsqlBox(top: 0.5886900693559756d,right: 0.5467717670937872d,bottom: 0.38919538347367233d,left: 0.18840748914287297d),
new NpgsqlTypes.NpgsqlBox(top: 0.7582040268095446d,right: 0.679581905704158d,bottom: 0.3030572581974432d,left: 0.5655627787457593d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.566271222438345d,right: 0.9889327616148929d,bottom: 0.06516235375149404d,left: 0.8933858847890283d),
new NpgsqlTypes.NpgsqlBox(top: 0.07236312763300834d,right: 0.8869394846030719d,bottom: 0.014668975356088798d,left: 0.628531810941871d),
new NpgsqlTypes.NpgsqlBox(top: 0.8217283470236195d,right: 0.9210709995310418d,bottom: 0.7740456011540201d,left: 0.07348839972457533d),
new NpgsqlTypes.NpgsqlBox(top: 0.36621624798677965d,right: 0.541177743217783d,bottom: 0.1377585204128695d,left: 0.3177067149487519d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.85520572816792d,right: 0.46205277524389377d,bottom: 0.634859158825658d,left: 0.1256664724335571d),
new NpgsqlTypes.NpgsqlBox(top: 0.8997054057378276d,right: 0.7642206362657766d,bottom: 0.8799242730377619d,left: 0.06973018798276731d),
new NpgsqlTypes.NpgsqlBox(top: 0.982367254902992d,right: 0.5381025766837912d,bottom: 0.6253565981292112d,left: 0.3646154421344442d),
new NpgsqlTypes.NpgsqlBox(top: 0.9935715077486043d,right: 0.5038384738088899d,bottom: 0.9297288005201692d,left: 0.40930531723250974d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.300377243230304d,right: 0.814174693212076d,bottom: 0.21484374050630273d,left: 0.6608533886765054d),
new NpgsqlTypes.NpgsqlBox(top: 0.25318239901433814d,right: 0.4068826138181998d,bottom: 0.07900220202855823d,left: 0.008305251014112058d),
new NpgsqlTypes.NpgsqlBox(top: 0.6742518741161352d,right: 0.820022536277631d,bottom: 0.12543429365399983d,left: 0.20713856417351817d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7526193134117547d,right: 0.27999925540467574d,bottom: 0.059716701703460884d,left: 0.18681489791936234d),
new NpgsqlTypes.NpgsqlBox(top: 0.9610870636491912d,right: 0.41177505773950085d,bottom: 0.8972820311532207d,left: 0.32083351478042554d),
new NpgsqlTypes.NpgsqlBox(top: 0.6387132577247474d,right: 0.6104492969668397d,bottom: 0.6227579321509403d,left: 0.470551867659184d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9407700608743753d,right: 0.4200481804077768d,bottom: 0.8274288369304023d,left: 0.055630654672261026d),
new NpgsqlTypes.NpgsqlBox(top: 0.7722546059103825d,right: 0.6770547869324985d,bottom: 0.5879045579743964d,left: 0.3778603383336886d),
new NpgsqlTypes.NpgsqlBox(top: 0.5577465362072447d,right: 0.9740310502162401d,bottom: 0.5290257159556053d,left: 0.4620189619827719d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4201776779152444d,right: 0.3938422175028501d,bottom: 0.2691962808557967d,left: 0.3854022787842616d),
new NpgsqlTypes.NpgsqlBox(top: 0.7703523910224062d,right: 0.6562128897137369d,bottom: 0.22159680625289613d,left: 0.06024377195272068d),
new NpgsqlTypes.NpgsqlBox(top: 0.26726803395355736d,right: 0.7590523417689706d,bottom: 0.0569867951901778d,left: 0.5338972299918437d),
new NpgsqlTypes.NpgsqlBox(top: 0.8275414482407486d,right: 0.7532074025771924d,bottom: 0.8207994729931812d,left: 0.6180489398193305d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7342419976161785d,right: 0.9520739173312457d,bottom: 0.5024193125599943d,left: 0.20314789918039977d),
new NpgsqlTypes.NpgsqlBox(top: 0.24285323344338117d,right: 0.6391458644049276d,bottom: 0.00612579066273955d,left: 0.6104427321126866d),
new NpgsqlTypes.NpgsqlBox(top: 0.36822485388901294d,right: 0.7828154290525842d,bottom: 0.17834442703108166d,left: 0.5581773372808612d),
new NpgsqlTypes.NpgsqlBox(top: 0.8824686724204378d,right: 0.8979589362725997d,bottom: 0.3903746208902621d,left: 0.6675374732137471d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8534904945389877d,right: 0.8386039013674693d,bottom: 0.24175092147657107d,left: 0.05676012576304479d),
new NpgsqlTypes.NpgsqlBox(top: 0.8029682382497026d,right: 0.6427661976342435d,bottom: 0.10483073636623164d,left: 0.11698198281819516d),
new NpgsqlTypes.NpgsqlBox(top: 0.7346880740265898d,right: 0.8600430213369474d,bottom: 0.36087233189069934d,left: 0.36936896201791714d),
new NpgsqlTypes.NpgsqlBox(top: 0.8407908380772472d,right: 0.9759428010106669d,bottom: 0.675563849694086d,left: 0.17501981809870015d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6365478681448345d,right: 0.8733744425152938d,bottom: 0.5481569546421214d,left: 0.00706588752440751d),
new NpgsqlTypes.NpgsqlBox(top: 0.6444088880768429d,right: 0.590335410762416d,bottom: 0.416265514542263d,left: 0.253285741976493d),
new NpgsqlTypes.NpgsqlBox(top: 0.9036603963573095d,right: 0.5118248440074691d,bottom: 0.1259747347361514d,left: 0.3379691269155085d),
new NpgsqlTypes.NpgsqlBox(top: 0.5988015514157846d,right: 0.8587503952161882d,bottom: 0.5109028268953788d,left: 0.17164239914649793d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7763180195436484d,right: 0.5196012472822166d,bottom: 0.2990338492733188d,left: 0.4156608238996048d),
new NpgsqlTypes.NpgsqlBox(top: 0.7693750888074725d,right: 0.37988519783717545d,bottom: 0.4546286659446568d,left: 0.009694227202872274d),
new NpgsqlTypes.NpgsqlBox(top: 0.4884379969921856d,right: 0.5753852893732717d,bottom: 0.0265174289426785d,left: 0.5038754018888624d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2900998734918381d,right: 0.6374258835590985d,bottom: 0.16327559805844372d,left: 0.45008656175961537d),
new NpgsqlTypes.NpgsqlBox(top: 0.9725779632831951d,right: 0.8921907768030216d,bottom: 0.8996038313256445d,left: 0.10214648969895823d),
new NpgsqlTypes.NpgsqlBox(top: 0.2741972478172915d,right: 0.5788901730356089d,bottom: 0.24997105824517407d,left: 0.15434490935780698d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8816488069332825d,right: 0.8073186001711647d,bottom: 0.05265006097000502d,left: 0.34114218886749337d),
new NpgsqlTypes.NpgsqlBox(top: 0.40668707460724574d,right: 0.8376848491126243d,bottom: 0.20271831661802575d,left: 0.7934694910735463d),
new NpgsqlTypes.NpgsqlBox(top: 0.6877058239830715d,right: 0.5387534225322762d,bottom: 0.43448518411793435d,left: 0.4510180344823913d),
new NpgsqlTypes.NpgsqlBox(top: 0.8185713906732004d,right: 0.6042683040917155d,bottom: 0.2740513270538272d,left: 0.5708782434717152d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8243985172530761d,right: 0.9426546067092711d,bottom: 0.2657213195908317d,left: 0.6020836512314608d),
new NpgsqlTypes.NpgsqlBox(top: 0.3566925176978617d,right: 0.609493410316869d,bottom: 0.10024394728853991d,left: 0.561387225506946d),
new NpgsqlTypes.NpgsqlBox(top: 0.8645566558953455d,right: 0.8295699508761722d,bottom: 0.3697078788985101d,left: 0.1558606471331977d),
new NpgsqlTypes.NpgsqlBox(top: 0.35474722993197494d,right: 0.7175588522339531d,bottom: 0.11317887730799303d,left: 0.5579113908402521d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.974375649700055d,right: 0.7467219082271421d,bottom: 0.7680832765214721d,left: 0.49227464320106185d),
new NpgsqlTypes.NpgsqlBox(top: 0.12233257013641785d,right: 0.8377554860168949d,bottom: 0.05379517586949778d,left: 0.3291584924473159d),
new NpgsqlTypes.NpgsqlBox(top: 0.8471877545045478d,right: 0.9291388182570656d,bottom: 0.273775950294748d,left: 0.30895258923746216d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8038650373176751d,right: 0.6241749900529814d,bottom: 0.37298188228534923d,left: 0.052560386353880606d),
new NpgsqlTypes.NpgsqlBox(top: 0.9532961642185513d,right: 0.350632937035224d,bottom: 0.8041728552626547d,left: 0.11842761415815695d),
new NpgsqlTypes.NpgsqlBox(top: 0.5704691744899263d,right: 0.8238270224872536d,bottom: 0.15733641005779575d,left: 0.421333443304554d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.17349622768887263d,right: 0.5682129955503347d,bottom: 0.10364874252731016d,left: 0.06797379490938804d),
new NpgsqlTypes.NpgsqlBox(top: 0.8430201691264153d,right: 0.9196929625806364d,bottom: 0.40428338142290965d,left: 0.5551810386962966d),
new NpgsqlTypes.NpgsqlBox(top: 0.5630713105609835d,right: 0.7417011479838621d,bottom: 0.07651693507515989d,left: 0.431640351813672d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7788275840182607d,right: 0.6653924270838159d,bottom: 0.08348163011671272d,left: 0.5503568075138922d),
new NpgsqlTypes.NpgsqlBox(top: 0.9692363128240781d,right: 0.6325893132634118d,bottom: 0.27887749668755246d,left: 0.5160400806088483d),
new NpgsqlTypes.NpgsqlBox(top: 0.5356410595161012d,right: 0.8064444348680285d,bottom: 0.4137635926127686d,left: 0.4535334115544377d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3315681277428234d,right: 0.6930780263801956d,bottom: 0.3119264033887398d,left: 0.6100012632965536d),
new NpgsqlTypes.NpgsqlBox(top: 0.94522603428715d,right: 0.6427474671936984d,bottom: 0.6469966988989936d,left: 0.42824409490037707d),
new NpgsqlTypes.NpgsqlBox(top: 0.9355343879144798d,right: 0.6789282249496345d,bottom: 0.014584168492022154d,left: 0.4353340226442505d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9488642729951983d,right: 0.5618265871437673d,bottom: 0.1539387649478412d,left: 0.5397360344672842d),
new NpgsqlTypes.NpgsqlBox(top: 0.8061999232205519d,right: 0.5853640805002208d,bottom: 0.25116402981670416d,left: 0.5840127239888521d),
new NpgsqlTypes.NpgsqlBox(top: 0.8670186247072986d,right: 0.7515889758127453d,bottom: 0.75698729730734d,left: 0.21146641717811554d),
new NpgsqlTypes.NpgsqlBox(top: 0.46137555816458753d,right: 0.28604757641640444d,bottom: 0.031916958443648835d,left: 0.28403839642021456d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3891866810886535d,right: 0.5603191911380709d,bottom: 0.09127262754345666d,left: 0.0834646004879358d),
new NpgsqlTypes.NpgsqlBox(top: 0.5183000871391286d,right: 0.4221635334997943d,bottom: 0.04937818449058684d,left: 0.21453308738955523d),
new NpgsqlTypes.NpgsqlBox(top: 0.9569399125885968d,right: 0.7337561937342582d,bottom: 0.8373013336485251d,left: 0.19070797977909093d),
new NpgsqlTypes.NpgsqlBox(top: 0.9738297624516847d,right: 0.43418752825083506d,bottom: 0.9376339977105763d,left: 0.14928515559966893d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8356972079325397d,right: 0.7825032826954177d,bottom: 0.1239509915638698d,left: 0.27562985696160014d),
new NpgsqlTypes.NpgsqlBox(top: 0.3767860932374939d,right: 0.7148194386244127d,bottom: 0.1613105333773147d,left: 0.41224567980941274d),
new NpgsqlTypes.NpgsqlBox(top: 0.321376238332876d,right: 0.25872800291507514d,bottom: 0.2755508912672242d,left: 0.11820728197266805d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8972025871319147d,right: 0.8174360419240547d,bottom: 0.21338060489294275d,left: 0.619115414197754d),
new NpgsqlTypes.NpgsqlBox(top: 0.576150569185934d,right: 0.6694865502441797d,bottom: 0.3612351458710773d,left: 0.15018690844001714d),
new NpgsqlTypes.NpgsqlBox(top: 0.649812824564752d,right: 0.6290963206206647d,bottom: 0.5421468775614258d,left: 0.47928325854098974d),
new NpgsqlTypes.NpgsqlBox(top: 0.3454028799335189d,right: 0.9582137382382254d,bottom: 0.0710245175234856d,left: 0.19181366495479968d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.23230328613284634d,right: 0.40622983644883404d,bottom: 0.13622320987266945d,left: 0.27792577703189436d),
new NpgsqlTypes.NpgsqlBox(top: 0.4700010900045971d,right: 0.27548022755937385d,bottom: 0.38812137418905734d,left: 0.20026799558227226d),
new NpgsqlTypes.NpgsqlBox(top: 0.940396049510883d,right: 0.952411724401748d,bottom: 0.8871311481113606d,left: 0.7062311141386031d),
new NpgsqlTypes.NpgsqlBox(top: 0.5294144595029936d,right: 0.8379377024653861d,bottom: 0.08813781248529251d,left: 0.6211962804577208d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6804752467957589d,right: 0.9165913128514973d,bottom: 0.3329812242673339d,left: 0.33007271706304d),
new NpgsqlTypes.NpgsqlBox(top: 0.5714867332518988d,right: 0.5059114194781251d,bottom: 0.12180663022733851d,left: 0.41129194053876617d),
new NpgsqlTypes.NpgsqlBox(top: 0.9335097823177965d,right: 0.6539846647325033d,bottom: 0.21875811064097594d,left: 0.5237676969745317d),
new NpgsqlTypes.NpgsqlBox(top: 0.6826304243011935d,right: 0.8052980509886661d,bottom: 0.27510196818838584d,left: 0.4760543406863301d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.22890927814589324d,right: 0.16611155610368045d,bottom: 0.20141500962192826d,left: 0.1064336933915141d),
new NpgsqlTypes.NpgsqlBox(top: 0.5550195457354784d,right: 0.7301426564256309d,bottom: 0.08909375656364438d,left: 0.5524163156552407d),
new NpgsqlTypes.NpgsqlBox(top: 0.9759630868414646d,right: 0.8786617537038092d,bottom: 0.6678570223181497d,left: 0.6596544221480171d),
new NpgsqlTypes.NpgsqlBox(top: 0.8215272795136414d,right: 0.8015243045122384d,bottom: 0.4341730935388921d,left: 0.5099678103800136d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.20760176702108357d,right: 0.4281202721948003d,bottom: 0.14034950636098187d,left: 0.21703806402111003d),
new NpgsqlTypes.NpgsqlBox(top: 0.8041325822337622d,right: 0.12566768650488713d,bottom: 0.25291073967692457d,left: 0.015986506537729817d),
new NpgsqlTypes.NpgsqlBox(top: 0.831690393999904d,right: 0.6271816856061138d,bottom: 0.09556649472103407d,left: 0.22705759082481036d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.747191244410582d,right: 0.6488606946808937d,bottom: 0.43561865041094117d,left: 0.2595099261790963d),
new NpgsqlTypes.NpgsqlBox(top: 0.5155567221788208d,right: 0.9567587233160607d,bottom: 0.44445350399127725d,left: 0.7734289469564425d),
new NpgsqlTypes.NpgsqlBox(top: 0.5993756111088633d,right: 0.9653454532412644d,bottom: 0.5500639693637499d,left: 0.08143059149906473d),
new NpgsqlTypes.NpgsqlBox(top: 0.8227495216025716d,right: 0.8624411768801696d,bottom: 0.3762909631904958d,left: 0.8113998172813234d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8880083789450869d,right: 0.4030152809823906d,bottom: 0.13386482009013445d,left: 0.29353738628421144d),
new NpgsqlTypes.NpgsqlBox(top: 0.9548886633491346d,right: 0.9630446967970431d,bottom: 0.7296594113509672d,left: 0.74370580276592d),
new NpgsqlTypes.NpgsqlBox(top: 0.46566746860900377d,right: 0.23963043409277351d,bottom: 0.3191452488816997d,left: 0.19829485734641328d),
new NpgsqlTypes.NpgsqlBox(top: 0.8187708248991641d,right: 0.9995437304565161d,bottom: 0.22596024049281183d,left: 0.89068831405928d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8200027390522667d,right: 0.8137517095203396d,bottom: 0.18544090931276402d,left: 0.5524313873608937d),
new NpgsqlTypes.NpgsqlBox(top: 0.7660734527791102d,right: 0.4909322243949573d,bottom: 0.58554824151358d,left: 0.3578916133759734d),
new NpgsqlTypes.NpgsqlBox(top: 0.36681859829398544d,right: 0.8582417516691638d,bottom: 0.36155484972762786d,left: 0.452153246127188d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.48657677140439115d,right: 0.769617245225112d,bottom: 0.20618689752615538d,left: 0.6153553358229075d),
new NpgsqlTypes.NpgsqlBox(top: 0.9632320919133331d,right: 0.5430888776670502d,bottom: 0.0437898272371241d,left: 0.43384466135365507d),
new NpgsqlTypes.NpgsqlBox(top: 0.9451676052399124d,right: 0.7842653672502307d,bottom: 0.42279324429526677d,left: 0.16620033062847628d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.29358863038439187d,right: 0.8287282421826826d,bottom: 0.21201749764267896d,left: 0.8224113014668815d),
new NpgsqlTypes.NpgsqlBox(top: 0.6384048070971542d,right: 0.8769979131498622d,bottom: 0.5273268575090453d,left: 0.6035934164592653d),
new NpgsqlTypes.NpgsqlBox(top: 0.9532075906303298d,right: 0.9765517576416958d,bottom: 0.2608317389312095d,left: 0.729973419943335d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7786760508699799d,right: 0.3408151050477968d,bottom: 0.34555744590817683d,left: 0.32464122974450527d),
new NpgsqlTypes.NpgsqlBox(top: 0.7396264883772914d,right: 0.7980842249457655d,bottom: 0.1943115902209177d,left: 0.10609196649018005d),
new NpgsqlTypes.NpgsqlBox(top: 0.5546047634457318d,right: 0.29685606599990333d,bottom: 0.3434390213326314d,left: 0.21916582855738298d),
new NpgsqlTypes.NpgsqlBox(top: 0.7664275629514644d,right: 0.4317574567380227d,bottom: 0.5058063004401679d,left: 0.32032625495543554d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7988136998634495d,right: 0.7725986693109734d,bottom: 0.4319442133140935d,left: 0.6406181509050929d),
new NpgsqlTypes.NpgsqlBox(top: 0.26216599009155594d,right: 0.6428701210222708d,bottom: 0.007921163902239736d,left: 0.4546167035370251d),
new NpgsqlTypes.NpgsqlBox(top: 0.8381791935064095d,right: 0.05432030045175096d,bottom: 0.33528329803796786d,left: 0.02393029797096491d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8963850868258375d,right: 0.3564888791353623d,bottom: 0.007161813037048326d,left: 0.31534922122517406d),
new NpgsqlTypes.NpgsqlBox(top: 0.6130625607029874d,right: 0.2838586695741142d,bottom: 0.1369228686335332d,left: 0.25801941668959727d),
new NpgsqlTypes.NpgsqlBox(top: 0.9384840497497067d,right: 0.25150929089834817d,bottom: 0.6311426098945719d,left: 0.1446681875795205d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8297564997867236d,right: 0.6816216001453784d,bottom: 0.7525033134601093d,left: 0.6539790362914073d),
new NpgsqlTypes.NpgsqlBox(top: 0.8263831266283078d,right: 0.36585734904617984d,bottom: 0.46483865484982745d,left: 0.31664624978723976d),
new NpgsqlTypes.NpgsqlBox(top: 0.5503324837505109d,right: 0.5901710603649124d,bottom: 0.5337623337977981d,left: 0.4780435576769271d),
new NpgsqlTypes.NpgsqlBox(top: 0.7843745139997654d,right: 0.8213914761931975d,bottom: 0.6209528943967084d,left: 0.36185134958336973d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8998475525450416d,right: 0.14975723448740408d,bottom: 0.6412933309527594d,left: 0.019835376621913925d),
new NpgsqlTypes.NpgsqlBox(top: 0.9878712641845193d,right: 0.4429499068428826d,bottom: 0.18731738154699917d,left: 0.014719757721406102d),
new NpgsqlTypes.NpgsqlBox(top: 0.5987297308640036d,right: 0.5519417079329849d,bottom: 0.5493089522422272d,left: 0.3103689881405717d),
new NpgsqlTypes.NpgsqlBox(top: 0.9559679818865511d,right: 0.7128533322533878d,bottom: 0.27334086777787847d,left: 0.6797778907581783d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.16393915727793695d,right: 0.8649038373881172d,bottom: 0.1577760375592837d,left: 0.48949939245577045d),
new NpgsqlTypes.NpgsqlBox(top: 0.9709620814290469d,right: 0.8217441799977124d,bottom: 0.4599258620413752d,left: 0.28692624992788807d),
new NpgsqlTypes.NpgsqlBox(top: 0.7458744473863271d,right: 0.20189524131374337d,bottom: 0.7274729141424932d,left: 0.05971629427578262d),
new NpgsqlTypes.NpgsqlBox(top: 0.5352709886653249d,right: 0.9034978467036291d,bottom: 0.12814513452315524d,left: 0.3498820223724506d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8237229012981213d,right: 0.3771952915287231d,bottom: 0.23074597520801887d,left: 0.14578682887310257d),
new NpgsqlTypes.NpgsqlBox(top: 0.9351955187063545d,right: 0.6937265042722272d,bottom: 0.24688229640918502d,left: 0.07764127928217712d),
new NpgsqlTypes.NpgsqlBox(top: 0.7634973320188743d,right: 0.7200635607098528d,bottom: 0.06902374444775294d,left: 0.6671197538824646d),
new NpgsqlTypes.NpgsqlBox(top: 0.45308441752732953d,right: 0.7809571705559462d,bottom: 0.018314725360766282d,left: 0.4666335763267987d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7451293760068641d,right: 0.5740425359005332d,bottom: 0.43937595133026053d,left: 0.13292350072644488d),
new NpgsqlTypes.NpgsqlBox(top: 0.4753941446609655d,right: 0.963954290558767d,bottom: 0.2862660929015567d,left: 0.430792986107298d),
new NpgsqlTypes.NpgsqlBox(top: 0.9559459554232681d,right: 0.6346450047160175d,bottom: 0.4352856884711723d,left: 0.5974571583818545d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3186442973253044d,right: 0.8453150562953737d,bottom: 0.1433277722590417d,left: 0.11101978040490357d),
new NpgsqlTypes.NpgsqlBox(top: 0.5060608729715103d,right: 0.8326252971213666d,bottom: 0.052375123750614594d,left: 0.12362733766444534d),
new NpgsqlTypes.NpgsqlBox(top: 0.364918317534362d,right: 0.5753306448739164d,bottom: 0.13737077528087782d,left: 0.14821762454085552d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8299818466834376d,right: 0.6111185777774789d,bottom: 0.5604442445492873d,left: 0.2969976553974829d),
new NpgsqlTypes.NpgsqlBox(top: 0.4808033657034937d,right: 0.5872386443337636d,bottom: 0.15056642037260282d,left: 0.3529307436893929d),
new NpgsqlTypes.NpgsqlBox(top: 0.48730942295683843d,right: 0.8591812839919354d,bottom: 0.33719595369921906d,left: 0.749561433926016d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.29625117504942433d,right: 0.6855026172033174d,bottom: 0.005208944939629312d,left: 0.20092360461457692d),
new NpgsqlTypes.NpgsqlBox(top: 0.8100782048958584d,right: 0.6160869915714476d,bottom: 0.06979688569833675d,left: 0.20153857097629346d),
new NpgsqlTypes.NpgsqlBox(top: 0.9479833266177449d,right: 0.4882679261148358d,bottom: 0.19310593732720027d,left: 0.25054217029611925d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.40370503927771484d,right: 0.8161956875193103d,bottom: 0.22284656260955804d,left: 0.027310611215022096d),
new NpgsqlTypes.NpgsqlBox(top: 0.73010715817359d,right: 0.6875302741638587d,bottom: 0.2704920741147502d,left: 0.09478381848872885d),
new NpgsqlTypes.NpgsqlBox(top: 0.8891765457739751d,right: 0.7365205320062872d,bottom: 0.4632657281109942d,left: 0.6729259977241064d),
new NpgsqlTypes.NpgsqlBox(top: 0.6500922634642478d,right: 0.9697198167502418d,bottom: 0.4053700629976741d,left: 0.11524444014104285d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4404931639322408d,right: 0.7947389313499571d,bottom: 0.06296882156750316d,left: 0.655442571380066d),
new NpgsqlTypes.NpgsqlBox(top: 0.886535662641868d,right: 0.7572982991672755d,bottom: 0.32524445012257774d,left: 0.41794593311925354d),
new NpgsqlTypes.NpgsqlBox(top: 0.8629115464593372d,right: 0.3279033847306635d,bottom: 0.37606993868237104d,left: 0.03651657509013195d),
new NpgsqlTypes.NpgsqlBox(top: 0.9868282677249234d,right: 0.9892216161689951d,bottom: 0.18862417418846722d,left: 0.34522594299076725d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6613006942941255d,right: 0.67573176514445d,bottom: 0.310729367876005d,left: 0.42725978980464163d),
new NpgsqlTypes.NpgsqlBox(top: 0.5836197203047064d,right: 0.6606536896548677d,bottom: 0.46003337807038225d,left: 0.3450788939009871d),
new NpgsqlTypes.NpgsqlBox(top: 0.6414245294495279d,right: 0.6835960089419187d,bottom: 0.4021075687726483d,left: 0.10941573279397232d),
new NpgsqlTypes.NpgsqlBox(top: 0.74558367929351d,right: 0.15974580189631882d,bottom: 0.27889021092375976d,left: 0.1464846731149072d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.49564066803817564d,right: 0.21264620345685625d,bottom: 0.35977418661458216d,left: 0.10013604869630777d),
new NpgsqlTypes.NpgsqlBox(top: 0.6051388288242888d,right: 0.48801547702009385d,bottom: 0.32343149463000187d,left: 0.4604356511935931d),
new NpgsqlTypes.NpgsqlBox(top: 0.2863260305667694d,right: 0.9926728314948584d,bottom: 0.034182589817937314d,left: 0.6143888552836227d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3344674954627517d,right: 0.5454039702093412d,bottom: 0.2888751787259467d,left: 0.38464836764957366d),
new NpgsqlTypes.NpgsqlBox(top: 0.829221507553439d,right: 0.6464928166933758d,bottom: 0.789909686748258d,left: 0.5212677430886282d),
new NpgsqlTypes.NpgsqlBox(top: 0.17429625169377894d,right: 0.8643766615738583d,bottom: 0.03658924820492959d,left: 0.3024877832820271d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.888747817522317d,right: 0.6826882403764527d,bottom: 0.2115671551996371d,left: 0.10263651163643372d),
new NpgsqlTypes.NpgsqlBox(top: 0.43492878981340033d,right: 0.9119543288776559d,bottom: 0.3326284852583816d,left: 0.41322127735648206d),
new NpgsqlTypes.NpgsqlBox(top: 0.33091959902223445d,right: 0.8796664723320733d,bottom: 0.16693330278903562d,left: 0.7834585615589591d),
new NpgsqlTypes.NpgsqlBox(top: 0.39371125383280026d,right: 0.8458889151413788d,bottom: 0.2672665007547246d,left: 0.5648961157990379d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8678495767371184d,right: 0.5140445889888801d,bottom: 0.3252941295225975d,left: 0.08778561553094377d),
new NpgsqlTypes.NpgsqlBox(top: 0.30921175115470734d,right: 0.8372724307990203d,bottom: 0.2859528832966396d,left: 0.5695380525058074d),
new NpgsqlTypes.NpgsqlBox(top: 0.6008306789900973d,right: 0.9761527738224692d,bottom: 0.037481692555553114d,left: 0.9136800908278091d),
new NpgsqlTypes.NpgsqlBox(top: 0.3105970235184564d,right: 0.4964750776437825d,bottom: 0.18218421055913747d,left: 0.43509336525222886d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5916916424569822d,right: 0.5449751046521351d,bottom: 0.35830685519149175d,left: 0.17143471581386638d),
new NpgsqlTypes.NpgsqlBox(top: 0.8190855999986062d,right: 0.6901667908276379d,bottom: 0.37249256108488293d,left: 0.17990705912235372d),
new NpgsqlTypes.NpgsqlBox(top: 0.9693207933155702d,right: 0.1672788312754765d,bottom: 0.30973654469932443d,left: 0.11944565103833171d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7179358305680235d,right: 0.35143801944399167d,bottom: 0.31161997078116377d,left: 0.1398817034259091d),
new NpgsqlTypes.NpgsqlBox(top: 0.8717885000219553d,right: 0.27151409809120086d,bottom: 0.017412892699222526d,left: 0.14323891376446585d),
new NpgsqlTypes.NpgsqlBox(top: 0.18433688588991493d,right: 0.4784879452216142d,bottom: 0.08513313421304103d,left: 0.05634277042401181d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.45100690988097725d,right: 0.6592470381900777d,bottom: 0.1566574156463938d,left: 0.1979367585299353d),
new NpgsqlTypes.NpgsqlBox(top: 0.799239891457712d,right: 0.7016811712035069d,bottom: 0.374213357942495d,left: 0.20333992482071261d),
new NpgsqlTypes.NpgsqlBox(top: 0.6632020146937391d,right: 0.607125662587715d,bottom: 0.25371985486552906d,left: 0.1594811975234227d),
new NpgsqlTypes.NpgsqlBox(top: 0.3273503749069576d,right: 0.46132867923043896d,bottom: 0.02926680249162672d,left: 0.38286626664260615d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7407521684985228d,right: 0.3209376109915264d,bottom: 0.018195251369396592d,left: 0.24409926949163463d),
new NpgsqlTypes.NpgsqlBox(top: 0.8849284382999082d,right: 0.3223382198314948d,bottom: 0.7303561633878898d,left: 0.059379890093142706d),
new NpgsqlTypes.NpgsqlBox(top: 0.997240866139266d,right: 0.3124560258301565d,bottom: 0.7599206277789066d,left: 0.09416140071301948d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6664070052149411d,right: 0.7346655160282723d,bottom: 0.13629184700430674d,left: 0.6305066266308508d),
new NpgsqlTypes.NpgsqlBox(top: 0.9840059798462116d,right: 0.8148234983111692d,bottom: 0.7346928028590782d,left: 0.10305371892178095d),
new NpgsqlTypes.NpgsqlBox(top: 0.9609635907967276d,right: 0.5148843912168731d,bottom: 0.47605107549929193d,left: 0.14631197852891042d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.10911345608916134d,right: 0.5406956487373022d,bottom: 0.017977203312801393d,left: 0.1397218059362838d),
new NpgsqlTypes.NpgsqlBox(top: 0.7009391080525428d,right: 0.389469047223699d,bottom: 0.004344127126853059d,left: 0.3131610091748205d),
new NpgsqlTypes.NpgsqlBox(top: 0.6841897044904889d,right: 0.9834503521527931d,bottom: 0.6762067404721434d,left: 0.5298299739794476d),
new NpgsqlTypes.NpgsqlBox(top: 0.8681129475334317d,right: 0.5361423519928327d,bottom: 0.6528454053353284d,left: 0.4952048691162799d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.565767192949932d,right: 0.6080390026706908d,bottom: 0.03066564884896883d,left: 0.1583950536141574d),
new NpgsqlTypes.NpgsqlBox(top: 0.4420879063883437d,right: 0.4499374747590289d,bottom: 0.0321736164048656d,left: 0.40499346024026794d),
new NpgsqlTypes.NpgsqlBox(top: 0.4627372285348832d,right: 0.5159032713713549d,bottom: 0.3276923108678974d,left: 0.030396338598215777d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.45820729511581004d,right: 0.8497832187785223d,bottom: 0.4530832187122157d,left: 0.13969316292041634d),
new NpgsqlTypes.NpgsqlBox(top: 0.7034209069144454d,right: 0.7230112368382543d,bottom: 0.36721237845696697d,left: 0.13503333940310247d),
new NpgsqlTypes.NpgsqlBox(top: 0.7654303485331386d,right: 0.898466970935902d,bottom: 0.1267102475715307d,left: 0.8612804447268154d),
new NpgsqlTypes.NpgsqlBox(top: 0.5316647020291292d,right: 0.8660667339141424d,bottom: 0.5102881617213262d,left: 0.5168645209240768d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.70326530134728d,right: 0.8583777438684506d,bottom: 0.2696305402178385d,left: 0.1821502899177615d),
new NpgsqlTypes.NpgsqlBox(top: 0.50449869947894d,right: 0.8773471829465499d,bottom: 0.27529061401248633d,left: 0.5312770885382292d),
new NpgsqlTypes.NpgsqlBox(top: 0.5350230007132907d,right: 0.41002171993305525d,bottom: 0.20373396770093732d,left: 0.1814431548402341d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6827476601411631d,right: 0.5530770731752267d,bottom: 0.07557699914969362d,left: 0.17242970031338178d),
new NpgsqlTypes.NpgsqlBox(top: 0.898399147567107d,right: 0.6035885495393916d,bottom: 0.8130585895758643d,left: 0.31625535114074255d),
new NpgsqlTypes.NpgsqlBox(top: 0.992544828751961d,right: 0.43940433865828477d,bottom: 0.07774787896840474d,left: 0.3445187260675381d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.715410137101695d,right: 0.44156792829848324d,bottom: 0.4182958222821811d,left: 0.34816936687540967d),
new NpgsqlTypes.NpgsqlBox(top: 0.7857173673218955d,right: 0.8251609870926532d,bottom: 0.487127745713568d,left: 0.7642856002880346d),
new NpgsqlTypes.NpgsqlBox(top: 0.9799396992921684d,right: 0.530919285831296d,bottom: 0.16788901317019822d,left: 0.13365672239963244d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9767059713371735d,right: 0.7311668281810256d,bottom: 0.28564351201701554d,left: 0.25554897719747893d),
new NpgsqlTypes.NpgsqlBox(top: 0.5665223250210714d,right: 0.20211075355444474d,bottom: 0.09949383085629893d,left: 0.0747264597503502d),
new NpgsqlTypes.NpgsqlBox(top: 0.7130181664559756d,right: 0.9600217291240889d,bottom: 0.6253723516448647d,left: 0.9486324913497082d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7098568247993036d,right: 0.5844191866091003d,bottom: 0.48703841245624524d,left: 0.4271521422183533d),
new NpgsqlTypes.NpgsqlBox(top: 0.3127028164485599d,right: 0.4327557339968524d,bottom: 0.1706156939402773d,left: 0.017361469890828873d),
new NpgsqlTypes.NpgsqlBox(top: 0.8759400332676798d,right: 0.9381172116042792d,bottom: 0.17161317665989984d,left: 0.24140840002154995d),
new NpgsqlTypes.NpgsqlBox(top: 0.7699543635374692d,right: 0.9668621706091558d,bottom: 0.24389452368034747d,left: 0.8653867407329936d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9868497405900726d,right: 0.6564058166617855d,bottom: 0.5906768083797113d,left: 0.5763773423225876d),
new NpgsqlTypes.NpgsqlBox(top: 0.42828880634323563d,right: 0.8393441196275396d,bottom: 0.3964292101875667d,left: 0.6840113678341639d),
new NpgsqlTypes.NpgsqlBox(top: 0.9833978272417022d,right: 0.8707489225538747d,bottom: 0.3207512006779669d,left: 0.7608821271047633d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8230822295534617d,right: 0.4212650374277369d,bottom: 0.7405824342040483d,left: 0.08482549672212236d),
new NpgsqlTypes.NpgsqlBox(top: 0.9844280653418552d,right: 0.21196218125751876d,bottom: 0.6196336792020467d,left: 0.11438479483762343d),
new NpgsqlTypes.NpgsqlBox(top: 0.6855258251772187d,right: 0.6844467954780252d,bottom: 0.2784139622037277d,left: 0.6369375146475926d),
new NpgsqlTypes.NpgsqlBox(top: 0.9415078527309216d,right: 0.9970526234418449d,bottom: 0.4980429303055677d,left: 0.29051812752084283d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.36513642931214574d,right: 0.47893923713380226d,bottom: 0.2098822500755062d,left: 0.46171989293559623d),
new NpgsqlTypes.NpgsqlBox(top: 0.6686505296159891d,right: 0.9741692080225118d,bottom: 0.3946104267171402d,left: 0.5336965288384133d),
new NpgsqlTypes.NpgsqlBox(top: 0.6838923993176543d,right: 0.8276146163015086d,bottom: 0.14920040025855952d,left: 0.23562079043833595d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7845109467883262d,right: 0.44857267773928844d,bottom: 0.3665965380656224d,left: 0.08366634799710548d),
new NpgsqlTypes.NpgsqlBox(top: 0.8575046289224078d,right: 0.8474578033428177d,bottom: 0.8544674118876538d,left: 0.35512260643575466d),
new NpgsqlTypes.NpgsqlBox(top: 0.7506763789292341d,right: 0.4873959164624586d,bottom: 0.6716262551708397d,left: 0.33753121093224037d),
new NpgsqlTypes.NpgsqlBox(top: 0.4060293092873317d,right: 0.3193310655966255d,bottom: 0.35095052820188055d,left: 0.11316746048870907d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
INSERT INTO public.npgsqlboxboxmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)), 
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
                methodParametrName: "npgsqlboxboxmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd1e1mi_id
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
    npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7526193134117547d,right: 0.27999925540467574d,bottom: 0.059716701703460884d,left: 0.18681489791936234d),
new NpgsqlTypes.NpgsqlBox(top: 0.9610870636491912d,right: 0.41177505773950085d,bottom: 0.8972820311532207d,left: 0.32083351478042554d),
new NpgsqlTypes.NpgsqlBox(top: 0.6387132577247474d,right: 0.6104492969668397d,bottom: 0.6227579321509403d,left: 0.470551867659184d),
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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd1e1mi_id
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
    npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                methodParametrName: "npgsqlboxboxmmarrayd1e1mi_id", 
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
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7763180195436484d,right: 0.5196012472822166d,bottom: 0.2990338492733188d,left: 0.4156608238996048d),
new NpgsqlTypes.NpgsqlBox(top: 0.7693750888074725d,right: 0.37988519783717545d,bottom: 0.4546286659446568d,left: 0.009694227202872274d),
new NpgsqlTypes.NpgsqlBox(top: 0.4884379969921856d,right: 0.5753852893732717d,bottom: 0.0265174289426785d,left: 0.5038754018888624d),
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
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8816488069332825d,right: 0.8073186001711647d,bottom: 0.05265006097000502d,left: 0.34114218886749337d),
new NpgsqlTypes.NpgsqlBox(top: 0.40668707460724574d,right: 0.8376848491126243d,bottom: 0.20271831661802575d,left: 0.7934694910735463d),
new NpgsqlTypes.NpgsqlBox(top: 0.6877058239830715d,right: 0.5387534225322762d,bottom: 0.43448518411793435d,left: 0.4510180344823913d),
new NpgsqlTypes.NpgsqlBox(top: 0.8185713906732004d,right: 0.6042683040917155d,bottom: 0.2740513270538272d,left: 0.5708782434717152d),
}));
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8038650373176751d,right: 0.6241749900529814d,bottom: 0.37298188228534923d,left: 0.052560386353880606d),
new NpgsqlTypes.NpgsqlBox(top: 0.9532961642185513d,right: 0.350632937035224d,bottom: 0.8041728552626547d,left: 0.11842761415815695d),
new NpgsqlTypes.NpgsqlBox(top: 0.5704691744899263d,right: 0.8238270224872536d,bottom: 0.15733641005779575d,left: 0.421333443304554d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD1E1M> models = null;

                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD1E1M> models = null;

                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 33, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 6, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 162, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 63, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 27, query1, 82, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 148, query1, 133, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 74, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 59, query1, 120, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 23, 59))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 6, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxMArrayboxMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxMArrayboxMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 113);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxMArrayboxMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxMArrayboxMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MIWA),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MI),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
FROM public.binary_npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA), typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA), typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI), typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA), typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

