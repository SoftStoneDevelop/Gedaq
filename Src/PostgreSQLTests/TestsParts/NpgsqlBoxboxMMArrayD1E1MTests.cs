

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
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3576735742524747d,right: 0.9538794635520312d,bottom: 0.23765674810225756d,left: 0.6604903129261628d),
new NpgsqlTypes.NpgsqlBox(top: 0.672100729914471d,right: 0.731036057331537d,bottom: 0.162683980574174d,left: 0.20316270012578752d),
new NpgsqlTypes.NpgsqlBox(top: 0.36928447134324327d,right: 0.4682590863516747d,bottom: 0.23309423129614915d,left: 0.21514142608237252d),
new NpgsqlTypes.NpgsqlBox(top: 0.9176448374900245d,right: 0.20508731705350292d,bottom: 0.4101578974422586d,left: 0.13305075842124814d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8755541932150486d,right: 0.7882432406692773d,bottom: 0.8090247247578083d,left: 0.7569223781025355d),
new NpgsqlTypes.NpgsqlBox(top: 0.6905677032088351d,right: 0.9614077877696533d,bottom: 0.37129670963208516d,left: 0.6481808101222468d),
new NpgsqlTypes.NpgsqlBox(top: 0.2863304208115678d,right: 0.8795716516059573d,bottom: 0.22969199541301555d,left: 0.7648685084116639d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8481710118787638d,right: 0.2805764147940514d,bottom: 0.7746783658171261d,left: 0.22709205130715604d),
new NpgsqlTypes.NpgsqlBox(top: 0.47432618655016845d,right: 0.6231520374475913d,bottom: 0.31576131873831514d,left: 0.4599875678606481d),
new NpgsqlTypes.NpgsqlBox(top: 0.5031490122079766d,right: 0.7195907508230417d,bottom: 0.3193016655735582d,left: 0.6594118055525706d),
new NpgsqlTypes.NpgsqlBox(top: 0.9862700228698986d,right: 0.9679455649660245d,bottom: 0.8729300395918095d,left: 0.9399833369710954d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8306335804316927d,right: 0.8594256826039728d,bottom: 0.5552219084597494d,left: 0.37221124873689637d),
new NpgsqlTypes.NpgsqlBox(top: 0.31692481403155404d,right: 0.38390985364555996d,bottom: 0.2529507535765242d,left: 0.277200035193246d),
new NpgsqlTypes.NpgsqlBox(top: 0.657063283901043d,right: 0.9805645138441357d,bottom: 0.15789881513114024d,left: 0.21396695646674013d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7347694926683893d,right: 0.7672364493207299d,bottom: 0.6145576688422747d,left: 0.11999833460659948d),
new NpgsqlTypes.NpgsqlBox(top: 0.40565757067550534d,right: 0.5567598642990553d,bottom: 0.0815053490855745d,left: 0.3275418172099841d),
new NpgsqlTypes.NpgsqlBox(top: 0.7519689137109313d,right: 0.7359733646971504d,bottom: 0.32350904942786696d,left: 0.03741688925894948d),
new NpgsqlTypes.NpgsqlBox(top: 0.7310867390712678d,right: 0.8905863035984836d,bottom: 0.10994739230869177d,left: 0.6002677960186d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5840942275422345d,right: 0.5976242872202735d,bottom: 0.12314204369706727d,left: 0.5739206949255135d),
new NpgsqlTypes.NpgsqlBox(top: 0.27056949485396d,right: 0.7528378563885791d,bottom: 0.22605439875045719d,left: 0.6731952603288192d),
new NpgsqlTypes.NpgsqlBox(top: 0.33552878438419553d,right: 0.07068642266438918d,bottom: 0.07105849629401328d,left: 0.020573231462741592d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9805403878321229d,right: 0.7456077927225944d,bottom: 0.7039628710458241d,left: 0.34655364966247093d),
new NpgsqlTypes.NpgsqlBox(top: 0.6444382899495958d,right: 0.28811268395325607d,bottom: 0.06755414145997363d,left: 0.06666484910565063d),
new NpgsqlTypes.NpgsqlBox(top: 0.8277744145490337d,right: 0.7464340320780393d,bottom: 0.03890007845389387d,left: 0.373687288699335d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8780178189286506d,right: 0.47875794473262634d,bottom: 0.41751359288296386d,left: 0.04834321287203014d),
new NpgsqlTypes.NpgsqlBox(top: 0.4132225439900937d,right: 0.8939255291357171d,bottom: 0.1667007537546381d,left: 0.16688911081502078d),
new NpgsqlTypes.NpgsqlBox(top: 0.528989773994347d,right: 0.9275740172018127d,bottom: 0.48963244512122317d,left: 0.7466986804291159d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9423063782129089d,right: 0.9407521888448204d,bottom: 0.01158632745554411d,left: 0.44146859793600024d),
new NpgsqlTypes.NpgsqlBox(top: 0.691398273112831d,right: 0.43465643837729817d,bottom: 0.26335794584773187d,left: 0.23795199729485572d),
new NpgsqlTypes.NpgsqlBox(top: 0.7835092698261641d,right: 0.7133157957891948d,bottom: 0.01660054856644222d,left: 0.5948684649731133d),
new NpgsqlTypes.NpgsqlBox(top: 0.8864564762914153d,right: 0.6270776417704403d,bottom: 0.8794859677168172d,left: 0.5524040608864691d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3925418561050916d,right: 0.9578161954531651d,bottom: 0.08542208046819755d,left: 0.41353687702140207d),
new NpgsqlTypes.NpgsqlBox(top: 0.12823494257342072d,right: 0.39928314595198755d,bottom: 0.11480081342474191d,left: 0.277462343672238d),
new NpgsqlTypes.NpgsqlBox(top: 0.8168935485798632d,right: 0.9843655154967464d,bottom: 0.19738518598728305d,left: 0.8500551448144367d),
new NpgsqlTypes.NpgsqlBox(top: 0.32887701096116984d,right: 0.6586078078491449d,bottom: 0.013648732716522893d,left: 0.516210391117742d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8238744202004202d,right: 0.7008457905841492d,bottom: 0.24461468206396464d,left: 0.6300479617483868d),
new NpgsqlTypes.NpgsqlBox(top: 0.4650557556650392d,right: 0.4158408713018815d,bottom: 0.34324292922561084d,left: 0.33203894528522837d),
new NpgsqlTypes.NpgsqlBox(top: 0.9453640764953141d,right: 0.8292416111481591d,bottom: 0.8457820085641046d,left: 0.14384294919037754d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.759014253914775d,right: 0.9077205849843349d,bottom: 0.017592279458974125d,left: 0.25845191145141d),
new NpgsqlTypes.NpgsqlBox(top: 0.9568660441477427d,right: 0.7995764986473474d,bottom: 0.6012451226098879d,left: 0.22169379800266664d),
new NpgsqlTypes.NpgsqlBox(top: 0.2547274837801027d,right: 0.5498981024471224d,bottom: 0.16043944098466856d,left: 0.3430318327391355d),
new NpgsqlTypes.NpgsqlBox(top: 0.7525634343113298d,right: 0.24355766338280704d,bottom: 0.7155390084428225d,left: 0.04435324885774039d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9242344234539956d,right: 0.9936578091940226d,bottom: 0.03315063239183891d,left: 0.08016781341403156d),
new NpgsqlTypes.NpgsqlBox(top: 0.9911085022213166d,right: 0.9167262612972678d,bottom: 0.8520228611016678d,left: 0.5742142699018437d),
new NpgsqlTypes.NpgsqlBox(top: 0.5308425428258516d,right: 0.33481053319819454d,bottom: 0.45307096923153933d,left: 0.32210611823279656d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3173359316044836d,right: 0.8715619968416997d,bottom: 0.02114546376138471d,left: 0.5612073380557723d),
new NpgsqlTypes.NpgsqlBox(top: 0.6658110025411573d,right: 0.8337966107634498d,bottom: 0.16256460176093146d,left: 0.25020592903297256d),
new NpgsqlTypes.NpgsqlBox(top: 0.8220828905913289d,right: 0.7870714564493577d,bottom: 0.21628384722457272d,left: 0.1294665130897653d),
new NpgsqlTypes.NpgsqlBox(top: 0.974978499764432d,right: 0.9224913138285098d,bottom: 0.1440364317422299d,left: 0.8497258831156369d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7923055784920384d,right: 0.8354167383438983d,bottom: 0.35322360694506383d,left: 0.40474403322716057d),
new NpgsqlTypes.NpgsqlBox(top: 0.22450056782658168d,right: 0.676971296096082d,bottom: 0.06497464376756712d,left: 0.4680482459306555d),
new NpgsqlTypes.NpgsqlBox(top: 0.9399393871987766d,right: 0.646021231164114d,bottom: 0.7841525098332912d,left: 0.05304305949504118d),
new NpgsqlTypes.NpgsqlBox(top: 0.4860370601129502d,right: 0.8563181103364697d,bottom: 0.1657750780042596d,left: 0.020993394384297814d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5984611380701648d,right: 0.035879719162711154d,bottom: 0.1660265128191607d,left: 0.0033324513767092334d),
new NpgsqlTypes.NpgsqlBox(top: 0.18405698570826157d,right: 0.7599305270361999d,bottom: 0.14976581158543345d,left: 0.7486307912684116d),
new NpgsqlTypes.NpgsqlBox(top: 0.6722650297201654d,right: 0.8967079381535601d,bottom: 0.30174666181731236d,left: 0.650954153766045d),
new NpgsqlTypes.NpgsqlBox(top: 0.6122647110301092d,right: 0.8401223176874398d,bottom: 0.07224022523940721d,left: 0.5383601250076084d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6472337776530649d,right: 0.7670855582592631d,bottom: 0.417726391169683d,left: 0.7663973408179873d),
new NpgsqlTypes.NpgsqlBox(top: 0.5057264633812122d,right: 0.4460022019198171d,bottom: 0.01054942443130813d,left: 0.17568652713063093d),
new NpgsqlTypes.NpgsqlBox(top: 0.25132536559264473d,right: 0.8920531806529104d,bottom: 0.06963927906204459d,left: 0.7020125138172634d),
new NpgsqlTypes.NpgsqlBox(top: 0.32752843414003774d,right: 0.9983751516932196d,bottom: 0.12197034039008603d,left: 0.23332244476810493d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.49673296452213345d,right: 0.7353908466311527d,bottom: 0.1736283382339202d,left: 0.562651924419027d),
new NpgsqlTypes.NpgsqlBox(top: 0.6417638835427212d,right: 0.8704730647141636d,bottom: 0.036068563217665384d,left: 0.09245031592359698d),
new NpgsqlTypes.NpgsqlBox(top: 0.8467982282460944d,right: 0.870708310681811d,bottom: 0.4013444936706583d,left: 0.28204499359205204d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9163298873552278d,right: 0.474263060573224d,bottom: 0.47325980655450495d,left: 0.2457300816434359d),
new NpgsqlTypes.NpgsqlBox(top: 0.5188057062345802d,right: 0.9701294443879505d,bottom: 0.18063984079722017d,left: 0.950491097431491d),
new NpgsqlTypes.NpgsqlBox(top: 0.9692623789363775d,right: 0.8187717738353001d,bottom: 0.9622467538104288d,left: 0.5885439597411988d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8608633970596841d,right: 0.4620722973325515d,bottom: 0.3856153791112067d,left: 0.09901846384451862d),
new NpgsqlTypes.NpgsqlBox(top: 0.9777368635741568d,right: 0.8321171614615038d,bottom: 0.8422987473202768d,left: 0.46445960749639614d),
new NpgsqlTypes.NpgsqlBox(top: 0.6378267520622395d,right: 0.8306445435798082d,bottom: 0.414260031941575d,left: 0.4926139432725686d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7531319411096564d,right: 0.34624121394738894d,bottom: 0.527894320608966d,left: 0.18706732833333162d),
new NpgsqlTypes.NpgsqlBox(top: 0.6289611246113788d,right: 0.720162265203228d,bottom: 0.12274977911348695d,left: 0.4265883985874849d),
new NpgsqlTypes.NpgsqlBox(top: 0.9419645205741031d,right: 0.9755072609346221d,bottom: 0.7558761855642568d,left: 0.4622989690493332d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.809455242499811d,right: 0.22134259248444577d,bottom: 0.4597324756446204d,left: 0.20235405126244232d),
new NpgsqlTypes.NpgsqlBox(top: 0.7174089945353861d,right: 0.8857008466375884d,bottom: 0.5793773724520694d,left: 0.5670459004133469d),
new NpgsqlTypes.NpgsqlBox(top: 0.26306848714754494d,right: 0.7522654254959338d,bottom: 0.10207290656555079d,left: 0.3948987005335204d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6224089133535089d,right: 0.915042371309923d,bottom: 0.010833961735169373d,left: 0.2353074852272221d),
new NpgsqlTypes.NpgsqlBox(top: 0.897214038910514d,right: 0.6575050743956302d,bottom: 0.17082153969404756d,left: 0.3141870702066156d),
new NpgsqlTypes.NpgsqlBox(top: 0.2118313502928224d,right: 0.9330376786261861d,bottom: 0.11923713562725335d,left: 0.81273504120556d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8205918556141041d,right: 0.9989130047000245d,bottom: 0.7414235680966169d,left: 0.07455581910399078d),
new NpgsqlTypes.NpgsqlBox(top: 0.7027073307803522d,right: 0.6329599821167431d,bottom: 0.5501733139582561d,left: 0.35947395649170644d),
new NpgsqlTypes.NpgsqlBox(top: 0.6000754989223955d,right: 0.7233924037824339d,bottom: 0.4672569622347337d,left: 0.7036496034629085d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.752896490352807d,right: 0.8512237367808437d,bottom: 0.3748089389136443d,left: 0.05582333592253874d),
new NpgsqlTypes.NpgsqlBox(top: 0.6939076618714319d,right: 0.6873075925016658d,bottom: 0.5390634484683454d,left: 0.6586155779189248d),
new NpgsqlTypes.NpgsqlBox(top: 0.6555230473901233d,right: 0.34930457542058524d,bottom: 0.4012223995414448d,left: 0.3302134392261008d),
new NpgsqlTypes.NpgsqlBox(top: 0.653886231624488d,right: 0.30494625868577907d,bottom: 0.30584834644135894d,left: 0.18458011328817603d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7492461260384017d,right: 0.9707641489693818d,bottom: 0.1713838079616974d,left: 0.5679757819427123d),
new NpgsqlTypes.NpgsqlBox(top: 0.9511768995416674d,right: 0.8749499523460705d,bottom: 0.0715116739221966d,left: 0.3935808259662691d),
new NpgsqlTypes.NpgsqlBox(top: 0.9888904924705197d,right: 0.6335652421840176d,bottom: 0.8045796224413919d,left: 0.5546596364799206d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9612342556863156d,right: 0.794539646927182d,bottom: 0.8257069116648779d,left: 0.19449169581197734d),
new NpgsqlTypes.NpgsqlBox(top: 0.5617628717199225d,right: 0.9269532180734251d,bottom: 0.23006559546390692d,left: 0.6364223399736625d),
new NpgsqlTypes.NpgsqlBox(top: 0.171857622920203d,right: 0.2931521776176661d,bottom: 0.09350984543809693d,left: 0.04735140563268303d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8415151833826777d,right: 0.4291083024324587d,bottom: 0.5887967217761341d,left: 0.35752282489417286d),
new NpgsqlTypes.NpgsqlBox(top: 0.5156348729952672d,right: 0.6950365311533291d,bottom: 0.2849559818091376d,left: 0.6823459813326236d),
new NpgsqlTypes.NpgsqlBox(top: 0.7460395081046807d,right: 0.8921795258566397d,bottom: 0.25751178213369674d,left: 0.5715013877529955d),
new NpgsqlTypes.NpgsqlBox(top: 0.9601789968682469d,right: 0.3503026919904343d,bottom: 0.36288334302865266d,left: 0.18529964109657726d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6818701589585815d,right: 0.9391993429506981d,bottom: 0.04426998563166462d,left: 0.8178095424175086d),
new NpgsqlTypes.NpgsqlBox(top: 0.9429754486404559d,right: 0.8944055088961047d,bottom: 0.12266122831018778d,left: 0.6477113149222128d),
new NpgsqlTypes.NpgsqlBox(top: 0.6404175980965773d,right: 0.9058722856238031d,bottom: 0.07122574284938721d,left: 0.03471343301165697d),
new NpgsqlTypes.NpgsqlBox(top: 0.36809999153688766d,right: 0.259082815715755d,bottom: 0.3670579848584392d,left: 0.17356408645431298d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8132596914582109d,right: 0.6336028794483053d,bottom: 0.5829669436888903d,left: 0.3330366997136067d),
new NpgsqlTypes.NpgsqlBox(top: 0.9744523215389623d,right: 0.7855426009942765d,bottom: 0.3709936227192824d,left: 0.3023292956399303d),
new NpgsqlTypes.NpgsqlBox(top: 0.5078237825658741d,right: 0.9598276825399996d,bottom: 0.15131124027943776d,left: 0.9585221271791857d),
new NpgsqlTypes.NpgsqlBox(top: 0.4265396501646088d,right: 0.32846450436800834d,bottom: 0.3763061050071632d,left: 0.1904818427123206d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9920923992297156d,right: 0.7396535836697428d,bottom: 0.2362148320511519d,left: 0.1832317322567245d),
new NpgsqlTypes.NpgsqlBox(top: 0.7549584735507171d,right: 0.7705651503045025d,bottom: 0.36095603767569995d,left: 0.30640908158568714d),
new NpgsqlTypes.NpgsqlBox(top: 0.9712474522883751d,right: 0.6156152039178352d,bottom: 0.047108148817537d,left: 0.08244184223841777d),
new NpgsqlTypes.NpgsqlBox(top: 0.901659239521378d,right: 0.5022922110852103d,bottom: 0.5696801076426801d,left: 0.4827885592067468d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7127463961425489d,right: 0.6014904830047586d,bottom: 0.5055272003715127d,left: 0.3843950684650911d),
new NpgsqlTypes.NpgsqlBox(top: 0.8614679302622167d,right: 0.14347820904565478d,bottom: 0.3757333295960621d,left: 0.12189675543557965d),
new NpgsqlTypes.NpgsqlBox(top: 0.8244262681475778d,right: 0.5100431243435742d,bottom: 0.49823542505241414d,left: 0.37165252773980484d),
new NpgsqlTypes.NpgsqlBox(top: 0.8607889671712043d,right: 0.4987791477547566d,bottom: 0.25267292484898896d,left: 0.16079304048752896d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.552272571750397d,right: 0.7491825675357556d,bottom: 0.4596730144658484d,left: 0.5418926976489779d),
new NpgsqlTypes.NpgsqlBox(top: 0.7657349773442541d,right: 0.8508531129246227d,bottom: 0.4113224953752598d,left: 0.7627136245651948d),
new NpgsqlTypes.NpgsqlBox(top: 0.3713586260533146d,right: 0.7423393995389342d,bottom: 0.02916086603159973d,left: 0.6790367578087192d),
new NpgsqlTypes.NpgsqlBox(top: 0.4201576923435699d,right: 0.5646818431815203d,bottom: 0.026554795890863292d,left: 0.14275785499937343d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.693631262566328d,right: 0.10008924712510647d,bottom: 0.07361939785211014d,left: 0.03456406477242868d),
new NpgsqlTypes.NpgsqlBox(top: 0.9766542827692145d,right: 0.5222747768027095d,bottom: 0.8484939726381113d,left: 0.047114288978400864d),
new NpgsqlTypes.NpgsqlBox(top: 0.6604021826386659d,right: 0.803745917403317d,bottom: 0.5018960408088646d,left: 0.6258480492089779d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7910606971066076d,right: 0.9660275372149645d,bottom: 0.3873975116666948d,left: 0.7905991767965959d),
new NpgsqlTypes.NpgsqlBox(top: 0.9044310451680774d,right: 0.9635340463937634d,bottom: 0.676168879492678d,left: 0.7726640647893357d),
new NpgsqlTypes.NpgsqlBox(top: 0.9528962030002518d,right: 0.8592978658080934d,bottom: 0.8719874950209724d,left: 0.44667550619882346d),
new NpgsqlTypes.NpgsqlBox(top: 0.459788966344997d,right: 0.9555849268195377d,bottom: 0.20205914684399706d,left: 0.16129308014945676d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5682461927156912d,right: 0.1880043274610842d,bottom: 0.5502454163317675d,left: 0.14773423873688496d),
new NpgsqlTypes.NpgsqlBox(top: 0.6047204433046806d,right: 0.733713375917886d,bottom: 0.4864076752046649d,left: 0.2707468632597394d),
new NpgsqlTypes.NpgsqlBox(top: 0.44880448168781595d,right: 0.491566978429556d,bottom: 0.04479822814721668d,left: 0.4464857868964154d),
new NpgsqlTypes.NpgsqlBox(top: 0.6841596562830536d,right: 0.4482556060861397d,bottom: 0.6760891866857457d,left: 0.40180759823176826d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8559778695652526d,right: 0.71418409037876d,bottom: 0.7689172232061914d,left: 0.5528017853939754d),
new NpgsqlTypes.NpgsqlBox(top: 0.27297230495942015d,right: 0.6954982768322358d,bottom: 0.13512314206838782d,left: 0.09585330767095135d),
new NpgsqlTypes.NpgsqlBox(top: 0.44060316968903745d,right: 0.5116440431765579d,bottom: 0.004500450073102402d,left: 0.013949533307074491d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.41631803640789145d,right: 0.3131696241133608d,bottom: 0.04226397060226994d,left: 0.16426676004510277d),
new NpgsqlTypes.NpgsqlBox(top: 0.5785615394110266d,right: 0.7348928688930783d,bottom: 0.10616277275045782d,left: 0.20509037821838894d),
new NpgsqlTypes.NpgsqlBox(top: 0.6806278427188318d,right: 0.27929710433784516d,bottom: 0.20075255613617704d,left: 0.1658866648530798d),
new NpgsqlTypes.NpgsqlBox(top: 0.6409302717848202d,right: 0.9609793784368211d,bottom: 0.4168735928235575d,left: 0.16002128462794485d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8645259375919306d,right: 0.5839040413783688d,bottom: 0.8112057831165642d,left: 0.19400368056847972d),
new NpgsqlTypes.NpgsqlBox(top: 0.9325735189556646d,right: 0.6777459476158163d,bottom: 0.7742227487605449d,left: 0.6687909724866605d),
new NpgsqlTypes.NpgsqlBox(top: 0.9962977799513583d,right: 0.8742206133979255d,bottom: 0.535927578670669d,left: 0.13710216081029925d),
new NpgsqlTypes.NpgsqlBox(top: 0.6649643516899895d,right: 0.3885898858849609d,bottom: 0.5865616291400415d,left: 0.3517137912740069d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.40635460111943655d,right: 0.8314945799331634d,bottom: 0.3787188751999244d,left: 0.1549684217104923d),
new NpgsqlTypes.NpgsqlBox(top: 0.7073069262281216d,right: 0.7681106920153598d,bottom: 0.1766611677190223d,left: 0.18023778626692466d),
new NpgsqlTypes.NpgsqlBox(top: 0.11734189455860444d,right: 0.7500793364438811d,bottom: 0.10051307909326002d,left: 0.5476008128600797d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9341219892144973d,right: 0.8131875076671881d,bottom: 0.8798439484707513d,left: 0.48177016510733306d),
new NpgsqlTypes.NpgsqlBox(top: 0.9732531494255656d,right: 0.9285298048518249d,bottom: 0.4270151507476633d,left: 0.02794395798752547d),
new NpgsqlTypes.NpgsqlBox(top: 0.3578840353765984d,right: 0.6368338143369713d,bottom: 0.1483162303544746d,left: 0.15303000306730408d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7739142344883249d,right: 0.31162583949043554d,bottom: 0.013295600589622647d,left: 0.15084822446238433d),
new NpgsqlTypes.NpgsqlBox(top: 0.5388682073503893d,right: 0.9868957271437367d,bottom: 0.07536259914636712d,left: 0.23088475740593073d),
new NpgsqlTypes.NpgsqlBox(top: 0.36167242733989535d,right: 0.9692884927302252d,bottom: 0.1089296141006676d,left: 0.36531091220105394d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.83341099106638d,right: 0.6212321279764205d,bottom: 0.047201133202677825d,left: 0.531694954066174d),
new NpgsqlTypes.NpgsqlBox(top: 0.878598588096667d,right: 0.6582525807506546d,bottom: 0.8657142952057866d,left: 0.09708143302289218d),
new NpgsqlTypes.NpgsqlBox(top: 0.7405241881429669d,right: 0.10789020649963899d,bottom: 0.22758546678474056d,left: 0.09638049082068656d),
new NpgsqlTypes.NpgsqlBox(top: 0.9594432633987607d,right: 0.8346530156102355d,bottom: 0.23673380041507974d,left: 0.8269642037334769d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2822853381409838d,right: 0.6224240609511549d,bottom: 0.2006242810638288d,left: 0.5866753433576738d),
new NpgsqlTypes.NpgsqlBox(top: 0.9669211418656429d,right: 0.6654380786125567d,bottom: 0.2197416376870539d,left: 0.4821741553351887d),
new NpgsqlTypes.NpgsqlBox(top: 0.679063729664205d,right: 0.6481210878473944d,bottom: 0.1814130922534939d,left: 0.5962124812954576d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9508616271323681d,right: 0.5216973169944303d,bottom: 0.09409052028132847d,left: 0.13103274013700794d),
new NpgsqlTypes.NpgsqlBox(top: 0.8549653429489363d,right: 0.9351962588108566d,bottom: 0.796220558797938d,left: 0.1369020572776195d),
new NpgsqlTypes.NpgsqlBox(top: 0.5102338961519061d,right: 0.4713697112217612d,bottom: 0.42320594528316835d,left: 0.056348976401063844d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2562733542622926d,right: 0.6003832080528043d,bottom: 0.19226863451590015d,left: 0.08240169611469994d),
new NpgsqlTypes.NpgsqlBox(top: 0.9549567942722078d,right: 0.38050701320315305d,bottom: 0.3539115535041122d,left: 0.3106901713491782d),
new NpgsqlTypes.NpgsqlBox(top: 0.8918381744982704d,right: 0.8145602133854241d,bottom: 0.5812467056022801d,left: 0.6116351908722915d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6260471201475388d,right: 0.9620027549435773d,bottom: 0.594779299313583d,left: 0.28030215296546657d),
new NpgsqlTypes.NpgsqlBox(top: 0.6953927063370056d,right: 0.15320227546211584d,bottom: 0.43428584422297034d,left: 0.008489822498556676d),
new NpgsqlTypes.NpgsqlBox(top: 0.9234185463913922d,right: 0.20316355761574434d,bottom: 0.6751751034679383d,left: 0.1740472993210932d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.983877509414997d,right: 0.3124886672826579d,bottom: 0.7854391387728634d,left: 0.1057380093265432d),
new NpgsqlTypes.NpgsqlBox(top: 0.6318237472839329d,right: 0.838172963518506d,bottom: 0.4130550582085726d,left: 0.6284714408999734d),
new NpgsqlTypes.NpgsqlBox(top: 0.6141557883119939d,right: 0.7088585534306568d,bottom: 0.11326692065908917d,left: 0.012900659732750341d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5991671627699493d,right: 0.4362202260426732d,bottom: 0.07384477004672707d,left: 0.40532841973780076d),
new NpgsqlTypes.NpgsqlBox(top: 0.9442487181710149d,right: 0.6940979019066615d,bottom: 0.652422708007394d,left: 0.27957954232680504d),
new NpgsqlTypes.NpgsqlBox(top: 0.4101117628575437d,right: 0.6489061028307984d,bottom: 0.2974845943220872d,left: 0.08255600921420969d),
new NpgsqlTypes.NpgsqlBox(top: 0.7564514499916567d,right: 0.8063820633300748d,bottom: 0.6604492587160633d,left: 0.7198321267312162d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.779179254960468d,right: 0.4700650060515128d,bottom: 0.2666719510975829d,left: 0.10462347184249787d),
new NpgsqlTypes.NpgsqlBox(top: 0.3603234663470004d,right: 0.7465130408768816d,bottom: 0.27552313756318914d,left: 0.45907928983554847d),
new NpgsqlTypes.NpgsqlBox(top: 0.8390900334556491d,right: 0.7420699157805027d,bottom: 0.2454086794771152d,left: 0.00019093568607808642d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7734624006419452d,right: 0.6752486458468279d,bottom: 0.26720394360218636d,left: 0.5007371724648185d),
new NpgsqlTypes.NpgsqlBox(top: 0.3360771903296582d,right: 0.8503048072621388d,bottom: 0.010235932861537012d,left: 0.2659671226498105d),
new NpgsqlTypes.NpgsqlBox(top: 0.9813978249315609d,right: 0.6525088397464949d,bottom: 0.6354536172924363d,left: 0.36642800773653994d),
new NpgsqlTypes.NpgsqlBox(top: 0.5264437133471416d,right: 0.8591446935446606d,bottom: 0.4522447427523022d,left: 0.792474993181094d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.39704960695057934d,right: 0.6188158401307591d,bottom: 0.15328829048447024d,left: 0.20576959974443354d),
new NpgsqlTypes.NpgsqlBox(top: 0.8844478842123559d,right: 0.3725555884666838d,bottom: 0.334401139431207d,left: 0.02953112443752881d),
new NpgsqlTypes.NpgsqlBox(top: 0.7847681991358838d,right: 0.9848144139652284d,bottom: 0.6137975539650192d,left: 0.9123704361900192d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.613393090391812d,right: 0.8760925442735381d,bottom: 0.5215350607411773d,left: 0.04162009093672692d),
new NpgsqlTypes.NpgsqlBox(top: 0.8882956617494244d,right: 0.804612909433718d,bottom: 0.1536220165756862d,left: 0.4628065441649062d),
new NpgsqlTypes.NpgsqlBox(top: 0.8795479063929744d,right: 0.7945722076922973d,bottom: 0.22681937593617119d,left: 0.36680956562369893d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7446455096949381d,right: 0.40797682275283764d,bottom: 0.565687548488693d,left: 0.19945309946596834d),
new NpgsqlTypes.NpgsqlBox(top: 0.9549451521397003d,right: 0.6272921052327867d,bottom: 0.5042243608586819d,left: 0.1540809169809615d),
new NpgsqlTypes.NpgsqlBox(top: 0.9549239160834511d,right: 0.9797847102187385d,bottom: 0.8391085812510645d,left: 0.09689752845774313d),
new NpgsqlTypes.NpgsqlBox(top: 0.8377348074104427d,right: 0.757872071772523d,bottom: 0.23310079314241483d,left: 0.08550388683615906d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6792745281023749d,right: 0.5854832936151659d,bottom: 0.6475296367189312d,left: 0.012672162318525082d),
new NpgsqlTypes.NpgsqlBox(top: 0.7945825637042021d,right: 0.2590834037483649d,bottom: 0.7631724371962755d,left: 0.14698277441706653d),
new NpgsqlTypes.NpgsqlBox(top: 0.07210107204970073d,right: 0.6008594610496374d,bottom: 0.0069111183932919484d,left: 0.03924935150013242d),
new NpgsqlTypes.NpgsqlBox(top: 0.4498965292758731d,right: 0.24819599171196383d,bottom: 0.21713805913209827d,left: 0.07138487237294355d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7623479388601424d,right: 0.3127720318800753d,bottom: 0.043501750039880216d,left: 0.05025562019679042d),
new NpgsqlTypes.NpgsqlBox(top: 0.9593760282184197d,right: 0.8869441411844274d,bottom: 0.7898499240622785d,left: 0.581588177803733d),
new NpgsqlTypes.NpgsqlBox(top: 0.9998695090591758d,right: 0.9345410950493764d,bottom: 0.888389897135419d,left: 0.09900545098961633d),
new NpgsqlTypes.NpgsqlBox(top: 0.42654741899878d,right: 0.9364812374256507d,bottom: 0.2349141602558974d,left: 0.20277389556615733d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6610605326970692d,right: 0.8120917233661882d,bottom: 0.06495474575446591d,left: 0.28635477011405197d),
new NpgsqlTypes.NpgsqlBox(top: 0.7217788830364158d,right: 0.8700704961837535d,bottom: 0.4186156057548943d,left: 0.19706168995933138d),
new NpgsqlTypes.NpgsqlBox(top: 0.9536148536841876d,right: 0.6179436088304884d,bottom: 0.5903046093781359d,left: 0.5514397796829602d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6336608000264192d,right: 0.9975843701245077d,bottom: 0.10762532090439925d,left: 0.7017801652617685d),
new NpgsqlTypes.NpgsqlBox(top: 0.7163295488312129d,right: 0.8929830690140554d,bottom: 0.024006211836622993d,left: 0.8399173214886299d),
new NpgsqlTypes.NpgsqlBox(top: 0.5630383018493227d,right: 0.49923781321369043d,bottom: 0.3175585252269293d,left: 0.3179566567922295d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8956149783703873d,right: 0.9921942275218124d,bottom: 0.3763971561282239d,left: 0.9821001180065683d),
new NpgsqlTypes.NpgsqlBox(top: 0.6913399610450672d,right: 0.5151732503261255d,bottom: 0.3914380000409504d,left: 0.10345496718661495d),
new NpgsqlTypes.NpgsqlBox(top: 0.48661677613737253d,right: 0.8890048764889926d,bottom: 0.1034724357607878d,left: 0.0323856716957418d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.35167359517652286d,right: 0.18309804084558023d,bottom: 0.014836566968861264d,left: 0.07931081075731328d),
new NpgsqlTypes.NpgsqlBox(top: 0.24175801444019396d,right: 0.63492819705994d,bottom: 0.15465255085192497d,left: 0.01177559509111925d),
new NpgsqlTypes.NpgsqlBox(top: 0.9658178158536187d,right: 0.6157528517860281d,bottom: 0.7799977984716786d,left: 0.2216976087530389d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7619860333439661d,right: 0.8121885161199817d,bottom: 0.5940543565287658d,left: 0.3762243496829416d),
new NpgsqlTypes.NpgsqlBox(top: 0.8760728908706193d,right: 0.4087885873278002d,bottom: 0.2966109340589128d,left: 0.04897686627497677d),
new NpgsqlTypes.NpgsqlBox(top: 0.5155439610771039d,right: 0.13028287922326254d,bottom: 0.4545080362607906d,left: 0.019852292880684907d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.880332435379786d,right: 0.6236266233439456d,bottom: 0.6255516899651756d,left: 0.4877820749379249d),
new NpgsqlTypes.NpgsqlBox(top: 0.40349978387325147d,right: 0.6971133789924592d,bottom: 0.30710175771524206d,left: 0.6072213398456624d),
new NpgsqlTypes.NpgsqlBox(top: 0.3803210523582691d,right: 0.43902344381539504d,bottom: 0.1918490725139379d,left: 0.41266450953893974d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9160752163624043d,right: 0.9550591929424125d,bottom: 0.7810108676237209d,left: 0.18648003270888847d),
new NpgsqlTypes.NpgsqlBox(top: 0.3535958286392218d,right: 0.05103347878614628d,bottom: 0.03573697669283926d,left: 0.011179446500791279d),
new NpgsqlTypes.NpgsqlBox(top: 0.8744381236817003d,right: 0.9307447349036415d,bottom: 0.7055768903841478d,left: 0.268000524971691d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4546947982227727d,right: 0.4410741013214283d,bottom: 0.1854409760900685d,left: 0.021448508902849883d),
new NpgsqlTypes.NpgsqlBox(top: 0.5111893425267932d,right: 0.40220868687273637d,bottom: 0.3939930152381058d,left: 0.1118027506956133d),
new NpgsqlTypes.NpgsqlBox(top: 0.5283816194683607d,right: 0.7894514850554308d,bottom: 0.1181057402510386d,left: 0.28681934497241834d),
new NpgsqlTypes.NpgsqlBox(top: 0.6290914692317139d,right: 0.9955933468910603d,bottom: 0.18611613339488575d,left: 0.7765350539976575d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.620595277349233d,right: 0.7489117285692375d,bottom: 0.3676099796944976d,left: 0.24308017163916806d),
new NpgsqlTypes.NpgsqlBox(top: 0.7882010106236135d,right: 0.9828553551922801d,bottom: 0.545828679283063d,left: 0.6783731843433446d),
new NpgsqlTypes.NpgsqlBox(top: 0.9412681412264534d,right: 0.5884212376423813d,bottom: 0.6195210650970066d,left: 0.01561262280443676d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.49933674073431744d,right: 0.8206714583471929d,bottom: 0.32765123931060136d,left: 0.5870342059514485d),
new NpgsqlTypes.NpgsqlBox(top: 0.21305189027022398d,right: 0.6517518611830255d,bottom: 0.13940429588637993d,left: 0.6235197270361023d),
new NpgsqlTypes.NpgsqlBox(top: 0.7827451266973201d,right: 0.21227652449242496d,bottom: 0.18764074266993436d,left: 0.061199685801407444d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.1372543302334427d,right: 0.7160752091249966d,bottom: 0.023166866511918793d,left: 0.08083504786190865d),
new NpgsqlTypes.NpgsqlBox(top: 0.6697210789517625d,right: 0.5579811682504352d,bottom: 0.36550818327338797d,left: 0.3781543564867743d),
new NpgsqlTypes.NpgsqlBox(top: 0.8437052133152466d,right: 0.9593325791142907d,bottom: 0.13868016022786323d,left: 0.7496042902882384d),
new NpgsqlTypes.NpgsqlBox(top: 0.5610909746312105d,right: 0.23182617469499933d,bottom: 0.07969665561941974d,left: 0.2301781459379454d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7479285065572583d,right: 0.9387189983840722d,bottom: 0.5350408816476612d,left: 0.748488895288257d),
new NpgsqlTypes.NpgsqlBox(top: 0.46960045273885287d,right: 0.7601377563435912d,bottom: 0.44755054530627625d,left: 0.6943222245885273d),
new NpgsqlTypes.NpgsqlBox(top: 0.7468317167241957d,right: 0.7786404042937353d,bottom: 0.5512381827018455d,left: 0.23078921782298223d),
new NpgsqlTypes.NpgsqlBox(top: 0.8745437778712724d,right: 0.7360174075023189d,bottom: 0.868211366929032d,left: 0.7050194305327387d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.729638255863179d,right: 0.2981027037634387d,bottom: 0.6229223455093241d,left: 0.11835289268334737d),
new NpgsqlTypes.NpgsqlBox(top: 0.4573659756448314d,right: 0.8885719456532244d,bottom: 0.2119113756508375d,left: 0.16721947856244146d),
new NpgsqlTypes.NpgsqlBox(top: 0.8183042144484595d,right: 0.5450266096657059d,bottom: 0.015466825023633723d,left: 0.5010151541737677d),
new NpgsqlTypes.NpgsqlBox(top: 0.911196538846022d,right: 0.841667563873183d,bottom: 0.7575247562607086d,left: 0.6941345803740051d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5791265206858882d,right: 0.8016270125471617d,bottom: 0.43490532663855763d,left: 0.13491542687221436d),
new NpgsqlTypes.NpgsqlBox(top: 0.7243047768031751d,right: 0.1764009994010345d,bottom: 0.062162373056214415d,left: 0.04355371641822625d),
new NpgsqlTypes.NpgsqlBox(top: 0.9623887131356099d,right: 0.7455790543549681d,bottom: 0.5323467474361873d,left: 0.24177869066649005d),
new NpgsqlTypes.NpgsqlBox(top: 0.8237649639463945d,right: 0.680517874380974d,bottom: 0.6227601720535414d,left: 0.10533780297435802d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7104484156577979d,right: 0.31045820119595957d,bottom: 0.4988825040129272d,left: 0.2515881002985564d),
new NpgsqlTypes.NpgsqlBox(top: 0.44893487909330065d,right: 0.8727361280817132d,bottom: 0.23510800392692865d,left: 0.5838535543857d),
new NpgsqlTypes.NpgsqlBox(top: 0.7739132351758089d,right: 0.5175554448782489d,bottom: 0.46085809874936523d,left: 0.14178311228862572d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9201066020543542d,right: 0.4720307502945543d,bottom: 0.2925207446338164d,left: 0.03267643531772746d),
new NpgsqlTypes.NpgsqlBox(top: 0.9693266470215254d,right: 0.6313186361150115d,bottom: 0.04804247653720184d,left: 0.522691313861811d),
new NpgsqlTypes.NpgsqlBox(top: 0.7214135139115732d,right: 0.6812865214361015d,bottom: 0.6926400864812423d,left: 0.03171406611864991d),
new NpgsqlTypes.NpgsqlBox(top: 0.44054147842663793d,right: 0.1783958795302285d,bottom: 0.3032224099502252d,left: 0.05086280544317945d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5544150085735013d,right: 0.7086852007615697d,bottom: 0.05481961470780372d,left: 0.41402230561673325d),
new NpgsqlTypes.NpgsqlBox(top: 0.708758367087836d,right: 0.7298304103452156d,bottom: 0.6343192333979687d,left: 0.5312553824222964d),
new NpgsqlTypes.NpgsqlBox(top: 0.2774201723074472d,right: 0.9981837615615714d,bottom: 0.03555437952831042d,left: 0.15938151706621395d),
new NpgsqlTypes.NpgsqlBox(top: 0.508332669503928d,right: 0.9866472516330146d,bottom: 0.07958609736731825d,left: 0.2854196577292789d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.47005214294763187d,right: 0.18205110933920787d,bottom: 0.04212783274428544d,left: 0.13845291653511593d),
new NpgsqlTypes.NpgsqlBox(top: 0.5161639033072142d,right: 0.9794171871657424d,bottom: 0.2897868057126822d,left: 0.8782516523201913d),
new NpgsqlTypes.NpgsqlBox(top: 0.31135175248691116d,right: 0.9014128422627788d,bottom: 0.11125002398712625d,left: 0.592665255655139d),
new NpgsqlTypes.NpgsqlBox(top: 0.6290846027099852d,right: 0.43839340696372353d,bottom: 0.42803322936720845d,left: 0.2577299538851694d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9069323497316779d,right: 0.889213005757027d,bottom: 0.5747648210631725d,left: 0.37505079273177944d),
new NpgsqlTypes.NpgsqlBox(top: 0.6674853270317249d,right: 0.4992700156473d,bottom: 0.38441484381709823d,left: 0.2925355280056494d),
new NpgsqlTypes.NpgsqlBox(top: 0.8855221895780597d,right: 0.7674289306462992d,bottom: 0.8625158423452851d,left: 0.4869891605452651d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9426612479947477d,right: 0.5150261636686263d,bottom: 0.4177716395315142d,left: 0.2455672016411664d),
new NpgsqlTypes.NpgsqlBox(top: 0.40389477648526484d,right: 0.48131209199714153d,bottom: 0.29230855425571456d,left: 0.16435835570392998d),
new NpgsqlTypes.NpgsqlBox(top: 0.11596393131136962d,right: 0.5763074245691328d,bottom: 0.0005197783620928265d,left: 0.4370987097692647d),
new NpgsqlTypes.NpgsqlBox(top: 0.3526408180946319d,right: 0.2830177848070603d,bottom: 0.044232068576629535d,left: 0.1034261449109386d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4674471718451174d,right: 0.6303328931093757d,bottom: 0.30089826182302637d,left: 0.5351992442802639d),
new NpgsqlTypes.NpgsqlBox(top: 0.5754724330264714d,right: 0.4096679872860649d,bottom: 0.23276847940762135d,left: 0.2700491782057718d),
new NpgsqlTypes.NpgsqlBox(top: 0.5493079677604807d,right: 0.9925147852311641d,bottom: 0.2691023955489483d,left: 0.7578133856911763d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9289704586969959d,right: 0.8868515413085625d,bottom: 0.503012569033654d,left: 0.529102479465389d),
new NpgsqlTypes.NpgsqlBox(top: 0.2834783514203634d,right: 0.7914002898215923d,bottom: 0.11663399264978203d,left: 0.4214814246738958d),
new NpgsqlTypes.NpgsqlBox(top: 0.6224649396785834d,right: 0.6901871640328285d,bottom: 0.13149522152070903d,left: 0.33927536769835276d),
new NpgsqlTypes.NpgsqlBox(top: 0.6348849935998184d,right: 0.8444894545835847d,bottom: 0.5418962552329728d,left: 0.7046881609234972d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 179,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9307910575126744d,right: 0.5661149436496841d,bottom: 0.9110543633121828d,left: 0.3063622760464877d),
new NpgsqlTypes.NpgsqlBox(top: 0.3182627017705486d,right: 0.7841589175583983d,bottom: 0.0634767168251319d,left: 0.12954748349602285d),
new NpgsqlTypes.NpgsqlBox(top: 0.10654627305045283d,right: 0.905461934250356d,bottom: 0.09503104879185353d,left: 0.44257043001078666d),
new NpgsqlTypes.NpgsqlBox(top: 0.3627708737461759d,right: 0.9436515666925568d,bottom: 0.3280474520407958d,left: 0.7979883927072776d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8405045560949045d,right: 0.3408473388819644d,bottom: 0.5464946722289697d,left: 0.2351511029147173d),
new NpgsqlTypes.NpgsqlBox(top: 0.7131773090028617d,right: 0.576575535466434d,bottom: 0.06686836008241381d,left: 0.45399876088979985d),
new NpgsqlTypes.NpgsqlBox(top: 0.43044390709575964d,right: 0.9049408974903093d,bottom: 0.08885342638547544d,left: 0.6413354735595259d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3925418561050916d,right: 0.9578161954531651d,bottom: 0.08542208046819755d,left: 0.41353687702140207d),
new NpgsqlTypes.NpgsqlBox(top: 0.12823494257342072d,right: 0.39928314595198755d,bottom: 0.11480081342474191d,left: 0.277462343672238d),
new NpgsqlTypes.NpgsqlBox(top: 0.8168935485798632d,right: 0.9843655154967464d,bottom: 0.19738518598728305d,left: 0.8500551448144367d),
new NpgsqlTypes.NpgsqlBox(top: 0.32887701096116984d,right: 0.6586078078491449d,bottom: 0.013648732716522893d,left: 0.516210391117742d),
}));
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
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3173359316044836d,right: 0.8715619968416997d,bottom: 0.02114546376138471d,left: 0.5612073380557723d),
new NpgsqlTypes.NpgsqlBox(top: 0.6658110025411573d,right: 0.8337966107634498d,bottom: 0.16256460176093146d,left: 0.25020592903297256d),
new NpgsqlTypes.NpgsqlBox(top: 0.8220828905913289d,right: 0.7870714564493577d,bottom: 0.21628384722457272d,left: 0.1294665130897653d),
new NpgsqlTypes.NpgsqlBox(top: 0.974978499764432d,right: 0.9224913138285098d,bottom: 0.1440364317422299d,left: 0.8497258831156369d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.49673296452213345d,right: 0.7353908466311527d,bottom: 0.1736283382339202d,left: 0.562651924419027d),
new NpgsqlTypes.NpgsqlBox(top: 0.6417638835427212d,right: 0.8704730647141636d,bottom: 0.036068563217665384d,left: 0.09245031592359698d),
new NpgsqlTypes.NpgsqlBox(top: 0.8467982282460944d,right: 0.870708310681811d,bottom: 0.4013444936706583d,left: 0.28204499359205204d),
}));
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 166;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 166;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 150, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 51, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
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
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 125, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 127, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 127, query1, 30, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 87, query1, 87, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 51, query1, 170, query2))
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 103, query1, 150, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 170, 166))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 136, 93))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
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
                ((INpgsqlBoxMArrayboxMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxMArrayboxMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxMArrayboxMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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

