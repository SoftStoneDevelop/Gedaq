

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
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6899987994215259d,right: 0.9817555521318437d,bottom: 0.0939300594398893d,left: 0.8697771359621144d),
new NpgsqlTypes.NpgsqlBox(top: 0.8959840856170501d,right: 0.8045096283218746d,bottom: 0.22580414148969696d,left: 0.15212965964959035d),
new NpgsqlTypes.NpgsqlBox(top: 0.5110984204360518d,right: 0.46481415236167867d,bottom: 0.3060407186237787d,left: 0.22143344401725595d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4912467902947584d,right: 0.7490804036684893d,bottom: 0.33872073796518587d,left: 0.3345426396071577d),
new NpgsqlTypes.NpgsqlBox(top: 0.9454286127870006d,right: 0.41099462487826877d,bottom: 0.8974089512800172d,left: 0.08935053696794248d),
new NpgsqlTypes.NpgsqlBox(top: 0.551362281477003d,right: 0.9200509572281165d,bottom: 0.24746678890220186d,left: 0.018227298705447037d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8771027281448667d,right: 0.7042139214689676d,bottom: 0.06926391265688181d,left: 0.0432366969028557d),
new NpgsqlTypes.NpgsqlBox(top: 0.8144354633155341d,right: 0.5249188951326752d,bottom: 0.23314787816251892d,left: 0.514085620323625d),
new NpgsqlTypes.NpgsqlBox(top: 0.4439494910646711d,right: 0.9602736282219937d,bottom: 0.029183341484335212d,left: 0.585786947982785d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9595230720623652d,right: 0.22617959679066824d,bottom: 0.8509784296597654d,left: 0.05550580498540769d),
new NpgsqlTypes.NpgsqlBox(top: 0.5011691387518841d,right: 0.2941416604424444d,bottom: 0.06695705390589524d,left: 0.24100725952603252d),
new NpgsqlTypes.NpgsqlBox(top: 0.8743939338031865d,right: 0.7466027868883744d,bottom: 0.4082195355268097d,left: 0.576741944059047d),
new NpgsqlTypes.NpgsqlBox(top: 0.9579587888419684d,right: 0.7895575423976993d,bottom: 0.8798522166491037d,left: 0.6562017785049932d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8507034868600925d,right: 0.7796745125686256d,bottom: 0.4329440576962351d,left: 0.27861393606065654d),
new NpgsqlTypes.NpgsqlBox(top: 0.925122324613604d,right: 0.4831724088658925d,bottom: 0.5582963498445089d,left: 0.052306580470075414d),
new NpgsqlTypes.NpgsqlBox(top: 0.9633794404019999d,right: 0.6129405581651164d,bottom: 0.061797238615394545d,left: 0.047030985937970615d),
new NpgsqlTypes.NpgsqlBox(top: 0.4353143867498679d,right: 0.8075512664099546d,bottom: 0.24682024346598108d,left: 0.20312306290568238d),
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
new NpgsqlTypes.NpgsqlBox(top: 0.809744087769625d,right: 0.8512671262715109d,bottom: 0.13428355952130722d,left: 0.5389908711911756d),
new NpgsqlTypes.NpgsqlBox(top: 0.36190010767560143d,right: 0.0931158701075464d,bottom: 0.30636302630666035d,left: 0.05058955735739057d),
new NpgsqlTypes.NpgsqlBox(top: 0.31256045957332934d,right: 0.9274209256704354d,bottom: 0.0965894221852801d,left: 0.7035785688127513d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9187118623166665d,right: 0.22236671738384806d,bottom: 0.4886493887500575d,left: 0.07501742882490214d),
new NpgsqlTypes.NpgsqlBox(top: 0.4471546774662998d,right: 0.6663341745074335d,bottom: 0.2840005579832572d,left: 0.6077029946554243d),
new NpgsqlTypes.NpgsqlBox(top: 0.3218369389666881d,right: 0.4614313137454843d,bottom: 0.3186527988812716d,left: 0.4475214512892691d),
new NpgsqlTypes.NpgsqlBox(top: 0.7257525257829861d,right: 0.7117377674796351d,bottom: 0.5479011582954806d,left: 0.23308082991478263d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7338090771043153d,right: 0.842776189060173d,bottom: 0.509379846375707d,left: 0.23471497358234572d),
new NpgsqlTypes.NpgsqlBox(top: 0.7558729417419651d,right: 0.34434666425048555d,bottom: 0.182798918083108d,left: 0.12557150221605606d),
new NpgsqlTypes.NpgsqlBox(top: 0.7089710547797092d,right: 0.7812172712065266d,bottom: 0.32381223239235646d,left: 0.645740107226386d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3055968453852783d,right: 0.9565906585473116d,bottom: 0.22623173422258747d,left: 0.6295539638697513d),
new NpgsqlTypes.NpgsqlBox(top: 0.9148131022580338d,right: 0.32408696488701316d,bottom: 0.12153180937443242d,left: 0.006836006226807578d),
new NpgsqlTypes.NpgsqlBox(top: 0.6739890161716987d,right: 0.8286650226312328d,bottom: 0.23922842006519196d,left: 0.04695531770845962d),
new NpgsqlTypes.NpgsqlBox(top: 0.7296066895700245d,right: 0.7679565927836451d,bottom: 0.24376920174725714d,left: 0.34821101682617617d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4327859036881003d,right: 0.7523584722704082d,bottom: 0.30440389116811606d,left: 0.296020560881156d),
new NpgsqlTypes.NpgsqlBox(top: 0.6971122365964876d,right: 0.8788501140457465d,bottom: 0.3826137164425326d,left: 0.2348624638388721d),
new NpgsqlTypes.NpgsqlBox(top: 0.5293737952667794d,right: 0.19647097400657654d,bottom: 0.4485687477320899d,left: 0.048124865680889584d),
new NpgsqlTypes.NpgsqlBox(top: 0.6462279023213994d,right: 0.5583146748930036d,bottom: 0.4069236758897442d,left: 0.27954552515424125d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3544964273878024d,right: 0.3340732240062957d,bottom: 0.21097177045757587d,left: 0.3083277677248474d),
new NpgsqlTypes.NpgsqlBox(top: 0.9924565082002602d,right: 0.5488024703394012d,bottom: 0.44447568138046767d,left: 0.4891721268509045d),
new NpgsqlTypes.NpgsqlBox(top: 0.7814548549499302d,right: 0.18374315681308628d,bottom: 0.5651005719100705d,left: 0.12511127616173157d),
new NpgsqlTypes.NpgsqlBox(top: 0.43148161033772336d,right: 0.9671200840730397d,bottom: 0.350519301874644d,left: 0.36462593807428645d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.33309373656861674d,right: 0.47831044565613323d,bottom: 0.3040093845458811d,left: 0.3180085947908079d),
new NpgsqlTypes.NpgsqlBox(top: 0.44192873395604504d,right: 0.7340647382565082d,bottom: 0.40828878341114716d,left: 0.5054942884740672d),
new NpgsqlTypes.NpgsqlBox(top: 0.7249872110116469d,right: 0.6438619974345036d,bottom: 0.032828622164092325d,left: 0.08906493429967366d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.188864990105299d,right: 0.4143241252174452d,bottom: 0.1351012015584263d,left: 0.3976179907737316d),
new NpgsqlTypes.NpgsqlBox(top: 0.48954284849186724d,right: 0.3594876969668285d,bottom: 0.09133246403933648d,left: 0.15762941952626242d),
new NpgsqlTypes.NpgsqlBox(top: 0.8452170250139867d,right: 0.8558691276817846d,bottom: 0.39546793205823283d,left: 0.35249572085313263d),
new NpgsqlTypes.NpgsqlBox(top: 0.45849380126723294d,right: 0.8645693216173875d,bottom: 0.24917894662880924d,left: 0.507095002179154d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5946440190679881d,right: 0.5961853503788948d,bottom: 0.04156772629169969d,left: 0.03421950601087498d),
new NpgsqlTypes.NpgsqlBox(top: 0.7548170070187888d,right: 0.22084575732065315d,bottom: 0.441456772192483d,left: 0.09221517654698108d),
new NpgsqlTypes.NpgsqlBox(top: 0.929235855479032d,right: 0.5453958822367062d,bottom: 0.5265661640201409d,left: 0.5017399317004326d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7375136628886885d,right: 0.7927699107989976d,bottom: 0.15729468591651952d,left: 0.447902450579582d),
new NpgsqlTypes.NpgsqlBox(top: 0.5988090573267262d,right: 0.9947531650429348d,bottom: 0.312462528977443d,left: 0.059653175277180726d),
new NpgsqlTypes.NpgsqlBox(top: 0.5909707507638849d,right: 0.6934257192021656d,bottom: 0.5688539201160463d,left: 0.5050584630024462d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7626210982340492d,right: 0.8902311869498579d,bottom: 0.36298228781134323d,left: 0.16067459950294638d),
new NpgsqlTypes.NpgsqlBox(top: 0.6826151355498113d,right: 0.26944337469921154d,bottom: 0.5704694903036258d,left: 0.08219448059252887d),
new NpgsqlTypes.NpgsqlBox(top: 0.9880196639141906d,right: 0.8682527546612342d,bottom: 0.4608208353648835d,left: 0.38313850836565966d),
new NpgsqlTypes.NpgsqlBox(top: 0.465973365233162d,right: 0.5582106729744039d,bottom: 0.015866462644824275d,left: 0.24659278876101942d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.30317465069705196d,right: 0.10379408686948499d,bottom: 0.036311391300350326d,left: 0.09497545489044346d),
new NpgsqlTypes.NpgsqlBox(top: 0.7042055994830029d,right: 0.8126238435209426d,bottom: 0.6755508349354352d,left: 0.7652008530662687d),
new NpgsqlTypes.NpgsqlBox(top: 0.9856683042468357d,right: 0.6814061709424624d,bottom: 0.06489024834371604d,left: 0.4930011459322656d),
new NpgsqlTypes.NpgsqlBox(top: 0.5818788033775109d,right: 0.6685325228921218d,bottom: 0.4020240327095096d,left: 0.10149648313079718d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5473623126505659d,right: 0.6723063937529485d,bottom: 0.033775497141072086d,left: 0.47000942351544694d),
new NpgsqlTypes.NpgsqlBox(top: 0.9223429307332554d,right: 0.5917824716318131d,bottom: 0.6260842053731205d,left: 0.09118419983555726d),
new NpgsqlTypes.NpgsqlBox(top: 0.20534970770860972d,right: 0.9104773954374481d,bottom: 0.14155077428854812d,left: 0.5699558362647223d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9223982484142983d,right: 0.5427203250654185d,bottom: 0.7425669527694826d,left: 0.4006069288882982d),
new NpgsqlTypes.NpgsqlBox(top: 0.9339048728777223d,right: 0.6971448354730144d,bottom: 0.6327834687365118d,left: 0.19458599671699361d),
new NpgsqlTypes.NpgsqlBox(top: 0.6963864403883543d,right: 0.5668203611417459d,bottom: 0.6112898254186325d,left: 0.08960603123971966d),
new NpgsqlTypes.NpgsqlBox(top: 0.9388120123193853d,right: 0.7974819016168695d,bottom: 0.4384976712213642d,left: 0.5852506953450671d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5704877993121443d,right: 0.9560400183875357d,bottom: 0.5421430955958466d,left: 0.3980955301374087d),
new NpgsqlTypes.NpgsqlBox(top: 0.9101038988465158d,right: 0.9013571380687244d,bottom: 0.28375495574066534d,left: 0.012641272200722864d),
new NpgsqlTypes.NpgsqlBox(top: 0.7366179300432318d,right: 0.38290840641325996d,bottom: 0.6839777338241438d,left: 0.03577146700648426d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9712580565613244d,right: 0.7363525814532016d,bottom: 0.3737914348685293d,left: 0.679215315519367d),
new NpgsqlTypes.NpgsqlBox(top: 0.573892020739545d,right: 0.5926978544741487d,bottom: 0.09188721712265246d,left: 0.28686022379094256d),
new NpgsqlTypes.NpgsqlBox(top: 0.28958895252474703d,right: 0.8771109623344968d,bottom: 0.1709183432984125d,left: 0.36943845916298157d),
new NpgsqlTypes.NpgsqlBox(top: 0.3506780113066922d,right: 0.7611239104002077d,bottom: 0.11414987099685103d,left: 0.10266415017673225d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7002279710329538d,right: 0.875420285648918d,bottom: 0.3197568340654602d,left: 0.7893245496632376d),
new NpgsqlTypes.NpgsqlBox(top: 0.9127829542647596d,right: 0.9277167947029576d,bottom: 0.42845728388050175d,left: 0.30775564876988437d),
new NpgsqlTypes.NpgsqlBox(top: 0.8108420905951575d,right: 0.9303867801438397d,bottom: 0.6119521569700633d,left: 0.34763521473823067d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9192606545716799d,right: 0.3565895945139097d,bottom: 0.7498917738139026d,left: 0.06795411441541455d),
new NpgsqlTypes.NpgsqlBox(top: 0.8455162545399156d,right: 0.8437628266824821d,bottom: 0.7448998381350808d,left: 0.5257374136614492d),
new NpgsqlTypes.NpgsqlBox(top: 0.591959609616196d,right: 0.9696076470153163d,bottom: 0.45049378790998784d,left: 0.22064476768700658d),
new NpgsqlTypes.NpgsqlBox(top: 0.5502918773954724d,right: 0.6368982017006863d,bottom: 0.16695945592452432d,left: 0.27710732557770734d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.87519658233809d,right: 0.9259106924749656d,bottom: 0.7793903314696823d,left: 0.7130088196831897d),
new NpgsqlTypes.NpgsqlBox(top: 0.5773416010160795d,right: 0.8879176197222994d,bottom: 0.49165628272187556d,left: 0.47655430780657737d),
new NpgsqlTypes.NpgsqlBox(top: 0.6905298900734909d,right: 0.9881333543754989d,bottom: 0.2708217779620542d,left: 0.955443627601313d),
new NpgsqlTypes.NpgsqlBox(top: 0.8031258488596251d,right: 0.5589424613650654d,bottom: 0.7358226705859786d,left: 0.43342276368213417d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.23277006471509765d,right: 0.8627611359215885d,bottom: 0.16844514694193657d,left: 0.6787456387487858d),
new NpgsqlTypes.NpgsqlBox(top: 0.8932485036495478d,right: 0.8052251768386339d,bottom: 0.793701001730097d,left: 0.34258943500303085d),
new NpgsqlTypes.NpgsqlBox(top: 0.7194276765237156d,right: 0.5582629621626447d,bottom: 0.16255690986527815d,left: 0.08650680558041746d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9997323738484353d,right: 0.8686931646430802d,bottom: 0.2947204225015919d,left: 0.6557170375172113d),
new NpgsqlTypes.NpgsqlBox(top: 0.6734462781598325d,right: 0.7096965884379834d,bottom: 0.11254817721297483d,left: 0.3025839003939865d),
new NpgsqlTypes.NpgsqlBox(top: 0.7071718466624515d,right: 0.8522431127775717d,bottom: 0.279871181542819d,left: 0.8429623799181064d),
new NpgsqlTypes.NpgsqlBox(top: 0.5048499684728148d,right: 0.6133273236843706d,bottom: 0.49024164812241233d,left: 0.358484613714277d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5175394739000703d,right: 0.9968857823341974d,bottom: 0.49605724445008137d,left: 0.00235913488839834d),
new NpgsqlTypes.NpgsqlBox(top: 0.8940794034260925d,right: 0.843995311850576d,bottom: 0.8372838772782418d,left: 0.42455233018083216d),
new NpgsqlTypes.NpgsqlBox(top: 0.25327301208772957d,right: 0.6740151836655653d,bottom: 0.19109106352395477d,left: 0.4271651434811844d),
new NpgsqlTypes.NpgsqlBox(top: 0.40088947200274405d,right: 0.17851299683356492d,bottom: 0.12698319883879572d,left: 0.055544676699468054d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5273338054851153d,right: 0.8057387951067176d,bottom: 0.34960368700976374d,left: 0.5544620155819064d),
new NpgsqlTypes.NpgsqlBox(top: 0.5581900146763966d,right: 0.5499350413588269d,bottom: 0.5419475461930948d,left: 0.21495834967888983d),
new NpgsqlTypes.NpgsqlBox(top: 0.9051833925780902d,right: 0.2968983751593829d,bottom: 0.11926204955204123d,left: 0.03417138643945572d),
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
new NpgsqlTypes.NpgsqlBox(top: 0.6211401368656203d,right: 0.5727273388121082d,bottom: 0.36267944167673716d,left: 0.4024798332956069d),
new NpgsqlTypes.NpgsqlBox(top: 0.5852376258345827d,right: 0.11841121546327016d,bottom: 0.1233533987068478d,left: 0.028758157750422786d),
new NpgsqlTypes.NpgsqlBox(top: 0.9682266981727118d,right: 0.5952899238634818d,bottom: 0.15433424504125093d,left: 0.44378574464486287d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.26968663912876367d,right: 0.8292630995013085d,bottom: 0.12851843280171638d,left: 0.02186343650378919d),
new NpgsqlTypes.NpgsqlBox(top: 0.1535111758765606d,right: 0.6815648152314052d,bottom: 0.1309012901755504d,left: 0.6304560263239398d),
new NpgsqlTypes.NpgsqlBox(top: 0.1913420861511015d,right: 0.39726565292839555d,bottom: 0.18633284549269669d,left: 0.19676607717049432d),
new NpgsqlTypes.NpgsqlBox(top: 0.43719176423061135d,right: 0.7159870534610847d,bottom: 0.3941854469861584d,left: 0.5164178158972398d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.34723404320987294d,right: 0.8209744865534107d,bottom: 0.027305025733806443d,left: 0.4171897794192736d),
new NpgsqlTypes.NpgsqlBox(top: 0.9505585931166322d,right: 0.8766951024788088d,bottom: 0.2579608947742683d,left: 0.7820123997096545d),
new NpgsqlTypes.NpgsqlBox(top: 0.7557284560026594d,right: 0.7681281393675026d,bottom: 0.4782877545471591d,left: 0.2792727942465323d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2125134256029374d,right: 0.7852278593051287d,bottom: 0.09187160354377721d,left: 0.39038481576467543d),
new NpgsqlTypes.NpgsqlBox(top: 0.22689781376960538d,right: 0.7487797805074442d,bottom: 0.1450613317314633d,left: 0.6946905333428645d),
new NpgsqlTypes.NpgsqlBox(top: 0.9505002270672755d,right: 0.8152371343190865d,bottom: 0.10461119476939018d,left: 0.793579842830396d),
new NpgsqlTypes.NpgsqlBox(top: 0.9496100272811329d,right: 0.9659798951024082d,bottom: 0.6833335707743065d,left: 0.4962128471834538d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7652848994680721d,right: 0.36520324740781585d,bottom: 0.5519217841497093d,left: 0.34401873230267044d),
new NpgsqlTypes.NpgsqlBox(top: 0.5334201058578527d,right: 0.9722099031337238d,bottom: 0.4146868360488155d,left: 0.05619547356636034d),
new NpgsqlTypes.NpgsqlBox(top: 0.4406137433747934d,right: 0.8710197937396821d,bottom: 0.21090099381314575d,left: 0.48103953072910044d),
new NpgsqlTypes.NpgsqlBox(top: 0.5918905264512198d,right: 0.7793212175656684d,bottom: 0.5779294293901375d,left: 0.3862174251475463d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6152806670628117d,right: 0.6931293423446648d,bottom: 0.6115613140319492d,left: 0.6507431727201236d),
new NpgsqlTypes.NpgsqlBox(top: 0.7845343246811379d,right: 0.3061587422101717d,bottom: 0.5395321593260408d,left: 0.0463141227617887d),
new NpgsqlTypes.NpgsqlBox(top: 0.7280397589135751d,right: 0.8419489714833167d,bottom: 0.5380783825815069d,left: 0.06496461446070534d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7811145335695342d,right: 0.615143234718268d,bottom: 0.4629984514766653d,left: 0.04890617857339696d),
new NpgsqlTypes.NpgsqlBox(top: 0.4552076009496965d,right: 0.7145049912820679d,bottom: 0.01813311494432901d,left: 0.0616297160357121d),
new NpgsqlTypes.NpgsqlBox(top: 0.686269764930733d,right: 0.2236384180970996d,bottom: 0.5255853939455122d,left: 0.2033316717695487d),
new NpgsqlTypes.NpgsqlBox(top: 0.11379235600525883d,right: 0.869755458474638d,bottom: 0.08122366255346869d,left: 0.48847443306460503d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5556497692396806d,right: 0.6856294437341331d,bottom: 0.4820950946695015d,left: 0.5583871109391075d),
new NpgsqlTypes.NpgsqlBox(top: 0.7518178635133157d,right: 0.6656904424960964d,bottom: 0.17278971320524994d,left: 0.24983267439780144d),
new NpgsqlTypes.NpgsqlBox(top: 0.5116216854252036d,right: 0.3656007039749215d,bottom: 0.2295520495416391d,left: 0.18228012977267738d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9493478908987951d,right: 0.6209781939758066d,bottom: 0.3538677160587238d,left: 0.41054543869338644d),
new NpgsqlTypes.NpgsqlBox(top: 0.5541017239252282d,right: 0.8848143477678349d,bottom: 0.2448812606764913d,left: 0.41454659906430413d),
new NpgsqlTypes.NpgsqlBox(top: 0.5797760684061543d,right: 0.6057529911135138d,bottom: 0.0430122555135003d,left: 0.042099822345769256d),
new NpgsqlTypes.NpgsqlBox(top: 0.5427684848173739d,right: 0.5297695637081187d,bottom: 0.4091882373309842d,left: 0.4697903583548283d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9983015463337361d,right: 0.9420047922791253d,bottom: 0.839229085730605d,left: 0.2308876011606935d),
new NpgsqlTypes.NpgsqlBox(top: 0.3463688168569514d,right: 0.5326711364307933d,bottom: 0.026135151383539945d,left: 0.4200594476527433d),
new NpgsqlTypes.NpgsqlBox(top: 0.8189078340955076d,right: 0.5626354203610157d,bottom: 0.0883873775199081d,left: 0.3896661751775107d),
new NpgsqlTypes.NpgsqlBox(top: 0.4506478209836571d,right: 0.3025695043597605d,bottom: 0.2009552156850254d,left: 0.13331475656114433d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.586727714847465d,right: 0.7464332801115235d,bottom: 0.2776246756998172d,left: 0.4807685852573028d),
new NpgsqlTypes.NpgsqlBox(top: 0.8792803445307266d,right: 0.8704143110066497d,bottom: 0.5173244184988312d,left: 0.8508980763756971d),
new NpgsqlTypes.NpgsqlBox(top: 0.631760358432629d,right: 0.9913213443093521d,bottom: 0.53956273314536d,left: 0.9180835589913197d),
new NpgsqlTypes.NpgsqlBox(top: 0.9339763834948923d,right: 0.23448922359262403d,bottom: 0.4082931608106105d,left: 0.044884480998163556d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6071811223639254d,right: 0.9877758437631945d,bottom: 0.35963611667829154d,left: 0.233060251612494d),
new NpgsqlTypes.NpgsqlBox(top: 0.9418634181001602d,right: 0.2858617691649371d,bottom: 0.5078237207975985d,left: 0.20922155473922355d),
new NpgsqlTypes.NpgsqlBox(top: 0.5007248545268052d,right: 0.7663480443796883d,bottom: 0.1375347876273516d,left: 0.10775242147833164d),
new NpgsqlTypes.NpgsqlBox(top: 0.8748182539054862d,right: 0.7250558598165239d,bottom: 0.37276953580172767d,left: 0.16090874664916754d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.25236217373006287d,right: 0.8631164272357448d,bottom: 0.13759486168743673d,left: 0.7398838175948249d),
new NpgsqlTypes.NpgsqlBox(top: 0.8054171160531427d,right: 0.6786870476090039d,bottom: 0.7087503411118952d,left: 0.10638541344677421d),
new NpgsqlTypes.NpgsqlBox(top: 0.9817554036834207d,right: 0.8728317734885994d,bottom: 0.5280392133629143d,left: 0.06791968516430713d),
new NpgsqlTypes.NpgsqlBox(top: 0.9855885063074531d,right: 0.8930163854526336d,bottom: 0.7977782244839741d,left: 0.5428842591894502d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8114840701782098d,right: 0.997158270473912d,bottom: 0.22362664205303762d,left: 0.6419657624614846d),
new NpgsqlTypes.NpgsqlBox(top: 0.8349790079843334d,right: 0.6847019670806465d,bottom: 0.2641456173208825d,left: 0.23491833453605648d),
new NpgsqlTypes.NpgsqlBox(top: 0.8227602760691438d,right: 0.38713392691417037d,bottom: 0.3972873968252463d,left: 0.19854448754976795d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9038066296628655d,right: 0.7576347796792493d,bottom: 0.760582664944697d,left: 0.24931403496354942d),
new NpgsqlTypes.NpgsqlBox(top: 0.7868185206982043d,right: 0.8624337580418114d,bottom: 0.4681235914685312d,left: 0.4353475459199192d),
new NpgsqlTypes.NpgsqlBox(top: 0.8986093063086948d,right: 0.8285361318215922d,bottom: 0.36013555139489706d,left: 0.7633127966968551d),
new NpgsqlTypes.NpgsqlBox(top: 0.8714934948267706d,right: 0.9509736890992256d,bottom: 0.5548943483362357d,left: 0.5804390047979773d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8896953282203808d,right: 0.7205872752870517d,bottom: 0.6071621409092232d,left: 0.616712981594529d),
new NpgsqlTypes.NpgsqlBox(top: 0.880495799351395d,right: 0.7562004041089639d,bottom: 0.18094122848000915d,left: 0.07455611625104042d),
new NpgsqlTypes.NpgsqlBox(top: 0.9897908897066718d,right: 0.939379253057916d,bottom: 0.31858226902298414d,left: 0.18098269029633207d),
new NpgsqlTypes.NpgsqlBox(top: 0.40259231424041997d,right: 0.38913881360449887d,bottom: 0.38631874698985524d,left: 0.3394144008867699d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5224269929833009d,right: 0.6513043918067202d,bottom: 0.28982418633961804d,left: 0.3756982200016954d),
new NpgsqlTypes.NpgsqlBox(top: 0.9027450044767735d,right: 0.8364920027913204d,bottom: 0.29514943231113d,left: 0.40022595045880016d),
new NpgsqlTypes.NpgsqlBox(top: 0.8047163538984389d,right: 0.5070003484732628d,bottom: 0.28247204979448026d,left: 0.08409125276679663d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.03723634734491976d,right: 0.7917850283753174d,bottom: 0.013031877112013146d,left: 0.2188822860286771d),
new NpgsqlTypes.NpgsqlBox(top: 0.5286754035249093d,right: 0.431380050666896d,bottom: 0.14394831792878804d,left: 0.12733946471258084d),
new NpgsqlTypes.NpgsqlBox(top: 0.31701728788110084d,right: 0.7882514310204206d,bottom: 0.15794129691312941d,left: 0.6519679114085158d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8832450197229648d,right: 0.953415945994926d,bottom: 0.08905524760222139d,left: 0.04192682788276858d),
new NpgsqlTypes.NpgsqlBox(top: 0.8909222314786343d,right: 0.11796354105344953d,bottom: 0.19847640294345725d,left: 0.08787418493500554d),
new NpgsqlTypes.NpgsqlBox(top: 0.9727350992948386d,right: 0.8248998783797102d,bottom: 0.606520023045294d,left: 0.37660690502947447d),
new NpgsqlTypes.NpgsqlBox(top: 0.6691335343569604d,right: 0.6300431473304178d,bottom: 0.30353957900959594d,left: 0.3130289128047026d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.20002776281539814d,right: 0.3343419319130969d,bottom: 0.19916393803337507d,left: 0.3035866493851388d),
new NpgsqlTypes.NpgsqlBox(top: 0.9168587360089746d,right: 0.8738727338332839d,bottom: 0.5516674784711811d,left: 0.2730536771282608d),
new NpgsqlTypes.NpgsqlBox(top: 0.42056063009544997d,right: 0.4272966237593283d,bottom: 0.4040475202936683d,left: 0.07111862342387432d),
new NpgsqlTypes.NpgsqlBox(top: 0.11942313408488414d,right: 0.31388250918567906d,bottom: 0.008569631755236506d,left: 0.1292297133869038d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6428301510583253d,right: 0.8969884775940388d,bottom: 0.5489399253078461d,left: 0.7447112288175839d),
new NpgsqlTypes.NpgsqlBox(top: 0.5882123505615099d,right: 0.5563129777840007d,bottom: 0.353134338357892d,left: 0.2570937955411291d),
new NpgsqlTypes.NpgsqlBox(top: 0.6149652753436989d,right: 0.9128200896488573d,bottom: 0.14269181716390467d,left: 0.7977766512276673d),
new NpgsqlTypes.NpgsqlBox(top: 0.5080668967126586d,right: 0.8649491582174814d,bottom: 0.49706685727081d,left: 0.8096712890393396d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.873818100212197d,right: 0.21689669170935488d,bottom: 0.18552572936458467d,left: 0.1454344685975988d),
new NpgsqlTypes.NpgsqlBox(top: 0.8907422138920821d,right: 0.9777387955181336d,bottom: 0.13926871258697193d,left: 0.6584578064264973d),
new NpgsqlTypes.NpgsqlBox(top: 0.4215367213580391d,right: 0.7737445782647975d,bottom: 0.2941608995586956d,left: 0.039362414018293546d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8718189943181135d,right: 0.6975277889603315d,bottom: 0.4547799312255242d,left: 0.15776901136294186d),
new NpgsqlTypes.NpgsqlBox(top: 0.7798912425268141d,right: 0.4379266234979221d,bottom: 0.1286528653488328d,left: 0.22043393661422894d),
new NpgsqlTypes.NpgsqlBox(top: 0.5497381443993851d,right: 0.8739492457954651d,bottom: 0.3164852994845836d,left: 0.2951315547403567d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.16954365934360405d,right: 0.04883917655605119d,bottom: 0.15003887215355471d,left: 0.03701007456896521d),
new NpgsqlTypes.NpgsqlBox(top: 0.2550849398952906d,right: 0.42537068989889837d,bottom: 0.1881048630115021d,left: 0.1808600642834195d),
new NpgsqlTypes.NpgsqlBox(top: 0.8023468760978906d,right: 0.3368851802891777d,bottom: 0.19207844686979514d,left: 0.01590129639364979d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9909467428984701d,right: 0.9023083628046632d,bottom: 0.17461246912924422d,left: 0.5119130890903858d),
new NpgsqlTypes.NpgsqlBox(top: 0.7646606680354769d,right: 0.43743074609237476d,bottom: 0.5753161301977826d,left: 0.09454619080291238d),
new NpgsqlTypes.NpgsqlBox(top: 0.9751049333929851d,right: 0.7713704485426024d,bottom: 0.39308802823350664d,left: 0.7143910703759874d),
new NpgsqlTypes.NpgsqlBox(top: 0.6353603774216922d,right: 0.960267378442636d,bottom: 0.176986906665198d,left: 0.6372117569619369d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5392387663940775d,right: 0.8761524977993672d,bottom: 0.43834578948019576d,left: 0.7078447792468798d),
new NpgsqlTypes.NpgsqlBox(top: 0.9239508960976891d,right: 0.39656279509388837d,bottom: 0.5843252716743713d,left: 0.2546443781882546d),
new NpgsqlTypes.NpgsqlBox(top: 0.6342446092265698d,right: 0.846522225315053d,bottom: 0.09266925291226658d,left: 0.6624168555978616d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7742704677250852d,right: 0.6213738446109606d,bottom: 0.42732572794571344d,left: 0.1552820784792286d),
new NpgsqlTypes.NpgsqlBox(top: 0.7262226868024793d,right: 0.3893510969580658d,bottom: 0.00399735744249774d,left: 0.02635332163098436d),
new NpgsqlTypes.NpgsqlBox(top: 0.7142697282017023d,right: 0.9453484935458135d,bottom: 0.6864968162112174d,left: 0.5317489708221218d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9778078997806732d,right: 0.9952931477325526d,bottom: 0.2685806521124514d,left: 0.3183122345555095d),
new NpgsqlTypes.NpgsqlBox(top: 0.8106390580161668d,right: 0.9315288946100511d,bottom: 0.7307430318968604d,left: 0.032588059995581675d),
new NpgsqlTypes.NpgsqlBox(top: 0.3875631983112201d,right: 0.9842905767594315d,bottom: 0.1362290492338063d,left: 0.49250997089173365d),
new NpgsqlTypes.NpgsqlBox(top: 0.8428722658248419d,right: 0.3751488915501169d,bottom: 0.20644936734490693d,left: 0.1921480011166522d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5378780423322462d,right: 0.29954468931483813d,bottom: 0.3409354135379179d,left: 0.23344528514819052d),
new NpgsqlTypes.NpgsqlBox(top: 0.9619357576985482d,right: 0.3652114408530901d,bottom: 0.25063379296413657d,left: 0.09008674033479502d),
new NpgsqlTypes.NpgsqlBox(top: 0.6356408070259839d,right: 0.9204096984054954d,bottom: 0.26424190950779014d,left: 0.5180656831498702d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5162962146399296d,right: 0.6254449753519853d,bottom: 0.4130934477464464d,left: 0.11934657060782661d),
new NpgsqlTypes.NpgsqlBox(top: 0.3378190500555094d,right: 0.8122405909816167d,bottom: 0.26826760902670777d,left: 0.4610714862314761d),
new NpgsqlTypes.NpgsqlBox(top: 0.09038167155380572d,right: 0.6628168458822223d,bottom: 0.06064283971915496d,left: 0.4762259116532258d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9230380254309652d,right: 0.573396368001268d,bottom: 0.8332322347157444d,left: 0.12831616537187496d),
new NpgsqlTypes.NpgsqlBox(top: 0.9472810896125934d,right: 0.8482462397412086d,bottom: 0.42281334586696717d,left: 0.2280260970332616d),
new NpgsqlTypes.NpgsqlBox(top: 0.8873890917372288d,right: 0.6852869893054914d,bottom: 0.6831447810557087d,left: 0.47043777461453473d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6099847914131996d,right: 0.5743756655819383d,bottom: 0.2840900131228039d,left: 0.46565035518423303d),
new NpgsqlTypes.NpgsqlBox(top: 0.6579921443998968d,right: 0.32634712899048957d,bottom: 0.18708196854640813d,left: 0.0030805788411903956d),
new NpgsqlTypes.NpgsqlBox(top: 0.9410845546010252d,right: 0.9296226681986404d,bottom: 0.10292511990646724d,left: 0.42857994937976807d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.13568889522104277d,right: 0.5499992206492209d,bottom: 0.017175561147340423d,left: 0.2714844898078902d),
new NpgsqlTypes.NpgsqlBox(top: 0.809082646114493d,right: 0.8698240233630494d,bottom: 0.789273836054443d,left: 0.7415753928553018d),
new NpgsqlTypes.NpgsqlBox(top: 0.9904882880646102d,right: 0.6385699315095988d,bottom: 0.5133464058422825d,left: 0.02489047053871396d),
new NpgsqlTypes.NpgsqlBox(top: 0.9623727518887721d,right: 0.806232157164478d,bottom: 0.30707681543703325d,left: 0.31045985688687483d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3731876180757644d,right: 0.8195591770835534d,bottom: 0.368879338173731d,left: 0.4999206896956193d),
new NpgsqlTypes.NpgsqlBox(top: 0.6795144634879118d,right: 0.7519240136555563d,bottom: 0.20412520421565206d,left: 0.03918020226625585d),
new NpgsqlTypes.NpgsqlBox(top: 0.8913184083844837d,right: 0.8377349016240394d,bottom: 0.3744823229800618d,left: 0.09695602123727154d),
new NpgsqlTypes.NpgsqlBox(top: 0.29179753963618504d,right: 0.5507036114957828d,bottom: 0.2587787431698839d,left: 0.4777474828983166d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.38184696835611187d,right: 0.5362167331402155d,bottom: 0.22051349919765662d,left: 0.12250360778563496d),
new NpgsqlTypes.NpgsqlBox(top: 0.6044012565431056d,right: 0.8793093910944003d,bottom: 0.09543298244169207d,left: 0.09267721906796189d),
new NpgsqlTypes.NpgsqlBox(top: 0.4337515804526766d,right: 0.5684087815267833d,bottom: 0.17555196941552076d,left: 0.11801095485848156d),
new NpgsqlTypes.NpgsqlBox(top: 0.8855990059731691d,right: 0.9259058220327632d,bottom: 0.07496908730883545d,left: 0.8108796140371168d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4389252615202144d,right: 0.5603080216846804d,bottom: 0.3064750759467453d,left: 0.3750491439546101d),
new NpgsqlTypes.NpgsqlBox(top: 0.8860453795771145d,right: 0.6572195501318066d,bottom: 0.010379779214396034d,left: 0.4528223981928302d),
new NpgsqlTypes.NpgsqlBox(top: 0.5974750688111535d,right: 0.9780520863560881d,bottom: 0.3214193783016641d,left: 0.18990145916895762d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.25986428571281606d,right: 0.6963073002781595d,bottom: 0.25212045140225703d,left: 0.21602507377868985d),
new NpgsqlTypes.NpgsqlBox(top: 0.8308103598458146d,right: 0.6096097892239082d,bottom: 0.10607687571603397d,left: 0.2725873542362047d),
new NpgsqlTypes.NpgsqlBox(top: 0.6580874805396214d,right: 0.9755299642935148d,bottom: 0.6225409929578805d,left: 0.26970758329253774d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9574124219845135d,right: 0.9137941478008966d,bottom: 0.7713883952457545d,left: 0.6819722793090537d),
new NpgsqlTypes.NpgsqlBox(top: 0.8327906131249604d,right: 0.7962220162270405d,bottom: 0.5140043915602632d,left: 0.17198659260619054d),
new NpgsqlTypes.NpgsqlBox(top: 0.3412776216574802d,right: 0.9975737254230715d,bottom: 0.20031158529801552d,left: 0.44402441299857054d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.479379907355851d,right: 0.7047543671297692d,bottom: 0.3741031680824841d,left: 0.6047772394499518d),
new NpgsqlTypes.NpgsqlBox(top: 0.7642151134857853d,right: 0.8679543530554149d,bottom: 0.6464738300995326d,left: 0.4183955476533996d),
new NpgsqlTypes.NpgsqlBox(top: 0.5543038233960473d,right: 0.904187875498647d,bottom: 0.006755295787787885d,left: 0.606545557204209d),
new NpgsqlTypes.NpgsqlBox(top: 0.9222638801485151d,right: 0.495002153324257d,bottom: 0.5182297304255326d,left: 0.212820006542928d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6383481404292388d,right: 0.826279906213517d,bottom: 0.3614283402087043d,left: 0.5647734825924613d),
new NpgsqlTypes.NpgsqlBox(top: 0.6538812529654788d,right: 0.8973672804177961d,bottom: 0.3565086434123128d,left: 0.013504061974369153d),
new NpgsqlTypes.NpgsqlBox(top: 0.2819337327735574d,right: 0.9443220827370704d,bottom: 0.25780976746813167d,left: 0.007155355713110656d),
new NpgsqlTypes.NpgsqlBox(top: 0.737910116327399d,right: 0.9382019274133717d,bottom: 0.5810341693706218d,left: 0.19861383016518086d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.188864990105299d,right: 0.4143241252174452d,bottom: 0.1351012015584263d,left: 0.3976179907737316d),
new NpgsqlTypes.NpgsqlBox(top: 0.48954284849186724d,right: 0.3594876969668285d,bottom: 0.09133246403933648d,left: 0.15762941952626242d),
new NpgsqlTypes.NpgsqlBox(top: 0.8452170250139867d,right: 0.8558691276817846d,bottom: 0.39546793205823283d,left: 0.35249572085313263d),
new NpgsqlTypes.NpgsqlBox(top: 0.45849380126723294d,right: 0.8645693216173875d,bottom: 0.24917894662880924d,left: 0.507095002179154d),
}));
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
new NpgsqlTypes.NpgsqlBox(top: 0.30317465069705196d,right: 0.10379408686948499d,bottom: 0.036311391300350326d,left: 0.09497545489044346d),
new NpgsqlTypes.NpgsqlBox(top: 0.7042055994830029d,right: 0.8126238435209426d,bottom: 0.6755508349354352d,left: 0.7652008530662687d),
new NpgsqlTypes.NpgsqlBox(top: 0.9856683042468357d,right: 0.6814061709424624d,bottom: 0.06489024834371604d,left: 0.4930011459322656d),
new NpgsqlTypes.NpgsqlBox(top: 0.5818788033775109d,right: 0.6685325228921218d,bottom: 0.4020240327095096d,left: 0.10149648313079718d),
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
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7002279710329538d,right: 0.875420285648918d,bottom: 0.3197568340654602d,left: 0.7893245496632376d),
new NpgsqlTypes.NpgsqlBox(top: 0.9127829542647596d,right: 0.9277167947029576d,bottom: 0.42845728388050175d,left: 0.30775564876988437d),
new NpgsqlTypes.NpgsqlBox(top: 0.8108420905951575d,right: 0.9303867801438397d,bottom: 0.6119521569700633d,left: 0.34763521473823067d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.87519658233809d,right: 0.9259106924749656d,bottom: 0.7793903314696823d,left: 0.7130088196831897d),
new NpgsqlTypes.NpgsqlBox(top: 0.5773416010160795d,right: 0.8879176197222994d,bottom: 0.49165628272187556d,left: 0.47655430780657737d),
new NpgsqlTypes.NpgsqlBox(top: 0.6905298900734909d,right: 0.9881333543754989d,bottom: 0.2708217779620542d,left: 0.955443627601313d),
new NpgsqlTypes.NpgsqlBox(top: 0.8031258488596251d,right: 0.5589424613650654d,bottom: 0.7358226705859786d,left: 0.43342276368213417d),
}));
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
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
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

                var models =  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 114, query1, 4, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[1], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[2], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[3], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[4], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[5], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[6], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[7], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[8], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 110, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelBatchAsync(connection, 67, 67))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[29], false);
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
                var models =  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelBatch(connection, 54, 120))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[29], false);
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
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 116);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
        private void ImportModelInnerConfig()
        {
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

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
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

        [Test, Order(2)]
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

#endregion

    }
}

