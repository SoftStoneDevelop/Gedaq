

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
    internal partial interface INpgsqlBoxMArrayboxMArrayD2
    {
    }
    
    internal partial class NpgsqlBoxMArrayboxMArrayD2 : INpgsqlBoxMArrayboxMArrayD2
    {


#region TestData

        private readonly NpgsqlBoxboxMArrayD2E1M[] _testData = new NpgsqlBoxboxMArrayD2E1M[]
        {
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8554375181274717d,right: 0.23143381147750575d,bottom: 0.1705687288543175d,left: 0.01540414510550192d),
new NpgsqlTypes.NpgsqlBox(top: 0.564866126376325d,right: 0.8813390491151007d,bottom: 0.22142756356275206d,left: 0.3301531979101966d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5977902776550443d,right: 0.8770845959650322d,bottom: 0.5403093885534305d,left: 0.014490038742842493d),
new NpgsqlTypes.NpgsqlBox(top: 0.9480691353972203d,right: 0.9390941511543495d,bottom: 0.3670734500754569d,left: 0.5956900009058189d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9848572422371221d,right: 0.1882820563328249d,bottom: 0.05382233529410796d,left: 0.15700323422133577d),
new NpgsqlTypes.NpgsqlBox(top: 0.6216635807237804d,right: 0.7999394665562409d,bottom: 0.42994692477917973d,left: 0.44183218141870784d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6200143941128837d,right: 0.9760258135894758d,bottom: 0.3387085409950008d,left: 0.7839147041365332d),
new NpgsqlTypes.NpgsqlBox(top: 0.9985475151088273d,right: 0.9118439420706932d,bottom: 0.8444040020565836d,left: 0.6819902003531281d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7355589815525969d,right: 0.5805277771662056d,bottom: 0.6386152032873184d,left: 0.44045675379567095d),
new NpgsqlTypes.NpgsqlBox(top: 0.9230729805024144d,right: 0.7542625112078418d,bottom: 0.04254926681392157d,left: 0.7166672274895435d), } },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.49823974798181403d,right: 0.7239893459361633d,bottom: 0.4887020567665703d,left: 0.18576384606863816d),
new NpgsqlTypes.NpgsqlBox(top: 0.9893068627435831d,right: 0.8461988766717775d,bottom: 0.19639932685996775d,left: 0.7711027695463135d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6227526156135293d,right: 0.48663761030499264d,bottom: 0.27644251810804066d,left: 0.17758958564987704d),
new NpgsqlTypes.NpgsqlBox(top: 0.9803143675266813d,right: 0.8603907820744459d,bottom: 0.7200500125486813d,left: 0.6697372415029885d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5392003857999076d,right: 0.9617193237239752d,bottom: 0.3865514567770705d,left: 0.561117558090545d),
new NpgsqlTypes.NpgsqlBox(top: 0.7721840516578841d,right: 0.8907829415707701d,bottom: 0.2506577940608825d,left: 0.8347108379949465d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7930594486428293d,right: 0.6114775704015221d,bottom: 0.6351257907802386d,left: 0.019190503883093846d),
new NpgsqlTypes.NpgsqlBox(top: 0.7770113968384589d,right: 0.04995827332354685d,bottom: 0.5699470132700135d,left: 0.03447622981803178d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.36411524717456256d,right: 0.8511332102312834d,bottom: 0.0840329385117572d,left: 0.5150423831348694d),
new NpgsqlTypes.NpgsqlBox(top: 0.9923400059018566d,right: 0.7307003403635325d,bottom: 0.49990807758015654d,left: 0.29852026046014213d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6814185776053602d,right: 0.6399288598764877d,bottom: 0.35197239372092526d,left: 0.07351076029790515d),
new NpgsqlTypes.NpgsqlBox(top: 0.1877783794294875d,right: 0.9724915039594395d,bottom: 0.13589176340903653d,left: 0.7790108375112d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9340227975258494d,right: 0.21545511931149552d,bottom: 0.38620787449177285d,left: 0.1923090714101654d),
new NpgsqlTypes.NpgsqlBox(top: 0.5180609084478208d,right: 0.8027510749588721d,bottom: 0.12149625137118569d,left: 0.446975807145237d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5990290458396985d,right: 0.19014819804869842d,bottom: 0.5272473739792901d,left: 0.07022507542795042d),
new NpgsqlTypes.NpgsqlBox(top: 0.7633882948853125d,right: 0.6979814394273192d,bottom: 0.6016769783640001d,left: 0.6621809311799918d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6717154093132158d,right: 0.996164643363919d,bottom: 0.1050801373765119d,left: 0.3086192289316686d),
new NpgsqlTypes.NpgsqlBox(top: 0.6295769359121125d,right: 0.8169995865398819d,bottom: 0.07745377388437835d,left: 0.746219164956883d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.810006995231768d,right: 0.5128068810528942d,bottom: 0.6703068231550696d,left: 0.42293428633555796d),
new NpgsqlTypes.NpgsqlBox(top: 0.6359451899739729d,right: 0.20635467301563615d,bottom: 0.4223005471217972d,left: 0.14316495196274515d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8864433642165102d,right: 0.814204272877376d,bottom: 0.3230509967293065d,left: 0.3677418370312513d),
new NpgsqlTypes.NpgsqlBox(top: 0.677575722660131d,right: 0.7580470779872537d,bottom: 0.17340600110388393d,left: 0.6032340970386271d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.48817257597105435d,right: 0.47246529053436725d,bottom: 0.1971139564594141d,left: 0.345427209780792d),
new NpgsqlTypes.NpgsqlBox(top: 0.15406762539680996d,right: 0.15177687631183678d,bottom: 0.11753987711175917d,left: 0.09097273490495028d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.47338185105399766d,right: 0.9439609495487261d,bottom: 0.28932267138649626d,left: 0.6924593426814849d),
new NpgsqlTypes.NpgsqlBox(top: 0.691528430564101d,right: 0.21429689328143953d,bottom: 0.6078215246619065d,left: 0.05358534189727826d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.04422194904491583d,right: 0.5265332273889618d,bottom: 0.022117785600692774d,left: 0.4727462536701099d),
new NpgsqlTypes.NpgsqlBox(top: 0.49238855832932793d,right: 0.9132300902215643d,bottom: 0.01209702678128477d,left: 0.25492601556138617d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.861302675773926d,right: 0.9621350269576168d,bottom: 0.22558003972369178d,left: 0.832010104582855d),
new NpgsqlTypes.NpgsqlBox(top: 0.8267786648773543d,right: 0.7158184663636904d,bottom: 0.01850030706479655d,left: 0.32016863515808713d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7738871321060824d,right: 0.8486008056727218d,bottom: 0.7277539557253345d,left: 0.07588902539178422d),
new NpgsqlTypes.NpgsqlBox(top: 0.6753654838688876d,right: 0.6535152417448835d,bottom: 0.23650637555204412d,left: 0.3539949498659932d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6531438795834756d,right: 0.532781602435675d,bottom: 0.27057137684197774d,left: 0.3553355725568198d),
new NpgsqlTypes.NpgsqlBox(top: 0.8485506820244947d,right: 0.4478244203162841d,bottom: 0.5269906769999816d,left: 0.28073317276895915d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7411827985502312d,right: 0.8406119457540452d,bottom: 0.6238282160870262d,left: 0.3413390465909045d),
new NpgsqlTypes.NpgsqlBox(top: 0.9609867620793765d,right: 0.6805686988284728d,bottom: 0.13356940228628011d,left: 0.5067972628208826d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8844893474392541d,right: 0.9982278996268004d,bottom: 0.8230344835466404d,left: 0.03442486446333337d),
new NpgsqlTypes.NpgsqlBox(top: 0.8507907666513074d,right: 0.492178224252957d,bottom: 0.47438238858249593d,left: 0.09034666061926855d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8777981309606798d,right: 0.8017220021380862d,bottom: 0.025674575480331918d,left: 0.06884024388837562d),
new NpgsqlTypes.NpgsqlBox(top: 0.5986755174775671d,right: 0.7468370840706495d,bottom: 0.2730664243199036d,left: 0.0688834023432241d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.0363003231393384d,right: 0.7759261241008404d,bottom: 0.022370743004191174d,left: 0.43287575603956685d),
new NpgsqlTypes.NpgsqlBox(top: 0.8511333513435319d,right: 0.0244532478817987d,bottom: 0.14365930292135276d,left: 0.013974536632163526d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9892663549183592d,right: 0.687633128016511d,bottom: 0.3777264124588652d,left: 0.18463394502267627d),
new NpgsqlTypes.NpgsqlBox(top: 0.6414998241663271d,right: 0.08678604257720213d,bottom: 0.16752798839905558d,left: 0.04489471572959136d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.36963156320441304d,right: 0.9143114935841421d,bottom: 0.08567988911388402d,left: 0.424326465529302d),
new NpgsqlTypes.NpgsqlBox(top: 0.38278963295517265d,right: 0.9082524546757063d,bottom: 0.029963084568397913d,left: 0.5654047950688484d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.35942611996596974d,right: 0.8527520984990759d,bottom: 0.08736381230392753d,left: 0.6935944085326768d),
new NpgsqlTypes.NpgsqlBox(top: 0.7092048842318245d,right: 0.4988137876770954d,bottom: 0.6847827220911769d,left: 0.2853546771698726d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5335254099033789d,right: 0.9566795820219784d,bottom: 0.3855121123184351d,left: 0.06078883912743671d),
new NpgsqlTypes.NpgsqlBox(top: 0.35692019195164193d,right: 0.4657865560407013d,bottom: 0.2528834252253568d,left: 0.022596802429122653d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8557954962121472d,right: 0.6133884087851974d,bottom: 0.3129562585428519d,left: 0.5172077813574721d),
new NpgsqlTypes.NpgsqlBox(top: 0.5979757394009579d,right: 0.9315589973821741d,bottom: 0.27723862704737534d,left: 0.28766109590042677d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8257614011723673d,right: 0.6990856782523354d,bottom: 0.01738269135618442d,left: 0.5640957641713016d),
new NpgsqlTypes.NpgsqlBox(top: 0.18451742850852204d,right: 0.25781764734440604d,bottom: 0.046979199401006366d,left: 0.18334980870438022d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.936618687388946d,right: 0.6682588388366922d,bottom: 0.7537294891246639d,left: 0.23443588664378856d),
new NpgsqlTypes.NpgsqlBox(top: 0.9678726271693595d,right: 0.852992664557418d,bottom: 0.6260595831294578d,left: 0.3093360622210558d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9005415482496287d,right: 0.5089160787847178d,bottom: 0.24579343037827206d,left: 0.11655300192255569d),
new NpgsqlTypes.NpgsqlBox(top: 0.8844919662459176d,right: 0.9530229797524641d,bottom: 0.20676818912907324d,left: 0.48805894196398303d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6383451174608136d,right: 0.8466309060951703d,bottom: 0.13938647413064265d,left: 0.24308651572692652d),
new NpgsqlTypes.NpgsqlBox(top: 0.3944371028438306d,right: 0.5856088347117429d,bottom: 0.3565973188392584d,left: 0.5294161104796568d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5044042863107835d,right: 0.7888738005558158d,bottom: 0.4498801956624514d,left: 0.1017627277962937d),
new NpgsqlTypes.NpgsqlBox(top: 0.7027733205978939d,right: 0.8245238400044087d,bottom: 0.10229404988219981d,left: 0.02710987699832479d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.44311255614083267d,right: 0.6114038226912497d,bottom: 0.376042997693559d,left: 0.2798400222373697d),
new NpgsqlTypes.NpgsqlBox(top: 0.6798265864436701d,right: 0.5819354788626777d,bottom: 0.3138409978899014d,left: 0.20624888074719083d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.627261118983126d,right: 0.49706993057883553d,bottom: 0.5420018882149259d,left: 0.2726905375548433d),
new NpgsqlTypes.NpgsqlBox(top: 0.2162198280389287d,right: 0.9953577659741651d,bottom: 0.08469208990790811d,left: 0.3682217534130148d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.45107667191630385d,right: 0.7854607785299654d,bottom: 0.004391967114824813d,left: 0.28391453997606797d),
new NpgsqlTypes.NpgsqlBox(top: 0.8722175297636519d,right: 0.9589192290154729d,bottom: 0.687700821511787d,left: 0.3460067717202183d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8131866134142471d,right: 0.3753363818916635d,bottom: 0.13572421668239742d,left: 0.09376736394953633d),
new NpgsqlTypes.NpgsqlBox(top: 0.9602604436679669d,right: 0.2793455981054591d,bottom: 0.31253970607820847d,left: 0.10600034487549437d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.3801947901058709d,right: 0.3500738546104055d,bottom: 0.3762472871959043d,left: 0.11949872924717242d),
new NpgsqlTypes.NpgsqlBox(top: 0.9109044839072941d,right: 0.8757841951834251d,bottom: 0.7513513008479313d,left: 0.38389554779772317d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7785223424256004d,right: 0.548795430319071d,bottom: 0.5574940407466067d,left: 0.11892739468790148d),
new NpgsqlTypes.NpgsqlBox(top: 0.6113253321731468d,right: 0.3157483831929392d,bottom: 0.2562373402754171d,left: 0.19774738943572134d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6212207399972653d,right: 0.8250585724850005d,bottom: 0.1175549839712341d,left: 0.6446790399950693d),
new NpgsqlTypes.NpgsqlBox(top: 0.6146421359723776d,right: 0.8035519444922978d,bottom: 0.22948055537337897d,left: 0.7426919760111516d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6795682619109068d,right: 0.7562045038432841d,bottom: 0.2075858624422282d,left: 0.3286653108368003d),
new NpgsqlTypes.NpgsqlBox(top: 0.9476330020215039d,right: 0.4493892768104175d,bottom: 0.5281132145145508d,left: 0.2501959525891383d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5151880257515725d,right: 0.2894747508087363d,bottom: 0.026503994830318844d,left: 0.10365203513614352d),
new NpgsqlTypes.NpgsqlBox(top: 0.8837911962871009d,right: 0.374363833325993d,bottom: 0.2907717623502578d,left: 0.17920283735995868d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9165864900949259d,right: 0.31953474537326676d,bottom: 0.41826800290294275d,left: 0.06802660593411436d),
new NpgsqlTypes.NpgsqlBox(top: 0.7528849441333484d,right: 0.5289880377429246d,bottom: 0.2592245390340082d,left: 0.06010955424583808d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6127909608069471d,right: 0.4889359526945538d,bottom: 0.039137869155225435d,left: 0.08061155409546139d),
new NpgsqlTypes.NpgsqlBox(top: 0.32499032608776723d,right: 0.46443900542327965d,bottom: 0.13849792882259981d,left: 0.30684063916475457d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7131108732812059d,right: 0.8707982954744421d,bottom: 0.5922713306074225d,left: 0.18397361895961029d),
new NpgsqlTypes.NpgsqlBox(top: 0.8716649870925304d,right: 0.6548595773630936d,bottom: 0.1413807164015759d,left: 0.36972892990229533d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.4310426204685144d,right: 0.42036311907125035d,bottom: 0.2341250468898386d,left: 0.2101805241073863d),
new NpgsqlTypes.NpgsqlBox(top: 0.33266402269262974d,right: 0.905817986541337d,bottom: 0.22382647897733265d,left: 0.5637187359710263d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8760999738299131d,right: 0.8013559168082385d,bottom: 0.8541996254964187d,left: 0.7101267474913497d),
new NpgsqlTypes.NpgsqlBox(top: 0.5851322781312558d,right: 0.9404727170313532d,bottom: 0.143065789904813d,left: 0.7893002412798846d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.47166172745238344d,right: 0.7695309667122471d,bottom: 0.4409092958389388d,left: 0.35968911650876567d),
new NpgsqlTypes.NpgsqlBox(top: 0.8011931363525355d,right: 0.8213808019403469d,bottom: 0.23630224151200074d,left: 0.6362981417994843d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6726829474447339d,right: 0.7379807625270278d,bottom: 0.22110406456863452d,left: 0.4686812961923831d),
new NpgsqlTypes.NpgsqlBox(top: 0.2864032481439296d,right: 0.9467396591033803d,bottom: 0.18241279735644644d,left: 0.2533890990065586d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.4913611267756328d,right: 0.5054029103709026d,bottom: 0.20775676598163195d,left: 0.3699897137573248d),
new NpgsqlTypes.NpgsqlBox(top: 0.4370401590563744d,right: 0.9820811313359972d,bottom: 0.019764927813735733d,left: 0.12724682046977442d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9150312527285921d,right: 0.7255371600176709d,bottom: 0.8694721821292696d,left: 0.2921258497154875d),
new NpgsqlTypes.NpgsqlBox(top: 0.6087010228353031d,right: 0.45912153772776876d,bottom: 0.18785136553305004d,left: 0.031538660620109904d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.36154469410029055d,right: 0.7316623060319378d,bottom: 0.019531534752327606d,left: 0.10407531319436492d),
new NpgsqlTypes.NpgsqlBox(top: 0.8053878293092227d,right: 0.7781087423695651d,bottom: 0.7884237704133228d,left: 0.23609175788224357d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.3456637023412451d,right: 0.5520393851477358d,bottom: 0.0794041164356647d,left: 0.1809204078542439d),
new NpgsqlTypes.NpgsqlBox(top: 0.7883605242948003d,right: 0.9580283150578442d,bottom: 0.7408835621124714d,left: 0.9247714857391497d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5807453370230974d,right: 0.5188271663957178d,bottom: 0.36666946427448444d,left: 0.2475886804476901d),
new NpgsqlTypes.NpgsqlBox(top: 0.11490192409830102d,right: 0.6126855791162045d,bottom: 0.023126268464387145d,left: 0.22432588772500528d), } },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8170087842180589d,right: 0.9331974474205571d,bottom: 0.20214358661152698d,left: 0.8927994370166413d),
new NpgsqlTypes.NpgsqlBox(top: 0.8764004721778526d,right: 0.671986185021521d,bottom: 0.2766467315286226d,left: 0.6717555166273955d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6994378397637537d,right: 0.2299472025636854d,bottom: 0.026822666532611228d,left: 0.14373840598713628d),
new NpgsqlTypes.NpgsqlBox(top: 0.5070867032065999d,right: 0.9239967550378739d,bottom: 0.048243602778370365d,left: 0.7837733647524019d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6462945810281264d,right: 0.1753910468874721d,bottom: 0.34895929632686296d,left: 0.08284072354590066d),
new NpgsqlTypes.NpgsqlBox(top: 0.5533218602638361d,right: 0.8841723020706258d,bottom: 0.08013744928156441d,left: 0.6958768125729898d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.1947496836259589d,right: 0.7448451461176846d,bottom: 0.18989249010580111d,left: 0.44006358982484606d),
new NpgsqlTypes.NpgsqlBox(top: 0.7963038861561604d,right: 0.6313171071066668d,bottom: 0.5414725022288209d,left: 0.6303119809762752d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7952890588512934d,right: 0.8892997387099442d,bottom: 0.17049489477832613d,left: 0.32082425060819886d),
new NpgsqlTypes.NpgsqlBox(top: 0.5702026652086423d,right: 0.6781910469738178d,bottom: 0.04073077939656555d,left: 0.6421639392688888d), } },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.5559640843468139d,right: 0.5296821519904047d,bottom: 0.2629715595796841d,left: 0.08748208563693738d),
new NpgsqlTypes.NpgsqlBox(top: 0.4273712840161492d,right: 0.7939086362728706d,bottom: 0.051605332850994556d,left: 0.21149412864840544d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7406509806406899d,right: 0.6348272353063386d,bottom: 0.1738869461218584d,left: 0.4565208450682904d),
new NpgsqlTypes.NpgsqlBox(top: 0.6224645757079295d,right: 0.9678814036605036d,bottom: 0.5332330947027184d,left: 0.8834496269639257d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.7888380383206143d,right: 0.9795939847415365d,bottom: 0.21171360055895694d,left: 0.7192271142990461d),
new NpgsqlTypes.NpgsqlBox(top: 0.29095166967535246d,right: 0.4299064391526235d,bottom: 0.16688757364950935d,left: 0.17069405884343225d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.690480815824015d,right: 0.9800881670278333d,bottom: 0.11209076458110079d,left: 0.9102262017887478d),
new NpgsqlTypes.NpgsqlBox(top: 0.7853803621751475d,right: 0.5483673843574579d,bottom: 0.45424252563653056d,left: 0.23407147659563043d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.610576407462898d,right: 0.9464023600479015d,bottom: 0.5998252463438425d,left: 0.3404642357897605d),
new NpgsqlTypes.NpgsqlBox(top: 0.8189780613593275d,right: 0.7997036039578336d,bottom: 0.16452727190703376d,left: 0.2852478878066318d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.34184027844444653d,right: 0.6496731209564274d,bottom: 0.31857501628691176d,left: 0.35187387114407287d),
new NpgsqlTypes.NpgsqlBox(top: 0.9575568043843178d,right: 0.5034068189607871d,bottom: 0.8779718558785164d,left: 0.3807248987579305d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8075925990776454d,right: 0.5945794504464469d,bottom: 0.21206640785557473d,left: 0.26726360358098333d),
new NpgsqlTypes.NpgsqlBox(top: 0.8084898503833231d,right: 0.27885290001985763d,bottom: 0.6972259054285542d,left: 0.23427027543141643d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.9464585384102264d,right: 0.14986345895924003d,bottom: 0.8960396663241307d,left: 0.1461294388496479d),
new NpgsqlTypes.NpgsqlBox(top: 0.6039014203379754d,right: 0.9528107681617354d,bottom: 0.383245325821978d,left: 0.276141504232866d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.6559336902156013d,right: 0.27007396179672283d,bottom: 0.07351040699309697d,left: 0.09556097503746874d),
new NpgsqlTypes.NpgsqlBox(top: 0.5777255762506404d,right: 0.09255815371612663d,bottom: 0.5031821995738622d,left: 0.08142635783615426d), } },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.790281602430834d,right: 0.9031848087112446d,bottom: 0.41421077989046684d,left: 0.3356911646764278d),
new NpgsqlTypes.NpgsqlBox(top: 0.7243722113212747d,right: 0.6056840838507772d,bottom: 0.08326862083384079d,left: 0.4772705142512984d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8540195546930373d,right: 0.5085922547522884d,bottom: 0.47102857960973854d,left: 0.501938579560041d),
new NpgsqlTypes.NpgsqlBox(top: 0.3883154203759055d,right: 0.9638378866487639d,bottom: 0.3060556580840378d,left: 0.7830905023196297d), } },
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 179,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.12947866949992093d,right: 0.8618360272797594d,bottom: 0.09244001420905745d,left: 0.4057811210890093d),
new NpgsqlTypes.NpgsqlBox(top: 0.49868930306077597d,right: 0.6518335210317321d,bottom: 0.020276887591746062d,left: 0.19762035974411385d), } },
    ModelInner = new NpgsqlBoxboxMArrayD21MI
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8221698271691155d,right: 0.09341260516725758d,bottom: 0.8207623967731943d,left: 0.07659175037836385d),
new NpgsqlTypes.NpgsqlBox(top: 0.4192232459484475d,right: 0.7143458349627663d,bottom: 0.19571299983645385d,left: 0.12585594433097125d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMArrayD2E1M
{
    Id = 188,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.4796912790693144d,right: 0.52803023827736d,bottom: 0.3869110537844854d,left: 0.09625166209111347d),
new NpgsqlTypes.NpgsqlBox(top: 0.15454339333937905d,right: 0.1465565757395516d,bottom: 0.035803133860923375d,left: 0.09722548600502467d), } },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmarrayd21mi(
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmarrayd21mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
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

                changedRows =  ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmarrayd21mi_id
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxmarrayd21mi_id", 
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
                changedRows =  ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmarrayd21mi_id
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
    npgsqlboxboxmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlBoxMArrayboxMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlBoxMArrayboxMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlBoxMArrayboxMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlBoxMArrayboxMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.04422194904491583d,right: 0.5265332273889618d,bottom: 0.022117785600692774d,left: 0.4727462536701099d),
