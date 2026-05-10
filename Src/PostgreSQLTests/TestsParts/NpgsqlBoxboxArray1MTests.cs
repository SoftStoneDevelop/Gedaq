

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
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8862688543479356d,right: 0.696570745635654d,bottom: 0.22429728296902185d,left: 0.3831360489312934d),
new NpgsqlTypes.NpgsqlBox(top: 0.9529092247172977d,right: 0.7972744297463943d,bottom: 0.7244206751392444d,left: 0.5928924221506613d),
new NpgsqlTypes.NpgsqlBox(top: 0.899535039865041d,right: 0.5471371156904804d,bottom: 0.24977064852459074d,left: 0.35093708507248444d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.17947111079725675d,right: 0.3832515414262273d,bottom: 0.10971267152607067d,left: 0.27489938867723895d),
new NpgsqlTypes.NpgsqlBox(top: 0.2240482392294444d,right: 0.7432390501527719d,bottom: 0.0789957209203529d,left: 0.6156211293025325d),
new NpgsqlTypes.NpgsqlBox(top: 0.8158002395614138d,right: 0.6664609909222775d,bottom: 0.04127254402756608d,left: 0.43114463795540436d),
new NpgsqlTypes.NpgsqlBox(top: 0.3818165046651353d,right: 0.7609127295710774d,bottom: 0.2308722208207843d,left: 0.5439738541977619d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9769269182559688d,right: 0.7287589679515272d,bottom: 0.3108575321173054d,left: 0.6886011666987274d),
new NpgsqlTypes.NpgsqlBox(top: 0.8983642909599021d,right: 0.5690687861851988d,bottom: 0.7272582859952936d,left: 0.06283030083580698d),
new NpgsqlTypes.NpgsqlBox(top: 0.7939676829634422d,right: 0.9022944380415066d,bottom: 0.7246697511325212d,left: 0.7076467936595308d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.30015476301284916d,right: 0.43847143767855845d,bottom: 0.2954642216559654d,left: 0.3976089958068716d),
new NpgsqlTypes.NpgsqlBox(top: 0.783087294113303d,right: 0.23356089107254285d,bottom: 0.53889332962018d,left: 0.13518800488232752d),
new NpgsqlTypes.NpgsqlBox(top: 0.46503535413079555d,right: 0.4779472950555238d,bottom: 0.2210402473840678d,left: 0.1100382164253918d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6273067288899177d,right: 0.31739107342541795d,bottom: 0.10470982523756789d,left: 0.11715863102553825d),
new NpgsqlTypes.NpgsqlBox(top: 0.9592195071978452d,right: 0.9056017902424986d,bottom: 0.3737671009042832d,left: 0.6407454720895265d),
new NpgsqlTypes.NpgsqlBox(top: 0.804278274231416d,right: 0.7793581241479589d,bottom: 0.46426420314224826d,left: 0.40813831222110963d),
new NpgsqlTypes.NpgsqlBox(top: 0.7894909039250797d,right: 0.09486292254916706d,bottom: 0.34388084985951894d,left: 0.06290178759967979d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.27271103328126733d,right: 0.4073755856249429d,bottom: 0.14958317681632394d,left: 0.35605835514105344d),
new NpgsqlTypes.NpgsqlBox(top: 0.7543201074519192d,right: 0.96273832690244d,bottom: 0.5068827578357703d,left: 0.17874265357087704d),
new NpgsqlTypes.NpgsqlBox(top: 0.2571275482450064d,right: 0.18587926082366235d,bottom: 0.2564989132223402d,left: 0.18395779064109097d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7463490226347175d,right: 0.6881639197197608d,bottom: 0.23700780665546262d,left: 0.32899437859468517d),
new NpgsqlTypes.NpgsqlBox(top: 0.8981046184004037d,right: 0.7143589814725658d,bottom: 0.39659619052393347d,left: 0.2706979738332349d),
new NpgsqlTypes.NpgsqlBox(top: 0.8454693768943299d,right: 0.7432993180981425d,bottom: 0.019376328670770104d,left: 0.1905860004497546d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4056324917694042d,right: 0.8866300267598747d,bottom: 0.1441961663817971d,left: 0.46840948509137137d),
new NpgsqlTypes.NpgsqlBox(top: 0.5587708520829334d,right: 0.4480490883092194d,bottom: 0.04027528463280039d,left: 0.38580333435918157d),
new NpgsqlTypes.NpgsqlBox(top: 0.49894229515783706d,right: 0.3344117267675044d,bottom: 0.2888259111112389d,left: 0.2630538483164122d),
new NpgsqlTypes.NpgsqlBox(top: 0.37342617868262373d,right: 0.8887934195267223d,bottom: 0.33184358002909276d,left: 0.41794483473224453d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7213489740754703d,right: 0.956143016287535d,bottom: 0.3458327194964379d,left: 0.8749159939027673d),
new NpgsqlTypes.NpgsqlBox(top: 0.9670295291582769d,right: 0.8667522690363634d,bottom: 0.04543701525874466d,left: 0.3280737728257035d),
new NpgsqlTypes.NpgsqlBox(top: 0.8396874341817421d,right: 0.4265918554636706d,bottom: 0.3829101772876824d,left: 0.22704743085315604d),
new NpgsqlTypes.NpgsqlBox(top: 0.7385327551373896d,right: 0.6430471352874035d,bottom: 0.4831459666817359d,left: 0.2419298778940131d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8303497940660559d,right: 0.9478087957757007d,bottom: 0.216369408172555d,left: 0.30557771161614733d),
new NpgsqlTypes.NpgsqlBox(top: 0.9255179781927302d,right: 0.6066248810987833d,bottom: 0.09057409305858677d,left: 0.023845893585326405d),
new NpgsqlTypes.NpgsqlBox(top: 0.814919569626531d,right: 0.630281180415978d,bottom: 0.21138238524125263d,left: 0.322773257334217d),
new NpgsqlTypes.NpgsqlBox(top: 0.9116098907034531d,right: 0.7421673991091405d,bottom: 0.15868714620715008d,left: 0.3364222740384242d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4657513608464051d,right: 0.8204270692839045d,bottom: 0.23523354090633164d,left: 0.2083896380719512d),
new NpgsqlTypes.NpgsqlBox(top: 0.6765484821904639d,right: 0.7399464223167246d,bottom: 0.11146830818449527d,left: 0.14101409822187783d),
new NpgsqlTypes.NpgsqlBox(top: 0.8665741365720768d,right: 0.9153753291526942d,bottom: 0.31578594530891924d,left: 0.8110045912016153d),
new NpgsqlTypes.NpgsqlBox(top: 0.6019017175806212d,right: 0.6172457882951035d,bottom: 0.02098471842724381d,left: 0.34984731482938813d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8384945334846433d,right: 0.7226311031169981d,bottom: 0.0022420206048504587d,left: 0.451410788337536d),
new NpgsqlTypes.NpgsqlBox(top: 0.5046324376374742d,right: 0.7011333088124821d,bottom: 0.20415108044314767d,left: 0.64200270878928d),
new NpgsqlTypes.NpgsqlBox(top: 0.8824219697462629d,right: 0.8879673591367029d,bottom: 0.46159468240373236d,left: 0.6013843811488595d),
new NpgsqlTypes.NpgsqlBox(top: 0.8654302897535848d,right: 0.8224235889817656d,bottom: 0.21445081928091803d,left: 0.1547562208333917d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3410308586256259d,right: 0.6622229020821584d,bottom: 0.20207816356170105d,left: 0.395382588576054d),
new NpgsqlTypes.NpgsqlBox(top: 0.7825238939811713d,right: 0.5186474215110719d,bottom: 0.07235297711757849d,left: 0.06863635204508312d),
new NpgsqlTypes.NpgsqlBox(top: 0.6117375937396048d,right: 0.7238529495570318d,bottom: 0.5559099654767417d,left: 0.3589885854175979d),
new NpgsqlTypes.NpgsqlBox(top: 0.3675715867808471d,right: 0.9036082573332221d,bottom: 0.2928388880385524d,left: 0.1214055714208071d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9824499686014839d,right: 0.9867298202830339d,bottom: 0.21914148576986503d,left: 0.7970165401356455d),
new NpgsqlTypes.NpgsqlBox(top: 0.8355116898513362d,right: 0.43058151592015614d,bottom: 0.4335491575325583d,left: 0.19947803178441104d),
new NpgsqlTypes.NpgsqlBox(top: 0.9522011537497618d,right: 0.48536987752233907d,bottom: 0.7966494119582893d,left: 0.2974291300823174d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4484878378132612d,right: 0.9382755736306311d,bottom: 0.05339439501159926d,left: 0.2413870257271693d),
new NpgsqlTypes.NpgsqlBox(top: 0.916768292408763d,right: 0.850005843405388d,bottom: 0.6665114892592439d,left: 0.2691186282631852d),
new NpgsqlTypes.NpgsqlBox(top: 0.2161688075793753d,right: 0.9229659371624784d,bottom: 0.20323113142018878d,left: 0.164352978946383d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.964882021078712d,right: 0.2528727406348166d,bottom: 0.4896735775604888d,left: 0.18972370675894967d),
new NpgsqlTypes.NpgsqlBox(top: 0.3809702879946547d,right: 0.8732047369302036d,bottom: 0.3388340323105188d,left: 0.1812134942867497d),
new NpgsqlTypes.NpgsqlBox(top: 0.8802702598269733d,right: 0.8669566236292627d,bottom: 0.047792752984283315d,left: 0.13055258304594353d),
new NpgsqlTypes.NpgsqlBox(top: 0.745307204260738d,right: 0.7709796946389398d,bottom: 0.45534866195717616d,left: 0.4984767826144608d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5522566238665905d,right: 0.9168279972107072d,bottom: 0.14600576518464414d,left: 0.8020680412676073d),
new NpgsqlTypes.NpgsqlBox(top: 0.4470582057351373d,right: 0.3750443874401197d,bottom: 0.18436485904159006d,left: 0.133323550244564d),
new NpgsqlTypes.NpgsqlBox(top: 0.9497055971485291d,right: 0.405000006247468d,bottom: 0.11651435569497781d,left: 0.10109554311867086d),
new NpgsqlTypes.NpgsqlBox(top: 0.7022874733968145d,right: 0.8428002336953476d,bottom: 0.4385869106790642d,left: 0.14678330769176728d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4777659879048157d,right: 0.13418967780709734d,bottom: 0.4320117127849509d,left: 0.03603419940439434d),
new NpgsqlTypes.NpgsqlBox(top: 0.6857868588031683d,right: 0.9708020660484485d,bottom: 0.4376425211226852d,left: 0.29550480542684654d),
new NpgsqlTypes.NpgsqlBox(top: 0.32552849150658414d,right: 0.7388812576964885d,bottom: 0.2554879275070352d,left: 0.7076513201911466d),
new NpgsqlTypes.NpgsqlBox(top: 0.8451710040425432d,right: 0.9159349368435395d,bottom: 5.569702093988216E-05d,left: 0.8342903376632624d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.31666283406855045d,right: 0.9920878680035325d,bottom: 0.1455844939600519d,left: 0.16650430609779632d),
new NpgsqlTypes.NpgsqlBox(top: 0.5099120328688295d,right: 0.47318837417722903d,bottom: 0.2172561148687131d,left: 0.28744921808426227d),
new NpgsqlTypes.NpgsqlBox(top: 0.21673919657605045d,right: 0.8509160134744843d,bottom: 0.008866751512374704d,left: 0.556145071777864d),
new NpgsqlTypes.NpgsqlBox(top: 0.6154833950042536d,right: 0.7813756686346863d,bottom: 0.4872815858856758d,left: 0.2676244273209093d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9167825340187072d,right: 0.2825679921402011d,bottom: 0.5398191415224879d,left: 0.16582626365228204d),
new NpgsqlTypes.NpgsqlBox(top: 0.8972471695610122d,right: 0.7257958739259636d,bottom: 0.6411131522098024d,left: 0.6447460526738116d),
new NpgsqlTypes.NpgsqlBox(top: 0.8041571018915494d,right: 0.5252020959251703d,bottom: 0.4103805122647196d,left: 0.35617871180663796d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.956596941296665d,right: 0.5711758914252548d,bottom: 0.3189286101421155d,left: 0.423659055000429d),
new NpgsqlTypes.NpgsqlBox(top: 0.6266155988194568d,right: 0.29013824120915166d,bottom: 0.3828710250370928d,left: 0.07551552558438712d),
new NpgsqlTypes.NpgsqlBox(top: 0.2642028662047856d,right: 0.5639153744933016d,bottom: 0.15893911585876763d,left: 0.21860459328952442d),
new NpgsqlTypes.NpgsqlBox(top: 0.6711325716511928d,right: 0.6188498935590933d,bottom: 0.5946119798085003d,left: 0.23194897425117877d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7490163102711895d,right: 0.5250720504482362d,bottom: 0.08382971824069241d,left: 0.47468549225070156d),
new NpgsqlTypes.NpgsqlBox(top: 0.5371800545944014d,right: 0.527291260110304d,bottom: 0.09992368478661573d,left: 0.03546509905039963d),
new NpgsqlTypes.NpgsqlBox(top: 0.2957243480972842d,right: 0.9249750870051237d,bottom: 0.2849715044640885d,left: 0.1699254919504185d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.34183394811841183d,right: 0.38752206698469105d,bottom: 0.11703397473099508d,left: 0.13882472086752584d),
new NpgsqlTypes.NpgsqlBox(top: 0.3763503809778206d,right: 0.9943202700346769d,bottom: 0.11741239375677825d,left: 0.03746907397050969d),
new NpgsqlTypes.NpgsqlBox(top: 0.49241454644483995d,right: 0.863521428906817d,bottom: 0.059546357316025755d,left: 0.542369699747953d),
new NpgsqlTypes.NpgsqlBox(top: 0.7572937093658577d,right: 0.3207259849852857d,bottom: 0.021680121428355736d,left: 0.006632746879535523d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9437185797446005d,right: 0.36906773851298147d,bottom: 0.8061290706501809d,left: 0.05332909493159532d),
new NpgsqlTypes.NpgsqlBox(top: 0.8186763907445778d,right: 0.6760987892855117d,bottom: 0.54268948700342d,left: 0.1970478496866921d),
new NpgsqlTypes.NpgsqlBox(top: 0.9152119459011312d,right: 0.9130873302357784d,bottom: 0.8555125930088158d,left: 0.3646428212191244d),
new NpgsqlTypes.NpgsqlBox(top: 0.9103461090765337d,right: 0.7443238861299305d,bottom: 0.0075349120549317306d,left: 0.5718995469655945d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6558029603485396d,right: 0.5400701293791919d,bottom: 0.04676508016820424d,left: 0.34998226194780646d),
new NpgsqlTypes.NpgsqlBox(top: 0.6728062753731698d,right: 0.7605845767051019d,bottom: 0.20096769028937822d,left: 0.3870999254072648d),
new NpgsqlTypes.NpgsqlBox(top: 0.7977346239418673d,right: 0.9880032263732412d,bottom: 0.47497281909420996d,left: 0.23910360590602853d),
new NpgsqlTypes.NpgsqlBox(top: 0.09343294966652782d,right: 0.7647733219303284d,bottom: 0.07361579430078435d,left: 0.6040630385633746d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6581225070523726d,right: 0.27676214379295816d,bottom: 0.04244963154872705d,left: 0.09546577286357738d),
new NpgsqlTypes.NpgsqlBox(top: 0.6976144735967527d,right: 0.9851680570218053d,bottom: 0.1245097109651011d,left: 0.09453910186408299d),
new NpgsqlTypes.NpgsqlBox(top: 0.04089010152687622d,right: 0.4452026792680751d,bottom: 0.020575201887679695d,left: 0.3737565078181365d),
new NpgsqlTypes.NpgsqlBox(top: 0.5106054483348633d,right: 0.7654150247671555d,bottom: 0.10176303351161065d,left: 0.2578447519934749d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.517056184677337d,right: 0.7131521133650507d,bottom: 0.43811143275840947d,left: 0.26609245243934854d),
new NpgsqlTypes.NpgsqlBox(top: 0.5363452223394709d,right: 0.6934692705335987d,bottom: 0.12120642658465974d,left: 0.04926000588569546d),
new NpgsqlTypes.NpgsqlBox(top: 0.8554470736999258d,right: 0.5433665167394707d,bottom: 0.043435746505471884d,left: 0.23949956194565525d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3552422233462892d,right: 0.5875015264828587d,bottom: 0.15716880051683446d,left: 0.15673430461193705d),
new NpgsqlTypes.NpgsqlBox(top: 0.9927342775347284d,right: 0.3820004382404546d,bottom: 0.7755955862442557d,left: 0.2004313214997855d),
new NpgsqlTypes.NpgsqlBox(top: 0.5601329992356215d,right: 0.16793056859421773d,bottom: 0.2476546656030839d,left: 0.1023199601247855d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8939126240120563d,right: 0.6838739941818041d,bottom: 0.20620278960932759d,left: 0.02579188997095383d),
new NpgsqlTypes.NpgsqlBox(top: 0.8969616893545596d,right: 0.6136740878278978d,bottom: 0.39481817462327606d,left: 0.5913180999148446d),
new NpgsqlTypes.NpgsqlBox(top: 0.6550061753040108d,right: 0.7105897186365037d,bottom: 0.6396488245073354d,left: 0.4617996773341483d),
new NpgsqlTypes.NpgsqlBox(top: 0.6376727673728942d,right: 0.43763566037741897d,bottom: 0.292631162796294d,left: 0.40542350769185254d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8780525524189733d,right: 0.7919044122354766d,bottom: 0.357674049102625d,left: 0.7355485587862404d),
new NpgsqlTypes.NpgsqlBox(top: 0.25549650413075875d,right: 0.765560539285038d,bottom: 0.21743022153799463d,left: 0.32007439884968103d),
new NpgsqlTypes.NpgsqlBox(top: 0.4073834608222062d,right: 0.5558652186795493d,bottom: 0.06335486850043459d,left: 0.22849321546482848d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7550737648046377d,right: 0.49496498946071255d,bottom: 0.5482902655364997d,left: 0.13456163323223158d),
new NpgsqlTypes.NpgsqlBox(top: 0.8670215501169983d,right: 0.3169537452058865d,bottom: 0.20331898706422047d,left: 0.0322958690195434d),
new NpgsqlTypes.NpgsqlBox(top: 0.6657379169029044d,right: 0.9865319905746417d,bottom: 0.09982302740156379d,left: 0.5171601642553328d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4557242019589861d,right: 0.5847583638852507d,bottom: 0.4367997148800734d,left: 0.5533445706783379d),
new NpgsqlTypes.NpgsqlBox(top: 0.8438316471870287d,right: 0.17260058008370438d,bottom: 0.545693906105805d,left: 0.12217070783770301d),
new NpgsqlTypes.NpgsqlBox(top: 0.5571072764148332d,right: 0.41190849323332523d,bottom: 0.34895539024073874d,left: 0.38717086112360055d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5724083866063078d,right: 0.8474796269791115d,bottom: 0.3310772781221242d,left: 0.6900777741581354d),
new NpgsqlTypes.NpgsqlBox(top: 0.547753565199172d,right: 0.5047337794998783d,bottom: 0.34507134148591867d,left: 0.35251937880299766d),
new NpgsqlTypes.NpgsqlBox(top: 0.9007514733639816d,right: 0.5024034939241749d,bottom: 0.7631024928775068d,left: 0.06630937572834261d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.48783505823528606d,right: 0.571908321758101d,bottom: 0.4448935495958425d,left: 0.5273493358398406d),
new NpgsqlTypes.NpgsqlBox(top: 0.27156233951407316d,right: 0.8287575997782425d,bottom: 0.060440081871537155d,left: 0.12990500220037293d),
new NpgsqlTypes.NpgsqlBox(top: 0.6244854423011046d,right: 0.6031250110160394d,bottom: 0.2491705579563006d,left: 0.43624661103317763d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.820770348437072d,right: 0.5753780377610938d,bottom: 0.7874803268606374d,left: 0.15924963040172235d),
new NpgsqlTypes.NpgsqlBox(top: 0.9269752153318239d,right: 0.9845440928372462d,bottom: 0.6476346684587013d,left: 0.7440552094413676d),
new NpgsqlTypes.NpgsqlBox(top: 0.9011948576391529d,right: 0.8949197283405432d,bottom: 0.749193696499384d,left: 0.21156737347284194d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7308387283845438d,right: 0.6569334020005824d,bottom: 0.03623646651915746d,left: 0.3412988607362011d),
new NpgsqlTypes.NpgsqlBox(top: 0.7031748688016235d,right: 0.5122471698336755d,bottom: 0.345119025422984d,left: 0.02190758794456449d),
new NpgsqlTypes.NpgsqlBox(top: 0.5773768243283068d,right: 0.4944238092366535d,bottom: 0.005077125380987368d,left: 0.40263073714468756d),
new NpgsqlTypes.NpgsqlBox(top: 0.5615344181348659d,right: 0.8896896621390865d,bottom: 0.18968702220740863d,left: 0.27196236198074775d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.895750743014687d,right: 0.8974843844752086d,bottom: 0.6563399629403857d,left: 0.6888253573239599d),
new NpgsqlTypes.NpgsqlBox(top: 0.5027131862653824d,right: 0.7685853098973886d,bottom: 0.4038983979363908d,left: 0.46689283446883023d),
new NpgsqlTypes.NpgsqlBox(top: 0.7053995290554815d,right: 0.9947963417712856d,bottom: 0.38192267062843843d,left: 0.7414835522846775d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8673399576174889d,right: 0.9550544621645749d,bottom: 0.32418693111918495d,left: 0.6766645162413951d),
new NpgsqlTypes.NpgsqlBox(top: 0.6892444752766814d,right: 0.32587276683825694d,bottom: 0.68213107513826d,left: 0.1977076259813324d),
new NpgsqlTypes.NpgsqlBox(top: 0.17620521785806953d,right: 0.8431841810116264d,bottom: 0.0083217691956613d,left: 0.7056412287127976d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6495945012527166d,right: 0.591854792832757d,bottom: 0.0024061429538514423d,left: 0.5520540047356012d),
new NpgsqlTypes.NpgsqlBox(top: 0.46352890464883667d,right: 0.7163176596893489d,bottom: 0.360974617088878d,left: 0.1263160001682314d),
new NpgsqlTypes.NpgsqlBox(top: 0.6740798145391256d,right: 0.8934859859400632d,bottom: 0.6408289899330132d,left: 0.8763185486636961d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4747602049150714d,right: 0.7000640074917589d,bottom: 0.33504813117712995d,left: 0.5956335081831028d),
new NpgsqlTypes.NpgsqlBox(top: 0.8382981671521003d,right: 0.5131096041242315d,bottom: 0.15318443445979002d,left: 0.24650817211933573d),
new NpgsqlTypes.NpgsqlBox(top: 0.534686117551513d,right: 0.27175112550230496d,bottom: 0.3593864358708745d,left: 0.12504529967670752d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3740091812479066d,right: 0.8545637766627164d,bottom: 0.3716338750841538d,left: 0.02071758148422631d),
new NpgsqlTypes.NpgsqlBox(top: 0.8656610628750585d,right: 0.19041166283612598d,bottom: 0.1844667998051701d,left: 0.18726296734961922d),
new NpgsqlTypes.NpgsqlBox(top: 0.9993028841701886d,right: 0.9782086440808091d,bottom: 0.08451938890429345d,left: 0.29439021563207624d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9454781976205092d,right: 0.9468033076084735d,bottom: 0.9278993079898952d,left: 0.0870383485679399d),
new NpgsqlTypes.NpgsqlBox(top: 0.1788470271744269d,right: 0.9530117497628986d,bottom: 0.1449292314466839d,left: 0.5760665710229932d),
new NpgsqlTypes.NpgsqlBox(top: 0.7930712439033681d,right: 0.5627450953050324d,bottom: 0.3768436399379176d,left: 0.4212558975681907d),
new NpgsqlTypes.NpgsqlBox(top: 0.8361368091152841d,right: 0.9936305823865457d,bottom: 0.05723080899498678d,left: 0.8295309079334916d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7887336911451637d,right: 0.20837785253227348d,bottom: 0.4087086038239758d,left: 0.04507728320570836d),
new NpgsqlTypes.NpgsqlBox(top: 0.5957437052181002d,right: 0.5482669237072118d,bottom: 0.59195601790827d,left: 0.0743919572900501d),
new NpgsqlTypes.NpgsqlBox(top: 0.9243574566216927d,right: 0.8152322877045217d,bottom: 0.6000822610862685d,left: 0.20091800652366354d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3140344579869464d,right: 0.7605949299098725d,bottom: 0.07313328677134989d,left: 0.6806179654360613d),
new NpgsqlTypes.NpgsqlBox(top: 0.7025312532186162d,right: 0.11810020755140427d,bottom: 0.24599755093100217d,left: 0.015918600495479773d),
new NpgsqlTypes.NpgsqlBox(top: 0.8371847995006232d,right: 0.9228145986464196d,bottom: 0.04379264342449418d,left: 0.020727634784819093d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9997524094403849d,right: 0.33443860982612705d,bottom: 0.297714237182917d,left: 0.004121502538217081d),
new NpgsqlTypes.NpgsqlBox(top: 0.6775289306523875d,right: 0.8740656038283433d,bottom: 0.580573201047199d,left: 0.1748081892174681d),
new NpgsqlTypes.NpgsqlBox(top: 0.653638593069134d,right: 0.6061372775786196d,bottom: 0.5255202979160736d,left: 0.05460405641545907d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2735531804296104d,right: 0.8198089101569169d,bottom: 0.1168426612156589d,left: 0.5596047105292661d),
new NpgsqlTypes.NpgsqlBox(top: 0.9536994467437148d,right: 0.2543205313776893d,bottom: 0.3309470721331855d,left: 0.07564302969589909d),
new NpgsqlTypes.NpgsqlBox(top: 0.626026345292763d,right: 0.8101156746387376d,bottom: 0.6220991165996246d,left: 0.6793581275462526d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3902100848490099d,right: 0.9306522753011983d,bottom: 0.01602673568448043d,left: 0.31050838451147256d),
new NpgsqlTypes.NpgsqlBox(top: 0.5526576350500114d,right: 0.5775276050982061d,bottom: 0.3692466977048351d,left: 0.5626838347119381d),
new NpgsqlTypes.NpgsqlBox(top: 0.6702943111751936d,right: 0.3950511590328972d,bottom: 0.45747863243705744d,left: 0.009933153260684002d),
new NpgsqlTypes.NpgsqlBox(top: 0.9197892508777563d,right: 0.8729034749409192d,bottom: 0.44506654182266936d,left: 0.49978401667214756d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8759632754510273d,right: 0.8917825747547132d,bottom: 0.8731954719818242d,left: 0.19695907151460312d),
new NpgsqlTypes.NpgsqlBox(top: 0.2814100115022693d,right: 0.07492607374338522d,bottom: 0.05322778184896271d,left: 0.029236521529253268d),
new NpgsqlTypes.NpgsqlBox(top: 0.5322769887927131d,right: 0.26240714282447986d,bottom: 0.486669437620589d,left: 0.15334132322030036d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6607193726075732d,right: 0.09745675943060572d,bottom: 0.03361607793172017d,left: 0.05365710569918525d),
new NpgsqlTypes.NpgsqlBox(top: 0.72578270992224d,right: 0.46316563252873166d,bottom: 0.393761346610769d,left: 0.06227567916236687d),
new NpgsqlTypes.NpgsqlBox(top: 0.6111351914802926d,right: 0.6978637606518584d,bottom: 0.3605284979126817d,left: 0.24800054713498754d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.918716912220167d,right: 0.32124731562650677d,bottom: 0.125698888795317d,left: 0.06289833254482957d),
new NpgsqlTypes.NpgsqlBox(top: 0.6740231590136216d,right: 0.04189149766568567d,bottom: 0.2583399262387255d,left: 0.029961414471584624d),
new NpgsqlTypes.NpgsqlBox(top: 0.5732538718584763d,right: 0.3661856382503137d,bottom: 0.2025157887957998d,left: 0.12395386904834338d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9806419801893159d,right: 0.8592068615864003d,bottom: 0.3701933794717964d,left: 0.03159877119335264d),
new NpgsqlTypes.NpgsqlBox(top: 0.3600837197944994d,right: 0.40207412944466536d,bottom: 0.3207816221271631d,left: 0.37387877997394636d),
new NpgsqlTypes.NpgsqlBox(top: 0.9175154066588961d,right: 0.6594779783370611d,bottom: 0.734295297508373d,left: 0.30168057885125144d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5587257635048769d,right: 0.9901729657808958d,bottom: 0.12838051628548708d,left: 0.47746759077027134d),
new NpgsqlTypes.NpgsqlBox(top: 0.9530916317657829d,right: 0.7454723419959116d,bottom: 0.6796475121063715d,left: 0.703575977584235d),
new NpgsqlTypes.NpgsqlBox(top: 0.9620187915599103d,right: 0.8919900588972677d,bottom: 0.014835541660673135d,left: 0.2195097485825105d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7210035657608478d,right: 0.7487546066056259d,bottom: 0.2478916186339024d,left: 0.15365672463872404d),
new NpgsqlTypes.NpgsqlBox(top: 0.8749876490334448d,right: 0.9927202964169941d,bottom: 0.19782277589123665d,left: 0.6833119337134101d),
new NpgsqlTypes.NpgsqlBox(top: 0.5378304206503607d,right: 0.8690504972331741d,bottom: 0.43643619209639506d,left: 0.4791687257838002d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5037889249935588d,right: 0.9072779657317825d,bottom: 0.30410546843448394d,left: 0.10627952788317596d),
new NpgsqlTypes.NpgsqlBox(top: 0.5870682841555911d,right: 0.6696045437713853d,bottom: 0.44951679577979065d,left: 0.6212723428636859d),
new NpgsqlTypes.NpgsqlBox(top: 0.7416976810510186d,right: 0.858117917180914d,bottom: 0.4096632243324301d,left: 0.7891834785089168d),
new NpgsqlTypes.NpgsqlBox(top: 0.6799062610066628d,right: 0.28846717359727003d,bottom: 0.2214016113897982d,left: 0.11308194385845372d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9189819614461392d,right: 0.8494918376617463d,bottom: 0.4092548778546955d,left: 0.3962202954176557d),
new NpgsqlTypes.NpgsqlBox(top: 0.41363225598265474d,right: 0.02614869447984669d,bottom: 0.24120362500199422d,left: 0.021565099991785686d),
new NpgsqlTypes.NpgsqlBox(top: 0.9700443530824145d,right: 0.24238434794526753d,bottom: 0.9240521576876553d,left: 0.028886330571643914d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8481067434299808d,right: 0.8569372031361625d,bottom: 0.117687712701532d,left: 0.10576505627206334d),
new NpgsqlTypes.NpgsqlBox(top: 0.9713402611054459d,right: 0.3817035769311554d,bottom: 0.012860471737976553d,left: 0.20456366305279017d),
new NpgsqlTypes.NpgsqlBox(top: 0.6370006937687531d,right: 0.7967434385877937d,bottom: 0.39620343599510666d,left: 0.22504871688136552d),
new NpgsqlTypes.NpgsqlBox(top: 0.9085955433356723d,right: 0.4209817601556032d,bottom: 0.17102136781719113d,left: 0.16468171000561493d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7698053789834759d,right: 0.889140397445319d,bottom: 0.028802342546701776d,left: 0.7582439194619068d),
new NpgsqlTypes.NpgsqlBox(top: 0.7800073710564916d,right: 0.8531600579605292d,bottom: 0.4279780767357394d,left: 0.6040971196133413d),
new NpgsqlTypes.NpgsqlBox(top: 0.6346400349423021d,right: 0.7054675429904357d,bottom: 0.4763757479518895d,left: 0.26484513968670176d),
new NpgsqlTypes.NpgsqlBox(top: 0.6543977180202089d,right: 0.6909795272761665d,bottom: 0.17614556561105144d,left: 0.3652099809612317d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9942707809436053d,right: 0.7161610042529098d,bottom: 0.6356297975946911d,left: 0.005958412707341321d),
new NpgsqlTypes.NpgsqlBox(top: 0.57047461105356d,right: 0.9807212364603052d,bottom: 0.17270626513123655d,left: 0.9672917116158082d),
new NpgsqlTypes.NpgsqlBox(top: 0.9123563174723286d,right: 0.8244927646896855d,bottom: 0.6818459218901977d,left: 0.28617508733127384d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.945397436347242d,right: 0.6225461602209778d,bottom: 0.04326363011638967d,left: 0.15753918835237057d),
new NpgsqlTypes.NpgsqlBox(top: 0.5528249258593494d,right: 0.8015048394967624d,bottom: 0.26026711407814973d,left: 0.47510999111119157d),
new NpgsqlTypes.NpgsqlBox(top: 0.6581889098180222d,right: 0.9770880489709604d,bottom: 0.60616762489837d,left: 0.971565676759392d),
new NpgsqlTypes.NpgsqlBox(top: 0.8910220266167753d,right: 0.6263463786028387d,bottom: 0.21149519978922227d,left: 0.06760614121894792d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9875605273896375d,right: 0.7068938447652681d,bottom: 0.6525671474596983d,left: 0.31650883039648203d),
new NpgsqlTypes.NpgsqlBox(top: 0.9615986284984049d,right: 0.8183899093780589d,bottom: 0.41691506588177685d,left: 0.36690047131724024d),
new NpgsqlTypes.NpgsqlBox(top: 0.9648712792378902d,right: 0.8572464580499314d,bottom: 0.19350442744137708d,left: 0.1448729092375044d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.795382564730248d,right: 0.687164100565536d,bottom: 0.2489008141475978d,left: 0.6684175225207191d),
new NpgsqlTypes.NpgsqlBox(top: 0.6338143891296233d,right: 0.6256968902978057d,bottom: 0.09556593568265437d,left: 0.24756338254803045d),
new NpgsqlTypes.NpgsqlBox(top: 0.8091577305651647d,right: 0.5880098587020678d,bottom: 0.46648198463201185d,left: 0.510662348810098d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9117586484178706d,right: 0.1991003026104391d,bottom: 0.37577678391073455d,left: 0.1389590033214826d),
new NpgsqlTypes.NpgsqlBox(top: 0.8423744699020499d,right: 0.45404100390498314d,bottom: 0.07954235015489652d,left: 0.41494186692280877d),
new NpgsqlTypes.NpgsqlBox(top: 0.5116241073141232d,right: 0.8047889311011686d,bottom: 0.1252720016694876d,left: 0.5801269627919495d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7231270393838877d,right: 0.8864931405543386d,bottom: 0.3724040571092916d,left: 0.26722872729536473d),
new NpgsqlTypes.NpgsqlBox(top: 0.8467230591504433d,right: 0.5627062516486231d,bottom: 0.45463330368531674d,left: 0.04093977493320422d),
new NpgsqlTypes.NpgsqlBox(top: 0.4162374370005656d,right: 0.9987407504149105d,bottom: 0.1262932867640042d,left: 0.34562805110023775d),
new NpgsqlTypes.NpgsqlBox(top: 0.6601854891691786d,right: 0.6893881450161873d,bottom: 0.5122119162820786d,left: 0.46677486216782316d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7361265662041678d,right: 0.8728169200130076d,bottom: 0.6323437255398403d,left: 0.580798898080144d),
new NpgsqlTypes.NpgsqlBox(top: 0.3026059237417893d,right: 0.9599773284391309d,bottom: 0.01452988489874496d,left: 0.6787566857984113d),
new NpgsqlTypes.NpgsqlBox(top: 0.4179187355803722d,right: 0.7362653423356289d,bottom: 0.22692919614499618d,left: 0.7046473977352703d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7323994894644956d,right: 0.09522790004239179d,bottom: 0.18604483740183442d,left: 0.04630626496468182d),
new NpgsqlTypes.NpgsqlBox(top: 0.7611412533499777d,right: 0.8500246336784683d,bottom: 0.2688654595812916d,left: 0.0772595608486234d),
new NpgsqlTypes.NpgsqlBox(top: 0.7913785614171687d,right: 0.9257686376159072d,bottom: 0.2958022099405261d,left: 0.7331375789292804d),
new NpgsqlTypes.NpgsqlBox(top: 0.33503190421692686d,right: 0.5983864281222632d,bottom: 0.15943566342844584d,left: 0.3408935290753633d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6490048296684386d,right: 0.4644242336537675d,bottom: 0.6329416744044043d,left: 0.2096495498221943d),
new NpgsqlTypes.NpgsqlBox(top: 0.6346478899710774d,right: 0.410069154048914d,bottom: 0.6321934090358287d,left: 0.3730682473435487d),
new NpgsqlTypes.NpgsqlBox(top: 0.9446551759014569d,right: 0.8934120774504517d,bottom: 0.06374055219018282d,left: 0.31053033591707835d),
new NpgsqlTypes.NpgsqlBox(top: 0.6899256032639822d,right: 0.9998893742223914d,bottom: 0.32855464952297164d,left: 0.03506530702250177d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7487551901938536d,right: 0.8095855776608609d,bottom: 0.162714150908566d,left: 0.029311669227409354d),
new NpgsqlTypes.NpgsqlBox(top: 0.30648197784841347d,right: 0.9773270819006319d,bottom: 0.04834981240769609d,left: 0.9483050258330098d),
new NpgsqlTypes.NpgsqlBox(top: 0.8015550181211201d,right: 0.9010563859285808d,bottom: 0.5164010234595994d,left: 0.5882121821723191d),
new NpgsqlTypes.NpgsqlBox(top: 0.8150084289756141d,right: 0.2718844600582213d,bottom: 0.353149586965373d,left: 0.19984794855624932d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7878266110253032d,right: 0.6000968574784813d,bottom: 0.35498323435394497d,left: 0.37332827829418314d),
new NpgsqlTypes.NpgsqlBox(top: 0.4919010162000982d,right: 0.8942724278304294d,bottom: 0.2249512207776515d,left: 0.5876622113756454d),
new NpgsqlTypes.NpgsqlBox(top: 0.936233108032306d,right: 0.9369554012687766d,bottom: 0.2713796093149976d,left: 0.12760517394621196d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8621417912619553d,right: 0.4722438815178527d,bottom: 0.565641367548977d,left: 0.3444705354388953d),
new NpgsqlTypes.NpgsqlBox(top: 0.6535379174190143d,right: 0.5830582163675978d,bottom: 0.01903594129447117d,left: 0.20072393503344532d),
new NpgsqlTypes.NpgsqlBox(top: 0.993246513874766d,right: 0.615853983614391d,bottom: 0.2626365635546788d,left: 0.30081499922166566d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8770143372954027d,right: 0.46302412095355583d,bottom: 0.20362816177043186d,left: 0.01926642693064229d),
new NpgsqlTypes.NpgsqlBox(top: 0.7688185817056535d,right: 0.33329774369449094d,bottom: 0.6418614182678083d,left: 0.28453581947750706d),
new NpgsqlTypes.NpgsqlBox(top: 0.684750259910939d,right: 0.4414732490580462d,bottom: 0.1887843210080542d,left: 0.04867579754621654d),
new NpgsqlTypes.NpgsqlBox(top: 0.7016501352073434d,right: 0.4811914493385564d,bottom: 0.10279240028602599d,left: 0.12202540010898344d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5217032801810253d,right: 0.5083007300658369d,bottom: 0.47573371806160947d,left: 0.2669360699707294d),
new NpgsqlTypes.NpgsqlBox(top: 0.8901622746620416d,right: 0.6534418469227423d,bottom: 0.519937009851962d,left: 0.49350222935230537d),
new NpgsqlTypes.NpgsqlBox(top: 0.7826970372344942d,right: 0.6925425259011473d,bottom: 0.35812296478968453d,left: 0.6403660768775685d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 183,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8122514993527014d,right: 0.987982937197715d,bottom: 0.21332865957078062d,left: 0.5551416835778501d),
new NpgsqlTypes.NpgsqlBox(top: 0.9311863204325225d,right: 0.1377634400675739d,bottom: 0.5302863402844119d,left: 0.05347738223066978d),
new NpgsqlTypes.NpgsqlBox(top: 0.7619097667244072d,right: 0.603182333622494d,bottom: 0.6970574452835601d,left: 0.559380166752152d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.299917307658071d,right: 0.8944800258122731d,bottom: 0.12333050438955817d,left: 0.5488033258486906d),
new NpgsqlTypes.NpgsqlBox(top: 0.4006106896885695d,right: 0.999395294613725d,bottom: 0.2021566905997918d,left: 0.4389586167082067d),
new NpgsqlTypes.NpgsqlBox(top: 0.5086516597315193d,right: 0.6545400103904369d,bottom: 0.3459070888444762d,left: 0.49511401033257096d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 185,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7077500852788969d,right: 0.442181543801874d,bottom: 0.5402325515747023d,left: 0.11951952253569886d),
new NpgsqlTypes.NpgsqlBox(top: 0.8152369161709075d,right: 0.7356984194913321d,bottom: 0.40465846395402627d,left: 0.2690803938096167d),
new NpgsqlTypes.NpgsqlBox(top: 0.7679025614641928d,right: 0.6528217465886593d,bottom: 0.23646814469039878d,left: 0.4100015582875821d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9101034588007221d,right: 0.45928818160604024d,bottom: 0.754380598885878d,left: 0.11128472939250522d),
new NpgsqlTypes.NpgsqlBox(top: 0.8861554452359207d,right: 0.32118769159793714d,bottom: 0.3061902757784649d,left: 0.14747161904782746d),
new NpgsqlTypes.NpgsqlBox(top: 0.7114555975552512d,right: 0.7867317833546351d,bottom: 0.326327596278122d,left: 0.31394082789073097d),
},
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlBox(top: 0.5522566238665905d,right: 0.9168279972107072d,bottom: 0.14600576518464414d,left: 0.8020680412676073d),
new NpgsqlTypes.NpgsqlBox(top: 0.4470582057351373d,right: 0.3750443874401197d,bottom: 0.18436485904159006d,left: 0.133323550244564d),
new NpgsqlTypes.NpgsqlBox(top: 0.9497055971485291d,right: 0.405000006247468d,bottom: 0.11651435569497781d,left: 0.10109554311867086d),
new NpgsqlTypes.NpgsqlBox(top: 0.7022874733968145d,right: 0.8428002336953476d,bottom: 0.4385869106790642d,left: 0.14678330769176728d),
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
new NpgsqlTypes.NpgsqlBox(top: 0.31666283406855045d,right: 0.9920878680035325d,bottom: 0.1455844939600519d,left: 0.16650430609779632d),
new NpgsqlTypes.NpgsqlBox(top: 0.5099120328688295d,right: 0.47318837417722903d,bottom: 0.2172561148687131d,left: 0.28744921808426227d),
new NpgsqlTypes.NpgsqlBox(top: 0.21673919657605045d,right: 0.8509160134744843d,bottom: 0.008866751512374704d,left: 0.556145071777864d),
new NpgsqlTypes.NpgsqlBox(top: 0.6154833950042536d,right: 0.7813756686346863d,bottom: 0.4872815858856758d,left: 0.2676244273209093d),
}));
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.34183394811841183d,right: 0.38752206698469105d,bottom: 0.11703397473099508d,left: 0.13882472086752584d),
new NpgsqlTypes.NpgsqlBox(top: 0.3763503809778206d,right: 0.9943202700346769d,bottom: 0.11741239375677825d,left: 0.03746907397050969d),
new NpgsqlTypes.NpgsqlBox(top: 0.49241454644483995d,right: 0.863521428906817d,bottom: 0.059546357316025755d,left: 0.542369699747953d),
new NpgsqlTypes.NpgsqlBox(top: 0.7572937093658577d,right: 0.3207259849852857d,bottom: 0.021680121428355736d,left: 0.006632746879535523d),
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
                Assert.That(nullable, Is.Null);
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
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 176;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 176;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 176;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 170;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 155;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 114, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 148, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 9, query1, 170, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 9, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 155, query1, 148, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[34], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 63, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
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
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 43, query1, 73, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[34], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 63, query1, 162, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
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
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 176, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 22, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[34], false);
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
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[30], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[31], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[32], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[33], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 51);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[14], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[15], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[29], false);
                NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[30], false);
                NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[31], false);
                NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[32], false);
                NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[33], false);
                NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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

        [Test, Order(13)]
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
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI), typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                await ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
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
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