new NpgsqlTypes.NpgsqlBox(top: 0.49238855832932793d,right: 0.9132300902215643d,bottom: 0.01209702678128477d,left: 0.25492601556138617d), } }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmarrayd21mi_id
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
    npgsqlboxboxmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxmarrayd21mi_id", 
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
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                nullable =  ((INpgsqlBoxMArrayboxMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxMArrayboxMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { {
new NpgsqlTypes.NpgsqlBox(top: 0.8844893474392541d,right: 0.9982278996268004d,bottom: 0.8230344835466404d,left: 0.03442486446333337d),
new NpgsqlTypes.NpgsqlBox(top: 0.8507907666513074d,right: 0.492178224252957d,bottom: 0.47438238858249593d,left: 0.09034666061926855d), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                nullable = await ((INpgsqlBoxMArrayboxMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxMArrayboxMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMArrayD2E1M> models = null;

                models =  ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMArrayD2E1M> models = null;

                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxMArrayboxMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD2E1M), typeof(FlatNpgsqlBoxboxMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmarrayd21mi mi ON mi.id = m.npgsqlboxboxmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD2E1M), typeof(FlatNpgsqlBoxboxMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmarrayd21mi mi ON mi.id = m.npgsqlboxboxmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD2E1M), typeof(FlatNpgsqlBoxboxMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                await((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
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
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 171;
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
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmarrayd21mi mi ON mi.id = m.npgsqlboxboxmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
                var models = await((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD2E1M), typeof(FlatNpgsqlBoxboxMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                await((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 16, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 163, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 121, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 90, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 15, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 52, query1, 149, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 42, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
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
FROM public.npgsqlboxboxmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 136, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlboxboxmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmarrayd21mi mi ON mi.id = m.npgsqlboxboxmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
                var models = await((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 149, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 114, 70))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxboxMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxMArrayboxMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxMArrayboxMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 108);
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxMArrayboxMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxMArrayboxMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models =  ((INpgsqlBoxMArrayboxMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                NpgsqlBoxboxMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
FROM public.binary_npgsqlboxboxmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMArrayD21MIWA),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMArrayD21MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMArrayD21MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMArrayD21MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMArrayD21MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmarrayd21mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMArrayD21MI),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMArrayD21MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMArrayD21MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMArrayD21MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMArrayD21MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxmarrayd21mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2))]
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
FROM public.binary_npgsqlboxboxmarrayd2e1m m
LEFT JOIN public.binary_npgsqlboxboxmarrayd21mi mi ON mi.id = m.npgsqlboxboxmarrayd21mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxmarrayd21mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
                var models =  ((INpgsqlBoxMArrayboxMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD21MIWA), typeof(NpgsqlBoxboxMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
                var models1 = new List<NpgsqlBoxboxMArrayD21MIWA>();
                var models2 = new List<NpgsqlBoxboxMArrayD21MIWA>();
                await ((INpgsqlBoxMArrayboxMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMArrayD21MIWA>();
                var models2 = new List<NpgsqlBoxboxMArrayD21MIWA>();
                ((INpgsqlBoxMArrayboxMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmarrayd21mi
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
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmarrayd21mi
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
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD21MIWA), typeof(NpgsqlBoxboxMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2))]
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
                var models1 = new List<NpgsqlBoxboxMArrayD21MIWA>();
                var models2 = new List<NpgsqlBoxboxMArrayD21MIWA>();
                await ((INpgsqlBoxMArrayboxMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMArrayD21MIWA>();
                var models2 = new List<NpgsqlBoxboxMArrayD21MIWA>();
                ((INpgsqlBoxMArrayboxMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2))]
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
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmarrayd21mi
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
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmarrayd21mi
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
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD21MI), typeof(NpgsqlBoxboxMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
                var models1 = new List<NpgsqlBoxboxMArrayD21MI>();
                var models2 = new List<NpgsqlBoxboxMArrayD21MI>();
                await ((INpgsqlBoxMArrayboxMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMArrayD21MI>();
                var models2 = new List<NpgsqlBoxboxMArrayD21MI>();
                ((INpgsqlBoxMArrayboxMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmarrayd21mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2)),
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
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD21MIWA), typeof(NpgsqlBoxboxMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2))]
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
                var models1 = new List<NpgsqlBoxboxMArrayD21MIWA>();
                var models2 = new List<NpgsqlBoxboxMArrayD21MIWA>();
                await ((INpgsqlBoxMArrayboxMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMArrayD21MIWA>();
                var models2 = new List<NpgsqlBoxboxMArrayD21MIWA>();
                ((INpgsqlBoxMArrayboxMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMArrayD2))]
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
                var models = await ((INpgsqlBoxMArrayboxMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

